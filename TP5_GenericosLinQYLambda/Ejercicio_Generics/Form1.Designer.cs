namespace Ejercicio_Generics
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
            grillaProductos = new DataGridView();
            label1 = new Label();
            btnAgregarProducto = new Button();
            grillaFiltroProductos = new DataGridView();
            label2 = new Label();
            btnFiltrarProducto = new Button();
            grillaVendedor = new DataGridView();
            grillaFiltroVendedor = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            btnFiltrarVendedor = new Button();
            btnAgregarVendedor = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaFiltroProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaVendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaFiltroVendedor).BeginInit();
            SuspendLayout();
            // 
            // grillaProductos
            // 
            grillaProductos.AllowUserToAddRows = false;
            grillaProductos.AllowUserToDeleteRows = false;
            grillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductos.Location = new Point(39, 50);
            grillaProductos.Name = "grillaProductos";
            grillaProductos.ReadOnly = true;
            grillaProductos.Size = new Size(426, 197);
            grillaProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 2;
            label1.Text = "Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(39, 253);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // grillaFiltroProductos
            // 
            grillaFiltroProductos.AllowUserToAddRows = false;
            grillaFiltroProductos.AllowUserToDeleteRows = false;
            grillaFiltroProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFiltroProductos.Location = new Point(521, 50);
            grillaFiltroProductos.Name = "grillaFiltroProductos";
            grillaFiltroProductos.ReadOnly = true;
            grillaFiltroProductos.Size = new Size(426, 197);
            grillaFiltroProductos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 22);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Filtro";
            // 
            // btnFiltrarProducto
            // 
            btnFiltrarProducto.Location = new Point(120, 253);
            btnFiltrarProducto.Name = "btnFiltrarProducto";
            btnFiltrarProducto.Size = new Size(75, 23);
            btnFiltrarProducto.TabIndex = 6;
            btnFiltrarProducto.Text = "Filtrar";
            btnFiltrarProducto.UseVisualStyleBackColor = true;
            btnFiltrarProducto.Click += btnFiltrarProducto_Click;
            // 
            // grillaVendedor
            // 
            grillaVendedor.AllowUserToAddRows = false;
            grillaVendedor.AllowUserToDeleteRows = false;
            grillaVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedor.Location = new Point(39, 345);
            grillaVendedor.Name = "grillaVendedor";
            grillaVendedor.ReadOnly = true;
            grillaVendedor.Size = new Size(426, 197);
            grillaVendedor.TabIndex = 7;
            // 
            // grillaFiltroVendedor
            // 
            grillaFiltroVendedor.AllowUserToAddRows = false;
            grillaFiltroVendedor.AllowUserToDeleteRows = false;
            grillaFiltroVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFiltroVendedor.Location = new Point(521, 345);
            grillaFiltroVendedor.Name = "grillaFiltroVendedor";
            grillaFiltroVendedor.ReadOnly = true;
            grillaFiltroVendedor.Size = new Size(426, 197);
            grillaFiltroVendedor.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 317);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 9;
            label3.Text = "Vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(521, 317);
            label4.Name = "label4";
            label4.Size = new Size(305, 25);
            label4.TabIndex = 10;
            label4.Text = "Filtro por letra inicial del apellido";
            // 
            // btnFiltrarVendedor
            // 
            btnFiltrarVendedor.Location = new Point(120, 548);
            btnFiltrarVendedor.Name = "btnFiltrarVendedor";
            btnFiltrarVendedor.Size = new Size(75, 23);
            btnFiltrarVendedor.TabIndex = 12;
            btnFiltrarVendedor.Text = "Filtrar";
            btnFiltrarVendedor.UseVisualStyleBackColor = true;
            btnFiltrarVendedor.Click += btnFiltrarVendedor_Click;
            // 
            // btnAgregarVendedor
            // 
            btnAgregarVendedor.Location = new Point(39, 548);
            btnAgregarVendedor.Name = "btnAgregarVendedor";
            btnAgregarVendedor.Size = new Size(75, 23);
            btnAgregarVendedor.TabIndex = 11;
            btnAgregarVendedor.Text = "Agregar";
            btnAgregarVendedor.UseVisualStyleBackColor = true;
            btnAgregarVendedor.Click += btnAgregarVendedor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 600);
            Controls.Add(btnFiltrarVendedor);
            Controls.Add(btnAgregarVendedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(grillaFiltroVendedor);
            Controls.Add(grillaVendedor);
            Controls.Add(btnFiltrarProducto);
            Controls.Add(label2);
            Controls.Add(grillaFiltroProductos);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label1);
            Controls.Add(grillaProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaFiltroProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaVendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaFiltroVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaProductos;
        private Label label1;
        private Button btnAgregarProducto;
        private DataGridView grillaFiltroProductos;
        private Label label2;
        private Button btnFiltrarProducto;
        private DataGridView grillaVendedor;
        private DataGridView grillaFiltroVendedor;
        private Label label3;
        private Label label4;
        private Button btnFiltrarVendedor;
        private Button btnAgregarVendedor;
    }
}
