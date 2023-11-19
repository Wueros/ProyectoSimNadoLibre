using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNadoLibre
{
    public partial class FGame : Form
    {
        FInicio fI = new FInicio();
        public FGame(List<Jugador> players)
        {
            InitializeComponent();
            playersList = players;
        }
        List<Jugador> playersList = new List<Jugador>();

        private void FGame_Load(object sender, EventArgs e)
        {
           PbImgNadador.Image= playersList[0].PlayerNadador.Image;
        }

        private void BLanzar_Click(object sender, EventArgs e)
        {

        }
    }
}
