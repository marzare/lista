using ListaUczestnikow.ModelDanych;

namespace ListaUczestnikow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ZBazy zbazy;
            zbazy = new ZBazy();
            zbazy.PobierzDane();
            PokazDane();
            InitializeComponent();

            
        }
        public void PokazDane()
        {
            textBoxOsoby.Clear();
            foreach(osoba osoba in zbazy.listaOsob)
            {
                textBoxOsoby.Text += osoba.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ZBazy.listaOsob.Sort();
            PokazDane();
        }
    }
}