namespace SistemaBecas
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
            grillaBeneficiarios = new DataGridView();
            grillaBecas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            grillaBecaDelBeneficiario = new DataGridView();
            label3 = new Label();
            btnAgregarBeneficiario = new Button();
            btnBorrarBeneficiario = new Button();
            btnModificarBeneficiario = new Button();
            btnAgregarBeca = new Button();
            btnAsignarBeca = new Button();
            btnQuitarBeca = new Button();
            cbxTipoBeneficiario = new ComboBox();
            dtpFechaOtorgamiento = new DateTimePicker();
            btnPagarCuota = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaBeneficiarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaBecas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaBecaDelBeneficiario).BeginInit();
            SuspendLayout();
            // 
            // grillaBeneficiarios
            // 
            grillaBeneficiarios.AllowUserToAddRows = false;
            grillaBeneficiarios.AllowUserToDeleteRows = false;
            grillaBeneficiarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaBeneficiarios.Location = new Point(31, 64);
            grillaBeneficiarios.Name = "grillaBeneficiarios";
            grillaBeneficiarios.ReadOnly = true;
            grillaBeneficiarios.Size = new Size(599, 150);
            grillaBeneficiarios.TabIndex = 0;
            grillaBeneficiarios.RowEnter += grillaBeneficiarios_RowEnter;
            // 
            // grillaBecas
            // 
            grillaBecas.AllowUserToAddRows = false;
            grillaBecas.AllowUserToDeleteRows = false;
            grillaBecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaBecas.Location = new Point(729, 64);
            grillaBecas.Name = "grillaBecas";
            grillaBecas.ReadOnly = true;
            grillaBecas.Size = new Size(442, 150);
            grillaBecas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Beneficiarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(729, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Becas";
            // 
            // grillaBecaDelBeneficiario
            // 
            grillaBecaDelBeneficiario.AllowUserToAddRows = false;
            grillaBecaDelBeneficiario.AllowUserToDeleteRows = false;
            grillaBecaDelBeneficiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaBecaDelBeneficiario.Location = new Point(729, 317);
            grillaBecaDelBeneficiario.Name = "grillaBecaDelBeneficiario";
            grillaBecaDelBeneficiario.ReadOnly = true;
            grillaBecaDelBeneficiario.Size = new Size(440, 150);
            grillaBecaDelBeneficiario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(729, 289);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 5;
            label3.Text = "Beca del beneficiario";
            // 
            // btnAgregarBeneficiario
            // 
            btnAgregarBeneficiario.Location = new Point(31, 220);
            btnAgregarBeneficiario.Name = "btnAgregarBeneficiario";
            btnAgregarBeneficiario.Size = new Size(75, 23);
            btnAgregarBeneficiario.TabIndex = 6;
            btnAgregarBeneficiario.Text = "Agregar";
            btnAgregarBeneficiario.UseVisualStyleBackColor = true;
            btnAgregarBeneficiario.Click += btnAgregarBeneficiario_Click;
            // 
            // btnBorrarBeneficiario
            // 
            btnBorrarBeneficiario.Location = new Point(123, 220);
            btnBorrarBeneficiario.Name = "btnBorrarBeneficiario";
            btnBorrarBeneficiario.Size = new Size(75, 23);
            btnBorrarBeneficiario.TabIndex = 7;
            btnBorrarBeneficiario.Text = "Borrar";
            btnBorrarBeneficiario.UseVisualStyleBackColor = true;
            btnBorrarBeneficiario.Click += btnBorrarBeneficiario_Click;
            // 
            // btnModificarBeneficiario
            // 
            btnModificarBeneficiario.Location = new Point(227, 220);
            btnModificarBeneficiario.Name = "btnModificarBeneficiario";
            btnModificarBeneficiario.Size = new Size(75, 23);
            btnModificarBeneficiario.TabIndex = 8;
            btnModificarBeneficiario.Text = "Modificar";
            btnModificarBeneficiario.UseVisualStyleBackColor = true;
            btnModificarBeneficiario.Click += btnModificarBeneficiario_Click;
            // 
            // btnAgregarBeca
            // 
            btnAgregarBeca.Location = new Point(729, 220);
            btnAgregarBeca.Name = "btnAgregarBeca";
            btnAgregarBeca.Size = new Size(75, 23);
            btnAgregarBeca.TabIndex = 9;
            btnAgregarBeca.Text = "Agregar";
            btnAgregarBeca.UseVisualStyleBackColor = true;
            btnAgregarBeca.Click += btnAgregarBeca_Click;
            // 
            // btnAsignarBeca
            // 
            btnAsignarBeca.Location = new Point(636, 107);
            btnAsignarBeca.Name = "btnAsignarBeca";
            btnAsignarBeca.Size = new Size(75, 23);
            btnAsignarBeca.TabIndex = 10;
            btnAsignarBeca.Text = "Asignar";
            btnAsignarBeca.UseVisualStyleBackColor = true;
            btnAsignarBeca.Click += btnAsignarBeca_Click;
            // 
            // btnQuitarBeca
            // 
            btnQuitarBeca.Location = new Point(636, 136);
            btnQuitarBeca.Name = "btnQuitarBeca";
            btnQuitarBeca.Size = new Size(75, 23);
            btnQuitarBeca.TabIndex = 11;
            btnQuitarBeca.Text = "Quitar";
            btnQuitarBeca.UseVisualStyleBackColor = true;
            btnQuitarBeca.Click += btnQuitarBeca_Click;
            // 
            // cbxTipoBeneficiario
            // 
            cbxTipoBeneficiario.FormattingEnabled = true;
            cbxTipoBeneficiario.Items.AddRange(new object[] { "Ingresante", "Grado", "Posgrado" });
            cbxTipoBeneficiario.Location = new Point(31, 249);
            cbxTipoBeneficiario.Name = "cbxTipoBeneficiario";
            cbxTipoBeneficiario.Size = new Size(167, 23);
            cbxTipoBeneficiario.TabIndex = 12;
            // 
            // dtpFechaOtorgamiento
            // 
            dtpFechaOtorgamiento.Format = DateTimePickerFormat.Short;
            dtpFechaOtorgamiento.Location = new Point(832, 220);
            dtpFechaOtorgamiento.Name = "dtpFechaOtorgamiento";
            dtpFechaOtorgamiento.Size = new Size(200, 23);
            dtpFechaOtorgamiento.TabIndex = 13;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(227, 249);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(75, 42);
            btnPagarCuota.TabIndex = 14;
            btnPagarCuota.Text = "Pagar cuota";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 498);
            Controls.Add(btnPagarCuota);
            Controls.Add(dtpFechaOtorgamiento);
            Controls.Add(cbxTipoBeneficiario);
            Controls.Add(btnQuitarBeca);
            Controls.Add(btnAsignarBeca);
            Controls.Add(btnAgregarBeca);
            Controls.Add(btnModificarBeneficiario);
            Controls.Add(btnBorrarBeneficiario);
            Controls.Add(btnAgregarBeneficiario);
            Controls.Add(label3);
            Controls.Add(grillaBecaDelBeneficiario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaBecas);
            Controls.Add(grillaBeneficiarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaBeneficiarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaBecas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaBecaDelBeneficiario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaBeneficiarios;
        private DataGridView grillaBecas;
        private Label label1;
        private Label label2;
        private DataGridView grillaBecaDelBeneficiario;
        private Label label3;
        private Button btnAgregarBeneficiario;
        private Button btnBorrarBeneficiario;
        private Button btnModificarBeneficiario;
        private Button btnAgregarBeca;
        private Button btnAsignarBeca;
        private Button btnQuitarBeca;
        private ComboBox cbxTipoBeneficiario;
        private DateTimePicker dtpFechaOtorgamiento;
        private Button btnPagarCuota;
    }
}
