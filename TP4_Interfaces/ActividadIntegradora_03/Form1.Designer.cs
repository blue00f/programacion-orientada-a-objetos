namespace ActividadIntegradora_03
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
            btnBorrarProducto = new Button();
            btnModificarProducto = new Button();
            grillaIdAsc = new DataGridView();
            grillaIdDesc = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grillaPrecioDesc = new DataGridView();
            grillaPrecioAsc = new DataGridView();
            txtDescripcionClon = new TextBox();
            btnModificarClon = new Button();
            btnClonarDeLaGrilla = new Button();
            txtPrecioClon = new TextBox();
            txtStockClon = new TextBox();
            btnIterarId = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaIdAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaIdDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaPrecioDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaPrecioAsc).BeginInit();
            SuspendLayout();
            // 
            // grillaProductos
            // 
            grillaProductos.AllowUserToAddRows = false;
            grillaProductos.AllowUserToDeleteRows = false;
            grillaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProductos.Location = new Point(34, 45);
            grillaProductos.Name = "grillaProductos";
            grillaProductos.ReadOnly = true;
            grillaProductos.Size = new Size(736, 205);
            grillaProductos.TabIndex = 0;
            grillaProductos.RowEnter += grillaProductos_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(153, 256);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(104, 41);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(279, 256);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(104, 41);
            btnBorrarProducto.TabIndex = 3;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(405, 256);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(104, 41);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // grillaIdAsc
            // 
            grillaIdAsc.AllowUserToAddRows = false;
            grillaIdAsc.AllowUserToDeleteRows = false;
            grillaIdAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaIdAsc.Location = new Point(34, 358);
            grillaIdAsc.Name = "grillaIdAsc";
            grillaIdAsc.ReadOnly = true;
            grillaIdAsc.Size = new Size(626, 181);
            grillaIdAsc.TabIndex = 5;
            // 
            // grillaIdDesc
            // 
            grillaIdDesc.AllowUserToAddRows = false;
            grillaIdDesc.AllowUserToDeleteRows = false;
            grillaIdDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaIdDesc.Location = new Point(34, 595);
            grillaIdDesc.Name = "grillaIdDesc";
            grillaIdDesc.ReadOnly = true;
            grillaIdDesc.Size = new Size(626, 181);
            grillaIdDesc.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 330);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 7;
            label2.Text = "ID Ascendente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 567);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 8;
            label3.Text = "ID Descendente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(728, 567);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 12;
            label4.Text = "Precio Descendente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(728, 330);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 11;
            label5.Text = "Precio Ascendente";
            // 
            // grillaPrecioDesc
            // 
            grillaPrecioDesc.AllowUserToAddRows = false;
            grillaPrecioDesc.AllowUserToDeleteRows = false;
            grillaPrecioDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPrecioDesc.Location = new Point(728, 595);
            grillaPrecioDesc.Name = "grillaPrecioDesc";
            grillaPrecioDesc.ReadOnly = true;
            grillaPrecioDesc.Size = new Size(626, 181);
            grillaPrecioDesc.TabIndex = 10;
            // 
            // grillaPrecioAsc
            // 
            grillaPrecioAsc.AllowUserToAddRows = false;
            grillaPrecioAsc.AllowUserToDeleteRows = false;
            grillaPrecioAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPrecioAsc.Location = new Point(728, 358);
            grillaPrecioAsc.Name = "grillaPrecioAsc";
            grillaPrecioAsc.ReadOnly = true;
            grillaPrecioAsc.Size = new Size(626, 181);
            grillaPrecioAsc.TabIndex = 9;
            // 
            // txtDescripcionClon
            // 
            txtDescripcionClon.Location = new Point(786, 108);
            txtDescripcionClon.Name = "txtDescripcionClon";
            txtDescripcionClon.ReadOnly = true;
            txtDescripcionClon.Size = new Size(90, 23);
            txtDescripcionClon.TabIndex = 14;
            // 
            // btnModificarClon
            // 
            btnModificarClon.Location = new Point(786, 137);
            btnModificarClon.Name = "btnModificarClon";
            btnModificarClon.Size = new Size(302, 23);
            btnModificarClon.TabIndex = 15;
            btnModificarClon.Text = "Modificar clon";
            btnModificarClon.UseVisualStyleBackColor = true;
            btnModificarClon.Click += btnModificarClon_Click;
            // 
            // btnClonarDeLaGrilla
            // 
            btnClonarDeLaGrilla.Location = new Point(786, 45);
            btnClonarDeLaGrilla.Name = "btnClonarDeLaGrilla";
            btnClonarDeLaGrilla.Size = new Size(302, 41);
            btnClonarDeLaGrilla.TabIndex = 16;
            btnClonarDeLaGrilla.Text = "Clonar registro";
            btnClonarDeLaGrilla.UseVisualStyleBackColor = true;
            btnClonarDeLaGrilla.Click += btnClonarDeLaGrilla_Click;
            // 
            // txtPrecioClon
            // 
            txtPrecioClon.Location = new Point(893, 108);
            txtPrecioClon.Name = "txtPrecioClon";
            txtPrecioClon.ReadOnly = true;
            txtPrecioClon.Size = new Size(90, 23);
            txtPrecioClon.TabIndex = 17;
            // 
            // txtStockClon
            // 
            txtStockClon.Location = new Point(998, 108);
            txtStockClon.Name = "txtStockClon";
            txtStockClon.ReadOnly = true;
            txtStockClon.Size = new Size(90, 23);
            txtStockClon.TabIndex = 18;
            // 
            // btnIterarId
            // 
            btnIterarId.Location = new Point(536, 256);
            btnIterarId.Name = "btnIterarId";
            btnIterarId.Size = new Size(104, 41);
            btnIterarId.TabIndex = 19;
            btnIterarId.Text = "Iterar ID";
            btnIterarId.UseVisualStyleBackColor = true;
            btnIterarId.Click += btnIterarId_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 798);
            Controls.Add(btnIterarId);
            Controls.Add(txtStockClon);
            Controls.Add(txtPrecioClon);
            Controls.Add(btnClonarDeLaGrilla);
            Controls.Add(btnModificarClon);
            Controls.Add(txtDescripcionClon);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(grillaPrecioDesc);
            Controls.Add(grillaPrecioAsc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grillaIdDesc);
            Controls.Add(grillaIdAsc);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnBorrarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label1);
            Controls.Add(grillaProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaIdAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaIdDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaPrecioDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaPrecioAsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaProductos;
        private Label label1;
        private Button btnAgregarProducto;
        private Button btnBorrarProducto;
        private Button btnModificarProducto;
        private DataGridView grillaIdAsc;
        private DataGridView grillaIdDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView grillaPrecioDesc;
        private DataGridView grillaPrecioAsc;
        private TextBox txtDescripcionClon;
        private Button btnModificarClon;
        private Button btnClonarDeLaGrilla;
        private TextBox txtPrecioClon;
        private TextBox txtStockClon;
        private Button btnIterarId;
    }
}
