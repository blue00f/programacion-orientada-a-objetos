namespace ExcepcionPersonalizada
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
            btnIngresarCliente = new Button();
            SuspendLayout();
            // 
            // btnIngresarCliente
            // 
            btnIngresarCliente.Location = new Point(44, 77);
            btnIngresarCliente.Name = "btnIngresarCliente";
            btnIngresarCliente.Size = new Size(183, 36);
            btnIngresarCliente.TabIndex = 0;
            btnIngresarCliente.Text = "Ingresar cliente";
            btnIngresarCliente.UseVisualStyleBackColor = true;
            btnIngresarCliente.Click += btnIngresarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 191);
            Controls.Add(btnIngresarCliente);
            Name = "Form1";
            Text = "Excepción personalizada";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresarCliente;
    }
}
