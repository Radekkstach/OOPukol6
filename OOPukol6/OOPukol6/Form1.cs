using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Osoba ja;
        Pacient Prasatko;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ja = new Osoba(textBox1.Text, textBox2.Text, double.Parse((textBox4.Text)), double.Parse(textBox3.Text));
                label1.Text = ja.ToString();
            }
            catch { }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Prasatko = new Pacient(textBox8.Text, textBox7.Text, double.Parse((textBox5.Text)), double.Parse(textBox6.Text), double.Parse(textBox9.Text));
                label10.Text = Prasatko.ToString();
            } catch { }
        }
    }
}
