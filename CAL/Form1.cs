using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;      
        string operation;
        int flag = 0;

        private void Digit_Click(object sender, EventArgs e)
        { 
            string digit = (sender as Button).Text;
            string number = txt_Display.Text + digit;
            double d = double.Parse(number);
            txt_Display.Text = d.ToString();   

        }

        private void Opr_CLick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string opr = ((Button)sender).Text;
                operation = opr;
                total = double.Parse(txt_Display.Text);
                txt_Display.Text = "0";
                flag = 1;
            }
            else
            {
                total = Calculate(double.Parse(txt_Display.Text));
                string opr = ((Button)sender).Text;
                operation = opr;                
                txt_Display.Text = "0";
            }
        }


        private double Calculate(double val)
        {
            switch (operation)
            {
                case "+": return total + val;
                case "-": return total - val;
                case "*": return total * val;
                case "/": return total / val;
                default: return 0;
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            txt_Display.Text = Calculate(double.Parse(txt_Display.Text)).ToString();
            operation = "";
            flag = 0;
        }

        private void btn_dt_Click(object sender, EventArgs e)
        {
            string number = txt_Display.Text;
            number += ".";
            txt_Display.Text =number.ToString();

        }
    }
}
