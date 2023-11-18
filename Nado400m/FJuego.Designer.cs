namespace Nado400m
{
    partial class FJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ppicina = new System.Windows.Forms.Panel();
            this.LbPosicion = new System.Windows.Forms.ListBox();
            this.BTirar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LDistancia = new System.Windows.Forms.Label();
            this.LTurno = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // Ppicina
            // 
            this.Ppicina.Location = new System.Drawing.Point(277, 50);
            this.Ppicina.Name = "Ppicina";
            this.Ppicina.Size = new System.Drawing.Size(1494, 573);
            this.Ppicina.TabIndex = 0;
            // 
            // LbPosicion
            // 
            this.LbPosicion.FormattingEnabled = true;
            this.LbPosicion.Location = new System.Drawing.Point(12, 85);
            this.LbPosicion.Name = "LbPosicion";
            this.LbPosicion.Size = new System.Drawing.Size(259, 472);
            this.LbPosicion.TabIndex = 1;
            // 
            // BTirar
            // 
            this.BTirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(187)))), ((int)(((byte)(81)))));
            this.BTirar.FlatAppearance.BorderSize = 0;
            this.BTirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTirar.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTirar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(179)))));
            this.BTirar.Location = new System.Drawing.Point(796, 735);
            this.BTirar.Name = "BTirar";
            this.BTirar.Size = new System.Drawing.Size(188, 39);
            this.BTirar.TabIndex = 2;
            this.BTirar.Text = "TIRAR (k)";
            this.BTirar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(752, 629);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1097, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "DISTANCIA RECORRIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "TURNO";
            // 
            // LDistancia
            // 
            this.LDistancia.AutoSize = true;
            this.LDistancia.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDistancia.Location = new System.Drawing.Point(1242, 722);
            this.LDistancia.Name = "LDistancia";
            this.LDistancia.Size = new System.Drawing.Size(114, 34);
            this.LDistancia.TabIndex = 6;
            this.LDistancia.Text = "0 metros";
            // 
            // LTurno
            // 
            this.LTurno.AutoSize = true;
            this.LTurno.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTurno.Location = new System.Drawing.Point(504, 722);
            this.LTurno.Name = "LTurno";
            this.LTurno.Size = new System.Drawing.Size(101, 34);
            this.LTurno.TabIndex = 7;
            this.LTurno.Text = "TURNO";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1804, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 780);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LTurno);
            this.Controls.Add(this.LDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTirar);
            this.Controls.Add(this.LbPosicion);
            this.Controls.Add(this.Ppicina);
            this.Name = "FJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJuego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ppicina;
        private System.Windows.Forms.ListBox LbPosicion;
        private System.Windows.Forms.Button BTirar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LDistancia;
        private System.Windows.Forms.Label LTurno;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}