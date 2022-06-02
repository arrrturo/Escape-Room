using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class Form_Pergamino : Form
    {
        private int opc;
        public Form_Pergamino(int opc)
        {
            this.opc = opc;
            InitializeComponent();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Pergamino_Load(object sender, EventArgs e)
        {
            if (opc == 1)
            {
                sala06_pbPapiro.BackgroundImage = Properties.Resources.sala06_Papiro1;
            }
            if (opc == 2)
            {
                sala06_pbPapiro.BackgroundImage = Properties.Resources.sala06_Papiro2;
            }
            if (opc == 3)
            {
                sala06_pbPapiro.BackgroundImage = Properties.Resources.sala06_Papiro3;
            }
        }
    }
}
