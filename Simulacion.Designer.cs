namespace final_sim
{
    partial class Simulacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCompraFaltante = new System.Windows.Forms.CheckBox();
            this.txtCantDias = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdDiaAnterior = new System.Windows.Forms.RadioButton();
            this.rd9 = new System.Windows.Forms.RadioButton();
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd7 = new System.Windows.Forms.RadioButton();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMontecarlo = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndClima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndCantidadDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPerdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMontecarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "VENTA DE ROSAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.MistyRose;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.LightCoral;
            this.txtResultado.Location = new System.Drawing.Point(201, 32);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(127, 26);
            this.txtResultado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ganancia diaria promedio :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCompraFaltante);
            this.groupBox1.Controls.Add(this.txtCantDias);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // chkCompraFaltante
            // 
            this.chkCompraFaltante.AutoSize = true;
            this.chkCompraFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompraFaltante.Location = new System.Drawing.Point(17, 191);
            this.chkCompraFaltante.Name = "chkCompraFaltante";
            this.chkCompraFaltante.Size = new System.Drawing.Size(321, 21);
            this.chkCompraFaltante.TabIndex = 5;
            this.chkCompraFaltante.Text = "Simular con mercadería faltante a $11/docena";
            this.chkCompraFaltante.UseVisualStyleBackColor = true;
            // 
            // txtCantDias
            // 
            this.txtCantDias.Location = new System.Drawing.Point(188, 39);
            this.txtCantDias.Name = "txtCantDias";
            this.txtCantDias.Size = new System.Drawing.Size(88, 24);
            this.txtCantDias.TabIndex = 4;
            this.txtCantDias.Text = "100";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.rdDiaAnterior);
            this.groupBox3.Controls.Add(this.rd9);
            this.groupBox3.Controls.Add(this.rd8);
            this.groupBox3.Controls.Add(this.rd7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(17, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 102);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Docenas a comprar:";
            // 
            // rdDiaAnterior
            // 
            this.rdDiaAnterior.AutoSize = true;
            this.rdDiaAnterior.Location = new System.Drawing.Point(139, 62);
            this.rdDiaAnterior.Name = "rdDiaAnterior";
            this.rdDiaAnterior.Size = new System.Drawing.Size(166, 21);
            this.rdDiaAnterior.TabIndex = 3;
            this.rdDiaAnterior.Text = "Demanda día anterior";
            this.rdDiaAnterior.UseVisualStyleBackColor = true;
            // 
            // rd9
            // 
            this.rd9.AutoSize = true;
            this.rd9.Location = new System.Drawing.Point(139, 35);
            this.rd9.Name = "rd9";
            this.rd9.Size = new System.Drawing.Size(95, 21);
            this.rd9.TabIndex = 2;
            this.rd9.Text = "9 docenas";
            this.rd9.UseVisualStyleBackColor = true;
            // 
            // rd8
            // 
            this.rd8.AutoSize = true;
            this.rd8.Checked = true;
            this.rd8.Location = new System.Drawing.Point(21, 62);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(95, 21);
            this.rd8.TabIndex = 1;
            this.rd8.TabStop = true;
            this.rd8.Text = "8 docenas";
            this.rd8.UseVisualStyleBackColor = true;
            // 
            // rd7
            // 
            this.rd7.AutoSize = true;
            this.rd7.Location = new System.Drawing.Point(21, 35);
            this.rd7.Name = "rd7";
            this.rd7.Size = new System.Drawing.Size(95, 21);
            this.rd7.TabIndex = 0;
            this.rd7.Text = "7 docenas";
            this.rd7.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            this.btnSimular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimular.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimular.Location = new System.Drawing.Point(188, 232);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(140, 45);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cant. de días a simular:";
            // 
            // grdMontecarlo
            // 
            this.grdMontecarlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdMontecarlo.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMontecarlo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.rndClima,
            this.clima,
            this.rndCantidadDemanda,
            this.cantDemanda,
            this.oferta,
            this.sobrante,
            this.costoCompra,
            this.costoPerdida,
            this.costoTotal,
            this.ingresoVenta,
            this.ingresoRecup,
            this.ingresoTotal,
            this.ganancia,
            this.gananciaAcum});
            this.grdMontecarlo.Location = new System.Drawing.Point(408, 40);
            this.grdMontecarlo.Name = "grdMontecarlo";
            this.grdMontecarlo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdMontecarlo.RowTemplate.Height = 24;
            this.grdMontecarlo.Size = new System.Drawing.Size(728, 453);
            this.grdMontecarlo.TabIndex = 4;
            // 
            // dia
            // 
            this.dia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dia.HeaderText = "Día";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            this.dia.Width = 61;
            // 
            // rndClima
            // 
            this.rndClima.HeaderText = "RND Clima";
            this.rndClima.MinimumWidth = 6;
            this.rndClima.Name = "rndClima";
            this.rndClima.Width = 105;
            // 
            // clima
            // 
            this.clima.HeaderText = "Clima";
            this.clima.MinimumWidth = 6;
            this.clima.Name = "clima";
            this.clima.Width = 76;
            // 
            // rndCantidadDemanda
            // 
            this.rndCantidadDemanda.HeaderText = "RND Cant. Demanda";
            this.rndCantidadDemanda.MinimumWidth = 6;
            this.rndCantidadDemanda.Name = "rndCantidadDemanda";
            this.rndCantidadDemanda.Width = 170;
            // 
            // cantDemanda
            // 
            this.cantDemanda.HeaderText = "Cant. Demanda";
            this.cantDemanda.MinimumWidth = 6;
            this.cantDemanda.Name = "cantDemanda";
            this.cantDemanda.Width = 136;
            // 
            // oferta
            // 
            this.oferta.HeaderText = "Oferta";
            this.oferta.MinimumWidth = 6;
            this.oferta.Name = "oferta";
            this.oferta.Width = 83;
            // 
            // sobrante
            // 
            this.sobrante.HeaderText = "Sobrante";
            this.sobrante.MinimumWidth = 6;
            this.sobrante.Name = "sobrante";
            this.sobrante.Width = 103;
            // 
            // costoCompra
            // 
            this.costoCompra.HeaderText = "Costo Compra";
            this.costoCompra.MinimumWidth = 6;
            this.costoCompra.Name = "costoCompra";
            this.costoCompra.Width = 127;
            // 
            // costoPerdida
            // 
            this.costoPerdida.HeaderText = "Costo Faltante";
            this.costoPerdida.MinimumWidth = 6;
            this.costoPerdida.Name = "costoPerdida";
            this.costoPerdida.Width = 130;
            // 
            // costoTotal
            // 
            this.costoTotal.HeaderText = "Costo Total";
            this.costoTotal.MinimumWidth = 6;
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Width = 110;
            // 
            // ingresoVenta
            // 
            this.ingresoVenta.HeaderText = "Ingreso Venta";
            this.ingresoVenta.MinimumWidth = 6;
            this.ingresoVenta.Name = "ingresoVenta";
            this.ingresoVenta.Width = 127;
            // 
            // ingresoRecup
            // 
            this.ingresoRecup.HeaderText = "Ingreso Recup.";
            this.ingresoRecup.MinimumWidth = 6;
            this.ingresoRecup.Name = "ingresoRecup";
            this.ingresoRecup.Width = 135;
            // 
            // ingresoTotal
            // 
            this.ingresoTotal.HeaderText = "Ingreso Total";
            this.ingresoTotal.MinimumWidth = 6;
            this.ingresoTotal.Name = "ingresoTotal";
            this.ingresoTotal.Width = 122;
            // 
            // ganancia
            // 
            this.ganancia.HeaderText = "Ganancia";
            this.ganancia.MinimumWidth = 6;
            this.ganancia.Name = "ganancia";
            this.ganancia.Width = 106;
            // 
            // gananciaAcum
            // 
            this.gananciaAcum.HeaderText = "Ganancia AC";
            this.gananciaAcum.MinimumWidth = 6;
            this.gananciaAcum.Name = "gananciaAcum";
            this.gananciaAcum.Width = 120;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdMontecarlo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMontecarlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantDias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd8;
        private System.Windows.Forms.RadioButton rd7;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdMontecarlo;
        private System.Windows.Forms.CheckBox chkCompraFaltante;
        private System.Windows.Forms.RadioButton rdDiaAnterior;
        private System.Windows.Forms.RadioButton rd9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndClima;
        private System.Windows.Forms.DataGridViewTextBoxColumn clima;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndCantidadDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPerdida;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoRecup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaAcum;
    }
}

