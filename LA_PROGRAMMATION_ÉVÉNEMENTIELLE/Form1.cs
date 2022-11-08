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
        private float result=0;
        private Button lastOpration=null ;
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
            operationClicked(BtnDiv);
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            btnClicked(BtnZero);
        }

        private void BtnEgale_Click(object sender, EventArgs e)
        {
            if (lastOpration != null)
            {
                operationClicked(lastOpration, true);
                Lblresult.Text = Convert.ToString(result);
            }
            else
            {
                Lblresult.Text=insertedNumber;
            }

        }

        private void BtnPnt_Click(object sender, EventArgs e)
        {
            btnClicked(BtnPnt);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            btnClicked(BtnPlus);
            operationClicked(BtnPlus);

        }

        private void BtnMoin_Click(object sender, EventArgs e)
        {
            btnClicked(BtnMoin);
            operationClicked(BtnMoin);
        }

        private void BtnMltply_Click(object sender, EventArgs e)
        {
            btnClicked(BtnMltply);
            operationClicked(BtnMltply);

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
            btnClicked(Btn4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            btnClicked(Btn5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            btnClicked(Btn6);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            btnClicked(Btn9);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            btnClicked(Btn7);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            btnClicked(Btn8);
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
            if (btn.Text!="+" && btn.Text != "-" && btn.Text != "/" && btn.Text != "*"  )
            {
                insertedNumber += btn.Text;
            }
            
            LblExpression.Text = expression;
           

        }
        private void  operationClicked( Button operation , bool isEgaleOperation = false)
        {

            
            if (operation.Text == "+")
            {
                result+=float.Parse(insertedNumber);
                
            }
            else if (operation.Text == "-")
            {
                result -= float.Parse(insertedNumber);

            }
            else if (operation.Text == "*")
            {
                if (result==0)
                {
                    result = 1;
                }
                
                result = (result)*(float.Parse(insertedNumber));
            }
            else if (operation.Text == "/")
            {
                if (result == 0)
                {
                    result = 1;
                }
                result /=float.Parse(insertedNumber);
            }
            insertedNumber = "0";

            if (!isEgaleOperation)
            lastOpration = operation;
            
            


        }


    }
}
