using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        //=============Variables==================
       
        double n1 = 0;
        double n2 = 0;
        string operador = "";
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            n1 = 0;
            n2 = 0;
            operador = "";
        }

        // Borra caracteres de mas 
        private void btnCe_Click(object sender, EventArgs e)
        {
            if (txtPantalla.TextLength == 1) txtPantalla.Text = "0";
            else txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";     
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ",";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (operador == "*" || operador == "/" || operador == "-")
            {
                operador = "+";
            }
            else
            {
                operador = "+";
                n1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "0";
            }
        }


        private void BtnRestar_Click(object sender, EventArgs e)
        {
            if (operador == "*" || operador == "/" || operador == "+")
            {
                operador = "-";
            }
            else
            {
                operador = "-";
                n1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "0";
            }
        }

        private void btnMultiplicación_Click(object sender, EventArgs e)
        {
            if (operador == "+" || operador == "/" || operador == "-")
            {
                operador = "*";
            }
            else
            {
                operador = "*";
                n1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "0";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (operador == "*" || operador == "+" || operador == "-")
            {
                operador = "/";
            }
            else
            {
                operador = "/";
                n1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "0";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtPantalla.Text);

            switch (operador)
            {
                case "+":
                    txtPantalla.Text = $"{n1 + n2}";
                break;
                
                case "-":
                    txtPantalla.Text = $"{n1 - n2}";
                    break;

                case "*":
                    txtPantalla.Text = $"{n1 * n2}";
                    break;
                case "/":
                    txtPantalla.Text = $"{n1 / n2}";
                    break;

            }

        }
    }
}
