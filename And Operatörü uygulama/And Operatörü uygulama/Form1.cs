using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace And_Operatörü_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;
            if (kadi == "Kerem" && sifre == "54321")
            {
                label4.Text = (kadi == "Kerem" && sifre == "54321").ToString();
                MessageBox.Show("Kullanıcı Adı Ve Şifre Doğru");
            }
            else 
            {
                label4.Text = (kadi == "Kerem" && sifre == "54321").ToString();
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }
    }
}
