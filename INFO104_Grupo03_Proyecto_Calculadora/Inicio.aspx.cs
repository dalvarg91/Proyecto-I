using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFO104_Grupo03_Proyecto_Calculadora
{
    public partial class Inicio : System.Web.UI.Page
    {
        Global global = new Global();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }//Pantalla que muestra cada numero que presionamos en la calculadora

        protected void Btn0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                return;
            }
            else 
            {
                TextBox1.Text += "0";
            }
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "1";
            }
            else
            {
                TextBox1.Text += "1";
            }
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "2";
            }
            else
            {
                TextBox1.Text += "2";
            }
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "3";
            }
            else
            {
                TextBox1.Text += "3";
            }
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "4";
            }
            else
            {
                TextBox1.Text += "4";
            }
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "5";
            }
            else
            {
                TextBox1.Text += "5";
            }
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "6";
            }
            else
            {
                TextBox1.Text += "6";
            }
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "7";
            }
            else
            {
                TextBox1.Text += "7";
            }
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "8";
            }
            else
            {
                TextBox1.Text += "8";
            }
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "9";
            }
            else
            {
                TextBox1.Text += "9";
            }
        }

        protected void Btncoma_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = ",";
            }
            else
            {
                TextBox1.Text += ",";
            }
        }

        protected void Btnsuma_Click(object sender, EventArgs e)
        {
            Global.operacion = "+";// Variable string que se utiliza para que el switch identifique cual boton fue presionado
            Global.val1 = double.Parse(TextBox1.Text); //Almacena el numero seleccionado en la calculadora
            historial.Text += TextBox1.Text + "+"; //Muestra arriba de la pantalla de la calculadora los numeros que hemos utilizado
            TextBox1.Text = "0";//Despues de cada operacion la pantalla de la calculadora vuelve a 0
        }

        protected void Btnresta_Click(object sender, EventArgs e)
        {
            Global.operacion = "-";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += TextBox1.Text + "-";
            TextBox1.Text = "0";
        }

        protected void Btnmultiplica_Click(object sender, EventArgs e)
        {
            Global.operacion = "*";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += TextBox1.Text + "*";
            TextBox1.Text = "0";
        }

        protected void Btndivision_Click(object sender, EventArgs e)
        {
            Global.operacion = "/";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += TextBox1.Text + "/";
            TextBox1.Text = "0";
        }

        protected void Btnraiz_Click(object sender, EventArgs e)
        {
            Global.operacion = "√";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += "√"+Global.val1;
            TextBox1.Text = "0";
        }

        protected void Btnpotenciacuadrado_Click(object sender, EventArgs e)
        {
            Global.operacion = "x²";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += TextBox1.Text + "^2";
            TextBox1.Text = "0";
        }

        protected void Btnlog_Click(object sender, EventArgs e)
        {           
           Global.operacion = "log";
           Global.val1 = double.Parse(TextBox1.Text);
           historial.Text += "Log"+Global.val1;
           TextBox1.Text = "0";                  
        }

        protected void BtnpotenciaN_Click(object sender, EventArgs e)
        {
            Global.operacion = "10^x";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += "10^" + Global.val1;
            TextBox1.Text = "0";
        }

        protected void BtnXpotenciaN_Click(object sender, EventArgs e)
        {
            Global.operacion = "x^n";
            Global.val1 = double.Parse(TextBox1.Text);
            historial.Text += Global.val1 + "^" + Global.val2;
            TextBox1.Text = "0";
        }

        protected void Btnigual_Click(object sender, EventArgs e)
        {
            Global.val2 = double.Parse(TextBox1.Text);//Segunda variable para almacenar un numero
            historial.Text += TextBox1.Text + "=";

            switch (Global.operacion)
            {
                case "+":
                    Global.resultado = Global.val1 + Global.val2;
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "-":
                    Global.resultado = Global.val1 - Global.val2;
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "*":
                    Global.resultado = Global.val1 * Global.val2;
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "/":
                    Global.resultado = Global.val1 / Global.val2;
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "√":
                    Global.resultado = Math.Sqrt(Global.val1);//Se utiliza la funcion Math.Sqrt() dentro del parentisis va el numero al que se le va a aplicar la funcion de raiz
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "x²" :
                    Global.resultado = Math.Pow(Global.val1,2);//Se utiliza la funcion Math.Pow() entre parentesis va el valor seleccionado y el numero de la potencia
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "log":
                    Global.resultado = Math.Log(Global.val1, 10);//Se utiliza la funcion Math.Log() entre parentesis va el valor seleccionado y en este caso como es un logaritmo de base 10 se utiliza el valor 10
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "10^x":
                    Global.resultado = Math.Pow(10, Global.val1);//Se utiliza la funcion Math.Pow() entre parentesis va el numero 10 que viene por defecto y la potencia es seleccionada por el usuario 
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                case "x^n":
                    Global.resultado = Math.Pow(Global.val1,Global.val2);//Se utiliza la funcion Math.Pow() entre parentesis va el numero seleccionado como base y el numero seleccionado como potencia
                    TextBox1.Text = Global.resultado.ToString();
                    break;
                default:
                    break;
            }
        }

        protected void Btnreset_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            historial.Text = "";
        }

        
    }
}