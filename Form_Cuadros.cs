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
    public partial class Form_Cuadros : Form
    {

        bool solucion = false;

        bool dianaOK = false;

        bool siguiente = false;

        bool cartasOK = false;

        Form_Juego1 juego1;
        Form_Juego2 juego2;
        Form_Juego3 juego3;
        public Form_Cuadros()
        {
            InitializeComponent();
        }

        private void Form_Cuadros_Load(object sender, EventArgs e)
        {
            sala06_pbAtrás.Enabled = true;
            sala06_pbCuadro1.Enabled = false;
            sala06_pbCuadro2.Enabled = false;
            sala06_pbCuadro3.Enabled = false;
            sala06_pbJuego1.Enabled = false;
            sala06_pbJuego2.Enabled = false;
            sala06_pbJuego3.Enabled = false;
            sala06_pbPapiro1Pixelado.Visible = false;
            sala06_pbPapiro2Pixelado.Visible = false;
            sala06_pbPapiro3Pixelado.Visible = false;
            sala06_pbCandado.Enabled = false;
            sala06_pbDardo.Enabled = true;
            sala06_pbObjJuego3.Enabled = true;
            sala06_pbMartillo.Enabled = true;
            sala06_pbLlave.Enabled = true;
            sala06_pbLupa.Enabled = true;
            sala06_pbAlicate.Enabled = true;
            sala06_pbPincel.Enabled = true;
            sala06_pbSerrucho.Enabled = true;
            sala06_pbFlecha.Enabled = true;
            sala06_pbIman.Enabled = true;
            sala06_pbSiguiente.Visible = false;
            sala06_pbSiguiente.Enabled = false;
            sala06_pbJuegoResuelto.Visible = false;
            sala06_pbJuegoResuelto.Enabled = false;
        }

       
        private void pbJuego1_Click(object sender, EventArgs e)
        {

            juego1 = new Form_Juego1(solucion);
            juego1.ShowDialog();

            sala06_pbIman.Visible = true;
            sala06_pbJuego1.Enabled = false;

            if (juego1.Solucion)
            {
                sala06_pbPapiro1Pixelado.Enabled = false;
                sala06_pbPapiro1Pixelado.Visible = true;

            }
            else
            {
                sala06_pbPapiro1Pixelado.Enabled = false;
                sala06_pbPapiro1Pixelado.Visible = false;

            }
          
            atras();
        }

        private void pbJuego2_Click(object sender, EventArgs e)
        {
            juego2 = new Form_Juego2(dianaOK);
            juego2.ShowDialog();
            sala06_pbDardo.Visible = true;
            sala06_pbJuego2.Enabled = false;

            if (juego2.DianaOK)
            {
                sala06_pbPapiro2Pixelado.Enabled = false;
                sala06_pbPapiro2Pixelado.Visible = true;
            }
            else
            {
                sala06_pbPapiro2Pixelado.Enabled = false;
                sala06_pbPapiro2Pixelado.Visible = false;
            }          
            atras();
        }

        private void pbJuego3_Click(object sender, EventArgs e)
        {
            juego3 = new Form_Juego3(cartasOK);
            juego3.ShowDialog();

            if (juego3.CartasOK)
            {
                sala06_pbPapiro3Pixelado.Enabled = false;
                sala06_pbPapiro3Pixelado.Visible = true;
            }
            else
            {
                sala06_pbPapiro3Pixelado.Enabled = false;
                sala06_pbPapiro3Pixelado.Visible = false;
            }           
            atras();
        }

        

        private void pbDardo_Click(object sender, EventArgs e)
        {
            sala06_pbDardo.Visible = false;
            sala06_pbJuego2.Enabled = true;

            anularTodo();
        }

        private void pbCanoa_Click(object sender, EventArgs e)
        {
            sala06_pbObjJuego3.Visible = false;
            sala06_pbJuego3.Enabled = true;

            anularTodo();
        }

        private void pbIman_Click(object sender, EventArgs e)
        {
            sala06_pbIman.Visible = false;
            sala06_pbJuego1.Enabled = true;

            anularTodo();
        }

        private void pbLupa_Click(object sender, EventArgs e)
        {
            sala06_pbLupa.Visible = false;
            sala06_pbPapiro1Pixelado.Enabled = true;
            sala06_pbPapiro2Pixelado.Enabled = true;
            sala06_pbPapiro3Pixelado.Enabled = true;

            anularTodo();
        }

        private void pbMartillo_Click(object sender, EventArgs e)
        {
            sala06_pbMartillo.Visible = false;

            anularTodo();
        }

        private void pbLlave_Click(object sender, EventArgs e)
        {
            sala06_pbLlave.Visible = false;
            sala06_pbCandado.Enabled = true;

            anularTodo();
        }

        private void pbAlicate_Click(object sender, EventArgs e)
        {
            sala06_pbAlicate.Visible = false;

            anularTodo();
        }

        private void pbPincel_Click(object sender, EventArgs e)
        {
            sala06_pbPincel.Visible = false;
           
            anularTodo();
        }

        private void pbDestornillador_Click(object sender, EventArgs e)
        {
            sala06_pbSerrucho.Visible = false;

            anularTodo();
        }

        private void pbFlecha_Click(object sender, EventArgs e)
        {
            sala06_pbFlecha.Visible = false;

            anularTodo();
        }

        private void pbPapiro1Pixelado_Click(object sender, EventArgs e)
        {
            Form_Pergamino uno = new Form_Pergamino(1);
            uno.ShowDialog();
            sala06_pbLupa.Visible = true;
            sala06_pbPapiro1Pixelado.Enabled = false;
            sala06_pbPapiro2Pixelado.Enabled = false;
            sala06_pbPapiro3Pixelado.Enabled = false;

            atras();
        }

        private void pbPapiro2Pixelado_Click(object sender, EventArgs e)
        {
            Form_Pergamino dos = new Form_Pergamino(2);
            dos.ShowDialog();

            sala06_pbLupa.Visible = true;
            sala06_pbPapiro1Pixelado.Enabled = false;
            sala06_pbPapiro2Pixelado.Enabled = false;
            sala06_pbPapiro3Pixelado.Enabled = false;

            juego2.comprobarResultado();
            atras();
        }

        private void pbPapiro3Pixelado_Click(object sender, EventArgs e)
        {
            Form_Pergamino tres = new Form_Pergamino(3);
            tres.ShowDialog();
            sala06_pbLupa.Visible = true;
            sala06_pbPapiro1Pixelado.Enabled = false;
            sala06_pbPapiro2Pixelado.Enabled = false;
            sala06_pbPapiro3Pixelado.Enabled = false;

            atras();
        }

        private void pbCandado_Click(object sender, EventArgs e)
        {
            Form_Candado candado = new Form_Candado(siguiente);
            candado.ShowDialog();
            sala06_pbLlave.Visible = true;
            sala06_pbCandado.Enabled = false;

            if (candado.Siguiente)
            {
                sala06_pbSiguiente.Visible = true;
                sala06_pbSiguiente.Enabled = true;
            }
            else
            {
                sala06_pbSiguiente.Visible = false;
                sala06_pbSiguiente.Enabled = false;
            }

            atras();
        }

        private void pbAtrás_Click(object sender, EventArgs e)
        {
            atras();
        }

        private void atras()
        {
            sala06_pbCuadro1.Enabled = false;
            sala06_pbCuadro2.Enabled = false;
            sala06_pbCuadro3.Enabled = false;

            sala06_pbJuego1.Enabled = false;
            sala06_pbJuego2.Enabled = false;
            sala06_pbJuego3.Enabled = false;
            sala06_pbCandado.Enabled = false;

            habilitarTodo();
            verTodo();
        }

        private void anularTodo()
        {
            sala06_pbDardo.Enabled = false;
            sala06_pbObjJuego3.Enabled = false;
            sala06_pbMartillo.Enabled = false;
            sala06_pbLlave.Enabled = false;
            sala06_pbLupa.Enabled = false;
            sala06_pbAlicate.Enabled = false;
            sala06_pbPincel.Enabled = false;
            sala06_pbSerrucho.Enabled = false;
            sala06_pbFlecha.Enabled = false;
            sala06_pbIman.Enabled = false;
        }

        private void habilitarTodo()
        {
            sala06_pbDardo.Enabled = true;
            sala06_pbObjJuego3.Enabled = true;
            sala06_pbMartillo.Enabled = true;
            sala06_pbLlave.Enabled = true;
            sala06_pbLupa.Enabled = true;
            sala06_pbAlicate.Enabled = true;
            sala06_pbPincel.Enabled = true;
            sala06_pbSerrucho.Enabled = true;
            sala06_pbFlecha.Enabled = true;
            sala06_pbIman.Enabled = true;
        }

        private void verTodo()
        {
            sala06_pbDardo.Visible = true;
            sala06_pbObjJuego3.Visible = true;
            sala06_pbMartillo.Visible = true;
            sala06_pbLlave.Visible = true;
            sala06_pbLupa.Visible = true;
            sala06_pbAlicate.Visible = true;
            sala06_pbPincel.Visible = true;
            sala06_pbSerrucho.Visible = true;
            sala06_pbFlecha.Visible = true;
            sala06_pbIman.Visible = true;
        }

        private void ocultarTodo()
        {
            sala06_pbDardo.Visible = false;
            sala06_pbObjJuego3.Visible = false;
            sala06_pbMartillo.Visible = false;
            sala06_pbLlave.Visible = false;
            sala06_pbLupa.Visible = false;
            sala06_pbAlicate.Visible = false;
            sala06_pbPincel.Visible = false;
            sala06_pbSerrucho.Visible = false;
            sala06_pbFlecha.Visible = false;
            sala06_pbIman.Visible = false;
            sala06_pbAtrás.Visible = false;
            sala06_pbCandado.Visible = false;
            sala06_pbSiguiente.Visible = false;
            sala06_pbJuego1.Visible = false;
            sala06_pbJuego2.Visible = false;
            sala06_pbJuego3.Visible = false;
            sala06_pbCuadro1.Visible = false;
            sala06_pbCuadro2.Visible = false;
            sala06_pbCuadro3.Visible = false;
            sala06_pbPapiro1Pixelado.Visible = false;
            sala06_pbPapiro2Pixelado.Visible = false;
            sala06_pbPapiro3Pixelado.Visible = false;
        }

        private void pbSiguiente_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            sala06_pbJuegoResuelto.Visible = true;
            sala06_pbJuegoResuelto.Enabled = true;           
        }

        private void pbJuegoResuelto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Volver(int numJuego)
        {
            switch (numJuego)
            {
                case 1:
                    sala06_pbIman.Visible = true;
                    sala06_pbJuego1.Enabled = false;
                    sala06_pbPapiro1Pixelado.Enabled = false;
                    sala06_pbPapiro1Pixelado.Visible = true;
                    break;

                case 2:
                    sala06_pbDardo.Visible = true;
                    sala06_pbJuego2.Enabled = false;
                    sala06_pbPapiro2Pixelado.Enabled = false;
                    sala06_pbPapiro2Pixelado.Visible = true;
                    break;

                case 3:
                    sala06_pbJuego3.Visible = true;
                    sala06_pbJuego3.Enabled = false;
                    sala06_pbPapiro3Pixelado.Enabled = false;
                    sala06_pbPapiro3Pixelado.Visible = true;
                    break;
            }
            atras();
        }      
    }
}
