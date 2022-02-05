using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_sifarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox5.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label12.Text+" "+label13.Text+" "+label14.Text+" "+label15.Text+" "+label16.Text+" "+label17.Text+" "+label18.Text+" "+label19.Text);
        }
        private void Sosis_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = CheckBox1.Text;
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = CheckBox2.Text;
        }
        private void CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            label14.Text = CheckBox3.Text;
        }

        private void CheckBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            label15.Text = CheckBox4.Text;
        }
        private void CheckBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            label16.Text = CheckBox5.Text;
        }

        private void CheckBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            label17.Text = CheckBox6.Text;
        }

        private void CheckBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            label18.Text = CheckBox7.Text;
        }

        private void CheckBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            label19.Text = CheckBox8.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            
        }
    }
}
