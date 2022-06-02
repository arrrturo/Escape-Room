using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EscapeRoom
{
    public partial class Form_Candado : Form
    {
       
        private bool siguiente = false;

        public bool Siguiente { get => siguiente; set => siguiente = value; }

        public Form_Candado(bool siguiente)
        {
            InitializeComponent();          
            this.siguiente = siguiente;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(sala06_numericUpDown3.Value == 253)
            {                
                noVisible();

                sala06_pbSolucionado.Visible = true;
                sala06_pbSolucionado.Enabled = true;              
            }
            else
            {                
                noVisible();

                sala06_pbFail.Visible = true;
                sala06_pbFail.Enabled = true;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSolucionado_Click(object sender, EventArgs e)
        {
            siguiente = true;
            this.Close();
        }

        private void pbFail_Click(object sender, EventArgs e)
        {
            siguiente = false;
            this.Close();
        }

        private void Form_Candado_Load(object sender, EventArgs e)
        {          
            sala06_pictureBox1.Enabled = true;
            sala06_pbSolucionado.Visible = false;
            sala06_pbFail.Visible = false;
        }

        private void noVisible()
        {
            sala06_pictureBox1.Visible = false;
            
            sala06_pbAtras.Visible = false;
            sala06_numericUpDown3.Visible = false;
        }
    }
}
