using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class TossCoin : Form
    {
        private Random rand = new Random();
        public TossCoin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Орёл или решка";
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
            AnimationToss.Visible = false;
            AnimationToss.Image = Properties.Resources.coin_flip_black_white;
            Coin.Image = Properties.Resources.reshkaCoin;
            buttonToss.Image = Properties.Resources.buttonToss;
        }

        private bool TossACoin() => rand.Next(0, 2) == 0 ? false : true;

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            AnimationToss.Visible = true;
            buttonToss.Enabled = false;

            await Task.Delay(2500);

            AnimationToss.Visible = false;
            buttonToss.Enabled = true;

            if (TossACoin()) Coin.Image = Properties.Resources.eagleCoin;
            else Coin.Image = Properties.Resources.reshkaCoin;
        }

    }
}
