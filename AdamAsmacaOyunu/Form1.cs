using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        char[] harfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'İ', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        Oyun oyun;
        Kelimeler k = new Kelimeler();
        public Form1()
        {
            InitializeComponent();
            KlavyeOluştur();
        }
        

        public void KlavyeOluştur()
        {
            Button button;

            int i = 0,j = 370;

            foreach (var item in harfler)
            {
                button = new Button();
                button.Name = item.ToString();
                button.Text = item.ToString();
                button.Size = new Size(30, 30);
                button.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                button.Location = new Point(i+=40,j);
                this.Controls.Add(button);
                button.Click += Button_Click;

                if (i == 400) { i = 0; j+=40; }
                    
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Visible=false;
            oyun.HarfKontrolEt(button.Name);
        }

        private void YeniOyun_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            oyun = new Oyun(k,Controls);
            oyun.OyunaBasla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in harfler)
            {
                Controls[item.ToString()].Visible = false;
            }
        }

    }
}
