using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Futbolista> futbolistas = new List<Futbolista>();

        private void Form1_Load(object sender, EventArgs e)
        {
            futbolistas.AddRange(new List<Futbolista>
            { 
                new (1, "Sergio", "Almirón"),
                new (2, "Sergio", "Batista"),
                new (3, "Ricardo Enrique", "Bochini"),
                new (4, "Claudio", "Borghi"),
                new (5, "José Luis", "Brown"),
                new (6, "Daniel", "Passarella"),
                new (7, "Jorge", "Burruchaga"),
                new (8, "Néstor", "Clausen"),
                new (9, "José Luis", "Cuciuffo"),
                new (10, "Diego", "Maradona"),
                new (11, "Jorge", "Valdano"),
                new (12, "Héctor", "Enrique")
            });

            foreach (var c in this.Controls)
            {
                if (c is DataGridView)
                {
                    ((DataGridView)c).MultiSelect = false;
                    ((DataGridView)c).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }

            Mostrar(grillaFutbolistas, futbolistas);
            Mostrar(grillaFiltroPorNombre, futbolistas);
        }

        private void Mostrar(DataGridView pGrilla, object pDatos)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pDatos;
        }
        private void txtBuscadorApe_TextChanged(object sender, EventArgs e)
        {
            var Consulta = (from a in futbolistas where txtBuscadorApe.Text.ToString() == a.Apellido.ToString().Substring(0, txtBuscadorApe.Text.Length) select a).ToList<Futbolista>();
            Mostrar(grillaFiltroPorNombre, Consulta);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt16(Interaction.InputBox("Ingrese el número:"));
                if (futbolistas.Find(x => x.Numero == numero) != null) throw new Exception("Número repetido!");

                string nombre = Interaction.InputBox("Ingrese el nombre:", "Alta alumno");
                string apellido = Interaction.InputBox("Ingrese el apellido:", "Alta alumno");

                Futbolista f = new(numero, nombre, apellido);
                futbolistas.Add(f);

                Mostrar(grillaFutbolistas, futbolistas);

                if (txtBuscadorApe.Text == "") Mostrar(grillaFiltroPorNombre, futbolistas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaFutbolistas.Rows.Count == 0) throw new Exception("No hay futbolistas en la grilla!");
                var a = grillaFutbolistas.SelectedRows[0].DataBoundItem as Futbolista;

                futbolistas.Remove(a);
                Mostrar(grillaFutbolistas, futbolistas);
                Mostrar(grillaFiltroPorNombre, futbolistas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaFutbolistas.Rows.Count == 0) throw new Exception("No hay futbolistas en la grilla!");
                var f = grillaFutbolistas.SelectedRows[0].DataBoundItem as Futbolista;

                string nombre = Interaction.InputBox("Ingrese el nombre:", "Modificar alumno", f.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido:", "Modificar alumno", f.Apellido);

                f.Nombre = nombre;
                f.Apellido = apellido;

                Mostrar(grillaFutbolistas, futbolistas);
                Mostrar(grillaFiltroPorNombre, futbolistas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaFutbolistas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grillaFutbolistas.Rows.Count > 0)
                {
                    var ConsultaApe = (from f in futbolistas orderby f.Apellido descending select f).ToList<Futbolista>();
                    var ConsultaLeg = (from f in futbolistas orderby f.Numero descending select f).ToList<Futbolista>();

                    Mostrar(grillaApellidoDesc, ConsultaApe);
                    Mostrar(grillaNumeroDesc, ConsultaLeg);
                }
            }
            catch (Exception)
            { }
        }

        private void btnBuscarPorRangoNum_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaFutbolistas.Rows.Count == 0) throw new Exception("No hay futbolistas en la grilla!");
                var fut = grillaFutbolistas.SelectedRows[0].DataBoundItem as Futbolista;

                int numDesde = Convert.ToInt16(Interaction.InputBox("Ingrese el número inicial", "Búsqueda de número por rango"));
                if (numDesde < 1 || numDesde > futbolistas.Count) throw new Exception("El número inicial es incorrecto!");

                int numHasta = Convert.ToInt16(Interaction.InputBox("Ingrese el número final", "Búsqueda de número por rango"));
                if (numHasta < 1 || numHasta > futbolistas.Count) throw new Exception("El número inicial es incorrecto!");

                var Consulta = (from f in futbolistas where f.Numero >= numDesde && f.Numero <= numHasta select f).ToList<Futbolista>();
                Mostrar(grillaRangoDeNumero, Consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
