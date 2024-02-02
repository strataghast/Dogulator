using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_2_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2;
        string operate;

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "1";
                txtDisplayHistory.Text = "1";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "1";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "1";
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "2";
                txtDisplayHistory.Text = "2";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "2";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "3";
                txtDisplayHistory.Text = "3";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "3";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "3";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "4";
                txtDisplayHistory.Text = "4";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "4";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "5";
                txtDisplayHistory.Text = "5";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "5";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "5";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "6";
                txtDisplayHistory.Text = "6";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "6";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "7";
                txtDisplayHistory.Text = "7";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "7";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "8";
                txtDisplayHistory.Text = "8";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "8";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "9";
                txtDisplayHistory.Text = "9";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "9";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "9";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text == "0" && txtDisplayHistory.Text == "0")
            {
                txtDisplayMain.Text = "0";
                txtDisplayHistory.Text = "0";
            }
            else
            {
                txtDisplayMain.Text = txtDisplayMain.Text + "0";
                txtDisplayHistory.Text = txtDisplayHistory.Text + "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplayMain.Clear();
            txtDisplayHistory.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            num1 = double.Parse(txtDisplayMain.Text);
            operate = "+";
            txtDisplayHistory.Text = txtDisplayHistory.Text + operate; 
            txtDisplayMain.Clear();

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplayMain.Text);
            operate = "-";
            txtDisplayHistory.Text = txtDisplayHistory.Text + operate;
            txtDisplayMain.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplayMain.Text);
            operate = "x";
            txtDisplayHistory.Text = txtDisplayHistory.Text + operate;
            txtDisplayMain.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplayMain.Text);
            operate = "/";
            txtDisplayHistory.Text = txtDisplayHistory.Text + operate;
            txtDisplayMain.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplayMain.Text);

            switch(operate)
            {
                case "+":
                    Calculations operAdd;
                    operAdd = new Calculations();
                    txtDisplayMain.Text = operAdd.Addition(num1, num2).ToString();
                    txtDisplayHistory.Text = txtDisplayHistory.Text + " = " + operAdd.Addition(num1, num2).ToString() + System.Environment.NewLine;
                    break;
                case "-":
                    Calculations operSub;
                    operSub = new Calculations();
                    txtDisplayMain.Text = operSub.Subtraction(num1, num2).ToString();
                    txtDisplayHistory.Text = txtDisplayHistory.Text + " = " + operSub.Subtraction(num1, num2).ToString() + System.Environment.NewLine;
                    break;
                case "x":
                    Calculations operMul;
                    operMul = new Calculations();
                    txtDisplayMain.Text = operMul.Multiplication(num1, num2).ToString();
                    txtDisplayHistory.Text = txtDisplayHistory.Text + " = " + operMul.Multiplication(num1, num2).ToString() + System.Environment.NewLine;
                    break;
                case "/":
                    Calculations operDiv;
                    operDiv = new Calculations();
                    txtDisplayMain.Text = operDiv.Division(num1, num2).ToString();
                    txtDisplayHistory.Text = txtDisplayHistory.Text + " = " + operDiv.Division(num1, num2).ToString() + System.Environment.NewLine;
                    break;
                default:
                    txtDisplayMain.Text = "I am confused.";
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplayMain.Clear();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplayMain.Text.Length > 0 && txtDisplayHistory.Text.Length > 0)
            {
                txtDisplayMain.Text = txtDisplayMain.Text.Remove(txtDisplayMain.Text.Length - 1, 1);
                txtDisplayHistory.Text = txtDisplayHistory.Text.Remove(txtDisplayHistory.Text.Length - 1, 1);
            }
            if (txtDisplayMain.Text =="")
            {
                txtDisplayMain.Text = "0";
            }
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtDisplayMain.Text);
            txtDisplayMain.Text = Convert.ToString(-1 * val);
            double val2 = Convert.ToDouble(txtDisplayHistory.Text);
            txtDisplayHistory.Text = Convert.ToString(-1 * val2);
        }

        private void btnDogulate_Click(object sender, EventArgs e)
        {
            string numDog = txtDisplayMain.Text;
            Calculations operDog;
            operDog = new Calculations();
            txtDisplayMain.Text = operDog.Dogulate(numDog).ToString();
            txtDisplayHistory.Text = txtDisplayHistory.Text + " = "+ operDog.Dogulate(numDog).ToString() + " in dog years." + System.Environment.NewLine;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplayMain.Text.Contains("."))
            {
                txtDisplayMain.Text = txtDisplayMain.Text + btnDecimal.Text;
                txtDisplayHistory.Text = txtDisplayHistory.Text + btnDecimal.Text;
            }
        }
    }
}
