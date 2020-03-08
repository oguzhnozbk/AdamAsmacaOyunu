using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    class Oyun
    {
        private int _skor = 0;
        public int Skor
        {
            get { return _skor; }
            
        }
        private Kelimeler _Kelimeler;
        private Control.ControlCollection _Control;
        private string _kelime;
        private string slabel ="";
        char[] harfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'İ', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        private int yanlisSayisi = 1;


        public Oyun(Kelimeler kelime,Control.ControlCollection control)
        {
            _Kelimeler = kelime;

            _Control = control;
            _Control["skor"].Text = _skor.ToString();
        }
        public void OyunaBasla()
        {
            slabel = "";
            _kelime = _Kelimeler.KelimeGetir();
            foreach (var item in _kelime.ToCharArray())
            {
                slabel += "*";
            }

            _Control["label2"].Text = slabel;
            foreach (var item in harfler)
            {
                _Control[item.ToString()].Visible = true;
            }
            for (int i = 1; i < 9; i++)
            {
                _Control["incorrect" + i].Visible = false;
            }
            yanlisSayisi = 1;
        }
        public void HarfKontrolEt(string harf)
        {
            char[] kelime = _kelime.ToCharArray();
            char[] label = slabel.ToCharArray();
            int i = 0;
            bool harfDogruMu = false;
            foreach (var item in kelime)
            {
                if (item.ToString() == harf)
                {
                    label[i] = item;
                    harfDogruMu = true;
                }
                i++;
            }
            if (!harfDogruMu)
            {
                HarfYanlıs();
            }
            else
                LabelGuncelle(new string(label));
            OyunBittiMi();
        }
        private void HarfYanlıs()
        {
            _Control["incorrect" + yanlisSayisi].Visible = true;
            yanlisSayisi++;
            OyunBittiMi();
        }
        private void OyunBittiMi()
        {
            if (yanlisSayisi >= 9)
                Kaybettiniz();
            bool kontrol = true;
            foreach (var item in _Control["label2"].Text.ToCharArray())
            {
                if (item == '*')
                {
                    kontrol = false;
                }
            }
            if (kontrol)
                Kazandiniz();

        }
        private void Kaybettiniz()
        {
            MessageBox.Show("Üzülme Kelimeyi Bilemedin. Tekrar Deneyebilirsin. Bu Kez Başaracağına İnanıyorum. İyi Oyunlar =)  Bilemediğiniz Kelime : " + _kelime);
            _skor-=50;
            _Control["skor"].Text = _skor.ToString();
            OyunaBasla();
        }
        private void Kazandiniz()
        {
            MessageBox.Show("Tebrikler Kazandınız.");
            _skor+=100;
            _Control["skor"].Text = _skor.ToString();
            OyunaBasla();
            
        }
        private void LabelGuncelle(string s)
        {
            _Control["label2"].Text = s;
            slabel = s;
        }
    }
}
