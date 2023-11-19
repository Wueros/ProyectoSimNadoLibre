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
    public partial class FDataPlayer : Form
    {
        public delegate void Login( int NumPlayer ,Color PlayerColor, String PlayerName,Image NadadorImg);
        public event Login LoginPlayer;
        Bitmap ImageColors;
        int NumPlayer;
        List<Color> Colores = new List<Color>();
        Color PlayerColor;
        public FDataPlayer(int NumPlayer)
        {
            this.NumPlayer = NumPlayer;
            InitializeComponent();
            LPlayerInTurn.Text = "Jugador " + NumPlayer;
            LPlayerInTurn.Left = this.Width / 2;
            Colores.Add(Color.FromArgb(255,30,4,255));//azul
            Colores.Add(Color.FromArgb(255,46,255,4));//Verde
            Colores.Add(Color.FromArgb(255,255,4,4));//Rojo
            Colores.Add(Color.FromArgb(255,4,255,205));//Cian
            Colores.Add(Color.FromArgb(255, 255, 142, 4));//Naranja
            Colores.Add(Color.FromArgb(255,168, 4, 255));//morado
            Colores.Add(Color.FromArgb(255, 255, 231, 4));//amarillo
            Colores.Add(Color.FromArgb(255, 255, 4, 220));//rosa
        }

        private void PBColors_MouseDown(object sender, MouseEventArgs e)
        {
            ImageColors = new Bitmap(PBColors.Image);
            PlayerColor = ImageColors.GetPixel(e.X, e.Y);
            ImagenPersonaje();
        }
        public void ImagenPersonaje()
        {
            if (PlayerColor == Colores[0]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorAzul;
            else if (PlayerColor == Colores[1]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorVerde;
            else if (PlayerColor == Colores[2]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorRojo1;
            else if (PlayerColor == Colores[3]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorCian;
            else if (PlayerColor == Colores[4]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorOrange;
            else if (PlayerColor == Colores[5]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorMorado;
            else if (PlayerColor == Colores[6]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadoraAmarillo;
            else if (PlayerColor == Colores[7]) PBNadador.Image = PNadoLibre.Properties.Resources.NadadorRosa;
            else PBNadador.Image = PNadoLibre.Properties.Resources.NadadorAzul;
        }
        private void BAcept_Click(object sender, EventArgs e)
        {
            if(TBPlayerName.Text == String.Empty) TBPlayerName.Text = LPlayerInTurn.Text;
            LoginPlayer(NumPlayer,PlayerColor, TBPlayerName.Text, PBNadador.Image);
            Close();
        }
    }
}
