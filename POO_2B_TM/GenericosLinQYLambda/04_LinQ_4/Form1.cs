namespace LinQ_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> p;
    
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            p=new List<Persona>();
            List<Auto> a1 = new List<Auto>();
            a1.AddRange(new Auto[] { new Auto() {Patente="111",Marca="Ford" },
                                     new Auto() {Patente="222",Marca="Fiat" },
                                     new Auto() {Patente="333",Marca="BMW"}});
            var a2 = new List<Auto>();
            a2.AddRange(new Auto[] { new Auto() {Patente="444",Marca="M.Benz" },
                                     new Auto() {Patente="555",Marca="Volkswagen" }});
            var a3 = new List<Auto>();
            a3.AddRange(new Auto[] { new Auto() { Patente="666", Marca="Renault" } });


           p.AddRange(new Persona[] {new Persona() {DNI="11.111.111",Nombre="Juan",Apellido="Garcia",Autos=a1},
                                     new Persona() {DNI="22.222.222",Nombre="Ana",Apellido="Garcia",Autos=a2},
                                     new Persona() {DNI="33.333.333",Nombre="Sol",Apellido="Alvarez",Autos=a3}});

            dataGridView1.DataSource= (from x in p select new { DNI = x.DNI, Nombre = x.Nombre, Apellido = x.Apellido}).ToList();
            dataGridView2.DataSource= (from x in p orderby x.Apellido ascending,x.Nombre ascending select x).ToList();
            dataGridView3.DataSource= (from x in p select new { DNI = x.DNI, Nombre = x.Nombre, Apellido = x.Apellido, Autos = x.Autos.Count() }).ToList();
        }
    }
}
