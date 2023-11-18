namespace Nado400m
{
    partial class FDatosJugadores
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
            this.LbJugador = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.CD1 = new System.Windows.Forms.ColorDialog();
            this.BColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LColor = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbJugador
            // 
            this.LbJugador.AutoSize = true;
            this.LbJugador.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbJugador.Location = new System.Drawing.Point(101, 9);
            this.LbJugador.Name = "LbJugador";
            this.LbJugador.Size = new System.Drawing.Size(197, 56);
            this.LbJugador.TabIndex = 0;
            this.LbJugador.Text = "JUGADOR ";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(145, 139);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(300, 38);
            this.TBNombre.TabIndex = 1;
            // 
            // BColor
            // 
            this.BColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BColor.FlatAppearance.BorderSize = 0;
            this.BColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BColor.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BColor.Location = new System.Drawing.Point(36, 233);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(127, 59);
            this.BColor.TabIndex = 2;
            this.BColor.Text = "COLOR";
            this.BColor.UseVisualStyleBackColor = false;
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre :";
            // 
            // LColor
            // 
            this.LColor.AutoSize = true;
            this.LColor.BackColor = System.Drawing.Color.White;
            this.LColor.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LColor.Location = new System.Drawing.Point(189, 238);
            this.LColor.Name = "LColor";
            this.LColor.Size = new System.Drawing.Size(129, 43);
            this.LColor.TabIndex = 4;
            this.LColor.Text = "           ";
            // 
            // BAceptar
            // 
            this.BAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BAceptar.FlatAppearance.BorderSize = 0;
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.Location = new System.Drawing.Point(93, 437);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(297, 84);
            this.BAceptar.TabIndex = 5;
            this.BAceptar.Text = "ACEPTAR";
            this.BAceptar.UseVisualStyleBackColor = false;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // FDatosJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(494, 533);
            this.ControlBox = false;
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.LColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BColor);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LbJugador);
            this.Name = "FDatosJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDatosJugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbJugador;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.ColorDialog CD1;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LColor;
        private System.Windows.Forms.Button BAceptar;
    }
}