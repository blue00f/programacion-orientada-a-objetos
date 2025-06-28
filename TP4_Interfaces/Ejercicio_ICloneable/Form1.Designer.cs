namespace Ejercicio_ICloneable
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
            btnCrearProducto = new Button();
            btnClonarProducto = new Button();
            grillaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(78, 113);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(162, 40);
            btnCrearProducto.TabIndex = 0;
            btnCrearProducto.Text = "Crear producto";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // btnClonarProducto
            // 
            btnClonarProducto.Location = new Point(78, 169);
            btnClonarProducto.Name = "btnClonarProducto";
            btnClonarProducto.Size = new Size(162, 40);
            btnClonarProducto.TabIndex = 1;
            btnClonarProducto.Text = "Clonar producto";
            btnClonarProducto.UseVisualStyleBackColor = true;
            btnClonarProducto.Click += btnClonarProducto_Click;
            // 
            // grillaProductos
            // 
            grillaProductos.AllowUserToAddRows = false;
            grillaProductos.AllowUserToDeleteRows = false;
            grillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductos.Location = new Point(298, 47);
            grillaProductos.Name = "grillaProductos";
            grillaProductos.ReadOnly = true;
            grillaProductos.Size = new Size(369, 242);
            grillaProductos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 343);
            Controls.Add(grillaProductos);
            Controls.Add(btnClonarProducto);
            Controls.Add(btnCrearProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearProducto;
        private Button btnClonarProducto;
        private DataGridView grillaProductos;
    }
}
