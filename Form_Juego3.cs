using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EscapeRoom
{
    public partial class Form_Juego3 : Form
    {
        bool cartasOK = false;

        int clickCartas;
        int contResp;
        PictureBox carta1;
        PictureBox carta2;

        public Form_Juego3(bool cartasOK)
        {
            InitializeComponent();

            clickCartas = 0;
            contResp = 0;
            this.cartasOK = cartasOK;

            sala06_pbCarta1.Tag = "2";
            sala06_pbCarta8.Tag = "2";
            sala06_pbCarta2.Tag = "4";
            sala06_pbCarta5.Tag = "4";
            sala06_pbCarta3.Tag = "5";
            sala06_pbCarta9.Tag = "5";
            sala06_pbCarta4.Tag = "3";
            sal06_pbCarta10.Tag = "3";
            sala06_pbCarta6.Tag = "A";
            sal06_pbCarta12.Tag = "A";
            sala06_pbCarta7.Tag = "K";
            sal06_pbCarta11.Tag = "K";
        }

        public bool CartasOK { get => cartasOK; set => cartasOK = value; }

        private void Form_Juego3_Load(object sender, EventArgs e)
        {
            sala06_pbSolucionado.Enabled = false;
            sala06_pbSolucionado.Visible = false;
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comprobarCarta(PictureBox cartaSeleccionada)
        {           
            clickCartas++;
            if (clickCartas == 2)
            {
                carta2 = cartaSeleccionada;
                comprobarPareja();
                clickCartas = 0;
            }
            else
            {
                carta1 = cartaSeleccionada;
                carta1.Enabled = false;
            }
        }

        private void pbCarta1_Click(object sender, EventArgs e)
        {          
            sala06_pbCarta1.BackgroundImage = Properties.Resources.sala06_2Corazon;
            comprobarCarta(sala06_pbCarta1);
        }

        private void pbCarta8_Click(object sender, EventArgs e)
        {           
            sala06_pbCarta8.BackgroundImage = Properties.Resources.sala06_2Diamante;
            comprobarCarta(sala06_pbCarta8);
        }

        private void pbCarta2_Click(object sender, EventArgs e)
        {          
            sala06_pbCarta2.BackgroundImage = Properties.Resources.sala06_4Trebol;           
            comprobarCarta(sala06_pbCarta2);
        }

        private void pbCarta5_Click(object sender, EventArgs e)
        {
            
            sala06_pbCarta5.BackgroundImage = Properties.Resources.sala06_4Picas;
            comprobarCarta(sala06_pbCarta5);
        }

        private void pbCarta3_Click(object sender, EventArgs e)
        {
            sala06_pbCarta3.BackgroundImage = Properties.Resources.sala06_5Diamante;
            comprobarCarta(sala06_pbCarta3);
        }

        private void pbCarta9_Click(object sender, EventArgs e)
        {
            sala06_pbCarta9.BackgroundImage = Properties.Resources.sala06_5Corazon;
            comprobarCarta(sala06_pbCarta9);
        }

        private void pbCarta4_Click(object sender, EventArgs e)
        {
            sala06_pbCarta4.BackgroundImage = Properties.Resources.sala06_3Trebol;
            comprobarCarta(sala06_pbCarta4);
        }

        private void pbCarta10_Click(object sender, EventArgs e)
        {
            sal06_pbCarta10.BackgroundImage = Properties.Resources.sala06_3Picas;
            comprobarCarta(sal06_pbCarta10);
        }

        private void pbCarta6_Click(object sender, EventArgs e)
        {
            sala06_pbCarta6.BackgroundImage = Properties.Resources.sala06_AsCorazon;
            comprobarCarta(sala06_pbCarta6);
        }

        private void pbCarta12_Click(object sender, EventArgs e)
        {
            sal06_pbCarta12.BackgroundImage = Properties.Resources.sala06_AsDiamante;
            comprobarCarta(sal06_pbCarta12);
        }

        private void pbCarta7_Click(object sender, EventArgs e)
        {
            sala06_pbCarta7.BackgroundImage = Properties.Resources.sala06_KPica;
            comprobarCarta(sala06_pbCarta7);
        }

        private void pbCarta11_Click(object sender, EventArgs e)
        {
            sal06_pbCarta11.BackgroundImage = Properties.Resources.sala06_KTrebol;
            comprobarCarta(sal06_pbCarta11);
        }

        private void comprobarFinal()
        {
            if (sala06_lblMarcador.Text == "6")
            {
                Application.DoEvents();
                Thread.Sleep(450);

                ocultarTodo();
               
                sala06_pbSolucionado.Visible = true;
                sala06_pbSolucionado.Enabled = true;               
            }
        }

        private void comprobarPareja()
        {
            if (carta1.Tag == carta2.Tag)
            {
                sala06_lblMarcador.Text = (Convert.ToInt32(sala06_lblMarcador.Text) + 1).ToString();
                carta1.Enabled = false;
                carta2.Enabled = false;
                contResp++;
            }
            else
            {
                Application.DoEvents();
                Thread.Sleep(350);
                carta1.BackgroundImage = Properties.Resources.sala06_DORSO_ROJO;
                carta2.BackgroundImage = Properties.Resources.sala06_DORSO_ROJO;
                carta1.Enabled = true;
            }
            comprobarFinal();
        }

        private void ocultarTodo()
        {
            sala06_pbCarta1.Visible = false;
            sala06_pbCarta2.Visible = false;
            sala06_pbCarta3.Visible = false;
            sala06_pbCarta4.Visible = false;
            sala06_pbCarta5.Visible = false;
            sala06_pbCarta6.Visible = false;
            sala06_pbCarta7.Visible = false;
            sala06_pbCarta8.Visible = false;
            sala06_pbCarta9.Visible = false;
            sal06_pbCarta10.Visible = false;
            sal06_pbCarta11.Visible = false;
            sal06_pbCarta12.Visible = false;
            sala06_pbTapete.Visible = false;
            sala06_pbAtras.Visible = false;
        }

        private void pbSolucionado_Click(object sender, EventArgs e)
        {
            cartasOK = true;
            this.Close();
        }
    }
}
