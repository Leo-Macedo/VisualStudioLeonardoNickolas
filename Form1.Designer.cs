﻿namespace Leonardo___Nickolas
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo3TabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.frm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmo1ToolStripMenuItem,
            this.algoritmo2ToolStripMenuItem,
            this.algoritmo3TabuadaToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click);
            // 
            // algoritmo1ToolStripMenuItem
            // 
            this.algoritmo1ToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmo1ToolStripMenuItem.Name = "algoritmo1ToolStripMenuItem";
            this.algoritmo1ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.algoritmo1ToolStripMenuItem.Text = "Combustível";
            this.algoritmo1ToolStripMenuItem.Click += new System.EventHandler(this.algoritmo1ToolStripMenuItem_Click);
            // 
            // algoritmo2ToolStripMenuItem
            // 
            this.algoritmo2ToolStripMenuItem.Name = "algoritmo2ToolStripMenuItem";
            this.algoritmo2ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.algoritmo2ToolStripMenuItem.Text = "Votação";
            this.algoritmo2ToolStripMenuItem.Click += new System.EventHandler(this.algoritmo2ToolStripMenuItem_Click);
            // 
            // algoritmo3TabuadaToolStripMenuItem
            // 
            this.algoritmo3TabuadaToolStripMenuItem.Name = "algoritmo3TabuadaToolStripMenuItem";
            this.algoritmo3TabuadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.algoritmo3TabuadaToolStripMenuItem.Text = "Tabuada";
            this.algoritmo3TabuadaToolStripMenuItem.Click += new System.EventHandler(this.algoritmo3TabuadaToolStripMenuItem_Click);
            // 
            // frm
            // 
            this.frm.Name = "frm";
            this.frm.Size = new System.Drawing.Size(46, 20);
            this.frm.Text = "Sair";
            this.frm.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm;
        private System.Windows.Forms.ToolStripMenuItem algoritmo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmo3TabuadaToolStripMenuItem;
    }
}

