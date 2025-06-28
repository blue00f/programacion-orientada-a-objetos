using System.Collections.Immutable;

namespace EjercicioIComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona[] personas = new Persona[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            personas =
            [
                new ("Paul", "McCartney", "Bajo", 82),
                new ("Jimmy", "Page", "Guitarra", 80),
                new ("Gustavo", "Cerati", "Guitarra", 55),
                new ("Charly", "García", "Teclado", 72),
                new ("Luis", "Spinetta", "Guitarra", 62),
                new ("David", "Lebón", "Guitarra", 71),
                new ("Andrés", "Calamaro", "Voz", 62),
                new ("Ricardo", "Mollo", "Guitarra", 66),
                new ("Carlos", "López Puccio", "Teclado", 78),
                new ("Carlos", "Núñez Cortés", "Piano", 81),
                new ("Daniel", "Rabinovich", "Percusión", 71),
                new ("Jorge", "Maronna", "Guitarra", 76),
                new ("Marcos", "Mundstock", "Narrador", 77),
                new ("Gerardo", "Masana", "Vientos", 36),
                new ("Freddie", "Mercury", "Voz", 45),
                new ("John", "Lennon", "Guitarra", 40),
                new ("George", "Harrison", "Guitarra", 58),
                new ("Ringo", "Starr", "Batería", 84),
                new ("Roger", "Waters", "Bajo", 80),
                new ("David", "Gilmour", "Guitarra", 78),
            ];
            foreach (var control in this.Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void Mostrar(DataGridView pGrilla, object pFuente)
        {
            pGrilla.DataSource = null;
            pGrilla.DataSource = pFuente;
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            var instrumentoAsc = (Persona[])personas.Clone();
            Array.Sort(instrumentoAsc, new Persona.InstrumentoASC());
            Mostrar(grillaInstrumentoAsc, instrumentoAsc);

            var instrumentosDesc = (Persona[])personas.Clone();
            Array.Sort(instrumentosDesc, new Persona.InstrumentoDESC());
            Mostrar(grillaInstrumentoDesc, instrumentosDesc);

            var edadAsc = (Persona[])personas.Clone();
            Array.Sort(edadAsc, new Persona.EdadASC());
            Mostrar(grillaEdadAsc, edadAsc);

            var edadDesc = (Persona[])personas.Clone();
            Array.Sort(edadDesc, new Persona.EdadDESC());
            Mostrar(grillaEdadDesc, edadDesc);

            var nombreAsc = (Persona[])personas.Clone();
            Array.Sort(nombreAsc, new Persona.NombreASC());
            Mostrar(grillaNombreAsc, nombreAsc);
        }
    }
}
