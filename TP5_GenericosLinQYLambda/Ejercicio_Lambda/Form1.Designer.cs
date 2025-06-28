namespace Ejercicio_Lambda
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
            lstNumeros = new ListBox();
            btnFiltrarPares = new Button();
            lstPares = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(64, 59);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(160, 169);
            lstNumeros.TabIndex = 0;
            // 
            // btnFiltrarPares
            // 
            btnFiltrarPares.Location = new Point(64, 234);
            btnFiltrarPares.Name = "btnFiltrarPares";
            btnFiltrarPares.Size = new Size(160, 23);
            btnFiltrarPares.TabIndex = 1;
            btnFiltrarPares.Text = "Filtrar números pares";
            btnFiltrarPares.UseVisualStyleBackColor = true;
            btnFiltrarPares.Click += btnFiltrarPares_Click;
            // 
            // lstPares
            // 
            lstPares.FormattingEnabled = true;
            lstPares.ItemHeight = 15;
            lstPares.Location = new Point(246, 59);
            lstPares.Name = "lstPares";
            lstPares.Size = new Size(160, 169);
            lstPares.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 35);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 3;
            label1.Text = "Números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 35);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 4;
            label2.Text = "Pares";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 300);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPares);
            Controls.Add(btnFiltrarPares);
            Controls.Add(lstNumeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Button btnFiltrarPares;
        private ListBox lstPares;
        private Label label1;
        private Label label2;
    }
}
