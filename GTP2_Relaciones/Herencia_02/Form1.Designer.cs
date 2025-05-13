namespace Herencia_02
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
            dgvEmpleados = new DataGridView();
            btnAgregarEmpleado = new Button();
            label1 = new Label();
            dgvLegajoAsc = new DataGridView();
            dgvLegajoDesc = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnMostrarInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLegajoAsc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLegajoDesc).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(42, 70);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.Size = new Size(415, 205);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(42, 291);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(75, 23);
            btnAgregarEmpleado.TabIndex = 1;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "EMPLEADOS";
            // 
            // dgvLegajoAsc
            // 
            dgvLegajoAsc.AllowUserToAddRows = false;
            dgvLegajoAsc.AllowUserToDeleteRows = false;
            dgvLegajoAsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLegajoAsc.Location = new Point(516, 70);
            dgvLegajoAsc.Name = "dgvLegajoAsc";
            dgvLegajoAsc.ReadOnly = true;
            dgvLegajoAsc.Size = new Size(415, 205);
            dgvLegajoAsc.TabIndex = 3;
            // 
            // dgvLegajoDesc
            // 
            dgvLegajoDesc.AllowUserToAddRows = false;
            dgvLegajoDesc.AllowUserToDeleteRows = false;
            dgvLegajoDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLegajoDesc.Location = new Point(516, 348);
            dgvLegajoDesc.Name = "dgvLegajoDesc";
            dgvLegajoDesc.ReadOnly = true;
            dgvLegajoDesc.Size = new Size(415, 205);
            dgvLegajoDesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(516, 42);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 5;
            label2.Text = "LEGAJO ASCENDENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(516, 320);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 6;
            label3.Text = "LEGAJO DESCENDENTE";
            // 
            // btnMostrarInfo
            // 
            btnMostrarInfo.Location = new Point(123, 291);
            btnMostrarInfo.Name = "btnMostrarInfo";
            btnMostrarInfo.Size = new Size(143, 23);
            btnMostrarInfo.TabIndex = 7;
            btnMostrarInfo.Text = "Mostrar información";
            btnMostrarInfo.UseVisualStyleBackColor = true;
            btnMostrarInfo.Click += btnMostrarInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 581);
            Controls.Add(btnMostrarInfo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvLegajoDesc);
            Controls.Add(dgvLegajoAsc);
            Controls.Add(label1);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(dgvEmpleados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLegajoAsc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLegajoDesc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnAgregarEmpleado;
        private Label label1;
        private DataGridView dgvLegajoAsc;
        private DataGridView dgvLegajoDesc;
        private Label label2;
        private Label label3;
        private Button btnMostrarInfo;
    }
}
