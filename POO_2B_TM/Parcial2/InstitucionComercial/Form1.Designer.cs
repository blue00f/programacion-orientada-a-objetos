namespace Parcial2
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
            label1 = new Label();
            btnAgregarCliente = new Button();
            btnBorrarCliente = new Button();
            btnModificarCliente = new Button();
            label2 = new Label();
            grillaCobros = new DataGridView();
            btnAgregarCobro = new Button();
            btnPagarCobro = new Button();
            radCobroNormal = new RadioButton();
            radCobroEspecial = new RadioButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            grillaCobrosPagados = new DataGridView();
            label4 = new Label();
            grillaCobrosPagadosOrd = new DataGridView();
            groupBox2 = new GroupBox();
            radImporteDesc = new RadioButton();
            radImporteAsc = new RadioButton();
            label5 = new Label();
            grillaConsultaDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobros).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagadosOrd).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaConsultaDatos).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(55, 60);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.Size = new Size(237, 150);
            grillaClientes.TabIndex = 0;
            grillaClientes.RowEnter += grillaClientes_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(55, 216);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 2;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(136, 216);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(75, 23);
            btnBorrarCliente.TabIndex = 3;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(217, 216);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(75, 23);
            btnModificarCliente.TabIndex = 4;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 32);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 6;
            label2.Text = "Cobros pendientes";
            // 
            // grillaCobros
            // 
            grillaCobros.AllowUserToAddRows = false;
            grillaCobros.AllowUserToDeleteRows = false;
            grillaCobros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobros.Location = new Point(379, 60);
            grillaCobros.Name = "grillaCobros";
            grillaCobros.ReadOnly = true;
            grillaCobros.Size = new Size(432, 150);
            grillaCobros.TabIndex = 5;
            // 
            // btnAgregarCobro
            // 
            btnAgregarCobro.Location = new Point(379, 216);
            btnAgregarCobro.Name = "btnAgregarCobro";
            btnAgregarCobro.Size = new Size(75, 23);
            btnAgregarCobro.TabIndex = 7;
            btnAgregarCobro.Text = "Agregar";
            btnAgregarCobro.UseVisualStyleBackColor = true;
            btnAgregarCobro.Click += btnAgregarCobro_Click;
            // 
            // btnPagarCobro
            // 
            btnPagarCobro.Location = new Point(298, 112);
            btnPagarCobro.Name = "btnPagarCobro";
            btnPagarCobro.Size = new Size(75, 45);
            btnPagarCobro.TabIndex = 8;
            btnPagarCobro.Text = "Pagar";
            btnPagarCobro.UseVisualStyleBackColor = true;
            btnPagarCobro.Click += btnPagarCobro_Click;
            // 
            // radCobroNormal
            // 
            radCobroNormal.AutoSize = true;
            radCobroNormal.Checked = true;
            radCobroNormal.Location = new Point(9, 21);
            radCobroNormal.Name = "radCobroNormal";
            radCobroNormal.Size = new Size(65, 19);
            radCobroNormal.TabIndex = 9;
            radCobroNormal.TabStop = true;
            radCobroNormal.Text = "Normal";
            radCobroNormal.UseVisualStyleBackColor = true;
            // 
            // radCobroEspecial
            // 
            radCobroEspecial.AutoSize = true;
            radCobroEspecial.Location = new Point(80, 21);
            radCobroEspecial.Name = "radCobroEspecial";
            radCobroEspecial.Size = new Size(67, 19);
            radCobroEspecial.TabIndex = 10;
            radCobroEspecial.TabStop = true;
            radCobroEspecial.Text = "Especial";
            radCobroEspecial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radCobroEspecial);
            groupBox1.Controls.Add(radCobroNormal);
            groupBox1.Location = new Point(473, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 50);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de cobro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 287);
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
            grillaCobrosPagados.Location = new Point(55, 315);
            grillaCobrosPagados.Name = "grillaCobrosPagados";
            grillaCobrosPagados.ReadOnly = true;
            grillaCobrosPagados.Size = new Size(432, 150);
            grillaCobrosPagados.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(741, 287);
            label4.Name = "label4";
            label4.Size = new Size(315, 25);
            label4.TabIndex = 15;
            label4.Text = "Ordenamiento de cobros pagados";
            // 
            // grillaCobrosPagadosOrd
            // 
            grillaCobrosPagadosOrd.AllowUserToAddRows = false;
            grillaCobrosPagadosOrd.AllowUserToDeleteRows = false;
            grillaCobrosPagadosOrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCobrosPagadosOrd.Location = new Point(741, 315);
            grillaCobrosPagadosOrd.Name = "grillaCobrosPagadosOrd";
            grillaCobrosPagadosOrd.ReadOnly = true;
            grillaCobrosPagadosOrd.Size = new Size(432, 150);
            grillaCobrosPagadosOrd.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radImporteDesc);
            groupBox2.Controls.Add(radImporteAsc);
            groupBox2.Location = new Point(741, 471);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(201, 50);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenamiento por importe total";
            // 
            // radImporteDesc
            // 
            radImporteDesc.AutoSize = true;
            radImporteDesc.Location = new Point(102, 21);
            radImporteDesc.Name = "radImporteDesc";
            radImporteDesc.Size = new Size(93, 19);
            radImporteDesc.TabIndex = 10;
            radImporteDesc.TabStop = true;
            radImporteDesc.Text = "Descendente";
            radImporteDesc.UseVisualStyleBackColor = true;
            radImporteDesc.CheckedChanged += radImporteDesc_CheckedChanged;
            // 
            // radImporteAsc
            // 
            radImporteAsc.AutoSize = true;
            radImporteAsc.Checked = true;
            radImporteAsc.Location = new Point(9, 21);
            radImporteAsc.Name = "radImporteAsc";
            radImporteAsc.Size = new Size(87, 19);
            radImporteAsc.TabIndex = 9;
            radImporteAsc.TabStop = true;
            radImporteAsc.Text = "Ascendente";
            radImporteAsc.UseVisualStyleBackColor = true;
            radImporteAsc.CheckedChanged += radImporteAsc_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(864, 32);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 17;
            label5.Text = "Consulta de datos";
            // 
            // grillaConsultaDatos
            // 
            grillaConsultaDatos.AllowUserToAddRows = false;
            grillaConsultaDatos.AllowUserToDeleteRows = false;
            grillaConsultaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaConsultaDatos.Location = new Point(864, 60);
            grillaConsultaDatos.Name = "grillaConsultaDatos";
            grillaConsultaDatos.ReadOnly = true;
            grillaConsultaDatos.Size = new Size(309, 150);
            grillaConsultaDatos.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 546);
            Controls.Add(label5);
            Controls.Add(grillaConsultaDatos);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(grillaCobrosPagadosOrd);
            Controls.Add(label3);
            Controls.Add(grillaCobrosPagados);
            Controls.Add(groupBox1);
            Controls.Add(btnPagarCobro);
            Controls.Add(btnAgregarCobro);
            Controls.Add(label2);
            Controls.Add(grillaCobros);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnBorrarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label1);
            Controls.Add(grillaClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobros).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagados).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCobrosPagadosOrd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaConsultaDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private Label label1;
        private Button btnAgregarCliente;
        private Button btnBorrarCliente;
        private Button btnModificarCliente;
        private Label label2;
        private DataGridView grillaCobros;
        private Button btnAgregarCobro;
        private Button btnPagarCobro;
        private RadioButton radCobroNormal;
        private RadioButton radCobroEspecial;
        private GroupBox groupBox1;
        private Label label3;
        private DataGridView grillaCobrosPagados;
        private Label label4;
        private DataGridView grillaCobrosPagadosOrd;
        private GroupBox groupBox2;
        private RadioButton radImporteDesc;
        private RadioButton radImporteAsc;
        private Label label5;
        private DataGridView grillaConsultaDatos;
    }
}
