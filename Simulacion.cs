using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_sim
{
    public partial class Simulacion : Form
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (txtCantDias.Text == "")
            {
                MessageBox.Show("Debe ingresar la cantidad de días a simular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                bool puntoD = false;
                if (chkCompraFaltante.Checked) { puntoD = true; }
                int cantDias = int.Parse(txtCantDias.Text);
                if (rd7.Checked)
                {
                    int docenasOferta = 7;
                    simular(cantDias, docenasOferta, puntoD);
                }
                if (rd8.Checked)
                {
                    int docenasOferta = 8;
                    simular(cantDias, docenasOferta, puntoD);
                }
                if (rd9.Checked)
                {
                    int docenasOferta = 9;
                    simular(cantDias, docenasOferta, puntoD);
                }
                if (rdDiaAnterior.Checked) { simularConDiaAnterior(cantDias, puntoD); }
            }   
        }

        private void simularConDiaAnterior(int dias, bool puntoD)
        {
            grdMontecarlo.Rows.Clear();
            int cantDias = dias;
            int docenasOferta = 8;
            double gananciaAcumulada = 0;
            Random random = new Random();

            for (int i = 0; i < cantDias; i++)
            {
                double rndClima = random.NextDouble();
                string clima = clasificarClima(rndClima);
                double rndCantDemanda = random.NextDouble();
                int cantDemanda = calcularDemanda(rndCantDemanda, clima);

                int sobrantes = docenasOferta - cantDemanda;

                double[] costos = new double[3];
                if (puntoD) { costos = calcularCostosPuntoD(docenasOferta, sobrantes); }
                else { costos = calcularCostos(docenasOferta, sobrantes); }

                double[] ingresos = calcularIngresos(docenasOferta, sobrantes);
                double ganancia = ingresos[2] - costos[2]; // ingreso total - costo total
                gananciaAcumulada += ganancia;

                grdMontecarlo.Rows.Add(i + 1, truncarNumero(rndClima), clima, truncarNumero(rndCantDemanda), cantDemanda, docenasOferta, sobrantes, truncarNumero(costos[0]), truncarNumero(costos[1]), truncarNumero(costos[2]), truncarNumero(ingresos[0]), truncarNumero(ingresos[1]), truncarNumero(ingresos[2]), truncarNumero(ganancia), truncarNumero(gananciaAcumulada));
                docenasOferta = cantDemanda;
            }

            txtResultado.Text = "$" + truncarNumero(gananciaAcumulada / cantDias).ToString(); //último valor de la gananciaAC / cant de días = ganancia promedio por día

        }

        private void simular(int dias, int oferta, bool puntoD)
        {
            grdMontecarlo.Rows.Clear();
            int cantDias = dias;
            int docenasOferta = oferta;      
            double gananciaAcumulada = 0;
            Random random = new Random();

            for (int i = 0; i < cantDias; i++)
            {
                double rndClima = random.NextDouble();
                string clima = clasificarClima(rndClima);
                double rndCantDemanda = random.NextDouble();
                int cantDemanda = calcularDemanda(rndCantDemanda, clima);

                int sobrantes = docenasOferta - cantDemanda;

                double[] costos = new double[3];
                if (puntoD) { costos = calcularCostosPuntoD(docenasOferta, sobrantes); }
                else { costos = calcularCostos(docenasOferta, sobrantes); }
                
                double[] ingresos = calcularIngresos(docenasOferta, sobrantes);
                double ganancia = ingresos[2] - costos[2]; // ingreso total - costo total
                gananciaAcumulada += ganancia;

                grdMontecarlo.Rows.Add(i + 1, truncarNumero(rndClima), clima, truncarNumero(rndCantDemanda), cantDemanda, docenasOferta, sobrantes, truncarNumero(costos[0]), truncarNumero(costos[1]), truncarNumero(costos[2]), truncarNumero(ingresos[0]), truncarNumero(ingresos[1]), truncarNumero(ingresos[2]), truncarNumero(ganancia), truncarNumero(gananciaAcumulada));
            }

            txtResultado.Text = "$" + truncarNumero(gananciaAcumulada / cantDias).ToString(); //último valor de la gananciaAC / cant de días = ganancia promedio por día
        }

        private string clasificarClima(double rnd)
        {
            if (rnd > 0 && rnd < 0.73)
            {
                return "soleado";
            }
            else
            {
                return "nublado";
            }
        }
        private int calcularDemanda(double rnd, string clima)
        {
            if (clima == "soleado")
            {
                if (rnd > 0 && rnd < 0.1) { return 6; }
                if (rnd >= 0.1 && rnd < 0.3) { return 7; }
                if (rnd >= 0.3 && rnd < 0.75) { return 8; }
                if (rnd >= 0.75 && rnd < 1) { return 9; }
            }
            else
            {
                if (rnd > 0 && rnd < 0.1) { return 6; }
                if (rnd >= 0.1 && rnd < 0.3) { return 7; }
                if (rnd >= 0.3 && rnd < 0.75) { return 8; }
                if (rnd >= 0.75 && rnd < 1) { return 9; }
            }
            return -1;
        }
        private double[] calcularCostos(int cantOferta, int sobrantes)
        {
            double[] vector = new double[3];
            double costoCompra = 7 * cantOferta;   //$7 la docena
            double costoPerdida = 0;
            if (sobrantes <= 0) { costoPerdida = Math.Abs(sobrantes) * 0.96; } //$0.08 la unidad -> $0.96
   

            double costoTotal = costoCompra + costoPerdida;
            vector[0] = costoCompra;
            vector[1] = costoPerdida;
            vector[2] = costoTotal;
            return vector;
        }
        private double[] calcularCostosPuntoD(int cantOferta, int sobrantes)
        {
            double[] vector = new double[3];
            double costoCompra = 7 * cantOferta;   //$7 la docena
            double costoFaltante = 0;
            if (sobrantes <= 0) { costoFaltante = Math.Abs(sobrantes) * 11; } // $11 la docena
            

            double costoTotal = costoCompra + costoFaltante;
            vector[0] = costoCompra;
            vector[1] = costoFaltante;
            vector[2] = costoTotal;
            return vector;
        }

        private double[] calcularIngresos(int cantOferta, int sobrantes)
        {
            double[] vector = new double[3];
            double ingresoVenta = 0;
            if (sobrantes <= 0) { ingresoVenta = cantOferta * 12; } // $1 la unidad -> $12 la docena
            else { ingresoVenta = (cantOferta - sobrantes) * 12; }

            double ingresoRecup = 0;
            if (sobrantes > 0) { ingresoRecup = sobrantes * 1.44; } // $0.12 la unidad -> $1.44 la docena

            double ingresoTotal = ingresoVenta + ingresoRecup;
            vector[0] = ingresoVenta;
            vector[1] = ingresoRecup;
            vector[2] = ingresoTotal;
            return vector;
        }
        private double truncarNumero(double numero)
        {
            return Math.Truncate(numero * 100) / 100;
        }
    }
}

