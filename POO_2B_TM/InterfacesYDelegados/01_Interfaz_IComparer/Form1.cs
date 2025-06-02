namespace Ejemplo_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Auto> autos = new List<Auto>();
        int[] columnas = {150,150,100,70 };
        private void Form1_Load(object sender, EventArgs e)
        {
            autos.AddRange(new Auto[]
            {
                new Auto("AZ-211-QA","Ford", "Mondeo", 2018),
                new Auto("BS-423-SS","Chevrolet", "Onix", 2015),
                new Auto("AJ-987-AA","Toyota", "Corolla", 2020),
                new Auto("AJ-111-TS","Volkswagen", "Polo", 2018),
                new Auto("AC-123-WS","Ford", "Fiesta", 2010)
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Mostrar(dataGridView1); 
            autos.Sort(new Auto.PatenteASC()); Mostrar(dataGridView2);
            autos.Sort(new Auto.PatenteDESC()); Mostrar(dataGridView3);
            autos.Sort(new Auto.MarcaASC()); Mostrar(dataGridView4);
            autos.Sort(new Auto.MarcaDESC()); Mostrar(dataGridView5);
            autos.Sort(new Auto.ModeloASC()); Mostrar(dataGridView6);
            autos.Sort(new Auto.ModeloDESC()); Mostrar(dataGridView7);
            autos.Sort(new Auto.AxoASC()); Mostrar(dataGridView8);
            autos.Sort(new Auto.AxoDESC()); Mostrar(dataGridView9);
        }

        private void Mostrar(DataGridView pDGV)
        {
            pDGV.DataSource = null; pDGV.DataSource = autos.ToList();
            foreach (var item in pDGV.Columns)
            {
                ((DataGridViewColumn)item).Width = columnas[((DataGridViewColumn)item).Index];
            }
        }
    }
}
