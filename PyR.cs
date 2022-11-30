using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Móvil
{
    public partial class pnlPyR : Form
    {
        int resultado = 0;
        int seleccion = 1;

        public pnlPyR()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            if (MessageBox.Show("¡Benvenido!", "QUIEN QUIERE SER MILLONARIO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.txtPregunta.Text = "¿Cuando Ocurrio la segunda guerra mundial?.";
                this.txtRespuesta1.Text = "1939 y 1945";
                this.txtRespuesta2.Text = "1964 y 1970";
                this.txtRespuesta3.Text = "1804 y 1810";
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pregunta2()
        {
            this.txtPregunta.Text = "¿Quién pintó Las meninas?";
            this.txtRespuesta1.Text = "Francisco de Goya";
            this.txtRespuesta2.Text = "Diego Velázquez";
            this.txtRespuesta3.Text = "Salvador Dalí";
            this.txtRespuesta4.Text = "Ninguno de los anteriores";
            seleccion++;
        }
        private void pregunta3()
        {
            this.txtPregunta.Text = "Aproximadamente, ¿cuántos huesos tiene el cuerpo humano?";
            this.txtRespuesta1.Text = "40";
            this.txtRespuesta2.Text = "390";
            this.txtRespuesta3.Text = "208";
            this.txtRespuesta4.Text = "Un café con leche";
            seleccion++;
        }
        private void pregunta4()
        {
            this.txtPregunta.Text = "Si P = M+N, ¿cuál de las siguientes fórmulas es correcta?";
            this.txtRespuesta1.Text = "M = P + N";
            this.txtRespuesta2.Text = "N = P + M";
            this.txtRespuesta3.Text = "M = P – N";
            this.txtRespuesta4.Text = "N = P / M";
            seleccion++;
        }
        private void pregunta5()
        {
            this.txtPregunta.Text = "¿Poque la pizza es redonda, la caja cuadrada y las porciones triangulares?";
            this.txtRespuesta1.Text = "Todo queda calculado";
            this.txtRespuesta2.Text = "Para aparentar tamaño";
            this.txtRespuesta3.Text = "La belleza de las Matematicas y Trigonometria";
            this.txtRespuesta4.Text = "Eso no importa, la cuestion es de hambre";
            seleccion++;
        }


        private void Limpiar()
        {
            this.Opcion1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e) //BOTON SIGUIENTE
        {
            switch (seleccion)
            {
                case 1:
                    if (this.Opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.Opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.Opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.Opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.Opcion3.Checked == true)
                    {
                        resultado++;
                    }

                    if (resultado >= 3)
                    {
                        MessageBox.Show("Tu Resultado: " + resultado.ToString(), "FELICITACIONES!! Buen Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Tu Resultado: " + resultado.ToString(), "ESTUVO CERCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
