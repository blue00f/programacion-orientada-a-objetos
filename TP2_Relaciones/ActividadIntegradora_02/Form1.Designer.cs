namespace ActividadIntegradora_02
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
            grillaInversores = new DataGridView();
            grillaAccionesDelInversor = new DataGridView();
            grillaAcciones = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarInversor = new Button();
            btnBorrarInversor = new Button();
            btnModificarInversor = new Button();
            btnModificarAccion = new Button();
            btnBorrarAccion = new Button();
            btnAgregarAccion = new Button();
            cbxTipoInversor = new ComboBox();
            btnComprarAccion = new Button();
            btnVenderAccion = new Button();
            lblTotalInvertidoPorInversor = new Label();
            lblRecaudadoComun = new Label();
            lblRecaudadoPremiumHasta20000 = new Label();
            lblRecaudadoPremiumSupera20000 = new Label();
            lblRecaudadoTotal = new Label();
            label4 = new Label();
            grillaInversorAsc = new DataGridView();
            grillaInversorDesc = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grillaAccionDesc = new DataGridView();
            grillaAccionAsc = new DataGridView();
            btnVerCodigo = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInversores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionesDelInversor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAcciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversorAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversorDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionAsc).BeginInit();
            SuspendLayout();
            // 
            // grillaInversores
            // 
            grillaInversores.AllowUserToAddRows = false;
            grillaInversores.AllowUserToDeleteRows = false;
            grillaInversores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversores.Location = new Point(12, 50);
            grillaInversores.Name = "grillaInversores";
            grillaInversores.ReadOnly = true;
            grillaInversores.Size = new Size(580, 234);
            grillaInversores.TabIndex = 0;
            grillaInversores.RowEnter += grillaInversores_RowEnter;
            // 
            // grillaAccionesDelInversor
            // 
            grillaAccionesDelInversor.AllowUserToAddRows = false;
            grillaAccionesDelInversor.AllowUserToDeleteRows = false;
            grillaAccionesDelInversor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAccionesDelInversor.Location = new Point(731, 50);
            grillaAccionesDelInversor.Name = "grillaAccionesDelInversor";
            grillaAccionesDelInversor.ReadOnly = true;
            grillaAccionesDelInversor.Size = new Size(722, 234);
            grillaAccionesDelInversor.TabIndex = 1;
            // 
            // grillaAcciones
            // 
            grillaAcciones.AllowUserToAddRows = false;
            grillaAcciones.AllowUserToDeleteRows = false;
            grillaAcciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAcciones.Location = new Point(12, 389);
            grillaAcciones.Name = "grillaAcciones";
            grillaAcciones.ReadOnly = true;
            grillaAcciones.Size = new Size(580, 234);
            grillaAcciones.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 3;
            label1.Text = "Inversores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(731, 22);
            label2.Name = "label2";
            label2.Size = new Size(319, 25);
            label2.TabIndex = 4;
            label2.Text = "Acciones del inversor seleccionado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(12, 361);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Acciones";
            // 
            // btnAgregarInversor
            // 
            btnAgregarInversor.Location = new Point(157, 290);
            btnAgregarInversor.Name = "btnAgregarInversor";
            btnAgregarInversor.Size = new Size(90, 33);
            btnAgregarInversor.TabIndex = 6;
            btnAgregarInversor.Text = "Agregar";
            btnAgregarInversor.UseVisualStyleBackColor = true;
            btnAgregarInversor.Click += btnAgregarInversor_Click;
            // 
            // btnBorrarInversor
            // 
            btnBorrarInversor.Location = new Point(253, 290);
            btnBorrarInversor.Name = "btnBorrarInversor";
            btnBorrarInversor.Size = new Size(90, 33);
            btnBorrarInversor.TabIndex = 7;
            btnBorrarInversor.Text = "Borrar";
            btnBorrarInversor.UseVisualStyleBackColor = true;
            btnBorrarInversor.Click += btnBorrarInversor_Click;
            // 
            // btnModificarInversor
            // 
            btnModificarInversor.Location = new Point(349, 290);
            btnModificarInversor.Name = "btnModificarInversor";
            btnModificarInversor.Size = new Size(90, 33);
            btnModificarInversor.TabIndex = 8;
            btnModificarInversor.Text = "Modificar";
            btnModificarInversor.UseVisualStyleBackColor = true;
            btnModificarInversor.Click += btnModificarInversor_Click;
            // 
            // btnModificarAccion
            // 
            btnModificarAccion.Location = new Point(368, 629);
            btnModificarAccion.Name = "btnModificarAccion";
            btnModificarAccion.Size = new Size(90, 33);
            btnModificarAccion.TabIndex = 11;
            btnModificarAccion.Text = "Modificar";
            btnModificarAccion.UseVisualStyleBackColor = true;
            btnModificarAccion.Click += btnModificarAccion_Click;
            // 
            // btnBorrarAccion
            // 
            btnBorrarAccion.Location = new Point(272, 629);
            btnBorrarAccion.Name = "btnBorrarAccion";
            btnBorrarAccion.Size = new Size(90, 33);
            btnBorrarAccion.TabIndex = 10;
            btnBorrarAccion.Text = "Borrar";
            btnBorrarAccion.UseVisualStyleBackColor = true;
            btnBorrarAccion.Click += btnBorrarAccion_Click;
            // 
            // btnAgregarAccion
            // 
            btnAgregarAccion.Location = new Point(176, 629);
            btnAgregarAccion.Name = "btnAgregarAccion";
            btnAgregarAccion.Size = new Size(90, 33);
            btnAgregarAccion.TabIndex = 9;
            btnAgregarAccion.Text = "Agregar";
            btnAgregarAccion.UseVisualStyleBackColor = true;
            btnAgregarAccion.Click += btnAgregarAccion_Click;
            // 
            // cbxTipoInversor
            // 
            cbxTipoInversor.FormattingEnabled = true;
            cbxTipoInversor.Location = new Point(12, 296);
            cbxTipoInversor.Name = "cbxTipoInversor";
            cbxTipoInversor.Size = new Size(121, 23);
            cbxTipoInversor.TabIndex = 12;
            // 
            // btnComprarAccion
            // 
            btnComprarAccion.Location = new Point(607, 124);
            btnComprarAccion.Name = "btnComprarAccion";
            btnComprarAccion.Size = new Size(101, 33);
            btnComprarAccion.TabIndex = 13;
            btnComprarAccion.Text = "Comprar acción";
            btnComprarAccion.UseVisualStyleBackColor = true;
            btnComprarAccion.Click += btnComprarAccion_Click;
            // 
            // btnVenderAccion
            // 
            btnVenderAccion.Location = new Point(607, 174);
            btnVenderAccion.Name = "btnVenderAccion";
            btnVenderAccion.Size = new Size(101, 33);
            btnVenderAccion.TabIndex = 14;
            btnVenderAccion.Text = "Vender acción";
            btnVenderAccion.UseVisualStyleBackColor = true;
            btnVenderAccion.Click += btnVenderAccion_Click;
            // 
            // lblTotalInvertidoPorInversor
            // 
            lblTotalInvertidoPorInversor.AutoSize = true;
            lblTotalInvertidoPorInversor.Location = new Point(12, 333);
            lblTotalInvertidoPorInversor.Name = "lblTotalInvertidoPorInversor";
            lblTotalInvertidoPorInversor.Size = new Size(89, 15);
            lblTotalInvertidoPorInversor.TabIndex = 15;
            lblTotalInvertidoPorInversor.Text = "Total invertido: ";
            // 
            // lblRecaudadoComun
            // 
            lblRecaudadoComun.AutoSize = true;
            lblRecaudadoComun.Location = new Point(12, 717);
            lblRecaudadoComun.Name = "lblRecaudadoComun";
            lblRecaudadoComun.Size = new Size(201, 15);
            lblRecaudadoComun.TabIndex = 16;
            lblRecaudadoComun.Text = "Recaudado por inversores comunes: ";
            // 
            // lblRecaudadoPremiumHasta20000
            // 
            lblRecaudadoPremiumHasta20000.AutoSize = true;
            lblRecaudadoPremiumHasta20000.Location = new Point(12, 742);
            lblRecaudadoPremiumHasta20000.Name = "lblRecaudadoPremiumHasta20000";
            lblRecaudadoPremiumHasta20000.Size = new Size(271, 15);
            lblRecaudadoPremiumHasta20000.TabIndex = 17;
            lblRecaudadoPremiumHasta20000.Text = "Recaudado por inversores premium hasta $20.000:";
            // 
            // lblRecaudadoPremiumSupera20000
            // 
            lblRecaudadoPremiumSupera20000.AutoSize = true;
            lblRecaudadoPremiumSupera20000.Location = new Point(12, 768);
            lblRecaudadoPremiumSupera20000.Name = "lblRecaudadoPremiumSupera20000";
            lblRecaudadoPremiumSupera20000.Size = new Size(326, 15);
            lblRecaudadoPremiumSupera20000.TabIndex = 18;
            lblRecaudadoPremiumSupera20000.Text = "Recaudado por inversores premium que superan los $20.000:";
            // 
            // lblRecaudadoTotal
            // 
            lblRecaudadoTotal.AutoSize = true;
            lblRecaudadoTotal.Location = new Point(12, 794);
            lblRecaudadoTotal.Name = "lblRecaudadoTotal";
            lblRecaudadoTotal.Size = new Size(78, 15);
            lblRecaudadoTotal.TabIndex = 19;
            lblRecaudadoTotal.Text = "Total general:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(12, 680);
            label4.Name = "label4";
            label4.Size = new Size(453, 25);
            label4.TabIndex = 20;
            label4.Text = "Comisiones de las compras y ventas de la empresa";
            // 
            // grillaInversorAsc
            // 
            grillaInversorAsc.AllowUserToAddRows = false;
            grillaInversorAsc.AllowUserToDeleteRows = false;
            grillaInversorAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversorAsc.Location = new Point(606, 389);
            grillaInversorAsc.Name = "grillaInversorAsc";
            grillaInversorAsc.ReadOnly = true;
            grillaInversorAsc.Size = new Size(534, 198);
            grillaInversorAsc.TabIndex = 21;
            // 
            // grillaInversorDesc
            // 
            grillaInversorDesc.AllowUserToAddRows = false;
            grillaInversorDesc.AllowUserToDeleteRows = false;
            grillaInversorDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversorDesc.Location = new Point(606, 653);
            grillaInversorDesc.Name = "grillaInversorDesc";
            grillaInversorDesc.ReadOnly = true;
            grillaInversorDesc.Size = new Size(534, 198);
            grillaInversorDesc.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(606, 361);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 23;
            label5.Text = "Inversor Ascendente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(606, 625);
            label6.Name = "label6";
            label6.Size = new Size(205, 25);
            label6.TabIndex = 24;
            label6.Text = "Inversor Descendente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(1156, 625);
            label7.Name = "label7";
            label7.Size = new Size(191, 25);
            label7.TabIndex = 28;
            label7.Text = "Acción Descendente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(1156, 361);
            label8.Name = "label8";
            label8.Size = new Size(180, 25);
            label8.TabIndex = 27;
            label8.Text = "Acción Ascendente";
            // 
            // grillaAccionDesc
            // 
            grillaAccionDesc.AllowUserToAddRows = false;
            grillaAccionDesc.AllowUserToDeleteRows = false;
            grillaAccionDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAccionDesc.Location = new Point(1156, 653);
            grillaAccionDesc.Name = "grillaAccionDesc";
            grillaAccionDesc.ReadOnly = true;
            grillaAccionDesc.Size = new Size(513, 198);
            grillaAccionDesc.TabIndex = 26;
            // 
            // grillaAccionAsc
            // 
            grillaAccionAsc.AllowUserToAddRows = false;
            grillaAccionAsc.AllowUserToDeleteRows = false;
            grillaAccionAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAccionAsc.Location = new Point(1156, 389);
            grillaAccionAsc.Name = "grillaAccionAsc";
            grillaAccionAsc.ReadOnly = true;
            grillaAccionAsc.Size = new Size(513, 198);
            grillaAccionAsc.TabIndex = 25;
            // 
            // btnVerCodigo
            // 
            btnVerCodigo.Location = new Point(80, 629);
            btnVerCodigo.Name = "btnVerCodigo";
            btnVerCodigo.Size = new Size(90, 33);
            btnVerCodigo.TabIndex = 29;
            btnVerCodigo.Text = "Ver código";
            btnVerCodigo.UseVisualStyleBackColor = true;
            btnVerCodigo.Click += btnVerCodigo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 874);
            Controls.Add(btnVerCodigo);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(grillaAccionDesc);
            Controls.Add(grillaAccionAsc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(grillaInversorDesc);
            Controls.Add(grillaInversorAsc);
            Controls.Add(label4);
            Controls.Add(lblRecaudadoTotal);
            Controls.Add(lblRecaudadoPremiumSupera20000);
            Controls.Add(lblRecaudadoPremiumHasta20000);
            Controls.Add(lblRecaudadoComun);
            Controls.Add(lblTotalInvertidoPorInversor);
            Controls.Add(btnVenderAccion);
            Controls.Add(btnComprarAccion);
            Controls.Add(cbxTipoInversor);
            Controls.Add(btnModificarAccion);
            Controls.Add(btnBorrarAccion);
            Controls.Add(btnAgregarAccion);
            Controls.Add(btnModificarInversor);
            Controls.Add(btnBorrarInversor);
            Controls.Add(btnAgregarInversor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaAcciones);
            Controls.Add(grillaAccionesDelInversor);
            Controls.Add(grillaInversores);
            Name = "Form1";
            Text = "Gestión de bolsa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInversores).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionesDelInversor).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAcciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversorAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversorDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionAsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaInversores;
        private DataGridView grillaAccionesDelInversor;
        private DataGridView grillaAcciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarInversor;
        private Button btnBorrarInversor;
        private Button btnModificarInversor;
        private Button btnModificarAccion;
        private Button btnBorrarAccion;
        private Button btnAgregarAccion;
        private ComboBox cbxTipoInversor;
        private Button btnComprarAccion;
        private Button btnVenderAccion;
        private Label lblTotalInvertidoPorInversor;
        private Label lblRecaudadoComun;
        private Label lblRecaudadoPremiumHasta20000;
        private Label lblRecaudadoPremiumSupera20000;
        private Label lblRecaudadoTotal;
        private Label label4;
        private DataGridView grillaInversorAsc;
        private DataGridView grillaInversorDesc;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView grillaAccionDesc;
        private DataGridView grillaAccionAsc;
        private Button btnVerCodigo;
    }
}
