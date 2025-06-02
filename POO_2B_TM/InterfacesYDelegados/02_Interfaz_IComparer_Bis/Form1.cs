namespace Ejemplo07
{
    public partial class Form1 : Form
    {
        List<Persona> pl;
        public Form1()
        {
            InitializeComponent();
            pl=new List<Persona>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pl.AddRange(new Persona[] { new Persona() {Nombre="Juan",Apellido="Alonso",Edad=33},
                                        new Persona() {Nombre="Ana",Apellido="Alonso",Edad=11},
                                        new Persona() {Nombre="Cecilia",Apellido="Danoso",Edad=44},
                                        new Persona() {Nombre="Sol",Apellido="Alvarez",Edad=35},
                                        new Persona() {Nombre="Martín",Apellido="Procopio",Edad=48}});
        }
        private void DatosInfo(object sender, DatosEventArgs e)
        {
            textBox1.Text+=$"{e.Info}{Environment.NewLine}";
        }
            private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource=null; dataGridView1.DataSource=pl.ToList();
            var nasc = new Persona.NombreASC();
            nasc.Datos+=DatosInfo;
            pl.Sort(nasc);
            dataGridView2.DataSource=null; dataGridView2.DataSource=pl.ToList();
            pl.Sort(new Persona.NombreDESC());
            dataGridView3.DataSource=null; dataGridView3.DataSource=pl.ToList();
            pl.Sort(new Persona.ApellidoASC());
            dataGridView4.DataSource=null; dataGridView4.DataSource=pl.ToList();
            pl.Sort(new Persona.ApellidoDESC());
            dataGridView5.DataSource=null; dataGridView5.DataSource=pl.ToList();
            pl.Sort(new Persona.EdadASC());
            dataGridView6.DataSource=null; dataGridView6.DataSource=pl.ToList();
            pl.Sort(new Persona.EdadDESC());
            dataGridView7.DataSource=null; dataGridView7.DataSource=pl.ToList();
        }
    }
}
