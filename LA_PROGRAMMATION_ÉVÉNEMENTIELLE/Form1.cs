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
        private bool first_operation= true ;
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            buttons.Add(btnCE);
            buttons.Add(Btn1);
            buttons.Add(Btn2);
            buttons.Add(Btn3);  
            buttons.Add(Btn4);
            buttons.Add(Btn5);
            buttons.Add(Btn6);
            buttons.Add(Btn7);
            buttons.Add(Btn8);
            buttons.Add(Btn9);
            buttons.Add(BtnDiv);
            buttons.Add(BtnMltply);
            buttons.Add(BtnMoin);
            buttons.Add(BtnPlus);
            buttons.Add(BtnEgale);

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

            divLbl.Text = "";
            if (operation.Text == "+" && insertedNumber!=null)
            {
                if (first_operation)
                {
                    result = float.Parse(insertedNumber);
                    first_operation = false;
                }
                else
                {
                    result += float.Parse(insertedNumber);
                }
               
                
            }
            else if (operation.Text == "-" && insertedNumber != null)
            {
                if (first_operation)
                {
                    result = float.Parse(insertedNumber);
                    first_operation = false;
                }
                else
                {
                    result -= float.Parse(insertedNumber);
                }

            }
            else if (operation.Text == "*" && insertedNumber!=null)
            {
                if (first_operation)
                {
                    result = float.Parse(insertedNumber);
                    first_operation = false;
                }
                else
                {
                    result *= float.Parse(insertedNumber);
                }

                
            }
            else if (operation.Text == "/" && insertedNumber != null)
            {
                if (float.Parse(insertedNumber ) == 0)
                {
                    divLbl.Text = " on peut pas devisé sur ZERO";
                }else
                {
                    if (first_operation)
                    {
                        result = float.Parse(insertedNumber);
                        first_operation = false;
                    }
                    else
                    {
                        result /= float.Parse(insertedNumber);
                    }

                }
                
            }
            insertedNumber = null;

            if (!isEgaleOperation)
            lastOpration = operation;
            
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
          expression=null;
         insertedNumber=null;
         result = 0;
         lastOpration = null;
         LblExpression.Text = String.Empty;
         Lblresult.Text = String.Empty;
    }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button button in buttons)
            {
                if (char.ToString(e.KeyChar) == button.Text)
                {
                    button.PerformClick();
                }
                
            }
            if (char.ToString(e.KeyChar) == "c" )
            {
                btnCE.PerformClick();
            }


            
        }
    }
}
