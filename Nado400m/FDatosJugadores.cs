using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nado400m
{
    public partial class FDatosJugadores : Form
    {
 
        int numJugadores;
        public FDatosJugadores(int numJugadores)
        {
            InitializeComponent();
            this.numJugadores = numJugadores;
            TBNombre.Focus();
            
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BColor_Click(object sender, EventArgs e)
        {
            CD1.ShowDialog();
            LColor.BackColor = CD1.Color;
        }
    }
}
