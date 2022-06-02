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
    public partial class Form_Juego2 : Form
    {
        private bool dianaOK = false;
        int cont = 0;

        public bool DianaOK { get => dianaOK; set => dianaOK = value; }

        public Form_Juego2(bool dianaOK)
        {          
            InitializeComponent();
            this.dianaOK = dianaOK;
            sala06_lblMarcador.Text = "167";
        }



        private void Form_Juego2_Load(object sender, EventArgs e)
        {
            sala06_pbDardo1.Enabled = true;
            sala06_pbDardo2.Enabled = true;
            sala06_pbDardo3.Enabled = true;
            dianaBloqueada();
            sala06_pbSolucionado.Visible = false;
            sala06_pbSolucionado.Enabled = false;
            sala06_pbFail.Enabled = false;
            sala06_pbFail.Visible = false;     
        }

        private void pbDardo1_Click(object sender, EventArgs e)
        {
            cont++;
            sala06_pbDardo1.Visible = false;
            sala06_pbDardo1.Enabled = false;

            dianaDisponible();
        }


        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDiana_Click(object sender, EventArgs e)
        {          
            comprobarResultado();
            dianaBloqueada();
        }


        private void pbDardo2_Click(object sender, EventArgs e)
        {
            cont++;
            sala06_pbDardo2.Visible = false;
            sala06_pbDardo2.Enabled = false;
            dianaDisponible();
        }

        private void pbDardo3_Click(object sender, EventArgs e)
        {
            cont++;
            sala06_pbDardo3.Visible = false;
            sala06_pbDardo3.Enabled = false;
            dianaDisponible();
        }


        private void lblMarcador_Click(object sender, EventArgs e)
        {         
        }

        public void comprobarResultado()
        {
            bool error = false;

            if (sala06_lblMarcador.Text == "0")
            {
                Application.DoEvents();
                Thread.Sleep(450);

                ocultarTodo();
                
                sala06_pbSolucionado.Enabled = true;
                sala06_pbSolucionado.Visible = true;     
            }
            else if (Convert.ToInt32(sala06_lblMarcador.Text) < 0)
            {
                error = true;
            }
            else if (cont == 3 && (Convert.ToInt32(sala06_lblMarcador.Text) > 0))
            {
                error = true;
            }
            if (error)
            {
                Application.DoEvents();
                Thread.Sleep(450);
                ocultarTodo();
                sala06_pbFail.Enabled = true;
                sala06_pbFail.Visible = true;                
            }           
        }

        private void pbTriple20_Click_1(object sender, EventArgs e)
        {
            sala06_lblMarcador.Text = (Convert.ToInt32(sala06_lblMarcador.Text) - 60).ToString();
            comprobarResultado();
            dianaBloqueada();
        }

        private void pbCentro50_Click_1(object sender, EventArgs e)
        {           
            sala06_lblMarcador.Text = (Convert.ToInt32(sala06_lblMarcador.Text) - 50).ToString();
            comprobarResultado();
            dianaBloqueada();
        }

        private void pbTriple19_Click(object sender, EventArgs e)
        {         
            sala06_lblMarcador.Text = (Convert.ToInt32(sala06_lblMarcador.Text) - 57).ToString();
            comprobarResultado();
            dianaBloqueada();
        }

        private void dianaDisponible()
        {
            sala06_pbDiana.Enabled = true;
            sala06_pbTriple20.Enabled = true;
            sala06_pbTriple19.Enabled = true;
            sala06_pbCentro50.Enabled = true;
        }

        private void dianaBloqueada()
        {
            sala06_pbDiana.Enabled = false;
            sala06_pbTriple20.Enabled = false;
            sala06_pbTriple19.Enabled = false;
            sala06_pbCentro50.Enabled = false;
        }

        private void ocultarTodo()
        {
            sala06_pbAtras.Visible = false;
            sala06_pbDiana.Visible = false;
            sala06_pbTriple19.Visible = false;
            sala06_pbTriple20.Visible = false;
            sala06_pbCentro50.Visible = false;
            sala06_pbDardo1.Visible = false;
            sala06_pbDardo2.Visible = false;
            sala06_pbDardo3.Visible = false;
            sala06_lblMarcador.Visible = false;
            sala06_lblTextMarcador.Visible = false;
        }

        private void pbSolucionado_Click(object sender, EventArgs e)
        {
            dianaOK = true;
            this.Close();
        }

        private void pbFail_Click(object sender, EventArgs e)
        {
            dianaOK = false;
            this.Close();
        }
    }
}
