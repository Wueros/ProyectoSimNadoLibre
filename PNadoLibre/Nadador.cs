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
        public Nadador(Image NadadorImage, int y, int anc, int lar)
        {
            this.Image = NadadorImage;
            this.Left = 1;
            this.Top = y;
            this.Width = anc;
            this.Height = lar;
            NumVueltas = 0;
        }
        private int Vueltas;

        public int NumVueltas
        {
            get { return Vueltas; }
            set { Vueltas = value; }
        }

        public void Avanzar(int ValorDados, int LimitRight)
        {
            if (this.Left >= LimitRight) NumVueltas += 1;
            else if (this.Left <= 0) NumVueltas += 1;
            if (NumVueltas % 2 == 0) this.Left += ValorDados;
            else this.Left -= ValorDados;
        }
    }
}
