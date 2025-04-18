using TicTaq_to_Grzegorza.Properties;

namespace TicTaq_to_Grzegorza
{
    public partial class tiqtacto : Form
    {
        private int playerturn = 1; // By default player 1 starts
        private char[] letter; // Player 1 is Tiq(A), player 2 is Taq(B)
        private int played = 0;
        public tiqtacto()
        {
            InitializeComponent();
            letter = new char[10];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.Tiq;
                letter[1] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.taq;
                letter[1] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox2.Image == null)
            {
                pictureBox2.Image = Properties.Resources.Tiq;
                letter[2] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox2.Image == null)
            {
                pictureBox2.Image = Properties.Resources.taq;
                letter[2] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox3.Image == null)
            {
                pictureBox3.Image = Properties.Resources.Tiq;
                letter[3] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox3.Image == null)
            {
                pictureBox3.Image = Properties.Resources.taq;
                letter[3] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox4.Image == null)
            {
                pictureBox4.Image = Properties.Resources.Tiq;
                letter[4] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox4.Image == null)
            {
                pictureBox4.Image = Properties.Resources.taq;
                letter[4] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox5.Image == null)
            {
                pictureBox5.Image = Properties.Resources.Tiq;
                letter[5] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox5.Image == null)
            {
                pictureBox5.Image = Properties.Resources.taq;
                letter[5] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox6.Image == null)
            {
                pictureBox6.Image = Properties.Resources.Tiq;
                letter[6] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox6.Image == null)
            {
                pictureBox6.Image = Properties.Resources.taq;
                letter[6] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox7.Image == null)
            {
                pictureBox7.Image = Properties.Resources.Tiq;
                letter[7] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox7.Image == null)
            {
                pictureBox7.Image = Properties.Resources.taq;
                letter[7] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox8.Image == null)
            {
                pictureBox8.Image = Properties.Resources.Tiq;
                letter[8] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox8.Image == null)
            {
                pictureBox8.Image = Properties.Resources.taq;
                letter[8] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (playerturn == 1 && pictureBox9.Image == null)
            {
                pictureBox9.Image = Properties.Resources.Tiq;
                letter[9] = 'A';
                playerturn = 2;
            }
            else if (playerturn == 2 && pictureBox9.Image == null)
            {
                pictureBox9.Image = Properties.Resources.taq;
                letter[9] = 'B';
                playerturn = 1;
            }
            played += 1;
            zwyciestwo();
        }
        public void zwyciestwo()

        {
            // wygrana Tiq
            if (letter[1] == 'A' && letter[2] == 'A' && letter[3] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[4] == 'A' && letter[5] == 'A' && letter[6] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[7] == 'A' && letter[8] == 'A' && letter[9] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[1] == 'A' && letter[4] == 'A' && letter[7] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[2] == 'A' && letter[5] == 'A' && letter[8] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[3] == 'A' && letter[6] == 'A' && letter[9] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }

            else if (letter[1] == 'A' && letter[5] == 'A' && letter[9] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            else if (letter[3] == 'A' && letter[5] == 'A' && letter[7] == 'A')
            {
                label1.Text = ("Tiq Wygra³!");
                textBox1.Text = ("Tiq Wygra³!");
            }
            // wygrana Taq
            if (letter[1] == 'B' && letter[2] == 'B' && letter[3] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[4] == 'B' && letter[5] == 'B' && letter[6] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[7] == 'B' && letter[8] == 'B' && letter[9] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[1] == 'B' && letter[4] == 'B' && letter[7] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[2] == 'B' && letter[5] == 'B' && letter[8] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[3] == 'B' && letter[6] == 'B' && letter[9] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }

            else if (letter[1] == 'B' && letter[5] == 'B' && letter[9] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (letter[3] == 'B' && letter[5] == 'B' && letter[7] == 'B')
            {
                label1.Text = ("Taq Wygra³!");
                textBox1.Text = ("Taq Wygra³!");
            }
            else if (played == 9)
            {
                label1.Text = ("Bitwa nie rozstrzygniêta!");
                textBox1.Text = ("Graj od nowa!");
            }
        }
    }
}
