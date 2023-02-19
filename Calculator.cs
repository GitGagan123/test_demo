using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double resultvalue = 0;
        string opPerformed = "";
        bool isOPperformed = false;
        bool isEqualsClicked = false;
        bool ce = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isOPperformed))
                textBox.Clear();
            isOPperformed = false;
            Button n = (Button)sender;
            if (n.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }else
            textBox.Text = textBox.Text + n.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if(resultvalue !=0)
            {
                nequal.PerformClick();
                opPerformed = n.Text;
                
                lcurrentOp.Text = resultvalue + " " + opPerformed;
                isOPperformed = true;
            }
            else 
            {
                opPerformed = n.Text;
                resultvalue = Double.Parse(textBox.Text);
                lcurrentOp.Text = resultvalue + " " + opPerformed;
                isOPperformed = true;
            }
            
        }

        private void nce_Click(object sender, EventArgs e)
        {
            if (ce == true)
            {
                if (textBox.Text != "0" && textBox.TextLength > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.TextLength - 1);
                }
            }
           
            
            
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultvalue = 0;
            
            isEqualsClicked = false;
            ce = true;
        }

        private void nequal_click(object sender, EventArgs e)
        {
            if (isEqualsClicked == false)
            {
                switch (opPerformed)
                {

                    case "+":

                        textBox.Text = (resultvalue + Double.Parse(textBox.Text)).ToString();
                        lcurrentOp.Text = String.Empty;

                        break;

                    case "-":
                        textBox.Text = (resultvalue - Double.Parse(textBox.Text)).ToString();
                        lcurrentOp.Text = String.Empty;
                        break;

                    case "*":
                        textBox.Text = (resultvalue * Double.Parse(textBox.Text)).ToString();
                        lcurrentOp.Text = String.Empty;
                        break;

                    case "/":
                        textBox.Text = (resultvalue / Double.Parse(textBox.Text)).ToString();
                        lcurrentOp.Text = String.Empty;
                        break;

                    default:
                        break;


                }

                isEqualsClicked= true;
                ce = false;

                resultvalue = Double.Parse(textBox.Text);
                
            }
        }
    }
}









