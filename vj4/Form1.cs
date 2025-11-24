using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vj4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Linija;
            Linija = textBox1.Text + "|" + textBox2.Text;
            StreamWriter sw = new StreamWriter("student.txt", true);
            sw.WriteLine(Linija);
            sw.Close();
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Podaci su spremljeni");
        }

        
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
