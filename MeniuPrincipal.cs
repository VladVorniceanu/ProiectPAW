namespace Proiect
{
    public partial class MeniuPrincipal : Form
    {
        List<Candidati> listaCandidati = new List<Candidati>();
        public MeniuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            IntroducereStudent form2 = new IntroducereStudent();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntroducereFacultate formFac = new IntroducereFacultate();
            formFac.Show();
        }
    }
}