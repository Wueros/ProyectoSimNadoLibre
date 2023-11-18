namespace Nado400m
{
    partial class FInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bsalir = new System.Windows.Forms.Button();
            this.BIniciar = new System.Windows.Forms.Button();
            this.CBNumJugadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bsalir
            // 
            this.Bsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Bsalir.FlatAppearance.BorderSize = 0;
            this.Bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsalir.Font = new System.Drawing.Font("Tw Cen MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalir.Location = new System.Drawing.Point(367, 475);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(285, 76);
            this.Bsalir.TabIndex = 2;
            this.Bsalir.Text = "SALIR";
            this.Bsalir.UseVisualStyleBackColor = false;
            this.Bsalir.Click += new System.EventHandler(this.Bsal_Click);
            // 
            // BIniciar
            // 
            this.BIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BIniciar.FlatAppearance.BorderSize = 0;
            this.BIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIniciar.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIniciar.Location = new System.Drawing.Point(340, 348);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(345, 97);
            this.BIniciar.TabIndex = 1;
            this.BIniciar.Text = "JUGAR";
            this.BIniciar.UseVisualStyleBackColor = false;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            // 
            // CBNumJugadores
            // 
            this.CBNumJugadores.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNumJugadores.FormattingEnabled = true;
            this.CBNumJugadores.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CBNumJugadores.Location = new System.Drawing.Point(658, 265);
            this.CBNumJugadores.Name = "CBNumJugadores";
            this.CBNumJugadores.Size = new System.Drawing.Size(113, 64);
            this.CBNumJugadores.TabIndex = 3;
            this.CBNumJugadores.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECCIONE JUGADORES :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(897, 111);
            this.label2.TabIndex = 5;
            this.label2.Text = "NADO LIBRE 400 METROS";
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1030, 587);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBNumJugadores);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.BIniciar);
            this.Name = "FInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bsalir;
        private System.Windows.Forms.Button BIniciar;
        private System.Windows.Forms.ComboBox CBNumJugadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

