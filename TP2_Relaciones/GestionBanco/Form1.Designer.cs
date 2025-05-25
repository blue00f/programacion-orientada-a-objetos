namespace GestionBanco
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
            grillaCuentas = new DataGridView();
            btnAgregarCliente = new Button();
            btnAsignarCuenta = new Button();
            radCajaAhorro = new RadioButton();
            radCuentaCorriente = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            grillaTodasLasCuentas = new DataGridView();
            btnDepositar = new Button();
            label3 = new Label();
            btnExtraer = new Button();
            btnTransferir = new Button();
            btnBorrarCliente = new Button();
            btnModificarCliente = new Button();
            btnModificarCuenta = new Button();
            btnBorrarCuenta = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaTodasLasCuentas).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(40, 54);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.Size = new Size(480, 237);
            grillaClientes.TabIndex = 0;
            grillaClientes.RowEnter += grillaClientes_RowEnter;
            // 
            // grillaCuentas
            // 
            grillaCuentas.AllowUserToAddRows = false;
            grillaCuentas.AllowUserToDeleteRows = false;
            grillaCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCuentas.Location = new Point(668, 54);
            grillaCuentas.Name = "grillaCuentas";
            grillaCuentas.ReadOnly = true;
            grillaCuentas.Size = new Size(497, 237);
            grillaCuentas.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(122, 297);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(86, 36);
            btnAgregarCliente.TabIndex = 2;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnAsignarCuenta
            // 
            btnAsignarCuenta.Location = new Point(539, 96);
            btnAsignarCuenta.Name = "btnAsignarCuenta";
            btnAsignarCuenta.Size = new Size(102, 54);
            btnAsignarCuenta.TabIndex = 3;
            btnAsignarCuenta.Text = "Asignar y crear cuenta";
            btnAsignarCuenta.UseVisualStyleBackColor = true;
            btnAsignarCuenta.Click += btnAsignarCuenta_Click;
            // 
            // radCajaAhorro
            // 
            radCajaAhorro.AutoSize = true;
            radCajaAhorro.Checked = true;
            radCajaAhorro.Location = new Point(539, 166);
            radCajaAhorro.Name = "radCajaAhorro";
            radCajaAhorro.Size = new Size(102, 19);
            radCajaAhorro.TabIndex = 4;
            radCajaAhorro.TabStop = true;
            radCajaAhorro.Text = "Caja de ahorro";
            radCajaAhorro.UseVisualStyleBackColor = true;
            // 
            // radCuentaCorriente
            // 
            radCuentaCorriente.AutoSize = true;
            radCuentaCorriente.Location = new Point(539, 191);
            radCuentaCorriente.Name = "radCuentaCorriente";
            radCuentaCorriente.Size = new Size(113, 19);
            radCuentaCorriente.TabIndex = 5;
            radCuentaCorriente.Text = "Cuenta corriente";
            radCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 6;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(668, 26);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 7;
            label2.Text = "Cuentas del cliente";
            // 
            // grillaTodasLasCuentas
            // 
            grillaTodasLasCuentas.AllowUserToAddRows = false;
            grillaTodasLasCuentas.AllowUserToDeleteRows = false;
            grillaTodasLasCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaTodasLasCuentas.Location = new Point(40, 383);
            grillaTodasLasCuentas.Name = "grillaTodasLasCuentas";
            grillaTodasLasCuentas.ReadOnly = true;
            grillaTodasLasCuentas.Size = new Size(480, 237);
            grillaTodasLasCuentas.TabIndex = 8;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(783, 339);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(86, 36);
            btnDepositar.TabIndex = 9;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 355);
            label3.Name = "label3";
            label3.Size = new Size(236, 25);
            label3.TabIndex = 10;
            label3.Text = "Todas las cuentas creadas";
            // 
            // btnExtraer
            // 
            btnExtraer.Location = new Point(887, 339);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(86, 36);
            btnExtraer.TabIndex = 11;
            btnExtraer.Text = "Extraer";
            btnExtraer.UseVisualStyleBackColor = true;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(991, 339);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(86, 36);
            btnTransferir.TabIndex = 12;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(226, 297);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(86, 36);
            btnBorrarCliente.TabIndex = 13;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(334, 297);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(86, 36);
            btnModificarCliente.TabIndex = 14;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnModificarCuenta
            // 
            btnModificarCuenta.Location = new Point(936, 297);
            btnModificarCuenta.Name = "btnModificarCuenta";
            btnModificarCuenta.Size = new Size(86, 36);
            btnModificarCuenta.TabIndex = 16;
            btnModificarCuenta.Text = "Modificar";
            btnModificarCuenta.UseVisualStyleBackColor = true;
            btnModificarCuenta.Click += btnModificarCuenta_Click;
            // 
            // btnBorrarCuenta
            // 
            btnBorrarCuenta.Location = new Point(835, 297);
            btnBorrarCuenta.Name = "btnBorrarCuenta";
            btnBorrarCuenta.Size = new Size(86, 36);
            btnBorrarCuenta.TabIndex = 15;
            btnBorrarCuenta.Text = "Borrar";
            btnBorrarCuenta.UseVisualStyleBackColor = true;
            btnBorrarCuenta.Click += btnBorrarCuenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 640);
            Controls.Add(btnModificarCuenta);
            Controls.Add(btnBorrarCuenta);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnBorrarCliente);
            Controls.Add(btnTransferir);
            Controls.Add(btnExtraer);
            Controls.Add(label3);
            Controls.Add(btnDepositar);
            Controls.Add(grillaTodasLasCuentas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radCuentaCorriente);
            Controls.Add(radCajaAhorro);
            Controls.Add(btnAsignarCuenta);
            Controls.Add(btnAgregarCliente);
            Controls.Add(grillaCuentas);
            Controls.Add(grillaClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaTodasLasCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private DataGridView grillaCuentas;
        private Button btnAgregarCliente;
        private Button btnAsignarCuenta;
        private RadioButton radCajaAhorro;
        private RadioButton radCuentaCorriente;
        private Label label1;
        private Label label2;
        private DataGridView grillaTodasLasCuentas;
        private Button btnDepositar;
        private Label label3;
        private Button btnExtraer;
        private Button btnTransferir;
        private Button btnBorrarCliente;
        private Button btnModificarCliente;
        private Button btnModificarCuenta;
        private Button btnBorrarCuenta;
    }
}
