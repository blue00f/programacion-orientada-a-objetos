using EjercicioIComparable;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona[] personas = new Persona[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            personas =
            [
                new ("Paul", "McCartney"),
                new ("John", "Lennon"),
                new ("George", "Harrison"),
                new ("Ringo", "Starr"),
            ];

            grillaPersonas.DataSource = null;
            grillaPersonas.DataSource = personas;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(personas);
            grillaPersonas.DataSource = null;
            grillaPersonas.DataSource = personas;
        }
    }
}
