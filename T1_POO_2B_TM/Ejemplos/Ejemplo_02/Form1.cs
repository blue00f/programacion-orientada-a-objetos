using Microsoft.VisualBasic;

namespace Ejemplo_02
{
    public partial class Form1 : Form
    {
        Agenda a;
        public Form1()
        {
            InitializeComponent();
            a = new Agenda();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pDNI = "";
            string pNombre = "";
            string pApellido = "";
            IngresaDatosPersona(new Persona() { DNI = "00000000", Nombre = "Nombre", Apellido = "Apellido" }, out pDNI, out pNombre, out pApellido);
            Persona p = new Persona() { DNI = pDNI, Nombre = pNombre, Apellido = pApellido };
            a.AgregarPersona(p);
            Mostrar(dataGridView1, a.ObtenerPersonas());
        }
        private void Mostrar(DataGridView pDGV, Object pO)
        { pDGV.DataSource = null; pDGV.DataSource = pO; }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Persona pa = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                string pDNI = "";
                string pNombre = "";
                string pApellido = "";
                IngresaDatosPersona(pa, out pDNI, out pNombre, out pApellido);
                Persona px = new Persona() { DNI = pDNI, Nombre = pNombre, Apellido = pApellido };
                a.ModificarPersona(pa, px);
                Mostrar(dataGridView1, a.ObtenerPersonas());
                dataGridView1_RowEnter(null, null);
            }
        }

        private void IngresaDatosPersona(Persona pa, out string pDNI, out string pNombre, out string pApellido)
        {
            pDNI = Interaction.InputBox("Ingrese el DNI de la persona", "DNI", pa.DNI);
            pNombre = Interaction.InputBox("Ingrese el Nombre de la persona", "Nombre", pa.Nombre);
            pApellido = Interaction.InputBox("Ingrese el Apellido de la persona", "Apellido", pa.Apellido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Persona pa = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                a.EliminarPersona(pa);
                Mostrar(dataGridView1, a.ObtenerPersonas());
                dataGridView1_RowEnter(null, null);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Persona p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                var valor = Interaction.InputBox("Ingrese el valor del contacto", "Valor", "00000000");
                var descripcion = Interaction.InputBox("Ingrese la descripcion del contacto", "Descripcion", "Descripcion");
                Contacto c = new Contacto() { Valor = valor, Descripcion = descripcion };
                a.AgregarContactoPersona(p, c);
                dataGridView1_RowEnter(null, null);

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    var p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                    Mostrar(dataGridView2, p.ObtenerContactos());
                }
            }
            catch (Exception)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
            {
                var p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                var c = (Contacto)dataGridView2.SelectedRows[0].DataBoundItem;
                a.BorrarContactoPersona(p, c);
                Mostrar(dataGridView1, a.ObtenerPersonas());
                dataGridView1_RowEnter(null, null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
            {
                var p = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                var ca = (Contacto)dataGridView2.SelectedRows[0].DataBoundItem;
                var valor = Interaction.InputBox("Ingrese el valor del contacto", "Valor", ca.Valor);
                var descripcion = Interaction.InputBox("Ingrese la descripcion del contacto", "Descripcion", ca.Descripcion);
                var cn = new Contacto() {Valor=valor,Descripcion=descripcion };
                a.ModicarContactoPersona(p, ca, cn);
                Mostrar(dataGridView1, a.ObtenerPersonas());
                dataGridView1_RowEnter(null, null);
            }
        }
    }
}