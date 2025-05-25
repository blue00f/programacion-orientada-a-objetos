namespace EventoEstatico
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
            txtNombre = new TextBox();
            txtTemperatura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lstTemperaturas = new ListBox();
            btnCrearSensor = new Button();
            btnActualizarTemp = new Button();
            btnResetearTemp = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(42, 212);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(117, 23);
            txtTemperatura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 73);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del sensor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 194);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Temperatura";
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 15;
            lstTemperaturas.Location = new Point(197, 31);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(327, 304);
            lstTemperaturas.TabIndex = 4;
            // 
            // btnCrearSensor
            // 
            btnCrearSensor.Location = new Point(42, 120);
            btnCrearSensor.Name = "btnCrearSensor";
            btnCrearSensor.Size = new Size(117, 23);
            btnCrearSensor.TabIndex = 5;
            btnCrearSensor.Text = "Crear sensor";
            btnCrearSensor.UseVisualStyleBackColor = true;
            btnCrearSensor.Click += btnCrearSensor_Click;
            // 
            // btnActualizarTemp
            // 
            btnActualizarTemp.Location = new Point(42, 241);
            btnActualizarTemp.Name = "btnActualizarTemp";
            btnActualizarTemp.Size = new Size(117, 23);
            btnActualizarTemp.TabIndex = 6;
            btnActualizarTemp.Text = "Actualizar temperatura";
            btnActualizarTemp.UseVisualStyleBackColor = true;
            btnActualizarTemp.Click += btnActualizarTemp_Click;
            // 
            // btnResetearTemp
            // 
            btnResetearTemp.Location = new Point(42, 270);
            btnResetearTemp.Name = "btnResetearTemp";
            btnResetearTemp.Size = new Size(117, 23);
            btnResetearTemp.TabIndex = 7;
            btnResetearTemp.Text = "Resetear";
            btnResetearTemp.UseVisualStyleBackColor = true;
            btnResetearTemp.Click += btnResetearTemp_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 299);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 360);
            Controls.Add(btnSalir);
            Controls.Add(btnResetearTemp);
            Controls.Add(btnActualizarTemp);
            Controls.Add(btnCrearSensor);
            Controls.Add(lstTemperaturas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTemperatura);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTemperatura;
        private Label label1;
        private Label label2;
        private ListBox lstTemperaturas;
        private Button btnCrearSensor;
        private Button btnActualizarTemp;
        private Button btnResetearTemp;
        private Button btnSalir;
    }
}
