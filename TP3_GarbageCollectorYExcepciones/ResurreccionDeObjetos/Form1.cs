namespace ResurreccionDeObjetos
{
    public partial class Form1 : Form
    {
        Refugio refugio;
        public Form1()
        {
            InitializeComponent();
            refugio = new Refugio("Campito refugio");
        }

        private void btnCrearPerro_Click(object sender, EventArgs e)
        {
            Perro p = new Perro("Dogo argentino", "blanco", refugio);
            MessageBox.Show(p.ToString(), "CREACI�N DEL PERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refugio.UltimoPerroRescatado = p;
        }

        private void btnDestruirPerro_Click(object sender, EventArgs e)
        {
            refugio.UltimoPerroRescatado = null;
            MessageBox.Show("Se destruy� el objeto perro!", "DESTRUCCI�N DEL PERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRevivirPerro_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MessageBox.Show(refugio.UltimoPerroRescatado.ToString(), "VERIFICACI�N DE QUE EL PERRO REVIVI�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
