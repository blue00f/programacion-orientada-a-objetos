namespace ResurreccionDeObjetos
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
            btnCrearPerro = new Button();
            btnDestruirPerro = new Button();
            btnRevivirPerro = new Button();
            SuspendLayout();
            // 
            // btnCrearPerro
            // 
            btnCrearPerro.Location = new Point(83, 97);
            btnCrearPerro.Name = "btnCrearPerro";
            btnCrearPerro.Size = new Size(117, 23);
            btnCrearPerro.TabIndex = 0;
            btnCrearPerro.Text = "Crear perro";
            btnCrearPerro.UseVisualStyleBackColor = true;
            btnCrearPerro.Click += btnCrearPerro_Click;
            // 
            // btnDestruirPerro
            // 
            btnDestruirPerro.Location = new Point(83, 126);
            btnDestruirPerro.Name = "btnDestruirPerro";
            btnDestruirPerro.Size = new Size(117, 23);
            btnDestruirPerro.TabIndex = 1;
            btnDestruirPerro.Text = "Destruir perro";
            btnDestruirPerro.UseVisualStyleBackColor = true;
            btnDestruirPerro.Click += btnDestruirPerro_Click;
            // 
            // btnRevivirPerro
            // 
            btnRevivirPerro.Location = new Point(83, 155);
            btnRevivirPerro.Name = "btnRevivirPerro";
            btnRevivirPerro.Size = new Size(117, 23);
            btnRevivirPerro.TabIndex = 2;
            btnRevivirPerro.Text = "Revivir perro";
            btnRevivirPerro.UseVisualStyleBackColor = true;
            btnRevivirPerro.Click += btnRevivirPerro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 290);
            Controls.Add(btnRevivirPerro);
            Controls.Add(btnDestruirPerro);
            Controls.Add(btnCrearPerro);
            Name = "Form1";
            Text = "Resurrección de objetos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearPerro;
        private Button btnDestruirPerro;
        private Button btnRevivirPerro;
    }
}
