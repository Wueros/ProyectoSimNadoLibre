using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace PNadoLibre
{
    public class Jugador
    {
        private string name;

        public string PlayerName
        {
            get { return name; }
            set { name = value; }
        }
        private Color color;

        public Color PlayerColor
        {
            get { return color; }
            set { color = value; }
        }
        private int Num;

        public int PlayerNum
        {
            get { return Num; }
            set { Num = value; }
        }
        private int Distance;

        public int PlayerDistance
        {
            get { return Distance; }
            set { Distance = value; }
        }
        private Nadador nadador;

        public Nadador PlayerNadador
        {
            get { return nadador; }
            set { nadador = value; }
        }
        public Jugador(string NamePlayer,Color colorPlayer,int numPlayer,Image nadadorReposImg,Image NadadorAnimation)
        {
            PlayerName = NamePlayer;
            PlayerColor = colorPlayer;
            PlayerNum = numPlayer;
            PlayerDistance = 0;
            CrearNadador(nadadorReposImg,NadadorAnimation);
        }
        int y = 60;
        public void CrearNadador(Image NadadorImg,Image NadadorAnim)
        {
                y *= (PlayerNum-1);
                PlayerNadador = new Nadador(NadadorImg, NadadorAnim, y+20, 100, 60);
        }
    }
}
