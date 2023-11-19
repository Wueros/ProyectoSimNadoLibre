
namespace PNadoLibre
{
    partial class FDataPlayer
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
            this.LPlayerInTurn = new System.Windows.Forms.Label();
            this.TBPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BAcept = new System.Windows.Forms.Button();
            this.PBColors = new System.Windows.Forms.PictureBox();
            this.PBNadador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNadador)).BeginInit();
            this.SuspendLayout();
            // 
            // LPlayerInTurn
            // 
            this.LPlayerInTurn.AutoSize = true;
            this.LPlayerInTurn.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPlayerInTurn.Location = new System.Drawing.Point(147, 9);
            this.LPlayerInTurn.Name = "LPlayerInTurn";
            this.LPlayerInTurn.Size = new System.Drawing.Size(114, 43);
            this.LPlayerInTurn.TabIndex = 0;
            this.LPlayerInTurn.Text = "label1";
            // 
            // TBPlayerName
            // 
            this.TBPlayerName.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPlayerName.Location = new System.Drawing.Point(226, 62);
            this.TBPlayerName.Name = "TBPlayerName";
            this.TBPlayerName.Size = new System.Drawing.Size(182, 28);
            this.TBPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un nombre:";
            // 
            // BAcept
            // 
            this.BAcept.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAcept.Location = new System.Drawing.Point(17, 491);
            this.BAcept.Name = "BAcept";
            this.BAcept.Size = new System.Drawing.Size(169, 56);
            this.BAcept.TabIndex = 5;
            this.BAcept.Text = "ACEPTAR";
            this.BAcept.UseVisualStyleBackColor = true;
            this.BAcept.Click += new System.EventHandler(this.BAcept_Click);
            // 
            // PBColors
            // 
            this.PBColors.Image = global::PNadoLibre.Properties.Resources.SeleccionadorColores;
            this.PBColors.Location = new System.Drawing.Point(11, 158);
            this.PBColors.Name = "PBColors";
            this.PBColors.Size = new System.Drawing.Size(190, 200);
            this.PBColors.TabIndex = 4;
            this.PBColors.TabStop = false;
            this.PBColors.WaitOnLoad = true;
            this.PBColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBColors_MouseDown);
            // 
            // PBNadador
            // 
            this.PBNadador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PBNadador.Image = global::PNadoLibre.Properties.Resources.NadadorAzul;
            this.PBNadador.Location = new System.Drawing.Point(217, 158);
            this.PBNadador.Name = "PBNadador";
            this.PBNadador.Size = new System.Drawing.Size(287, 400);
            this.PBNadador.TabIndex = 3;
            this.PBNadador.TabStop = false;
            this.PBNadador.WaitOnLoad = true;
            // 
            // FDataPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(516, 641);
            this.ControlBox = false;
            this.Controls.Add(this.BAcept);
            this.Controls.Add(this.PBColors);
            this.Controls.Add(this.PBNadador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPlayerName);
            this.Controls.Add(this.LPlayerInTurn);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FDataPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de los Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.PBColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNadador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPlayerInTurn;
        private System.Windows.Forms.TextBox TBPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBNadador;
        private System.Windows.Forms.PictureBox PBColors;
        private System.Windows.Forms.Button BAcept;
    }
}