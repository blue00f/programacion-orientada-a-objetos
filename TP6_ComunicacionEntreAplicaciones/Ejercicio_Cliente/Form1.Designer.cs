namespace Ejercicio_Cliente
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
            label1 = new Label();
            label2 = new Label();
            txtIp = new TextBox();
            txtPuerto = new TextBox();
            btnConectar = new Button();
            txtMensaje = new TextBox();
            btnEnviarMensaje = new Button();
            txtLog = new TextBox();
            cbxDestinatario = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 80);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Puerto:";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(82, 39);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(103, 23);
            txtIp.TabIndex = 1;
            txtIp.Text = "127.0.0.1";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(82, 77);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(103, 23);
            txtPuerto.TabIndex = 2;
            txtPuerto.Text = "8050";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(82, 118);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(103, 23);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(246, 42);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(317, 23);
            txtMensaje.TabIndex = 4;
            // 
            // btnEnviarMensaje
            // 
            btnEnviarMensaje.Location = new Point(460, 80);
            btnEnviarMensaje.Name = "btnEnviarMensaje";
            btnEnviarMensaje.Size = new Size(103, 23);
            btnEnviarMensaje.TabIndex = 6;
            btnEnviarMensaje.Text = "Enviar";
            btnEnviarMensaje.UseVisualStyleBackColor = true;
            btnEnviarMensaje.Click += btnEnviarMensaje_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(34, 160);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(529, 352);
            txtLog.TabIndex = 7;
            // 
            // cbxDestinatario
            // 
            cbxDestinatario.FormattingEnabled = true;
            cbxDestinatario.Items.AddRange(new object[] { "TODOS" });
            cbxDestinatario.Location = new Point(246, 80);
            cbxDestinatario.Name = "cbxDestinatario";
            cbxDestinatario.Size = new Size(175, 23);
            cbxDestinatario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 106);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 9;
            label3.Text = "Socket del cliente destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 24);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Mensaje:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 546);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxDestinatario);
            Controls.Add(txtLog);
            Controls.Add(btnEnviarMensaje);
            Controls.Add(txtMensaje);
            Controls.Add(btnConectar);
            Controls.Add(txtPuerto);
            Controls.Add(txtIp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cliente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIp;
        private TextBox txtPuerto;
        private Button btnConectar;
        private TextBox txtMensaje;
        private Button btnEnviarMensaje;
        private TextBox txtLog;
        private ComboBox cbxDestinatario;
        private Label label3;
        private Label label4;
    }
}
