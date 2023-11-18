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
    public partial class FInicio : Form
    {
        FDatosJugadores f2;
        public FInicio()
        {
            InitializeComponent();
        }
        private void FInicio_Load(object sender, EventArgs e)
        {

        }
        private void BIniciar_Click(object sender, EventArgs e)
        {
            int numJugadores = Convert.ToInt16(CBNumJugadores.Text);
            int i = 1;
            while (i <= numJugadores)
            {
              f2 = new FDatosJugadores(numJugadores);
                f2.ShowDialog();
                i++;
            }
            FJuego f3 = new FJuego(numJugadores);
            f3.Show();
            this.Hide();

        }
        private void Bsal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
