using Microsoft.VisualBasic;
using System.CodeDom;

namespace ActividadIntegradora_01
{
    public partial class Form1 : Form
    {
        List<Persona> listaPersonas;
        List<Auto> listaAutos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPersonas = new List<Persona>();
            listaAutos = new List<Auto>();

            dgvPersonas.MultiSelect = true;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAutos.MultiSelect = true;
            dgvAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAutosDePersona.MultiSelect = true;
            dgvAutosDePersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvInformacion.MultiSelect = true;
            dgvInformacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region "Funciones de servicio"

        private void Mostrar(DataGridView pGrilla, Object pLista)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pLista;
        }
        private void MostrarInfoGrilla()
        {
            dgvInformacion.Rows.Clear();
            foreach (var a in listaAutos)
            {
                if (a.PersonaDuenio != null)
                {
                    dgvInformacion.Rows.Add(a.Marca, a.Anio, a.Modelo, a.Patente, a.PersonaDuenio.DNI, $"{a.PersonaDuenio.Nombre}, {a.PersonaDuenio.Apellido}");
                }
            }
        }
        private void dgvPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Persona p = (Persona)dgvPersonas.Rows[e.RowIndex].DataBoundItem;
                    decimal total = p.Lista_de_autos().Sum(a => a.Precio);
                    lblAcumPrecioPorPersona.Text = $"Precio total de los autos: ${total}";
                    Mostrar(dgvAutosDePersona, p.Lista_de_autos());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "ABM_Persona"
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = Interaction.InputBox("Ingrese el DNI:", "DATOS PERSONA");
                string nombre = Interaction.InputBox("Ingrese el nombre:", "DATOS PERSONA");
                string apellido = Interaction.InputBox("Ingrese el apellido:", "DATOS PERSONA");

                if (dni.Length == 0) throw new Exception("El DNI está vacio!");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido está vacio!");

                Persona p = new Persona(dni, nombre, apellido);
                listaPersonas.Add(p);
                Mostrar(dgvPersonas, listaPersonas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count == 0) throw new Exception("No se puede borrar porque no hay registros de personas!");
                Persona p = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                listaPersonas.Remove(p);
                MostrarInfoGrilla();
                Mostrar(dgvPersonas, listaPersonas);
                Mostrar(dgvAutosDePersona, p.Lista_de_autos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count == 0) throw new Exception("No se puede modificar porque no hay registros de personas!");
                Persona pViejo = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;

                string dni = Interaction.InputBox("Ingrese el DNI:", "DATOS PERSONA", pViejo.DNI);
                string nombre = Interaction.InputBox("Ingrese el nombre:", "DATOS PERSONA", pViejo.Nombre);
                string apellido = Interaction.InputBox("Ingrese el apellido:", "DATOS PERSONA", pViejo.Apellido);

                if (dni.Length == 0) throw new Exception("El DNI está vacio!");
                if (nombre.Length == 0) throw new Exception("El nombre está vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido está vacio!");

                pViejo.DNI = dni;
                pViejo.Nombre = nombre;
                pViejo.Apellido = apellido;

                MostrarInfoGrilla();
                Mostrar(dgvPersonas, listaPersonas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "ABM_Auto"
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = Interaction.InputBox("Ingrese la patente:", "DATOS AUTO");
                string marca = Interaction.InputBox("Ingrese la marca:", "DATOS AUTO");
                string modelo = Interaction.InputBox("Ingrese el modelo:", "DATOS AUTO");
                string anio = Interaction.InputBox("Ingrese el año:", "DATOS AUTO");
                decimal precio;

                if (patente.Length == 0) throw new Exception("La patente está vacia!");
                if (marca.Length == 0) throw new Exception("La marca está vacia!");
                if (modelo.Length == 0) throw new Exception("El modelo está vacio!");
                if (anio.Length == 0) throw new Exception("El año está vacio!");
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el precio:", "DATOS AUTO"), out precio)) throw new Exception("El precio debe ser decimal!");

                Auto a = new Auto(patente, marca, modelo, anio, precio);
                listaAutos.Add(a);
                Mostrar(dgvAutos, listaAutos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAutos.Rows.Count == 0) throw new Exception("No se puede borrar porque no hay registros de autos!");
                Auto a = (Auto)dgvAutos.SelectedRows[0].DataBoundItem;
                listaAutos.Remove(a);
                MostrarInfoGrilla();
                Mostrar(dgvAutos, listaAutos);

                // Se actualiza la grilla 3
                Persona p = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                Mostrar(dgvAutosDePersona, p.Lista_de_autos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAutos.Rows.Count == 0) throw new Exception("No se puede borrar porque no hay registros de autos!");
                Auto aViejo = (Auto)dgvAutos.SelectedRows[0].DataBoundItem;

                string patente = Interaction.InputBox("Ingrese la patente:", "DATOS AUTO", aViejo.Patente);
                string marca = Interaction.InputBox("Ingrese la marca:", "DATOS AUTO", aViejo.Marca);
                string modelo = Interaction.InputBox("Ingrese el modelo:", "DATOS AUTO", aViejo.Modelo);
                string anio = Interaction.InputBox("Ingrese el año:", "DATOS AUTO", aViejo.Anio);
                decimal precio;

                if (patente.Length == 0) throw new Exception("La patente está vacia!");
                if (marca.Length == 0) throw new Exception("La marca está vacia!");
                if (modelo.Length == 0) throw new Exception("El modelo está vacio!");
                if (anio.Length == 0) throw new Exception("El año está vacio!");
                if (!decimal.TryParse(Interaction.InputBox("Ingrese el precio:", "DATOS AUTO", aViejo.Precio.ToString()), out precio)) throw new Exception("El precio debe ser decimal!");

                aViejo.Patente = patente;
                aViejo.Marca = marca;
                aViejo.Modelo = modelo;
                aViejo.Anio = anio;
                aViejo.Precio = precio;

                MostrarInfoGrilla();
                Mostrar(dgvAutos, listaAutos);

                // Se actualiza la grilla 3
                Persona p = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                Mostrar(dgvAutosDePersona, p.Lista_de_autos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Relacion entre Persona y Auto"
        private void btnAsignarPersonaAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count == 0) throw new Exception("No hay registro de personas para asignar!");
                if (dgvAutos.Rows.Count == 0) throw new Exception("No hay autos para que sean asignados!");
                Persona p = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                Auto a = (Auto)dgvAutos.SelectedRows[0].DataBoundItem;

                p.AgregarAuto(a);

                Mostrar(dgvAutosDePersona, p.Lista_de_autos());
                MostrarInfoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
