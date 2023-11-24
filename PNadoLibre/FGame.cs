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
        List<Jugador> AllPlayers = new List<Jugador>();
        Jugador PlayerInTurn;
        CDado D1, D2;
        string ruta = @"C:\Users\PC\Desktop\Programas\Proyecto-NadoLibre\PNadoLibre\Dados\";
        Random r = new Random();
        public FGame(List<Jugador> players)
        {
            InitializeComponent();
            D1 = new CDado(Pd1, 100, 100, 0, 0, ruta, r);
            D2 = new CDado(pd2, 100, 100, 0, 0, ruta, r);
            AllPlayers = players;
            foreach (Jugador jug in AllPlayers)
            {
                PPicina.Controls.Add(jug.PlayerNadador);
            }
            PlayerInTurn = AllPlayers[0];
            CambiarDataPlayer();

            PbImgNadador.Image = PlayerInTurn.PlayerNadador.ImageNadadorEnReposo;
        }
        int j;
        private void TIdentificador_Tick(object sender, EventArgs e)
        {
            if (D2.TimStop)
            {
                LResDados.Text = (D1.Pv + D2.Pv).ToString();
                j++;
                if (j == 1)
                {
                    PlayerInTurn.PlayerNadador.Avanzar((D1.Pv + D2.Pv) * 31, (PPicina.Width - 100), PlayerInTurn, LDistancia);
                    j++;
                }
                if (!PlayerInTurn.PlayerNadador.TimNad)
                {
                    CambiarTurno();
                    CambiarDataPlayer();
                    BLanzar.Enabled = true;
                    TIdentificador.Stop();
                    PlayerInTurn.PlayerNadador.TimNad = true;
                    IdentificarPosiciones();
                }

            }

        }

        private void PPicina_Paint(object sender, PaintEventArgs e)
        {

        }

        public void IdentificarPosiciones()
        {

        }
        private void BLanzar_Click(object sender, EventArgs e)
        {
            //lanzar y avanzar
            D1.Lanzar();
            D2.Lanzar();
            BLanzar.Enabled = false;
            j = 0;
            TIdentificador.Start();
        }

        private void FGame_Load(object sender, EventArgs e)
        {

        }
        #region Metodos
        public void CambiarDataPlayer()
        {
            LDistancia.Text = (PlayerInTurn.PlayerDistance / 31).ToString() + "m";
            LResDados.Text = "";
            LTurno.Text = PlayerInTurn.PlayerName;
            PbImgNadador.Image = PlayerInTurn.PlayerNadador.ImageNadadorEnReposo;
            foreach (Jugador jug in AllPlayers)
                LbPosicionJug.Items.Add(jug.PlayerName + " --- " + (jug.PlayerDistance / 31).ToString());

        }
        public void CambiarTurno()
        {
            Jugador PlayerSiguinte = null;
            for (int i = 0; i < AllPlayers.Count; i++)
            {
                if (AllPlayers[i] == PlayerInTurn)
                {
                    if (i == AllPlayers.Count - 1)
                        PlayerSiguinte = AllPlayers[0];
                    else
                        PlayerSiguinte = AllPlayers[i + 1];
                }
            }
            LbPosicionJug.Items.Clear();
            PlayerInTurn = PlayerSiguinte;
        }
        #endregion
    }
}