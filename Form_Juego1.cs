using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Media;

namespace EscapeRoom
{
    public partial class Form_Juego1 : Form
    {
        private bool solucion = false;
        private int cont;
        private bool primerMovimientoEsOculto;
        private bool laberintoSolucionado;
        private ResourceManager rm;
        private int[] movCorrectos = { 4, 3, 4, 2, 1, 2, 4, 3, 4, 3, 1, 3, 1, 3, 1, 3, 4, 3, 1, 3, 4, 2, 4, 2, 1, 2, 4, 2, 1, 3, 1, 2 };
        private int[] movOculto = { 2, 4 };

        public bool Solucion { get => solucion; set => solucion = value; }

        public Form_Juego1(bool solucion)
        {
            this.solucion = solucion;
            cont = 0;
            primerMovimientoEsOculto = false;
            laberintoSolucionado = false;
            rm = new ResourceManager("EscapeRoom.Properties.Resources", Assembly.GetExecutingAssembly());
            InitializeComponent();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            solucion = false;
            this.Close();
        }

        private void pbElectron_Click(object sender, EventArgs e)
        {
        }

        private void Form_Juego1_Load(object sender, EventArgs e)
        {
            bloquearTodo();
            sala06_pbSolucionado.Visible = false;
            sala06_pbSolucionado.Enabled = false;
        }

        private void ocultarTodo()
        {
            sala06_pbAtras.Visible = false;
            sala06_pbLaberinto.Visible = false;
            sala06_pbIman.Visible = false;
            sala06_pbElectron.Visible = false;
            sala06_pbProton.Visible = false;
            sala06_pbFlechas.Visible = false;
        }

        private void bloquearTodo()
        {
            sala06_pbLaberinto.Enabled = false;
            sala06_pbIman.Enabled = false;
            sala06_pbElectron.Enabled = false;
            sala06_pbProton.Enabled = false;
            sala06_pbFlechas.Enabled = false;
        }

        private void consultarMovimiento(int flecha)
        {
            if (cont == 0)
            {
                compruebaMovOculto(flecha);

                if (!primerMovimientoEsOculto)
                {
                    compruebaMovDentroLaberinto(flecha);
                }
            }
            else
            {
                if (primerMovimientoEsOculto)
                {
                    compruebaMovOculto(flecha);
                }
                else
                {
                    compruebaMovDentroLaberinto(flecha);
                }
            }

        }

        private void compruebaMovOculto(int flecha)
        {
            if (cont <= 1 && flecha == movOculto[cont])
            {
                if (cont == 0)
                {
                    primerMovimientoEsOculto = true;
                    cont++;
                    sala06_pbLaberinto.BackgroundImage = Properties.Resources.sala06_LaberintoAtajo;
                }
                else
                {
                    sala06_pbLaberinto.BackgroundImage = Properties.Resources.sala06_LaberintoSolucion;
                    Application.DoEvents();
                    Thread.Sleep(450);
                    solucionado();
                }
            }
            else
            {
                cont = 0;
                sala06_pbLaberinto.BackgroundImage = Properties.Resources.sala06_Laberinto1;
            }
        }

        private void compruebaMovDentroLaberinto(int flecha)
        {
            if (flecha == movCorrectos[cont])
            {
                if (cont < 31)
                {
                    cont++;
                    sala06_pbLaberinto.BackgroundImage = (Bitmap)rm.GetObject("sala06_Laberinto" + (cont + 1).ToString());
                }
                else
                {
                    sala06_pbLaberinto.BackgroundImage = Properties.Resources.sala06_LaberintoSolucion;
                    Application.DoEvents();
                    Thread.Sleep(450);
                    solucionado();
                }
                
            }
            else
            {                              
                cont = 0;
                sala06_pbLaberinto.BackgroundImage = Properties.Resources.sala06_Laberinto1;
            }
        }

        private void solucionado()
        {
            ocultarTodo();

            sala06_pbSolucionado.Visible = true;
            sala06_pbSolucionado.Enabled = true;          
        }

        private void pbLaberinto_Click(object sender, EventArgs e)
        {
        }

        private void pbSolucionado_Click(object sender, EventArgs e)
        {          
            laberintoSolucionado = true;
            solucion = true;
            this.Close();
        }

        private void Form_Juego1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!laberintoSolucionado &&
                (e.KeyCode == Keys.Left ||
                 e.KeyCode == Keys.Up ||
                 e.KeyCode == Keys.Down ||
                 e.KeyCode == Keys.Right))
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        sala06_pbFlechas.BackgroundImage = Properties.Resources.sala06_flechasNegras_Left;
                        consultarMovimiento(1);
                        break;
                    case Keys.Up:
                        sala06_pbFlechas.BackgroundImage = Properties.Resources.sala06_flechasNegras_Up;
                        consultarMovimiento(2);
                        break;
                    case Keys.Down:
                        sala06_pbFlechas.BackgroundImage = Properties.Resources.sala06_flechasNegras_Down;
                        consultarMovimiento(3);
                        break;
                    case Keys.Right:
                        sala06_pbFlechas.BackgroundImage = Properties.Resources.sala06_flechasNegras_Right;
                        consultarMovimiento(4);
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(250);

                sala06_pbFlechas.BackgroundImage = Properties.Resources.sala06_flechasNegras;
            }
        }
    }
}
