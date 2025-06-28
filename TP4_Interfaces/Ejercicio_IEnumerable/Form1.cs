using Microsoft.VisualBasic;

namespace Ejercicio_IEnumerable
{
    public partial class Form1 : Form
    {
        Playlist playlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlist = new Playlist();
            grillaPlaylist.MultiSelect = false;
            grillaPlaylist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Mostrar(object pPlaylist)
        {
            grillaPlaylist.DataSource = null;
            grillaPlaylist.DataSource = pPlaylist;
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Nombre de la canci�n", "Agregar canci�n");
            string artista = Interaction.InputBox("Nombre del artista", "Agregar canci�n");
            TimeSpan duracion = TimeSpan.Parse(Interaction.InputBox("Duraci�n de la canci�n", "Agregar canci�n"));

            Cancion c = new Cancion(nombre, artista, duracion);
            playlist.Agregar(c);
            Mostrar(playlist.ObtenerCanciones());
        }

        private void btnRecorrerPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaPlaylist.Rows.Count == 0) throw new Exception("No hay registros de canciones!");
                foreach (var c in playlist.ObtenerCanciones())
                {
                    MessageBox.Show(c.ToString(), "Informaci�n de la canci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
