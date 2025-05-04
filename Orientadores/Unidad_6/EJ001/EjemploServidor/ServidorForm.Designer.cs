namespace EjemploServidor
{
    partial class ServidorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(409, 12);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(127, 49);
            this.btnEnviarMensaje.TabIndex = 3;
            this.btnEnviarMensaje.Text = "Enviar mensaje a todos los clientes";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(12, 12);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(391, 21);
            this.txtMensaje.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 67);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(524, 416);
            this.txtLog.TabIndex = 4;
            this.txtLog.WordWrap = false;
            // 
            // ServidorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 495);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Name = "ServidorForm";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtLog;
    }
}

