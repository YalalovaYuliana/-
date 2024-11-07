namespace CoinToss
{
    partial class TossCoin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TossCoin));
            this.AnimationToss = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.buttonToss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationToss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToss)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimationToss
            // 
            this.AnimationToss.Location = new System.Drawing.Point(41, -12);
            this.AnimationToss.Name = "AnimationToss";
            this.AnimationToss.Size = new System.Drawing.Size(333, 408);
            this.AnimationToss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimationToss.TabIndex = 2;
            this.AnimationToss.TabStop = false;
            // 
            // Coin
            // 
            this.Coin.Location = new System.Drawing.Point(70, 106);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(250, 246);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin.TabIndex = 1;
            this.Coin.TabStop = false;
            // 
            // buttonToss
            // 
            this.buttonToss.Location = new System.Drawing.Point(70, 426);
            this.buttonToss.Name = "buttonToss";
            this.buttonToss.Size = new System.Drawing.Size(269, 68);
            this.buttonToss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonToss.TabIndex = 3;
            this.buttonToss.TabStop = false;
            this.buttonToss.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // TossCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 555);
            this.Controls.Add(this.buttonToss);
            this.Controls.Add(this.AnimationToss);
            this.Controls.Add(this.Coin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TossCoin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimationToss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonToss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox AnimationToss;
        private System.Windows.Forms.PictureBox buttonToss;
    }
}

