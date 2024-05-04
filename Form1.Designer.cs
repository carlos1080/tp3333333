namespace tp3333333
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSimulacion = new DataGridView();
            btnSimulacion = new Button();
            txtDiasSimulacion = new TextBox();
            txtValorVenta = new TextBox();
            txtCostosVariables = new TextBox();
            txtRemuneraciones = new TextBox();
            txtCantidadObrerosNomina = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDesdeDia = new TextBox();
            txtCantidadDiasMostrar = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dgvProb = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSimulacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProb).BeginInit();
            SuspendLayout();
            // 
            // dgvSimulacion
            // 
            dgvSimulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSimulacion.Location = new Point(0, 0);
            dgvSimulacion.Name = "dgvSimulacion";
            dgvSimulacion.Size = new Size(398, 209);
            dgvSimulacion.TabIndex = 0;
            // 
            // btnSimulacion
            // 
            btnSimulacion.Location = new Point(493, 28);
            btnSimulacion.Name = "btnSimulacion";
            btnSimulacion.Size = new Size(184, 151);
            btnSimulacion.TabIndex = 1;
            btnSimulacion.Text = "Simulacion";
            btnSimulacion.UseVisualStyleBackColor = true;
            btnSimulacion.Click += btnSimulacion_Click;
            // 
            // txtDiasSimulacion
            // 
            txtDiasSimulacion.Location = new Point(298, 323);
            txtDiasSimulacion.Name = "txtDiasSimulacion";
            txtDiasSimulacion.Size = new Size(100, 23);
            txtDiasSimulacion.TabIndex = 2;
            // 
            // txtValorVenta
            // 
            txtValorVenta.Location = new Point(298, 456);
            txtValorVenta.Name = "txtValorVenta";
            txtValorVenta.Size = new Size(100, 23);
            txtValorVenta.TabIndex = 3;
            // 
            // txtCostosVariables
            // 
            txtCostosVariables.Location = new Point(298, 414);
            txtCostosVariables.Name = "txtCostosVariables";
            txtCostosVariables.Size = new Size(100, 23);
            txtCostosVariables.TabIndex = 4;
            // 
            // txtRemuneraciones
            // 
            txtRemuneraciones.Location = new Point(298, 363);
            txtRemuneraciones.Name = "txtRemuneraciones";
            txtRemuneraciones.Size = new Size(100, 23);
            txtRemuneraciones.TabIndex = 5;
            // 
            // txtCantidadObrerosNomina
            // 
            txtCantidadObrerosNomina.Location = new Point(298, 277);
            txtCantidadObrerosNomina.Name = "txtCantidadObrerosNomina";
            txtCantidadObrerosNomina.Size = new Size(100, 23);
            txtCantidadObrerosNomina.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 277);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de obreros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 323);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Dias a simular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 363);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 9;
            label3.Text = "Remuneraciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 414);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "Costos variables";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 456);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 11;
            label5.Text = "Valor de venta";
            // 
            // txtDesdeDia
            // 
            txtDesdeDia.Location = new Point(298, 503);
            txtDesdeDia.Name = "txtDesdeDia";
            txtDesdeDia.Size = new Size(100, 23);
            txtDesdeDia.TabIndex = 12;
            // 
            // txtCantidadDiasMostrar
            // 
            txtCantidadDiasMostrar.Location = new Point(298, 552);
            txtCantidadDiasMostrar.Name = "txtCantidadDiasMostrar";
            txtCantidadDiasMostrar.Size = new Size(100, 23);
            txtCantidadDiasMostrar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 503);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Dia desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(149, 560);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 15;
            label7.Text = "Cantidad de iteraciones";
            // 
            // dgvProb
            // 
            dgvProb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProb.Location = new Point(493, 228);
            dgvProb.Name = "dgvProb";
            dgvProb.Size = new Size(929, 361);
            dgvProb.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 616);
            Controls.Add(dgvProb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCantidadDiasMostrar);
            Controls.Add(txtDesdeDia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidadObrerosNomina);
            Controls.Add(txtRemuneraciones);
            Controls.Add(txtCostosVariables);
            Controls.Add(txtValorVenta);
            Controls.Add(txtDiasSimulacion);
            Controls.Add(btnSimulacion);
            Controls.Add(dgvSimulacion);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSimulacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSimulacion;
        private Button btnSimulacion;
        private TextBox txtDiasSimulacion;
        private TextBox txtValorVenta;
        private TextBox txtCostosVariables;
        private TextBox txtRemuneraciones;
        private TextBox txtCantidadObrerosNomina;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDesdeDia;
        private TextBox txtCantidadDiasMostrar;
        private Label label6;
        private Label label7;
        private DataGridView dgvProb;
    }
}
