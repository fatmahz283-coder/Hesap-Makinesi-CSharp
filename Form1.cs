namespace ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double hesapla(string sayi)
        {
            sayi = sayi.Replace(" ", " ");//replace ile bosluklari siler 
            if (sayi.Contains("+"))
            {
                string[] parcala = sayi.Split("+");
                return double.Parse(parcala[0]) + double.Parse(parcala[1]);
            }
            else if (sayi.Contains("-"))
            {
                string[] parcala = sayi.Split("-");
                return double.Parse(parcala[0]) - double.Parse(parcala[1]);
            }
            else if (sayi.Contains("X"))
            {
                string[] parcala = sayi.Split("X");
                return double.Parse(parcala[0]) * double.Parse(parcala[1]);
            }
            else if (sayi.Contains("/"))
            {
                string[] parcala = sayi.Split("/");
                double bolunen = double.Parse(parcala[0]);
                double bolen = double.Parse(parcala[1]);
                return bolunen / bolen;
            }
            else if (sayi.Contains("^"))
            {
                string[] parcala = sayi.Split("^");
                double taban = double.Parse(parcala[0]);
                double us = double.Parse(parcala[1]);
                return Math.Pow(taban, us);
            }
            else if (sayi.Contains("%"))
            {
                string[] parcala = sayi.Split("%");
                double sayi1 = double.Parse(parcala[0]);
                double sayi2 = double.Parse(parcala[1]);
                return sayi1 % sayi2;
            }
            return 0;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtsayi.Clear();
        }
        private void btnbol_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btnn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            try
            {
                string sayi = txtsayi.Text;
                double sonuc = hesapla(sayi);
                txtsayi.Text = sonuc.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata olustu daha sonra tekrar deneyiniz" + hata);
            }
        }

        private void btnyuzde_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }

        private void btnus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtsayi.Text += btn.Text;
        }
    }
}
