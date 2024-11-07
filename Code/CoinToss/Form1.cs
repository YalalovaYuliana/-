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

        private void Form1_Load(object sender, EventArgs e) // Задание начальных настроек формы и элементов. 
        {
            this.Text = "Орёл или решка"; // Название формы (приложения)
            this.BackColor = Color.Black; // Задний фон приложения
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет на изменение размера формы.

            AnimationToss.Visible = false;
            AnimationToss.Image = Properties.Resources.coin_flip_black_white;
            Coin.Image = Properties.Resources.reshkaCoin; // Установка в качестве первоначального изображения Решки
            buttonToss.Image = Properties.Resources.buttonToss; // Установка изображения кнопки. Графическая надпись "Бросить"
        }

        private bool TossACoin() => rand.Next(0, 2) == 0 ? false : true; // Функция, которая генерирует случайное число

        private async void pictureBox3_Click(object sender, EventArgs e) // Функция, которая вызывается при нажатии кнопки "Бросить"
        {
            AnimationToss.Visible = true; // Запуск анимации
            buttonToss.Enabled = false; // Временная блокировка кнопки "Бросить" на время проигрывания анимации

            await Task.Delay(2500);

            AnimationToss.Visible = false; // Остановка анимации
            buttonToss.Enabled = true; // Разблокировка кнопки "Бросить"

            if (TossACoin()) Coin.Image = Properties.Resources.eagleCoin; // Отображение стороны монеты в зависимости от результата генерации
            else Coin.Image = Properties.Resources.reshkaCoin;
        }

    }
}
