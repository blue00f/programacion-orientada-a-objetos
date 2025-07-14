namespace Ejercicio_Servidor
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
            txtMensaje = new TextBox();
            btnEnviarMensaje = new Button();
            txtLog = new TextBox();
            grillaClientes = new DataGridView();
            btnEnviarMensajeAUnCliente = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            SuspendLayout();
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(35, 35);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(573, 23);
            txtMensaje.TabIndex = 0;
            // 
            // btnEnviarMensaje
            // 
            btnEnviarMensaje.Location = new Point(647, 35);
            btnEnviarMensaje.Name = "btnEnviarMensaje";
            btnEnviarMensaje.Size = new Size(132, 50);
            btnEnviarMensaje.TabIndex = 1;
            btnEnviarMensaje.Text = "Enviar mensaje a todos los clientes";
            btnEnviarMensaje.UseVisualStyleBackColor = true;
            btnEnviarMensaje.Click += btnEnviarMensaje_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(35, 101);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(573, 428);
            txtLog.TabIndex = 3;
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Location = new Point(647, 101);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.Size = new Size(324, 428);
            grillaClientes.TabIndex = 4;
            // 
            // btnEnviarMensajeAUnCliente
            // 
            btnEnviarMensajeAUnCliente.Location = new Point(839, 35);
            btnEnviarMensajeAUnCliente.Name = "btnEnviarMensajeAUnCliente";
            btnEnviarMensajeAUnCliente.Size = new Size(132, 50);
            btnEnviarMensajeAUnCliente.TabIndex = 2;
            btnEnviarMensajeAUnCliente.Text = "Enviar mensaje al cliente seleccionado";
            btnEnviarMensajeAUnCliente.UseVisualStyleBackColor = true;
            btnEnviarMensajeAUnCliente.Click += btnEnviarMensajeAUnCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Mensaje:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 553);
            Controls.Add(label1);
            Controls.Add(btnEnviarMensajeAUnCliente);
            Controls.Add(grillaClientes);
            Controls.Add(txtLog);
            Controls.Add(btnEnviarMensaje);
            Controls.Add(txtMensaje);
            Name = "Form1";
            Text = "Servidor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMensaje;
        private Button btnEnviarMensaje;
        private TextBox txtLog;
        private DataGridView grillaClientes;
        private Button btnEnviarMensajeAUnCliente;
        private Label label1;
    }
}
