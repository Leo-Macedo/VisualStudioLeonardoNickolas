namespace Leonardo___Nickolas
{
    partial class frm3
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
            this.txtv = new System.Windows.Forms.TextBox();
            this.btnvotar = new System.Windows.Forms.Button();
            this.lblv = new System.Windows.Forms.Label();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnr = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(452, 74);
            this.txtv.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(139, 20);
            this.txtv.TabIndex = 4;
            this.txtv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnvotar
            // 
            this.btnvotar.Location = new System.Drawing.Point(323, 106);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(75, 23);
            this.btnvotar.TabIndex = 5;
            this.btnvotar.Text = "Vote";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Location = new System.Drawing.Point(82, 77);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(316, 13);
            this.lblv.TabIndex = 6;
            this.lblv.Text = "Votar.1 = José da Silva, 2 = Maria Juruma e 3 = João da Tapioca.";
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(323, 154);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(75, 23);
            this.btnencerrar.TabIndex = 7;
            this.btnencerrar.Text = "Encerrar";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(85, 202);
            this.txtr.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(506, 20);
            this.txtr.TabIndex = 8;
            this.txtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(323, 246);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 23);
            this.btnr.TabIndex = 9;
            this.btnr.Text = "Reiniciar";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(516, 246);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.btnvotar);
            this.Controls.Add(this.txtv);
            this.Name = "frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.Load += new System.EventHandler(this.frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.Button btnvotar;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnvoltar;
    }
}