namespace ActividadIntegradora_01
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
            dgvPersonas = new DataGridView();
            dgvAutos = new DataGridView();
            dgvAutosDePersona = new DataGridView();
            dgvInformacion = new DataGridView();
            btnAgregarAuto = new Button();
            btnBorrarAuto = new Button();
            btnModificarAuto = new Button();
            label1 = new Label();
            label2 = new Label();
            btnModificarPersona = new Button();
            btnBorrarPersona = new Button();
            btnAgregarPersona = new Button();
            btnAsignarPersonaAuto = new Button();
            label3 = new Label();
            label4 = new Label();
            lblAcumPrecioPorPersona = new Label();
            marca = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            modelo = new DataGridViewTextBoxColumn();
            patente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutosDePersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInformacion).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(47, 57);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.Size = new Size(346, 237);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.RowEnter += dgvPersonas_RowEnter;
            // 
            // dgvAutos
            // 
            dgvAutos.AllowUserToAddRows = false;
            dgvAutos.AllowUserToDeleteRows = false;
            dgvAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutos.Location = new Point(576, 57);
            dgvAutos.Name = "dgvAutos";
            dgvAutos.ReadOnly = true;
            dgvAutos.Size = new Size(672, 237);
            dgvAutos.TabIndex = 1;
            // 
            // dgvAutosDePersona
            // 
            dgvAutosDePersona.AllowUserToAddRows = false;
            dgvAutosDePersona.AllowUserToDeleteRows = false;
            dgvAutosDePersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutosDePersona.Location = new Point(47, 419);
            dgvAutosDePersona.Name = "dgvAutosDePersona";
            dgvAutosDePersona.ReadOnly = true;
            dgvAutosDePersona.Size = new Size(346, 237);
            dgvAutosDePersona.TabIndex = 2;
            // 
            // dgvInformacion
            // 
            dgvInformacion.AllowUserToAddRows = false;
            dgvInformacion.AllowUserToDeleteRows = false;
            dgvInformacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformacion.Columns.AddRange(new DataGridViewColumn[] { marca, anio, modelo, patente, dni, nombre });
            dgvInformacion.Location = new Point(576, 419);
            dgvInformacion.Name = "dgvInformacion";
            dgvInformacion.ReadOnly = true;
            dgvInformacion.Size = new Size(672, 237);
            dgvInformacion.TabIndex = 3;
            // 
            // btnAgregarAuto
            // 
            btnAgregarAuto.Location = new Point(749, 305);
            btnAgregarAuto.Name = "btnAgregarAuto";
            btnAgregarAuto.Size = new Size(92, 30);
            btnAgregarAuto.TabIndex = 4;
            btnAgregarAuto.Text = "Agregar";
            btnAgregarAuto.UseVisualStyleBackColor = true;
            btnAgregarAuto.Click += btnAgregarAuto_Click;
            // 
            // btnBorrarAuto
            // 
            btnBorrarAuto.Location = new Point(875, 305);
            btnBorrarAuto.Name = "btnBorrarAuto";
            btnBorrarAuto.Size = new Size(92, 30);
            btnBorrarAuto.TabIndex = 5;
            btnBorrarAuto.Text = "Borrar";
            btnBorrarAuto.UseVisualStyleBackColor = true;
            btnBorrarAuto.Click += btnBorrarAuto_Click;
            // 
            // btnModificarAuto
            // 
            btnModificarAuto.Location = new Point(1003, 305);
            btnModificarAuto.Name = "btnModificarAuto";
            btnModificarAuto.Size = new Size(92, 30);
            btnModificarAuto.TabIndex = 6;
            btnModificarAuto.Text = "Modificar";
            btnModificarAuto.UseVisualStyleBackColor = true;
            btnModificarAuto.Click += btnModificarAuto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 7;
            label1.Text = "PERSONAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(576, 18);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 8;
            label2.Text = "AUTOS";
            // 
            // btnModificarPersona
            // 
            btnModificarPersona.Location = new Point(301, 305);
            btnModificarPersona.Name = "btnModificarPersona";
            btnModificarPersona.Size = new Size(92, 30);
            btnModificarPersona.TabIndex = 11;
            btnModificarPersona.Text = "Modificar";
            btnModificarPersona.UseVisualStyleBackColor = true;
            btnModificarPersona.Click += btnModificarPersona_Click;
            // 
            // btnBorrarPersona
            // 
            btnBorrarPersona.Location = new Point(173, 305);
            btnBorrarPersona.Name = "btnBorrarPersona";
            btnBorrarPersona.Size = new Size(92, 30);
            btnBorrarPersona.TabIndex = 10;
            btnBorrarPersona.Text = "Borrar";
            btnBorrarPersona.UseVisualStyleBackColor = true;
            btnBorrarPersona.Click += btnBorrarPersona_Click;
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.Location = new Point(47, 305);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(92, 30);
            btnAgregarPersona.TabIndex = 9;
            btnAgregarPersona.Text = "Agregar";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // btnAsignarPersonaAuto
            // 
            btnAsignarPersonaAuto.Location = new Point(439, 166);
            btnAsignarPersonaAuto.Name = "btnAsignarPersonaAuto";
            btnAsignarPersonaAuto.Size = new Size(92, 30);
            btnAsignarPersonaAuto.TabIndex = 12;
            btnAsignarPersonaAuto.Text = "Asignar auto";
            btnAsignarPersonaAuto.UseVisualStyleBackColor = true;
            btnAsignarPersonaAuto.Click += btnAsignarPersonaAuto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 380);
            label3.Name = "label3";
            label3.Size = new Size(223, 25);
            label3.TabIndex = 13;
            label3.Text = "AUTOS DE LA PERSONA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(576, 380);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 14;
            label4.Text = "INFORMACION";
            // 
            // lblAcumPrecioPorPersona
            // 
            lblAcumPrecioPorPersona.AutoSize = true;
            lblAcumPrecioPorPersona.Location = new Point(47, 659);
            lblAcumPrecioPorPersona.Name = "lblAcumPrecioPorPersona";
            lblAcumPrecioPorPersona.Size = new Size(202, 15);
            lblAcumPrecioPorPersona.TabIndex = 15;
            lblAcumPrecioPorPersona.Text = "Valor total de los autos de la persona:";
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.ReadOnly = true;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.Name = "anio";
            anio.ReadOnly = true;
            // 
            // modelo
            // 
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            modelo.ReadOnly = true;
            // 
            // patente
            // 
            patente.HeaderText = "Patente";
            patente.Name = "patente";
            patente.ReadOnly = true;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre y Apellido";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 716);
            Controls.Add(lblAcumPrecioPorPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAsignarPersonaAuto);
            Controls.Add(btnModificarPersona);
            Controls.Add(btnBorrarPersona);
            Controls.Add(btnAgregarPersona);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificarAuto);
            Controls.Add(btnBorrarAuto);
            Controls.Add(btnAgregarAuto);
            Controls.Add(dgvInformacion);
            Controls.Add(dgvAutosDePersona);
            Controls.Add(dgvAutos);
            Controls.Add(dgvPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAutosDePersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInformacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private DataGridView dgvAutos;
        private DataGridView dgvAutosDePersona;
        private DataGridView dgvInformacion;
        private Button btnAgregarAuto;
        private Button btnBorrarAuto;
        private Button btnModificarAuto;
        private Label label1;
        private Label label2;
        private Button btnModificarPersona;
        private Button btnBorrarPersona;
        private Button btnAgregarPersona;
        private Button btnAsignarPersonaAuto;
        private Label label3;
        private Label label4;
        private Label lblAcumPrecioPorPersona;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn anio;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn patente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
    }
}
