using Microsoft.VisualBasic;

namespace Herencia_02
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados;
        public Form1()
        {
            InitializeComponent();
            empleados = new List<Empleado>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is DataGridView)
                {
                    ((DataGridView)control).MultiSelect = false;
                    ((DataGridView)control).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ((DataGridView)control).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }
        private void Mostrar(DataGridView pGrilla)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = empleados.ToList();
            if (pGrilla.Columns["Legajo"] != null) pGrilla.Columns["Legajo"].FillWeight = 40;
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo;
                if (!int.TryParse(Interaction.InputBox("Ingrese el legajo", "Agregando empleado"), out legajo)) throw new Exception("El legajo debe ser numérico!");
                if (empleados.Find(x => x.Legajo == legajo) != null) throw new Exception("El legajo está repetido!");
                string nombre = Interaction.InputBox("Ingrese el nombre", "Agregando empleado");
                string apellido = Interaction.InputBox("Ingrese el apellido", "Agregando empleado");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio!");

                Empleado emp = new Empleado(nombre, apellido, legajo);
                empleados.Add(emp); Mostrar(dgvEmpleados);
                empleados.Sort(new Empleado.LegajoASC()); Mostrar(dgvLegajoAsc);
                empleados.Sort(new Empleado.LegajoDESC()); Mostrar(dgvLegajoDesc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.Rows.Count == 0) throw new Exception("No hay empleados cargados!");
                Empleado? emp = dgvEmpleados.SelectedRows[0].DataBoundItem as Empleado;
                MessageBox.Show(emp.MostrarInfo(), "Información del empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
