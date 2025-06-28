namespace WinFormsApp1
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
            grillaPersonas = new DataGridView();
            btnOrdenarApe = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaPersonas).BeginInit();
            SuspendLayout();
            // 
            // grillaPersonas
            // 
            grillaPersonas.AllowUserToAddRows = false;
            grillaPersonas.AllowUserToDeleteRows = false;
            grillaPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPersonas.Location = new Point(34, 33);
            grillaPersonas.Name = "grillaPersonas";
            grillaPersonas.ReadOnly = true;
            grillaPersonas.Size = new Size(344, 207);
            grillaPersonas.TabIndex = 0;
            // 
            // btnOrdenarApe
            // 
            btnOrdenarApe.Location = new Point(34, 246);
            btnOrdenarApe.Name = "btnOrdenarApe";
            btnOrdenarApe.Size = new Size(344, 34);
            btnOrdenarApe.TabIndex = 1;
            btnOrdenarApe.Text = "Ordenar por apellido";
            btnOrdenarApe.UseVisualStyleBackColor = true;
            btnOrdenarApe.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 323);
            Controls.Add(btnOrdenarApe);
            Controls.Add(grillaPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaPersonas;
        private Button btnOrdenarApe;
    }
}
