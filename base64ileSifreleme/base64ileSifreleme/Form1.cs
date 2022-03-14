using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64ileSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string SifrelemeYapBase64(string veri)
        {
            byte[] veriByteDizi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizi);
            return System.Net.WebUtility.HtmlEncode(sifrelenmisVeri);

        }
        public static string SifrelemeCozBase64(string cozVeri)
        {
            cozVeri = System.Net.WebUtility.HtmlDecode(cozVeri);
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;

        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string sifreliMetin = SifrelemeYapBase64(textBox1.Text);
            label3.Text = sifreliMetin;
            textBox2.Text = label3.Text;
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            string normalMetin = SifrelemeCozBase64(textBox2.Text);
            label6.Text = normalMetin;
            textBox1.Text = label6.Text;
        }
    }
}
