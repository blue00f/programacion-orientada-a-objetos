using Microsoft.VisualBasic;

namespace Ejemplo_02
{
    public partial class Form1 : Form
    {
        Universidad u;
        public Form1()
        {
            InitializeComponent();
            u = new Universidad();
        }
        private void Mostrar(DataGridView pDGV, Object pO)
        {
            pDGV.DataSource = null; pDGV.DataSource = pO;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = Interaction.InputBox("Ingrese el código de la asignatura: ", "Código Asignatura", "0");
                var descripcion = Interaction.InputBox("Ingrese la descripción de la asignatura: ", "Descripción Asignatura", "Asignatura");
                if (!Information.IsNumeric(codigo)) throw new Exception("El código debe ser numérico !!!");
                u.AgregarAsignatura(new Asignatura() { Codigo = Convert.ToInt32(codigo), Descripcion = descripcion });
                Mostrar(dataGridView1, u.ObtenerAsignaturas());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                u.EliminarAsignatura((Asignatura)dataGridView1.SelectedRows[0].DataBoundItem);
                Mostrar(dataGridView1, u.ObtenerAsignaturas());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {

                    var asignaturaOriginal = (Asignatura)dataGridView1.SelectedRows[0].DataBoundItem;
                    var codigo = Interaction.InputBox("Ingrese el código de la asignatura: ", "Código Asignatura", asignaturaOriginal.Codigo.ToString());
                    var descripcion = Interaction.InputBox("Ingrese la descripción de la asignatura: ", "Descripción Asignatura", asignaturaOriginal.Descripcion);
                    if (!Information.IsNumeric(codigo)) throw new Exception("El código debe ser numérico !!!");
                    var asignaturaModificada = new Asignatura() { Codigo = Convert.ToInt32(codigo), Descripcion = descripcion };
                    u.ModificarAsignatura(asignaturaOriginal, asignaturaModificada);
                    Mostrar(dataGridView1, u.ObtenerAsignaturas());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    var asignatura = (Asignatura)dataGridView1.SelectedRows[0].DataBoundItem;
                    var legajo = Interaction.InputBox("Ingrese el legajo del alumno: ", "Legajo Alumno", "0");
                    var nombre = Interaction.InputBox("Ingrese el nombre del alumno: ", "Nombre Alumno", "Nombre");
                    var apellido = Interaction.InputBox("Ingrese el apellido del alumno: ", "Apellido Alumno", "Apellido");
                    var alumno = new Alumno() { Legajo = legajo, Nombre = nombre, Apellido = apellido };
                    u.AsignarAlumnoAsignatura(alumno, asignatura);
                    dataGridView1_RowEnter(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView2.DataSource = ((Asignatura)dataGridView1.SelectedRows[0].DataBoundItem).ObtenerAlumnos();
                }
            }
            catch (Exception) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
            {
                var asignatura = (Asignatura)dataGridView1.SelectedRows[0].DataBoundItem;
                var alumno = (Alumno)dataGridView2.SelectedRows[0].DataBoundItem;
                u.EliminarAlumnoAsignatura(alumno, asignatura);
                Mostrar(dataGridView1, u.ObtenerAsignaturas());
                dataGridView1_RowEnter(null, null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
            {
                var asignatura = (Asignatura)dataGridView1.SelectedRows[0].DataBoundItem;
                var alumnoOriginal = (Alumno)dataGridView2.SelectedRows[0].DataBoundItem;
                var legajo = Interaction.InputBox("Ingrese el legajo del alumno: ", "Legajo Alumno", alumnoOriginal.Legajo);
                var nombre = Interaction.InputBox("Ingrese el nombre del alumno: ", "Nombre Alumno", alumnoOriginal.Nombre);
                var apellido = Interaction.InputBox("Ingrese el apellido del alumno: ", "Apellido Alumno", alumnoOriginal.Apellido);
                var alumnoModificado = new Alumno() { Legajo = legajo, Nombre = nombre, Apellido = apellido };
                u.ModificarAlumnoAsignatura(alumnoOriginal,alumnoModificado, asignatura);
                Mostrar(dataGridView1, u.ObtenerAsignaturas());
                dataGridView1_RowEnter(null, null);
            }
        }
    }
}
