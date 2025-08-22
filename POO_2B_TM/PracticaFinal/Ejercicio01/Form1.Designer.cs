namespace Ejercicio01
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
            grillaClientes = new DataGridView();
            btnAgregarCliente = new Button();
            btnBorrarCliente = new Button();
            btnModificarCliente = new Button();
            label1 = new Label();
            btnPagar = new Button();
            grillaCobros = new DataGridView();
            radCobroNormal = new RadioButton();
            radCobroEspecial = new RadioButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnAgregarCobro = new Button();
            label3 = new Label();
            grillaCobrosPagados = new DataGridView();
            label4 = new Label();
            grillaImporteOrd = new DataGridView();
            groupBox2 = new GroupBox();
            radOrdMenor = new RadioButton();
            radOrdMayor = new RadioButton();
            grillaInfoPago = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobros).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaImporteOrd).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaInfoPago).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(22, 41);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.Size = new Size(284, 198);
            grillaClientes.TabIndex = 0;
            grillaClientes.RowEnter += grillaClientes_RowEnter;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(22, 245);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(123, 245);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(75, 23);
            btnBorrarCliente.TabIndex = 2;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(231, 245);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(75, 23);
            btnModificarCliente.TabIndex = 3;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Clientes";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(338, 111);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(111, 44);
            btnPagar.TabIndex = 5;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // grillaCobros
            // 
            grillaCobros.AllowUserToAddRows = false;
            grillaCobros.AllowUserToDeleteRows = false;
            grillaCobros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobros.Location = new Point(520, 41);
            grillaCobros.Name = "grillaCobros";
            grillaCobros.ReadOnly = true;
            grillaCobros.Size = new Size(480, 198);
            grillaCobros.TabIndex = 6;
            // 
            // radCobroNormal
            // 
            radCobroNormal.AutoSize = true;
            radCobroNormal.Checked = true;
            radCobroNormal.Location = new Point(12, 22);
            radCobroNormal.Name = "radCobroNormal";
            radCobroNormal.Size = new Size(65, 19);
            radCobroNormal.TabIndex = 7;
            radCobroNormal.TabStop = true;
            radCobroNormal.Text = "Normal";
            radCobroNormal.UseVisualStyleBackColor = true;
            // 
            // radCobroEspecial
            // 
            radCobroEspecial.AutoSize = true;
            radCobroEspecial.Location = new Point(92, 22);
            radCobroEspecial.Name = "radCobroEspecial";
            radCobroEspecial.Size = new Size(67, 19);
            radCobroEspecial.TabIndex = 8;
            radCobroEspecial.Text = "Especial";
            radCobroEspecial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radCobroEspecial);
            groupBox1.Controls.Add(radCobroNormal);
            groupBox1.Location = new Point(779, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 53);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de cobro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 13);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 10;
            label2.Text = "Cobros";
            // 
            // btnAgregarCobro
            // 
            btnAgregarCobro.Location = new Point(520, 245);
            btnAgregarCobro.Name = "btnAgregarCobro";
            btnAgregarCobro.Size = new Size(75, 23);
            btnAgregarCobro.TabIndex = 11;
            btnAgregarCobro.Text = "Agregar";
            btnAgregarCobro.UseVisualStyleBackColor = true;
            btnAgregarCobro.Click += btnAgregarCobro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 296);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 13;
            label3.Text = "Cobros pagados";
            // 
            // grillaCobrosPagados
            // 
            grillaCobrosPagados.AllowUserToAddRows = false;
            grillaCobrosPagados.AllowUserToDeleteRows = false;
            grillaCobrosPagados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobrosPagados.Location = new Point(22, 324);
            grillaCobrosPagados.Name = "grillaCobrosPagados";
            grillaCobrosPagados.ReadOnly = true;
            grillaCobrosPagados.Size = new Size(480, 198);
            grillaCobrosPagados.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(520, 296);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 15;
            label4.Text = "Cobros pagados ord";
            // 
            // grillaImporteOrd
            // 
            grillaImporteOrd.AllowUserToAddRows = false;
            grillaImporteOrd.AllowUserToDeleteRows = false;
            grillaImporteOrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaImporteOrd.Location = new Point(520, 324);
            grillaImporteOrd.Name = "grillaImporteOrd";
            grillaImporteOrd.ReadOnly = true;
            grillaImporteOrd.Size = new Size(480, 198);
            grillaImporteOrd.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radOrdMenor);
            groupBox2.Controls.Add(radOrdMayor);
            groupBox2.Location = new Point(754, 528);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 53);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenamiento importe";
            // 
            // radOrdMenor
            // 
            radOrdMenor.AutoSize = true;
            radOrdMenor.Location = new Point(134, 22);
            radOrdMenor.Name = "radOrdMenor";
            radOrdMenor.Size = new Size(106, 19);
            radOrdMenor.TabIndex = 8;
            radOrdMenor.Text = "Menor a mayor";
            radOrdMenor.UseVisualStyleBackColor = true;
            radOrdMenor.CheckedChanged += radOrdMenor_CheckedChanged;
            // 
            // radOrdMayor
            // 
            radOrdMayor.AutoSize = true;
            radOrdMayor.Checked = true;
            radOrdMayor.Location = new Point(12, 22);
            radOrdMayor.Name = "radOrdMayor";
            radOrdMayor.Size = new Size(106, 19);
            radOrdMayor.TabIndex = 7;
            radOrdMayor.TabStop = true;
            radOrdMayor.Text = "Mayor a menor";
            radOrdMayor.UseVisualStyleBackColor = true;
            radOrdMayor.CheckedChanged += radOrdMayor_CheckedChanged;
            // 
            // grillaInfoPago
            // 
            grillaInfoPago.AllowUserToAddRows = false;
            grillaInfoPago.AllowUserToDeleteRows = false;
            grillaInfoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInfoPago.Location = new Point(1016, 41);
            grillaInfoPago.Name = "grillaInfoPago";
            grillaInfoPago.ReadOnly = true;
            grillaInfoPago.Size = new Size(404, 198);
            grillaInfoPago.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1016, 9);
            label5.Name = "label5";
            label5.Size = new Size(234, 25);
            label5.TabIndex = 17;
            label5.Text = "Salida de datos con LINQ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 591);
            Controls.Add(label5);
            Controls.Add(grillaInfoPago);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(grillaImporteOrd);
            Controls.Add(label3);
            Controls.Add(grillaCobrosPagados);
            Controls.Add(btnAgregarCobro);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(grillaCobros);
            Controls.Add(btnPagar);
            Controls.Add(label1);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnBorrarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(grillaClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobros).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaImporteOrd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaInfoPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private Button btnAgregarCliente;
        private Button btnBorrarCliente;
        private Button btnModificarCliente;
        private Label label1;
        private Button btnPagar;
        private DataGridView grillaCobros;
        private RadioButton radCobroNormal;
        private RadioButton radCobroEspecial;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnAgregarCobro;
        private Label label3;
        private DataGridView grillaCobrosPagados;
        private Label label4;
        private DataGridView grillaImporteOrd;
        private GroupBox groupBox2;
        private RadioButton radOrdMenor;
        private RadioButton radOrdMayor;
        private DataGridView grillaInfoPago;
        private Label label5;
    }
}
