namespace ControlDeAlumnos
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
            dgvAlumnos = new DataGridView();
            lblEncabezadoAlumno = new Label();
            lblLegajo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblFechaNacimiento = new Label();
            lblFechaIngreso = new Label();
            lblCantMateriasAprobadas = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCantMateriasAprobadas = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            btnAgregarAlumno = new Button();
            btnBorrarAlumno = new Button();
            btnModificarAlumno = new Button();
            txtAntiguedad = new TextBox();
            txtMateriasNoAprobadas = new TextBox();
            txtEdadIngreso = new TextBox();
            lblAntiguedad = new Label();
            lblMateriasNoAprobadas = new Label();
            lblEdadIngreso = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(485, 43);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.Size = new Size(596, 322);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            dgvAlumnos.CellDoubleClick += dgvAlumnos_CellDoubleClick;
            // 
            // lblEncabezadoAlumno
            // 
            lblEncabezadoAlumno.AutoSize = true;
            lblEncabezadoAlumno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezadoAlumno.Location = new Point(43, 43);
            lblEncabezadoAlumno.Name = "lblEncabezadoAlumno";
            lblEncabezadoAlumno.Size = new Size(172, 25);
            lblEncabezadoAlumno.TabIndex = 1;
            lblEncabezadoAlumno.Text = "Carga de alumnos";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(43, 91);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(43, 164);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(43, 203);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(43, 237);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(96, 15);
            lblFechaIngreso.TabIndex = 6;
            lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblCantMateriasAprobadas
            // 
            lblCantMateriasAprobadas.AutoSize = true;
            lblCantMateriasAprobadas.Location = new Point(43, 273);
            lblCantMateriasAprobadas.Name = "lblCantMateriasAprobadas";
            lblCantMateriasAprobadas.Size = new Size(177, 15);
            lblCantMateriasAprobadas.TabIndex = 7;
            lblCantMateriasAprobadas.Text = "Cantidad de materias aprobadas";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(233, 91);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(213, 23);
            txtLegajo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(233, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(233, 161);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtCantMateriasAprobadas
            // 
            txtCantMateriasAprobadas.Location = new Point(233, 270);
            txtCantMateriasAprobadas.Name = "txtCantMateriasAprobadas";
            txtCantMateriasAprobadas.Size = new Size(213, 23);
            txtCantMateriasAprobadas.TabIndex = 11;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(233, 203);
            dtpFechaNacimiento.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1890, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(213, 23);
            dtpFechaNacimiento.TabIndex = 12;
            dtpFechaNacimiento.Value = new DateTime(2025, 4, 27, 0, 0, 0, 0);
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(233, 237);
            dtpFechaIngreso.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFechaIngreso.MinDate = new DateTime(1890, 12, 31, 0, 0, 0, 0);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(213, 23);
            dtpFechaIngreso.TabIndex = 13;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(43, 321);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(117, 44);
            btnAgregarAlumno.TabIndex = 14;
            btnAgregarAlumno.Text = "Agregar";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // btnBorrarAlumno
            // 
            btnBorrarAlumno.Location = new Point(185, 321);
            btnBorrarAlumno.Name = "btnBorrarAlumno";
            btnBorrarAlumno.Size = new Size(117, 44);
            btnBorrarAlumno.TabIndex = 15;
            btnBorrarAlumno.Text = "Borrar";
            btnBorrarAlumno.UseVisualStyleBackColor = true;
            btnBorrarAlumno.Click += btnBorrarAlumno_Click;
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.Location = new Point(329, 321);
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.Size = new Size(117, 44);
            btnModificarAlumno.TabIndex = 16;
            btnModificarAlumno.Text = "Modificar";
            btnModificarAlumno.UseVisualStyleBackColor = true;
            btnModificarAlumno.Click += btnModificarAlumno_Click;
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(485, 401);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.ReadOnly = true;
            txtAntiguedad.Size = new Size(129, 23);
            txtAntiguedad.TabIndex = 17;
            // 
            // txtMateriasNoAprobadas
            // 
            txtMateriasNoAprobadas.Location = new Point(636, 401);
            txtMateriasNoAprobadas.Name = "txtMateriasNoAprobadas";
            txtMateriasNoAprobadas.ReadOnly = true;
            txtMateriasNoAprobadas.Size = new Size(129, 23);
            txtMateriasNoAprobadas.TabIndex = 18;
            // 
            // txtEdadIngreso
            // 
            txtEdadIngreso.Location = new Point(795, 401);
            txtEdadIngreso.Name = "txtEdadIngreso";
            txtEdadIngreso.ReadOnly = true;
            txtEdadIngreso.Size = new Size(129, 23);
            txtEdadIngreso.TabIndex = 19;
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(485, 383);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(69, 15);
            lblAntiguedad.TabIndex = 20;
            lblAntiguedad.Text = "Antiguedad";
            // 
            // lblMateriasNoAprobadas
            // 
            lblMateriasNoAprobadas.AutoSize = true;
            lblMateriasNoAprobadas.Location = new Point(636, 383);
            lblMateriasNoAprobadas.Name = "lblMateriasNoAprobadas";
            lblMateriasNoAprobadas.Size = new Size(127, 15);
            lblMateriasNoAprobadas.TabIndex = 21;
            lblMateriasNoAprobadas.Text = "Materias no aprobadas";
            // 
            // lblEdadIngreso
            // 
            lblEdadIngreso.AutoSize = true;
            lblEdadIngreso.Location = new Point(795, 383);
            lblEdadIngreso.Name = "lblEdadIngreso";
            lblEdadIngreso.Size = new Size(91, 15);
            lblEdadIngreso.TabIndex = 22;
            lblEdadIngreso.Text = "Edad de ingreso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 459);
            Controls.Add(lblEdadIngreso);
            Controls.Add(lblMateriasNoAprobadas);
            Controls.Add(lblAntiguedad);
            Controls.Add(txtEdadIngreso);
            Controls.Add(txtMateriasNoAprobadas);
            Controls.Add(txtAntiguedad);
            Controls.Add(btnModificarAlumno);
            Controls.Add(btnBorrarAlumno);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtCantMateriasAprobadas);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Controls.Add(lblCantMateriasAprobadas);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblLegajo);
            Controls.Add(lblEncabezadoAlumno);
            Controls.Add(dgvAlumnos);
            Name = "Form1";
            Text = "Carga de información del alumno";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private Label lblEncabezadoAlumno;
        private Label lblLegajo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblFechaIngreso;
        private Label lblCantMateriasAprobadas;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCantMateriasAprobadas;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Button btnAgregarAlumno;
        private Button btnBorrarAlumno;
        private Button btnModificarAlumno;
        private TextBox txtAntiguedad;
        private TextBox txtMateriasNoAprobadas;
        private TextBox txtEdadIngreso;
        private Label lblAntiguedad;
        private Label lblMateriasNoAprobadas;
        private Label lblEdadIngreso;
    }
}
