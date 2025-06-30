namespace InstitucionComercial
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
            grillaCobros = new DataGridView();
            label2 = new Label();
            btnPagarCobro = new Button();
            btnAgregarCobro = new Button();
            radCobroNormal = new RadioButton();
            radCobroEspecial = new RadioButton();
            label3 = new Label();
            grillaCobrosPagados = new DataGridView();
            grillaImporteOrd = new DataGridView();
            label4 = new Label();
            radOrdenarImporteAsc = new RadioButton();
            radOrdenarImporteDesc = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grillaConsultaDatos = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaImporteOrd).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaConsultaDatos).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(44, 49);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.Size = new Size(276, 229);
            grillaClientes.TabIndex = 0;
            grillaClientes.RowEnter += grillaClientes_RowEnter;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(44, 284);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(142, 284);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(75, 23);
            btnBorrarCliente.TabIndex = 2;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(245, 284);
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
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Clientes";
            // 
            // grillaCobros
            // 
            grillaCobros.AllowUserToAddRows = false;
            grillaCobros.AllowUserToDeleteRows = false;
            grillaCobros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobros.Location = new Point(443, 49);
            grillaCobros.Name = "grillaCobros";
            grillaCobros.ReadOnly = true;
            grillaCobros.Size = new Size(573, 229);
            grillaCobros.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 21);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 6;
            label2.Text = "Cobros pendientes";
            // 
            // btnPagarCobro
            // 
            btnPagarCobro.Location = new Point(343, 145);
            btnPagarCobro.Name = "btnPagarCobro";
            btnPagarCobro.Size = new Size(75, 35);
            btnPagarCobro.TabIndex = 7;
            btnPagarCobro.Text = "Pagar";
            btnPagarCobro.UseVisualStyleBackColor = true;
            btnPagarCobro.Click += btnPagarCobro_Click;
            // 
            // btnAgregarCobro
            // 
            btnAgregarCobro.Location = new Point(443, 284);
            btnAgregarCobro.Name = "btnAgregarCobro";
            btnAgregarCobro.Size = new Size(75, 23);
            btnAgregarCobro.TabIndex = 8;
            btnAgregarCobro.Text = "Agregar";
            btnAgregarCobro.UseVisualStyleBackColor = true;
            btnAgregarCobro.Click += btnAgregarCobro_Click;
            // 
            // radCobroNormal
            // 
            radCobroNormal.AutoSize = true;
            radCobroNormal.Checked = true;
            radCobroNormal.Location = new Point(22, 22);
            radCobroNormal.Name = "radCobroNormal";
            radCobroNormal.Size = new Size(99, 19);
            radCobroNormal.TabIndex = 9;
            radCobroNormal.TabStop = true;
            radCobroNormal.Text = "Cobro normal";
            radCobroNormal.UseVisualStyleBackColor = true;
            // 
            // radCobroEspecial
            // 
            radCobroEspecial.AutoSize = true;
            radCobroEspecial.Location = new Point(127, 22);
            radCobroEspecial.Name = "radCobroEspecial";
            radCobroEspecial.Size = new Size(103, 19);
            radCobroEspecial.TabIndex = 10;
            radCobroEspecial.Text = "Cobro especial";
            radCobroEspecial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 340);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 12;
            label3.Text = "Cobros pagados";
            // 
            // grillaCobrosPagados
            // 
            grillaCobrosPagados.AllowUserToAddRows = false;
            grillaCobrosPagados.AllowUserToDeleteRows = false;
            grillaCobrosPagados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobrosPagados.Location = new Point(44, 368);
            grillaCobrosPagados.Name = "grillaCobrosPagados";
            grillaCobrosPagados.ReadOnly = true;
            grillaCobrosPagados.Size = new Size(573, 229);
            grillaCobrosPagados.TabIndex = 11;
            // 
            // grillaImporteOrd
            // 
            grillaImporteOrd.AllowUserToAddRows = false;
            grillaImporteOrd.AllowUserToDeleteRows = false;
            grillaImporteOrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaImporteOrd.Location = new Point(687, 368);
            grillaImporteOrd.Name = "grillaImporteOrd";
            grillaImporteOrd.ReadOnly = true;
            grillaImporteOrd.Size = new Size(573, 229);
            grillaImporteOrd.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(687, 340);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 15;
            label4.Text = "Cobros pagados ASC";
            // 
            // radOrdenarImporteAsc
            // 
            radOrdenarImporteAsc.AutoSize = true;
            radOrdenarImporteAsc.Checked = true;
            radOrdenarImporteAsc.Location = new Point(20, 22);
            radOrdenarImporteAsc.Name = "radOrdenarImporteAsc";
            radOrdenarImporteAsc.Size = new Size(121, 19);
            radOrdenarImporteAsc.TabIndex = 16;
            radOrdenarImporteAsc.TabStop = true;
            radOrdenarImporteAsc.Text = "Orden ascendente";
            radOrdenarImporteAsc.UseVisualStyleBackColor = true;
            radOrdenarImporteAsc.CheckedChanged += radOrdenarImporteAsc_CheckedChanged;
            // 
            // radOrdenarImporteDesc
            // 
            radOrdenarImporteDesc.AutoSize = true;
            radOrdenarImporteDesc.Location = new Point(147, 22);
            radOrdenarImporteDesc.Name = "radOrdenarImporteDesc";
            radOrdenarImporteDesc.Size = new Size(128, 19);
            radOrdenarImporteDesc.TabIndex = 17;
            radOrdenarImporteDesc.Text = "Orden descendente";
            radOrdenarImporteDesc.UseVisualStyleBackColor = true;
            radOrdenarImporteDesc.CheckedChanged += radOrdenarImporteDesc_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radCobroEspecial);
            groupBox1.Controls.Add(radCobroNormal);
            groupBox1.Location = new Point(524, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 55);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de cobro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radOrdenarImporteDesc);
            groupBox2.Controls.Add(radOrdenarImporteAsc);
            groupBox2.Location = new Point(687, 603);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 56);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo ordenamiento";
            // 
            // grillaConsultaDatos
            // 
            grillaConsultaDatos.AllowUserToAddRows = false;
            grillaConsultaDatos.AllowUserToDeleteRows = false;
            grillaConsultaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaConsultaDatos.Location = new Point(1047, 49);
            grillaConsultaDatos.Name = "grillaConsultaDatos";
            grillaConsultaDatos.ReadOnly = true;
            grillaConsultaDatos.Size = new Size(394, 229);
            grillaConsultaDatos.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1047, 21);
            label5.Name = "label5";
            label5.Size = new Size(331, 25);
            label5.TabIndex = 21;
            label5.Text = "Consulta de datos - cobros pagados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 667);
            Controls.Add(label5);
            Controls.Add(grillaConsultaDatos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(grillaImporteOrd);
            Controls.Add(label3);
            Controls.Add(grillaCobrosPagados);
            Controls.Add(btnAgregarCobro);
            Controls.Add(btnPagarCobro);
            Controls.Add(label2);
            Controls.Add(grillaCobros);
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
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaImporteOrd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaConsultaDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private Button btnAgregarCliente;
        private Button btnBorrarCliente;
        private Button btnModificarCliente;
        private Label label1;
        private DataGridView grillaCobros;
        private Label label2;
        private Button btnPagarCobro;
        private Button btnAgregarCobro;
        private RadioButton radCobroNormal;
        private RadioButton radCobroEspecial;
        private Label label3;
        private DataGridView grillaCobrosPagados;
        private DataGridView grillaImporteOrd;
        private Label label4;
        private RadioButton radOrdenarImporteAsc;
        private RadioButton radOrdenarImporteDesc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView grillaConsultaDatos;
        private Label label5;
    }
}
