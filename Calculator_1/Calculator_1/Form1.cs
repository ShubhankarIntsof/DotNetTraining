using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_1
{
    public partial class FormCalculator : Form
    {
        float num, ans = 0;
        string ope;
        
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }



        private void CalcDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 9;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 8;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 7;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 6;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 5;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 4;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 3;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 2;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + 1;
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            //string s = CalcDisplay.Text;
            if (!CalcDisplay.Text.Contains("."))
            {
                CalcDisplay.Text = CalcDisplay.Text + ".";
                //CalcDisplay.Text = s;
            }
            
        }



        private void button_equals_Click(object sender, EventArgs e)
        {
            //CalcDisplay.Text = ans.ToString();

            Calculate(ope);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            CalcDisplay.Clear();

        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            num = float.Parse(CalcDisplay.Text);
            //ans = ans - num;
            CalcDisplay.Clear();
            ope = "Sub";

        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(CalcDisplay.Text);
            //ans = ans * num;
            CalcDisplay.Clear();
            ope = "Mul";
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            num = float.Parse(CalcDisplay.Text);
            //ans = ans / num;
            CalcDisplay.Clear();
            ope = "Div";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            num = float.Parse(CalcDisplay.Text);
            //ans = ans + num;
            CalcDisplay.Clear();
            ope = "Add";


        }
        public void Calculate(String O)
        {
            if (O == "Add")
            {
                ans = num + float.Parse(CalcDisplay.Text);
                //ans = ans + float.Parse(CalcDisplay.Text);
                CalcDisplay.Text = ans.ToString();
                return;

            }
            else if (O == "Sub")
            {
                ans = num - float.Parse(CalcDisplay.Text);
                CalcDisplay.Text = ans.ToString();
                return;
            }
            else if (O == "Mul")
            {
                ans = num * float.Parse(CalcDisplay.Text);
                CalcDisplay.Text = ans.ToString();
                return;

            }
            else if (O == "Div")
            {
                ans = num / float.Parse(CalcDisplay.Text);
                CalcDisplay.Text = ans.ToString();
                return;
            }
            else
            {
                ans = float.Parse(CalcDisplay.Text);
                return;

            }

        }
    }
}
