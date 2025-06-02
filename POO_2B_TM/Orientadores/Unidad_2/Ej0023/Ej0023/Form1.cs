using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej0023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Accionista> ListaAccionista = new List<Accionista>();
        List<Accion> ListaAccion = new List<Accion>();
        private void Form1_Load(object sender, EventArgs e)
        {
            #region "Configuración de la Grilla"
            
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Rows.Add(2);
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Rows[0].Cells[0].Value="Acción Empresa A";
            this.dataGridView1.Rows[1].Cells[0].Value = "Acción Empresa B";
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Se agrega la acción comprada al accionista que la compro  
                ((Accionista)this.dataGridView3.SelectedRows[0].DataBoundItem).AgregarAccion(
               (Accion)(this.dataGridView2.SelectedRows[0].DataBoundItem));
                // Se retira la accion de la lista de acciones disponibles
                this.ListaAccion.Remove((Accion)(this.dataGridView2.SelectedRows[0].DataBoundItem));
                // Se refresca la lista que muestra las acciones disponibles
                this.dataGridView2.DataSource = null; this.dataGridView2.DataSource = this.ListaAccion;
                // Se muestra las acciones del Accionista seleccionado
                this.dataGridView4.DataSource = null; this.dataGridView4.DataSource =
                ((Accionista)this.dataGridView3.SelectedRows[0].DataBoundItem).VerAcciones();
            }
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Se selecciona la acción de la grilla de acciones que ya fueron compradas
                Accion A = (Accion)(this.dataGridView4.SelectedRows[0].DataBoundItem);
                // Se saca la accion de la lista de acciones del accionista
                ((Accionista)(this.dataGridView3.SelectedRows[0].DataBoundItem)).BorrarAccion(A);
                // Se agrega la accion a la lista de acciones disponibles
                this.ListaAccion.Add(A);
                // Se refresca la grilla de acciones disponibles
                this.dataGridView2.DataSource = null; this.dataGridView2.DataSource = this.ListaAccion;
                // Se refresca la grilla de acciones del accionista seleccionado
                this.dataGridView4.DataSource = null; this.dataGridView4.DataSource =
               ((Accionista)this.dataGridView3.SelectedRows[0].DataBoundItem).VerAcciones();

            }
            catch (Exception)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == "Acción Empresa A")
            {
                this.ListaAccion.Add(new AccionEmpresaA(int.Parse(Interaction.InputBox("Cantidad:")),
                                                        "AEA", "Acción Empresa A", 
                                                        decimal.Parse(Interaction.InputBox("Cotización:"))));
            }
            else
            {
                this.ListaAccion.Add(new AccionEmpresaB(int.Parse(Interaction.InputBox("Cantidad:")),
                                                        "AEB", "Acción Empresa B", 
                                                        decimal.Parse(Interaction.InputBox("Cotización:"))));
            }
            this.dataGridView2.DataSource = null; this.dataGridView2.DataSource = this.ListaAccion;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ListaAccionista.Add(new Accionista(Interaction.InputBox("Nombre: ")));
            this.dataGridView3.DataSource = null; this.dataGridView3.DataSource = this.ListaAccionista;
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Se muestra las acciones del Accionista seleccionado
                this.dataGridView4.DataSource = null; this.dataGridView4.DataSource =
                ((Accionista)this.dataGridView3.SelectedRows[0].DataBoundItem).VerAcciones();
            }
            catch (Exception)
            {}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // si posee acciones se pasan como disponibles
                Accionista ACC = (Accionista)(this.dataGridView3.SelectedRows[0].DataBoundItem);
                if(ACC.VerAcciones().Count>0)
                {
                    this.ListaAccion.AddRange(ACC.VerAcciones());
                }
                // Se borra el accionista
                this.ListaAccionista.Remove(ACC);              
                // Se refresca la grilla de acciones disponibles
                this.dataGridView2.DataSource = null; this.dataGridView2.DataSource = this.ListaAccion;
                // Se refresca la grilla de accionistas
                this.dataGridView3.DataSource = null; this.dataGridView3.DataSource = this.ListaAccionista;
                // Se refresca la grilla de acciones del accionista seleccionado
                this.dataGridView4.DataSource = null; this.dataGridView4.DataSource = 
                    ((Accionista)this.dataGridView3.SelectedRows[0].DataBoundItem).VerAcciones();
            }
            catch (Exception)
            {}
        }
    }

    public class Accionista
    {
        public Accionista(string pNombre) { this.Nombre = pNombre; }
        public string Nombre { get; set; }
        private List<Accion> ListaDeAcciones = new List<Accion>();
        public void AgregarAccion(Accion pAccion) {this.ListaDeAcciones.Add(pAccion); }
        public void BorrarAccion(Accion pAccion) {this.ListaDeAcciones.Remove(pAccion);}
        public List<Accion> VerAcciones() {return this.ListaDeAcciones; }
    }
    abstract public class Accion
    {   public Accion (int pCantidad,string pIdentificador,string pDescripcion,decimal pCotizacion)
        {   this.Cantidad = pCantidad;this.Identificador = pIdentificador;
            this.Descripcion = pDescripcion;this.Cotizacion = pCotizacion;
        }
        public int Cantidad { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        public decimal Cotizacion { get; set; }
    }
    public class AccionEmpresaA : Accion
    { public AccionEmpresaA(int pCantidad, string pIdentificador, string pDescripcion, decimal pCotizacion)
            : base(pCantidad, pIdentificador, pDescripcion, pCotizacion) { }     
    }
    public class AccionEmpresaB : Accion
    { public AccionEmpresaB(int pCantidad, string pIdentificador, string pDescripcion, decimal pCotizacion)
           : base(pCantidad, pIdentificador, pDescripcion, pCotizacion) { }
    }
}
