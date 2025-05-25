using System.Runtime.CompilerServices;

namespace ControlDeAlumnos
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alumnos = new List<Alumno>();
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Mostrar(DataGridView pGrilla, List<Alumno> pLista)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pLista;
        }
        public void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCantMateriasAprobadas.Text = "";
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                DateOnly fechaNacimiento = DateOnly.Parse(dtpFechaNacimiento.Text);
                DateOnly fechaIngreso = DateOnly.Parse(dtpFechaIngreso.Text);
                int cantMateriasAprobadas;

                if (!int.TryParse(txtLegajo.Text, out legajo)) throw new Exception("El legajo debe ser numérico!");
                if (nombre.Length == 0) throw new Exception("El nombre no debe estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no debe estar vacio!");
                if (!int.TryParse(txtCantMateriasAprobadas.Text, out cantMateriasAprobadas)) throw new Exception("La cantidad de materias aprobadas debe ser numérica!");
                if (alumnos.Find(x => x.Legajo == legajo) != null) throw new Exception("El legajo esta repetido!");

                Alumno a = new Alumno(legajo, nombre, apellido, fechaNacimiento, fechaIngreso, cantMateriasAprobadas);
                alumnos.Add(a);
                Mostrar(dgvAlumnos, alumnos);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.Rows.Count == 0) throw new Exception("No hay alumnos para borrar!");
                Alumno a = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                alumnos.Remove(a);
                Mostrar(dgvAlumnos, alumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.Rows.Count == 0) throw new Exception("No hay alumnos para borrar!");
                Alumno a = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;

                int legajo;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                DateOnly fechaNacimiento = DateOnly.Parse(dtpFechaNacimiento.Text);
                DateOnly fechaIngreso = DateOnly.Parse(dtpFechaIngreso.Text);
                int cantMateriasAprobadas;

                if (!int.TryParse(txtLegajo.Text, out legajo)) throw new Exception("El legajo debe ser numérico!");
                if (nombre.Length == 0) throw new Exception("El nombre no debe estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no debe estar vacio!");
                if (!int.TryParse(txtCantMateriasAprobadas.Text, out cantMateriasAprobadas)) throw new Exception("La cantidad de materias aprobadas debe ser numérica!");

                a.Legajo = legajo;
                a.Nombre = nombre;
                a.Apellido = apellido;
                a.Fecha_Nacimiento = fechaNacimiento;
                a.Fecha_Ingreso = fechaIngreso;
                a.Cant_Materia_Aprobadas = cantMateriasAprobadas;
                Mostrar(dgvAlumnos, alumnos);
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];
                txtLegajo.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellido.Text = fila.Cells[2].Value.ToString();
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno a = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;

            if (a.Antiguedad(Alumno.TipoRetorno.Meses) < 12)
            {
                txtAntiguedad.Text = $"{a.Antiguedad(Alumno.TipoRetorno.Meses).ToString()} meses";
            }
            else
            {
                txtAntiguedad.Text = $"{a.Antiguedad(Alumno.TipoRetorno.Anios).ToString()} años";
            }
                txtMateriasNoAprobadas.Text = a.Materias_No_Aprobadas().ToString();
            txtEdadIngreso.Text = a.Edad_De_Ingreso().ToString();
        }
    }
}
