using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'x';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            if (radioOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }

            //Obtengo el número de palabras que forma el telegrama
            //Añado el método String.Split para que cree un array
            //de strings que contenga las palabras del telegrama.
            string[] palabras = textoTelegrama.Split(' ');
            //Cuento el número de palabras (no de caracteres) del telegrama.
            // +1 porque ,length cuenta el array desde el elemento 0.
            numPalabras = palabras.Length;


            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    //Aquí faltaba el coste base
                    //y calcular las palabras que pasaran de 10 x 0.5
                    coste = 3 + 0.5 * (numPalabras - 10);
                }
                txtPrecio.Text = coste.ToString() + " euros";
            }
            else if(tipoTelegrama == 'u')
            {

            //Si el telegrama es urgente
            //He quitado de aquí un if que no tenía sentido.
                if (numPalabras <= 10)
            {
                coste = 6;
            }
            else
            {
                coste = 6 + 0.75 * (numPalabras - 10);
            }
            txtPrecio.Text = coste.ToString() + " euros";


            } else
            {
                MessageBox.Show("tienes que marcar una opción ");
            }

        }
    }
}

