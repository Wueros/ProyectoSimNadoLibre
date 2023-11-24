using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PNadoLibre
{
    public class CDado : Panel
    {
        PictureBox cara;
        Random r;
        Timer tim;
        int cv;

        private int v;
        public int Pv
        {
            get { return v; }
            set { v = value; }
        }
        String[] fotos = new String[6];
        public CDado(Control con, int anc, int lar, int x, int y, String ruta, Random r)
        {
            // características del contenedor de la imágen
            this.Parent = con;
            this.Width = anc;
            this.Height = lar;
            this.Left = x;
            this.Top = y;
            this.BorderStyle = BorderStyle.Fixed3D;
            // Llenado de arreglo de las caras de un dado
            for (int i = 1; i <= 6; i++)
            {
                fotos[i - 1] = ruta + i.ToString() + ".png";
            }
            // Asiganción del generador de números aleatorios
            this.r = r;
            //***** características de la imágen
            cara = new PictureBox();
            cara.Parent = this;
            cara.Width = this.Width - 4;
            cara.Height = this.Height - 4;
            cara.Left = 2;
            cara.Top = 2;
            cara.SizeMode = PictureBoxSizeMode.StretchImage;
            cara.Load(fotos[0]);
            //***** características del Temporizador
            tim = new Timer();
            tim.Interval = 50;
            tim.Tick += Tim_Tick; //Asignación del manejador de evento Tick
        }
        private void Tim_Tick(object sender, EventArgs e)
        {
            cara.Load(fotos[r.Next(0, 6)]);
            cv++;
            if (cv == 30)
            {
                tim.Stop();
                Pv = r.Next(1, 7);
                cara.Load(fotos[Pv - 1]);
                TimStop = true;
            }
        }
        public void Lanzar()
        {
            cv = 1;
            tim.Start();
            TimStop = false;
        }
        private bool timStop;

        public bool TimStop
        {
            get { return timStop; }
            set { timStop = value; }
        }

    }
}
