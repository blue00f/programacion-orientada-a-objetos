namespace SistemaDeVentas
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
            label2 = new Label();
            grillaProductos = new DataGridView();
            label3 = new Label();
            grillaCompras = new DataGridView();
            btnAgregarCliente = new Button();
            btnBorrarCliente = new Button();
            btnModificarCliente = new Button();
            btnModificarProducto = new Button();
            btnBorrarProducto = new Button();
            btnAgregarProducto = new Button();
            btnComprar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCompras).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(30, 53);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.RowHeadersWidth = 62;
            grillaClientes.Size = new Size(483, 225);
            grillaClientes.TabIndex = 0;
            grillaClientes.RowEnter += grillaClientes_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 350);
            label2.Name = "label2";
            label2.Size = new Size(149, 38);
            label2.TabIndex = 3;
            label2.Text = "Productos";
            // 
            // grillaProductos
            // 
            grillaProductos.AllowUserToAddRows = false;
            grillaProductos.AllowUserToDeleteRows = false;
            grillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductos.Location = new Point(30, 391);
            grillaProductos.Name = "grillaProductos";
            grillaProductos.ReadOnly = true;
            grillaProductos.RowHeadersWidth = 62;
            grillaProductos.Size = new Size(483, 225);
            grillaProductos.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(718, 12);
            label3.Name = "label3";
            label3.Size = new Size(263, 38);
            label3.TabIndex = 5;
            label3.Text = "Compra del cliente";
            // 
            // grillaCompras
            // 
            grillaCompras.AllowUserToAddRows = false;
            grillaCompras.AllowUserToDeleteRows = false;
            grillaCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCompras.Location = new Point(718, 53);
            grillaCompras.Name = "grillaCompras";
            grillaCompras.ReadOnly = true;
            grillaCompras.RowHeadersWidth = 62;
            grillaCompras.Size = new Size(483, 225);
            grillaCompras.TabIndex = 4;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(30, 284);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(112, 34);
            btnAgregarCliente.TabIndex = 6;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(170, 284);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(112, 34);
            btnBorrarCliente.TabIndex = 7;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(310, 284);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(112, 34);
            btnModificarCliente.TabIndex = 8;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(310, 622);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(112, 34);
            btnModificarProducto.TabIndex = 11;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(170, 622);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(112, 34);
            btnBorrarProducto.TabIndex = 10;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(30, 622);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 34);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(549, 124);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(140, 53);
            btnComprar.TabIndex = 12;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 671);
            Controls.Add(btnComprar);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnBorrarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnBorrarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label3);
            Controls.Add(grillaCompras);
            Controls.Add(label2);
            Controls.Add(grillaProductos);
            Controls.Add(label1);
            Controls.Add(grillaClientes);
            Name = "Form1";
            Text = "Sistema de ventas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private Label label1;
        private Label label2;
        private DataGridView grillaProductos;
        private Label label3;
        private DataGridView grillaCompras;
        private Button btnAgregarCliente;
        private Button btnBorrarCliente;
        private Button btnModificarCliente;
        private Button btnModificarProducto;
        private Button btnBorrarProducto;
        private Button btnAgregarProducto;
        private Button btnComprar;
    }
}
