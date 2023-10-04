using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik
{
    public partial class MATEMATİK_2 : Form
    {
        public MATEMATİK_2()
        {
            InitializeComponent();
        }

        private void btnana_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnmd_Click(object sender, EventArgs e)
        {
            int deger = -10;
            int pozitif;
            pozitif= Math.Abs(deger);
            MessageBox.Show("Değer olarak -10 verdik ve mutlak değeri :" +pozitif.ToString());

        }

        private void btnustyuv_Click(object sender, EventArgs e)
        {
            double deger;
            deger= 5.4;
            double uyuvarla= Math.Ceiling(deger);
            MessageBox.Show("Değer olarak 5.4 verdik ve üste yuvarlanmışı :" + uyuvarla.ToString());
        }

        private void btnaltyuv_Click(object sender, EventArgs e)
        {
            double deger;
            deger = 3.9;
            double ayuvarla = Math.Floor(deger);
            MessageBox.Show("Değer olarak 3.9 verdik ve alta yuvarlanmışı :" + ayuvarla.ToString());
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            double buyukdeger = Math.Max(2.14, 77.953);
            MessageBox.Show("Değer olarak 2.14 ve 77.953 verdik ve maksimum değer :" + buyukdeger.ToString());
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            double kucukdeger = Math.Min(2.057, 77.13945);
            MessageBox.Show("Değer olarak 2.057 ve 77.13945 verdik ve minumum değer :" + kucukdeger.ToString());
        }

        private void btnus_Click(object sender, EventArgs e)
        {
            double us = Math.Pow(2, 8);
            MessageBox.Show("Değer olarak 2'nin 8. kuvvetini verdik ve üs değer :" + us.ToString());
        }

        private void btnkok_Click(object sender, EventArgs e)
        {
            double sayi = 624;
            double kok = Math.Sqrt(sayi);
            MessageBox.Show("Değer olarak 624 verdik ve karekök değer :" + kok.ToString());
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            double degerpi;
            degerpi = Math.PI;
            MessageBox.Show("PI'nin değeri :" + degerpi.ToString());
        }

        private void btnkln_Click(object sender, EventArgs e)
        {
            double degerkal;
            degerkal = Math.IEEERemainder(12, 5);
            MessageBox.Show("Değer olarak 12 ve 5 verdik kalan deger :" + degerkal.ToString());
        }

        private void btnsinüs_Click(object sender, EventArgs e)
        {
            double sinus;
            sinus = Math.Sin(90);
            MessageBox.Show("Sin(90)'ın degeri :" + sinus.ToString());
        }

        private void btcosinüs_Click(object sender, EventArgs e)
        {
            double cossinus;
            cossinus = Math.Cos(90);
            MessageBox.Show("Cos(90)'ın degeri :" + cossinus.ToString());
        }

        private void btntanjant_Click(object sender, EventArgs e)
        {
            double tanjant;
            tanjant = Math.Tan(180);
            MessageBox.Show("Tan(180)'in degeri :" + tanjant.ToString());
        }
    }
}
