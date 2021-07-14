using System;
using System.Windows.Forms;
using System.Text;

namespace ASDFASDF
{
    public partial class Form1 : Form
    {
        StringBuilder cfn = new StringBuilder();
        bool checker = false;
        float[] nums = new float[2];

        public bool Main()
        {
            bool count = txtbx_op.Text.Length >= 1;
            return count;
        }

        /// checking operations
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

        public bool test()
        {
            if (syn() == true)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }

        public void btn1(string num1)
        {
            if (test() == checker)
            {
                if (syn() == true)
                {
                    txtbx_op.Text = num1;
                    nums[0] = float.Parse(num1);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + num1;
                    nums[0] = float.Parse(num1);
                }
                MessageBox.Show("first");
            }
            else
            {
                if (syn() == true)
                {
                    txtbx_op.Text = num1;
                    nums[1] = float.Parse(num1);
                }
                else
                {
                    txtbx_op.Text = txtbx_op.Text + num1;
                    nums[1] = float.Parse(num1);
                }
                checker = true;
                MessageBox.Show("second");
            }
        }

        /// 1 = ÷, 2 = X, 3 = +, 4 = -
        public string formula()
        {
            string cfn1 = cfn.ToString();
            int cfn2 = int.Parse(cfn1);
            if (cfn2 == 1)
            {
                float ans = nums[0] / nums[1];
                nums[0] = ans;
                return nums[0].ToString();
            }
            if (cfn2 == 2)
            {
                float ans = nums[0] * nums[1];
                nums[0] = ans;
                return nums[0].ToString();
            }
            if (cfn2 == 3)
            {
                float ans = nums[0] + nums[1];
                nums[0] = ans;
                return nums[0].ToString();
            }
            if (cfn2 == 4)
            {
                float ans = nums[0] - nums[1];
                nums[0] = ans;
                return nums[0].ToString();
            }
            else
            {
                return "Syntax Error";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
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
                cfn.Clear();
                cfn.Append(4);
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
                cfn.Clear();
                cfn.Append(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void four_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void six_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            String btn = (sender as Button).Text;
            string btn2 = btn.ToString();
            btn1(btn2);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "X";
                cfn.Clear();
                cfn.Append(2);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Main())
            {
                txtbx_op.Text = txtbx_op.Text = "+";
                cfn.Clear();
                cfn.Append(3);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            txtbx_op.Text = formula();
            cfn.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            checker = false;
            txtbx_op.Text = txtbx_op.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }
    }
}
