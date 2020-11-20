using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTestMetodoEvento
{
    public partial class Form1 : Form
    {
        double Valor1, Valor2;
        string Operacion;
        public Form1()
        {
            InitializeComponent();
        }

       private void miMetodo_Click(object sender, EventArgs e)
        {
            
            string textoBoton = ((Button)sender).Text;
            switch (textoBoton)
            {
                case "FL":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoF = Math.Floor(Valor1);
                    lblnum.Text = resultadoF + "";
                    break;
                case "T":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoT = Math.Truncate(Valor1);
                    lblnum.Text = resultadoT + "";
                    break;
                case "Cei":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoC = Math.Ceiling(Valor1);
                    lblnum.Text = resultadoC + "";
                    break;
                case "E":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoE = Math.Exp(Valor1);
                    lblnum.Text = resultadoE + "";
                    break;
                case "ATan":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoATan = Math.Atan(Valor1);
                    lblnum.Text = resultadoATan + "";
                    break;
                case "ACos":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoACos = Math.Acos(Valor1);
                    lblnum.Text = resultadoACos + "";
                    break;
                case "ASin":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoASin = Math.Asin(Valor1);
                    lblnum.Text = resultadoASin + "";
                    break;
                case "| |":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoAbs = Math.Abs(Valor1);
                    lblnum.Text = resultadoAbs + "";
                    break;
                case "log10":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoL10 = Math.Log10(Valor1);
                    lblnum.Text = resultadoL10 + "";
                    break;
                case "R":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoR = Math.Round(Valor1);
                    lblnum.Text = resultadoR + "";
                    break;
                case "L":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoL = Math.Log(Valor1);
                    lblnum.Text = resultadoL + "";
                    break;
                case "Sin":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoSin = Math.Sin(Valor1);
                    lblnum.Text = resultadoSin + "";
                    break;
                case "Cos":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoCos = Math.Cos(Valor1);
                    lblnum.Text = resultadoCos + "";
                    break;
                case "Tan":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultadoTan = Math.Tan(Valor1);
                    lblnum.Text = resultadoTan + "";
                    break;
                case "√":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Valor1 = double.Parse(lblnum.Text);
                    double resultado = Math.Sqrt(Valor1);
                    lblnum.Text = resultado + "";
                    break;
                case "+":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Operacion = textoBoton;
                    Valor1 = double.Parse(lblnum.Text);
                    lblnum.Text = "";
                    break;
                case "-":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Operacion = textoBoton;
                    Valor1 = double.Parse(lblnum.Text);
                    lblnum.Text = "";
                    break;
                case "x":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Operacion = textoBoton;
                    Valor1 = double.Parse(lblnum.Text);
                    lblnum.Text = "";
                    break;
                case "÷":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    Operacion = textoBoton;
                    Valor1 = double.Parse(lblnum.Text);
                    lblnum.Text = "";
                    break;
                case "=":
                    if (lblnum.Text == "")
                    {
                        break;
                    }
                    switch (Operacion)
                    {

                        case "+":
                            Valor2 = double.Parse(lblnum.Text);
                            lblnum.Text = (Valor1 + Valor2) + "";
                            break;
                        case "-":
                            Valor2 = double.Parse(lblnum.Text);
                            lblnum.Text = (Valor1 - Valor2) + "";
                            break;
                        case "x":
                            Valor2 = double.Parse(lblnum.Text);
                            lblnum.Text = (Valor1 * Valor2) + "";
                            break;
                        case "÷":
                            Valor2 = double.Parse(lblnum.Text);
                            lblnum.Text = (Valor1 / Valor2) + "";
                            break;
                    }
                    break;
                case "AC":
                    lblnum.Text = "";
                    break;
                case ".":
                    if (lblnum.Text.IndexOf(".") == -1)
                    {
                        lblnum.Text += textoBoton;
                    }
                    break;
                default:
                    lblnum.Text += textoBoton;
                    break;
            
            }


            
        }

        
        private void btnResultado_Click(object sender, EventArgs e)
        {
            Valor2 = double.Parse(lblnum.Text);

            
            
                
        }

    }

       



        //private void btn1_Click(object sender, EventArgs e)
        //{

        //}
    }

