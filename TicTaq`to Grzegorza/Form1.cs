namespace TicTaq_to_Grzegorza
{
    public partial class tiqtacto : Form
    {
        int playerturn = 1; // By default player 1 starts
        private char[] board = new char[9];
        public tiqtacto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
