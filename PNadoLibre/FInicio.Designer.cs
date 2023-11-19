
namespace PNadoLibre
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.BSelectNP = new System.Windows.Forms.ToolStripMenuItem();
            this.CBNumPlayers = new System.Windows.Forms.ToolStripComboBox();
            this.BLoginPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.BStarGame = new System.Windows.Forms.ToolStripMenuItem();
            this.BSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BSelectNP,
            this.BLoginPlayers,
            this.BStarGame,
            this.BSalir});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(343, 661);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // BSelectNP
            // 
            this.BSelectNP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CBNumPlayers});
            this.BSelectNP.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSelectNP.Name = "BSelectNP";
            this.BSelectNP.Size = new System.Drawing.Size(330, 31);
            this.BSelectNP.Text = "Seleccionar Numero de Jugadores";
            // 
            // CBNumPlayers
            // 
            this.CBNumPlayers.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNumPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CBNumPlayers.Name = "CBNumPlayers";
            this.CBNumPlayers.Size = new System.Drawing.Size(121, 37);
            this.CBNumPlayers.Text = "2";
            this.CBNumPlayers.ToolTipText = "Maximo 8, Minimo 2";
            // 
            // BLoginPlayers
            // 
            this.BLoginPlayers.Name = "BLoginPlayers";
            this.BLoginPlayers.Size = new System.Drawing.Size(330, 31);
            this.BLoginPlayers.Text = "Registrar Datos de los Jugadores";
            this.BLoginPlayers.Click += new System.EventHandler(this.BLoginPlayers_Click);
            // 
            // BStarGame
            // 
            this.BStarGame.Enabled = false;
            this.BStarGame.Name = "BStarGame";
            this.BStarGame.Size = new System.Drawing.Size(330, 31);
            this.BStarGame.Text = "Empezar Juego";
            this.BStarGame.Click += new System.EventHandler(this.BStarGame_Click);
            // 
            // BSalir
            // 
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(330, 31);
            this.BSalir.Text = "Salir";
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nado Libre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem BSelectNP;
        private System.Windows.Forms.ToolStripMenuItem BLoginPlayers;
        private System.Windows.Forms.ToolStripMenuItem BStarGame;
        private System.Windows.Forms.ToolStripMenuItem BSalir;
        private System.Windows.Forms.ToolStripComboBox CBNumPlayers;
    }
}

