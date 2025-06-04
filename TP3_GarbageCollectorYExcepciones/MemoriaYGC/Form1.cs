namespace MemoriaYGC
{
    public partial class Form1 : Form
    {
        List<Persona> lp;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lp = new List<Persona>();

            // Se crean 100 instancias de persona
            for(int i = 0; i < 3000; i++)
            {
                lp.Add(new Persona(i.ToString(), i+1.ToString()));
            }

            // Se verifica la memoria utilizada por el GC
            long memoriaDespuesDeInstanciar = GC.GetTotalMemory(false);
            MessageBox.Show($"Memoria después de crear muchas instancias de persona: {memoriaDespuesDeInstanciar / 1024} MB");

            // Se llama al GC liberando la lista de objetos sin referencia
            lp = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Se verifica nuevamente la memoria utilizada por el GC
            long memoriaDespuesDeGC = GC.GetTotalMemory(true);
            MessageBox.Show($"Memoria después de romper la referencia de la lista de personas: {memoriaDespuesDeGC / 1024} MB");

            /* OBSERVACIÓN:
             * Se puede observar que memoriaDespuesDeInstanciar > memoriaDespuesDeGC.
             * Esto quiere decir que el heap que maneja el CLR al momento de crear 3000 instancias es de 650MB aproximadamente.
             * Después de romper la referencia de la lista, las 3000 instancias quedan en la memoria sin referencia, por lo tanto, el GC libera estas 3000 instancias de la memoria.
             * Finalmente, el heap que maneja el CLR pasa a valer 450MB, liberándose así 200MB de objetos sin referencias.
             */
        }
    }
}
