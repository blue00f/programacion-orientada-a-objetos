namespace Ej0001
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button5 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(29, 204);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(241, 23);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "Limpiar";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.ForeColor = System.Drawing.Color.Red;
            this.TextBox2.Location = new System.Drawing.Point(29, 158);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(241, 40);
            this.TextBox2.TabIndex = 12;
            this.TextBox2.Text = "Ejecutar en orden los botones. Desde primera consulta hasta N consulta.";
            this.TextBox2.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(29, 111);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(241, 23);
            this.Button4.TabIndex = 11;
            this.Button4.Text = "N consulta a la generación del objeto G";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(29, 82);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(241, 23);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "Tercera consulta a la generación del objeto G";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(29, 53);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(241, 23);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "Segunda consulta a la generación del objeto G";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(288, 24);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(339, 240);
            this.TextBox1.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(29, 24);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(241, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Primera consulta a la generación del objeto G";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 304);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button1;
    }
}

