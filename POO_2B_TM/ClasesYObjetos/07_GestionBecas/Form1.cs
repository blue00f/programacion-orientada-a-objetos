using _1erParcial.Entidades;
using Microsoft.VisualBasic;

namespace _1erParcial
{
    public partial class Form1 : Form
    {
        Universidad u;
        public Form1()
        {
            InitializeComponent();
            u = new Universidad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            { if (c is DataGridView) { ((DataGridView)c).MultiSelect = false; ((DataGridView)c).SelectionMode = DataGridViewSelectionMode.FullRowSelect; } }
        }
        private void Mostrar(DataGridView dgv, List<object> lista)
        {
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                AltaAlumno(new Ingresante());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void AltaAlumno(Alumno pAlumno)
        {
            var legajo = Interaction.InputBox("Legajo: ");
            pAlumno.Legajo = legajo;
            if (u.ValidaCodigoAlumno(pAlumno)) throw new Exception("El legajo ya existe.");
            pAlumno.Nombre = Interaction.InputBox("Nombre: ");
            pAlumno.Apeliido = Interaction.InputBox("Apellido: ");
            pAlumno.Dni = Interaction.InputBox("DNI: ");
            var cuota = Interaction.InputBox("Cuota: ");
            if (!Information.IsNumeric(cuota)) throw new Exception("La cuota debe ser un valor numérico.");
            pAlumno.AsignarCuota(new Cuota() { Importe = Convert.ToDecimal(cuota) });
            u.AgregarAlumno(pAlumno);
            Mostrar(dataGridView1, u.RetornaAlumnos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaAlumno(new Grado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaAlumno(new PosGrado());
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay alumnos para borrar !!!");
                Alumno a = new Ingresante() { Legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() };
                u.BorrarAlumno(a);
                Mostrar(dataGridView1, u.RetornaAlumnos());
                dataGridView1_RowEnter(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay alumnos para modificar !!!");
                Alumno a = new Ingresante() { Legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() };
                a.Nombre = Interaction.InputBox("Nombre: ", "", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                a.Apeliido = Interaction.InputBox("Apellido: ", "", dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                a.Dni = Interaction.InputBox("DNI: ", "", dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                u.ModificarAlumno(a);
                Mostrar(dataGridView1, u.RetornaAlumnos());
                dataGridView1_RowEnter(null, null);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay alumnos para asignar Beca !!!");
                var codigo = Interaction.InputBox("Código de Beca: ");
                if (codigo.Length != 6) throw new Exception("El código de Beca debe tener 6 caracteres.");
                if (!Information.IsNumeric(codigo.Substring(0, 4))) throw new Exception("Los primeros 4 caracteres del código de Beca deben ser numéricos.");
                if ((codigo[4] > 'z' || codigo[4] < 'A') || codigo[4] > 90 && codigo[4] < 97) throw new Exception("El quinto carácter del código de Beca debe ser una letra mayúscula o minúscula.");
                if ((codigo[5] > 'z' || codigo[5] < 'A') || codigo[5] > 90 && codigo[5] < 97) throw new Exception("El sexto carácter del código de Beca debe ser una letra mayúscula o minúscula.");
                var fecha = Interaction.InputBox("Fecha de Asignación (dd/mm/yyyy): ");
                if (!Information.IsDate(fecha)) throw new Exception("La fecha de asignación debe ser una fecha válida.");
                var importe = Interaction.InputBox("Importe de Beca: ");
                if (!Information.IsNumeric(importe)) throw new Exception("El importe de Beca debe ser un valor numérico.");
                if (Convert.ToDecimal(importe) > Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString())) throw new Exception("La beca no puede ser mayor que la cuota a abonar.");
                u.Crear_Asignar_Beca(new Ingresante() { Legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() }, new Beca() { Codigo = codigo, Fecha = Convert.ToDateTime(fecha), Importe = Convert.ToDecimal(importe) });
                Mostrar(dataGridView2, u.RetornaBecas());
                dataGridView1_RowEnter(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    Alumno a = new Ingresante() { Legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() };
                    Mostrar(dataGridView3, u.RetornaBecaAlumno(a));
                }
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alumno a = new Ingresante() { Legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() };
            MessageBox.Show($"El importe que debe abonar es: $ {u.CalcularPago(a)}");
        }
    }
}
