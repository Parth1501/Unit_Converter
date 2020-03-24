using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit_Converter.AlaService;
namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        WebService1SoapClient alaobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alaobj = new WebService1SoapClient();
            metroComboBox1.Items.Add("Rupee");
            metroComboBox1.Items.Add("Dollar");
            metroComboBox1.Items.Add("Euro");
            
            metroComboBox2.Items.Add("Dollar");
            metroComboBox2.Items.Add("Euro");


            metroComboBox3.Items.Add("Meter");
            metroComboBox3.Items.Add("Yard");
            metroComboBox3.Items.Add("Foot");
            metroComboBox4.Items.Add("Meter");
            metroComboBox4.Items.Add("Yard");
            metroComboBox4.Items.Add("Foot");


            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            metroComboBox4.SelectedIndex = 0;

            textBox2.Enabled = false;
            textBox3.Enabled = false;

            String result = alaobj.CurrencyConverter(metroComboBox1.Text, metroComboBox2.Text, textBox1.Text);
            textBox2.Text = result;
            String result1 = alaobj.LengthConverter(metroComboBox4.Text, metroComboBox3.Text, textBox4.Text);
            textBox3.Text = result1;

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                metroComboBox2.Items.Clear();
                metroComboBox2.Items.Add("Dollar");
                metroComboBox2.Items.Add("Euro");
                metroComboBox2.SelectedIndex = 0;

            }
            if (metroComboBox1.SelectedIndex == 1)
            {
                metroComboBox2.Items.Clear();
                metroComboBox2.Items.Add("Rupee");
                metroComboBox2.Items.Add("Euro");
                metroComboBox2.SelectedIndex = 0;

            }
            if (metroComboBox1.SelectedIndex == 2)
            {
                metroComboBox2.Items.Clear();
                metroComboBox2.Items.Add("Rupee");
                metroComboBox2.Items.Add("Dollar");
                metroComboBox2.SelectedIndex = 0;


            }
            String result = alaobj.CurrencyConverter(metroComboBox1.Text, metroComboBox2.Text, textBox1.Text);
            textBox2.Text = result;
        }
        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String result = alaobj.CurrencyConverter(metroComboBox1.Text, metroComboBox2.Text, textBox1.Text);
            textBox2.Text = result;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
      
            if (textBox1.Text != "" )
            {
                String result = alaobj.CurrencyConverter(metroComboBox1.Text, metroComboBox2.Text, textBox1.Text);
                textBox2.Text = result;
            }
            if(textBox1.Text=="")
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String str = "0123456789." + (char) 8;
            if (str.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        






        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                
                String result = alaobj.LengthConverter(metroComboBox4.Text, metroComboBox3.Text, textBox4.Text);
                textBox3.Text = result;
            }
            if (textBox4.Text == "")
            {
                textBox3.Text = "";
            }
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox4.SelectedIndex == 0)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Yard");
                metroComboBox3.Items.Add("Foot");
                metroComboBox3.SelectedIndex = 0;

            }
            if (metroComboBox4.SelectedIndex == 1)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Meter");
                metroComboBox3.Items.Add("Foot");
                metroComboBox3.SelectedIndex = 0;

            }
            if (metroComboBox4.SelectedIndex == 2)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Meter");
                metroComboBox3.Items.Add("Yard");
                metroComboBox3.SelectedIndex = 0;


            }
            String result = alaobj.LengthConverter(metroComboBox4.Text, metroComboBox3.Text, textBox4.Text);
            textBox3.Text = result;
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String result = alaobj.LengthConverter(metroComboBox4.Text, metroComboBox3.Text, textBox4.Text);
            textBox3.Text = result;
        }
    }
}
