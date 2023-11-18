using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Nado400m
{
    public class CJugador
    {
        private string nom;
        public string Nom
        {
            get{return nom;}
            set{nom = value;}
        }

        private Color col;
        public Color Col
        {
            get { return col; }
            set { col = value; }
        }
        private int playerM ;
        public int PlayerM
        {
            get { return playerM; }
            set { playerM = value; }
        }
        public CJugador(string nom,Color col)
        {
            Nom = nom;
            Col = col;
            PlayerM = 0;
        }
    }
}
