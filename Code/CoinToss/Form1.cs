using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Орёл или решка";
            this.BackColor = Color.Black;
            
            pictureBox2.Visible = false;
            pictureBox2.Image = Properties.Resources.coin_flip_black_white;
        }

        private bool TossACoin() => rand.Next(0, 2) == 0 ? false : true;

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Enabled = false;

            await Task.Delay(2500);

            pictureBox2.Visible = false;
            pictureBox3.Enabled = true;

            if (TossACoin()) pictureBox1.Image = Properties.Resources.орёл;
            else pictureBox1.Image = Properties.Resources.решка;
        }
    }
}
