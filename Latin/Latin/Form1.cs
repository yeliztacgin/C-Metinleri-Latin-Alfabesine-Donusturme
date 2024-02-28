using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string metin;

        private void degistirBtn_Click(object sender, EventArgs e)
        {
            metin = Convert.ToString(textBox1.Text);

            if (checkBox1.Checked==true)
            {
                metin = metin.Replace('ç', 'c');
            }
            if (checkBox2.Checked == true)
            {
                metin = metin.Replace('ğ', 'g');
            }
            if (checkBox3.Checked == true)
            {
                metin = metin.Replace('ı', 'i');
            }
            if (checkBox4.Checked == true)
            {
                metin = metin.Replace('ö', 'o');
            }
            if (checkBox5.Checked == true)
            {
                metin = metin.Replace('ü', 'u');
            }
            if (checkBox6.Checked == true)
            {
                metin = metin.Replace('ş', 's');
            }

            textBox2.Text = metin;

        }
    }
}
