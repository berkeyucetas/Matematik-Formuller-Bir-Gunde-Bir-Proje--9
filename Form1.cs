using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MATEMATİK_2 form2 = new MATEMATİK_2();
            form2.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void btnbuyuk_Click(object sender, EventArgs e)
        {
            int[] sayilar= new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i]= Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            lblbyk.Text = sayilar[sayilar.Length-1].ToString();
        }

        private void btnkucuk_Click(object sender, EventArgs e)
        {
            int[ ] sayilar= new int[listBox1.Items.Count];
            for (int i = 0;i < listBox1.Items.Count;i++)
            {
                sayilar[i]= Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            lblkck.Text= sayilar[0].ToString();
        }

        private void btntoplam_Click(object sender, EventArgs e)
        {
            int[] sayilar= new int[listBox1.Items.Count];
            for(int i = 0;i< listBox1.Items.Count;i++)
            {
                sayilar[i]= Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            lbltop.Text = toplam.ToString();
        }
        private void btnort_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for ( int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i]= Int32.Parse(listBox1.Items[i].ToString());
            }
        int toplam = 0;
        foreach (int sayi in sayilar)
            {
                toplam= toplam + sayi;
            }
        lblort.Text=(toplam/ sayilar.Length).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text)) // TextBox boş değilse
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblbyk.Text = "";
            lblkck.Text = "";
            lblort.Text = "";
            lbltop.Text = "";
        }

        private void btntek_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int i in sayilar)
            {
                if(i%2==1)
                {
                    listtek.Items.Add(i);
                }
            }
        }

        private void btncift_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int i in sayilar)
            {
                if (i % 2 == 0)
                {
                    listcift.Items.Add(i);
                }
            }
        }

        private void btnpztf_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int i in sayilar)
            {
                if (i >= 0)
                {
                    listpztf.Items.Add(i);
                }
            }
        }

        private void btnngtf_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            foreach (int i in sayilar)
            {
                if (i < 0)
                {
                    listngtf.Items.Add(i);
                }
            }
        }
    }
}
