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
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        List<Jugador> PlayersList = new List<Jugador>();

        private void BStarGame_Click(object sender, EventArgs e)
        {
            FGame fg = new FGame(PlayersList);
            fg.Show();
            this.Hide();
        }

        private void BLoginPlayers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt16(CBNumPlayers.Text); i++)
            {
                FDataPlayer fp = new FDataPlayer(i);
                fp.StartPosition = FormStartPosition.CenterScreen;
                fp.LoginPlayer += Fp_LoginPlayer;
                fp.ShowDialog();
            }
            BSelectNP.Enabled = false;
            BLoginPlayers.Enabled = false;
            BStarGame.Enabled = true;

        }
        private void Fp_LoginPlayer(int NumPlayer,Color PlayerColor, string PlayerName,Image PlayerNadadorImg)
        {
            PlayersList.Add(new Jugador(PlayerName,PlayerColor, NumPlayer, PlayerNadadorImg));
        }
    }
}
