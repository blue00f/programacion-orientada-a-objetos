namespace ManejoDeExcepciones
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
            txtNumero = new TextBox();
            txtIndice = new TextBox();
            txtDivisor = new TextBox();
            txtTexto = new TextBox();
            txtNumGrande = new TextBox();
            btnEjecutar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(265, 54);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(265, 110);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(100, 23);
            txtIndice.TabIndex = 1;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(265, 160);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 2;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(265, 213);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 3;
            // 
            // txtNumGrande
            // 
            txtNumGrande.Location = new Point(265, 266);
            txtNumGrande.Name = "txtNumGrande";
            txtNumGrande.Size = new Size(100, 23);
            txtNumGrande.TabIndex = 4;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(265, 311);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(100, 31);
            btnEjecutar.TabIndex = 5;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 57);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese un número entero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 113);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el índice del arreglo (0-2)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 163);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 8;
            label3.Text = "Ingrese el divisor para dividir a 10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 216);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 9;
            label4.Text = "Ingrese un texto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 269);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 10;
            label5.Text = "Ingrese un número grande";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 372);
            label6.Name = "label6";
            label6.Size = new Size(313, 15);
            label6.TabIndex = 11;
            label6.Text = "Se debe forzar el error en solo uno de los campos de texto.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 397);
            label7.Name = "label7";
            label7.Size = new Size(320, 15);
            label7.TabIndex = 12;
            label7.Text = "Para cada error forzado, se lanza una excepción del sistema.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 434);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Controls.Add(txtNumGrande);
            Controls.Add(txtTexto);
            Controls.Add(txtDivisor);
            Controls.Add(txtIndice);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Manejo de excepciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtIndice;
        private TextBox txtDivisor;
        private TextBox txtTexto;
        private TextBox txtNumGrande;
        private Button btnEjecutar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
