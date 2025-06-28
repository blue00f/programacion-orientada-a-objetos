namespace Ejemplo1
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
            txtBuscadorApe = new TextBox();
            grillaFiltroPorNombre = new DataGridView();
            grillaFutbolistas = new DataGridView();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificacion = new Button();
            label1 = new Label();
            label2 = new Label();
            grillaApellidoDesc = new DataGridView();
            grillaNumeroDesc = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            grillaRangoDeNumero = new DataGridView();
            btnBuscarPorRangoNum = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaFiltroPorNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaFutbolistas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaApellidoDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaNumeroDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaRangoDeNumero).BeginInit();
            SuspendLayout();
            // 
            // txtBuscadorApe
            // 
            txtBuscadorApe.Location = new Point(467, 42);
            txtBuscadorApe.Name = "txtBuscadorApe";
            txtBuscadorApe.Size = new Size(390, 23);
            txtBuscadorApe.TabIndex = 0;
            txtBuscadorApe.TextChanged += txtBuscadorApe_TextChanged;
            // 
            // grillaFiltroPorNombre
            // 
            grillaFiltroPorNombre.AllowUserToAddRows = false;
            grillaFiltroPorNombre.AllowUserToDeleteRows = false;
            grillaFiltroPorNombre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFiltroPorNombre.Location = new Point(467, 80);
            grillaFiltroPorNombre.Name = "grillaFiltroPorNombre";
            grillaFiltroPorNombre.ReadOnly = true;
            grillaFiltroPorNombre.Size = new Size(390, 254);
            grillaFiltroPorNombre.TabIndex = 1;
            // 
            // grillaFutbolistas
            // 
            grillaFutbolistas.AllowUserToAddRows = false;
            grillaFutbolistas.AllowUserToDeleteRows = false;
            grillaFutbolistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFutbolistas.Location = new Point(35, 80);
            grillaFutbolistas.Name = "grillaFutbolistas";
            grillaFutbolistas.ReadOnly = true;
            grillaFutbolistas.Size = new Size(390, 254);
            grillaFutbolistas.TabIndex = 2;
            grillaFutbolistas.RowEnter += grillaFutbolistas_RowEnter;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(35, 340);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(98, 23);
            btnAlta.TabIndex = 3;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(184, 340);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(98, 23);
            btnBaja.TabIndex = 4;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificacion
            // 
            btnModificacion.Location = new Point(327, 340);
            btnModificacion.Name = "btnModificacion";
            btnModificacion.Size = new Size(98, 23);
            btnModificacion.TabIndex = 5;
            btnModificacion.Text = "Modificación";
            btnModificacion.UseVisualStyleBackColor = true;
            btnModificacion.Click += btnModificacion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 6;
            label1.Text = "Futbolistas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 14);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 7;
            label2.Text = "Buscar por apellido";
            // 
            // grillaApellidoDesc
            // 
            grillaApellidoDesc.AllowUserToAddRows = false;
            grillaApellidoDesc.AllowUserToDeleteRows = false;
            grillaApellidoDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaApellidoDesc.Location = new Point(35, 430);
            grillaApellidoDesc.Name = "grillaApellidoDesc";
            grillaApellidoDesc.ReadOnly = true;
            grillaApellidoDesc.Size = new Size(390, 254);
            grillaApellidoDesc.TabIndex = 8;
            // 
            // grillaNumeroDesc
            // 
            grillaNumeroDesc.AllowUserToAddRows = false;
            grillaNumeroDesc.AllowUserToDeleteRows = false;
            grillaNumeroDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaNumeroDesc.Location = new Point(467, 430);
            grillaNumeroDesc.Name = "grillaNumeroDesc";
            grillaNumeroDesc.ReadOnly = true;
            grillaNumeroDesc.Size = new Size(390, 254);
            grillaNumeroDesc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 402);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 10;
            label3.Text = "Apellido descendente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(467, 402);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 11;
            label4.Text = "Número descendente";
            // 
            // grillaRangoDeNumero
            // 
            grillaRangoDeNumero.AllowUserToAddRows = false;
            grillaRangoDeNumero.AllowUserToDeleteRows = false;
            grillaRangoDeNumero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaRangoDeNumero.Location = new Point(900, 80);
            grillaRangoDeNumero.Name = "grillaRangoDeNumero";
            grillaRangoDeNumero.ReadOnly = true;
            grillaRangoDeNumero.Size = new Size(390, 254);
            grillaRangoDeNumero.TabIndex = 12;
            // 
            // btnBuscarPorRangoNum
            // 
            btnBuscarPorRangoNum.Location = new Point(900, 46);
            btnBuscarPorRangoNum.Name = "btnBuscarPorRangoNum";
            btnBuscarPorRangoNum.Size = new Size(390, 23);
            btnBuscarPorRangoNum.TabIndex = 13;
            btnBuscarPorRangoNum.Text = "Buscar por rango de números";
            btnBuscarPorRangoNum.UseVisualStyleBackColor = true;
            btnBuscarPorRangoNum.Click += btnBuscarPorRangoNum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 720);
            Controls.Add(btnBuscarPorRangoNum);
            Controls.Add(grillaRangoDeNumero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(grillaNumeroDesc);
            Controls.Add(grillaApellidoDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificacion);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(grillaFutbolistas);
            Controls.Add(grillaFiltroPorNombre);
            Controls.Add(txtBuscadorApe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaFiltroPorNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaFutbolistas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaApellidoDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaNumeroDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaRangoDeNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscadorApe;
        private DataGridView grillaFiltroPorNombre;
        private DataGridView grillaFutbolistas;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificacion;
        private Label label1;
        private Label label2;
        private DataGridView grillaApellidoDesc;
        private DataGridView grillaNumeroDesc;
        private Label label3;
        private Label label4;
        private DataGridView grillaRangoDeNumero;
        private Button btnBuscarPorRangoNum;
    }
}
