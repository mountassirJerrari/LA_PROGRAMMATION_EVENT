using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_PROGRAMMATION_ÉVÉNEMENTIELLE
{
    public partial class Form1 : Form
    {

        private string expression;
        private string insertedNumber;
        private int result;
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn2_Click(object sender, EventArgs e)
        {
            btnClicked(Btn2);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            btnClicked(BtnDiv);
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            btnClicked(BtnZero);
        }

        private void BtnEgale_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnPnt_Click(object sender, EventArgs e)
        {
            btnClicked(BtnPnt);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            btnClicked(BtnPlus);
        }

        private void BtnMoin_Click(object sender, EventArgs e)
        {
            btnClicked(BtnMoin);
        }

        private void BtnMltply_Click(object sender, EventArgs e)
        {
            btnClicked(BtnMltply);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            btnClicked(Btn1);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            btnClicked(Btn3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

        }

        private void Btn5_Click(object sender, EventArgs e)
        {

        }

        private void Btn6_Click(object sender, EventArgs e)
        {

        }

        private void Btn9_Click(object sender, EventArgs e)
        {

        }

        private void Btn7_Click(object sender, EventArgs e)
        {

        }

        private void Btn8_Click(object sender, EventArgs e)
        {

        }

        private void LblExpression_Click(object sender, EventArgs e)
        {
            
        }

        private void Lblresult_Click(object sender, EventArgs e)
        {

        }
        private void btnClicked(Button btn)
        {
            expression += btn.Text;
            insertedNumber += btn.Text;
            LblExpression.Text = expression;
           

        }
        private void operationClicked( Button operation)
        {
            
            if (operation.Text == "+")
            {
                result*=int.Parse(insertedNumber);
            }
            else if (operation.Text == "-")
            {
                result *= int.Parse(insertedNumber);
            }
            else if (operation.Text == "*")
            {
                result *= int.Parse(insertedNumber);
            }
            else
            {
                result *= int.Parse(insertedNumber);
            }
        }


    }
}
