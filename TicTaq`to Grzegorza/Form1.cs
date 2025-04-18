namespace TicTaq_to_Grzegorza
{
    public partial class tiqtacto : Form
    {
        int playerturn = 1; // By default player 1 starts
        public char[] board = new char[9];
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
            if (playerturn == 1 && pictureBox2.Image == null)
            {
                pictureBox2.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox2.Image == null)
            {
                pictureBox2.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox3.Image == null)
            {
                pictureBox3.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox3.Image == null)
            {
                pictureBox3.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox4.Image == null)
            {
                pictureBox4.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox4.Image == null)
            {
                pictureBox4.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox5.Image == null)
            {
                pictureBox5.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox5.Image == null)
            {
                pictureBox5.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox6.Image == null)
            {
                pictureBox6.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox6.Image == null)
            {
                pictureBox6.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox7.Image == null)
            {
                pictureBox7.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox7.Image == null)
            {
                pictureBox7.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox8.Image == null)
            {
                pictureBox8.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox8.Image == null)
            {
                pictureBox8.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox9.Image == null)
            {
                pictureBox9.Image = Properties.Resources.Tiq;
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox9.Image == null)
            {
                pictureBox9.Image = Properties.Resources.taq;
                playerturn = 1;
            }
        }
        public void zwyciestwo()

        {
            if 
            (pictureBox1.BackgroundImage == Properties.Resources.Tiq && pictureBox2.BackgroundImage == Properties.Resources.Tiq && pictureBox3.BackgroundImage == Properties.Resources.Tiq)
            {
                MessageBox.Show("Tiq Wygra³!");
            }
            else if (pictureBox1.BackgroundImage == Properties.Resources.Tiq && pictureBox2.BackgroundImage == Properties.Resources.Tiq && pictureBox3.BackgroundImage == Properties.Resources.Tiq)
            {
                MessageBox.Show("Tiq Wygra³!");
            }
        }
    }
}
