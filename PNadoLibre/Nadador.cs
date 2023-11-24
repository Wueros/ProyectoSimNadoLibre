using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace PNadoLibre
{
    public class Nadador : PictureBox
    {
        public Nadador(Image NadadorReposImage,Image NadadorAnimation, int y, int anc, int lar)
        {
            this.Image = NadadorAnimation;
               ImageNadadorEnReposo= NadadorReposImage;
            this.Left = 1;
            this.Top = y;
            this.Width = anc;
            this.Height = lar;
            NumVueltas = 0;
            tim.Interval = 100;
            tim.Tick += Tim_Tick;
            tim.Stop();
            TimNad = true;

        }
        private Image ImageNadadorReposo;

        public Image ImageNadadorEnReposo
        {
            get { return ImageNadadorReposo; }
            set { ImageNadadorReposo = value; }
        }

        private void Tim_Tick(object sender, EventArgs e)
        {

            if (this.Left>= LimitRight) NumVueltas += 1;
            else if (this.Left <= 0) NumVueltas += 1;
           
            if (NumVueltas % 2 == 0)
            {
                if (PlayerParent.PlayerDistance < Distancia)
                {
                    this.Left += 10;
                    PlayerParent.PlayerDistance += 10;
                }
                else tim.Stop();

            }
            else
            {
                if (PlayerParent.PlayerDistance < Distancia)
                {
                    this.Left -= 10;
                    PlayerParent.PlayerDistance += 10;
                }
                else tim.Stop();

            }

            LDis.Text = (PlayerParent.PlayerDistance / 31).ToString()+"m";
            if(!tim.Enabled)
            {
                TimNad = false;
            }
            else
            {
                TimNad = true;
            }
        }

        private int Vueltas;

        public int NumVueltas
        {
            get { return Vueltas; }
            set { Vueltas = value; }
        }
        Timer tim = new Timer();
        private bool TimStatus;

        public bool TimNad
        {
            get { return TimStatus; }
            set { TimStatus = value; }
        }
        int LimitRight,Distancia;
        Jugador PlayerParent;
        Label LDis;
        public void Avanzar(int ValorDados, int LimitRight,Jugador PlayerParent,Label LDis)
        {
            this.LDis = LDis;
            Distancia = PlayerParent.PlayerDistance + ValorDados;
            this.PlayerParent = PlayerParent;
            this.LimitRight = LimitRight;
            tim.Start();
        }
    }
}
