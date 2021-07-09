using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASDFASDF
{
    public partial class Form1 : Form
    {
        public bool Main()
        {
            bool count = txtbx_op.Text.Length >= 1;
            return count;
        }

        public bool syn()
        {
            if (txtbx_op.Text == "X")
            {
                return true;
            }
            if (txtbx_op.Text == "÷")
            {
                return true;
            }
            if (txtbx_op.Text == "+")
            {
                return true;
            }
            if (txtbx_op.Text == "-")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        StringBuilder eq = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (syn() == true)
            {
                txtbx_op.Text = txtbx_op.Text = "7";
                eq.Append(7);
            }
            else
            {
                txtbx_op.Text = txtbx_op.Text + "7";
                eq.Append(7);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (syn() == true)
            {
                txtbx_op.Text = txtbx_op.Text = "2";
                eq.Append(2);
            }
            else
            {
                txtbx_op.Text = txtbx_op.Text + "2";
                eq.Append(2);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                txtbx_op.Text = txtbx_op.Text.Remove(txtbx_op.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "-";
                eq.Append("-");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "÷";
                eq.Append("/");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "1";
                    eq.Append(1);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "1";
                    eq.Append(1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "5";
                    eq.Append(5);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "5";
                    eq.Append(5);
                }
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "3";
                    eq.Append(3);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "3";
                    eq.Append(3);
                }
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "4";
                    eq.Append(4);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "4";
                    eq.Append(4);
                }
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "6";
                    eq.Append(6);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "6";
                    eq.Append(6);
                }
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "8";
                    eq.Append(8);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "8";
                    eq.Append(8);
                }
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {

            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "9";
                    eq.Append(9);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "9";
                    eq.Append(9);
                }
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                if (syn() == true)
                {
                    txtbx_op.Text = txtbx_op.Text = "0";
                    eq.Append(0);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + "0";
                    eq.Append(0);
                }
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "X";
                eq.Append("*");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "+";
                eq.Append("+");
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtbx_op.Text = txtbx_op.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }
    }
}
