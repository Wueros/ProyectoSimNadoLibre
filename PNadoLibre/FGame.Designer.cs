
namespace PNadoLibre
{
    partial class FGame
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
            this.components = new System.ComponentModel.Container();
            this.LbPosicionJug = new System.Windows.Forms.ListBox();
            this.BLanzar = new System.Windows.Forms.Button();
            this.pd2 = new System.Windows.Forms.Panel();
            this.Pd1 = new System.Windows.Forms.Panel();
            this.LTurno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LDistancia = new System.Windows.Forms.Label();
            this.PbImgNadador = new System.Windows.Forms.PictureBox();
            this.PPicina = new System.Windows.Forms.Panel();
            this.TIdentificador = new System.Windows.Forms.Timer(this.components);
            this.LResDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbImgNadador)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPosicionJug
            // 
            this.LbPosicionJug.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPosicionJug.FormattingEnabled = true;
            this.LbPosicionJug.ItemHeight = 25;
            this.LbPosicionJug.Location = new System.Drawing.Point(27, 12);
            this.LbPosicionJug.Name = "LbPosicionJug";
            this.LbPosicionJug.Size = new System.Drawing.Size(204, 279);
            this.LbPosicionJug.TabIndex = 1;
            // 
            // BLanzar
            // 
            this.BLanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BLanzar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLanzar.Location = new System.Drawing.Point(812, 690);
            this.BLanzar.Name = "BLanzar";
            this.BLanzar.Size = new System.Drawing.Size(283, 72);
            this.BLanzar.TabIndex = 0;
            this.BLanzar.Text = "Lanzar Dados";
            this.BLanzar.UseVisualStyleBackColor = false;
            this.BLanzar.Click += new System.EventHandler(this.BLanzar_Click);
            // 
            // pd2
            // 
            this.pd2.Location = new System.Drawing.Point(995, 575);
            this.pd2.Name = "pd2";
            this.pd2.Size = new System.Drawing.Size(100, 100);
            this.pd2.TabIndex = 4;
            // 
            // Pd1
            // 
            this.Pd1.Location = new System.Drawing.Point(822, 575);
            this.Pd1.Name = "Pd1";
            this.Pd1.Size = new System.Drawing.Size(100, 100);
            this.Pd1.TabIndex = 5;
            // 
            // LTurno
            // 
            this.LTurno.AutoSize = true;
            this.LTurno.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTurno.Location = new System.Drawing.Point(306, 575);
            this.LTurno.Name = "LTurno";
            this.LTurno.Size = new System.Drawing.Size(391, 37);
            this.LTurno.TabIndex = 6;
            this.LTurno.Text = "TURNO DEL NADADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1265, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "DISTANCIA";
            // 
            // LDistancia
            // 
            this.LDistancia.AutoSize = true;
            this.LDistancia.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDistancia.Location = new System.Drawing.Point(1352, 638);
            this.LDistancia.Name = "LDistancia";
            this.LDistancia.Size = new System.Drawing.Size(39, 37);
            this.LDistancia.TabIndex = 8;
            this.LDistancia.Text = "0";
            // 
            // PbImgNadador
            // 
            this.PbImgNadador.Image = global::PNadoLibre.Properties.Resources.NadadorRojo1;
            this.PbImgNadador.Location = new System.Drawing.Point(27, 317);
            this.PbImgNadador.Name = "PbImgNadador";
            this.PbImgNadador.Size = new System.Drawing.Size(204, 358);
            this.PbImgNadador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbImgNadador.TabIndex = 3;
            this.PbImgNadador.TabStop = false;
            // 
            // PPicina
            // 
            this.PPicina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PPicina.Location = new System.Drawing.Point(237, 0);
            this.PPicina.Name = "PPicina";
            this.PPicina.Size = new System.Drawing.Size(1650, 530);
            this.PPicina.TabIndex = 0;
            this.PPicina.Paint += new System.Windows.Forms.PaintEventHandler(this.PPicina_Paint);
            // 
            // TIdentificador
            // 
            this.TIdentificador.Enabled = true;
            this.TIdentificador.Interval = 50;
            this.TIdentificador.Tick += new System.EventHandler(this.TIdentificador_Tick);
            // 
            // LResDados
            // 
            this.LResDados.AutoSize = true;
            this.LResDados.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResDados.Location = new System.Drawing.Point(928, 561);
            this.LResDados.Name = "LResDados";
            this.LResDados.Size = new System.Drawing.Size(0, 37);
            this.LResDados.TabIndex = 9;
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 774);
            this.Controls.Add(this.LResDados);
            this.Controls.Add(this.LDistancia);
            this.Controls.Add(this.LTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pd1);
            this.Controls.Add(this.BLanzar);
            this.Controls.Add(this.pd2);
            this.Controls.Add(this.PbImgNadador);
            this.Controls.Add(this.LbPosicionJug);
            this.Controls.Add(this.PPicina);
            this.Name = "FGame";
            this.Text = "FGame";
            this.Load += new System.EventHandler(this.FGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImgNadador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LbPosicionJug;
        private System.Windows.Forms.PictureBox PbImgNadador;
        private System.Windows.Forms.Button BLanzar;
        private System.Windows.Forms.Panel Pd1;
        private System.Windows.Forms.Panel pd2;
        private System.Windows.Forms.Label LTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LDistancia;
        public System.Windows.Forms.Panel PPicina;
        private System.Windows.Forms.Timer TIdentificador;
        private System.Windows.Forms.Label LResDados;
    }
}