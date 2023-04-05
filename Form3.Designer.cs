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
            this.txtv.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.txtv.Location = new System.Drawing.Point(534, 101);
            this.txtv.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(184, 22);
            this.txtv.TabIndex = 4;
            this.txtv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnvotar
            // 
            this.btnvotar.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.btnvotar.Location = new System.Drawing.Point(212, 167);
            this.btnvotar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(100, 28);
            this.btnvotar.TabIndex = 5;
            this.btnvotar.Text = "Vote";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.lblv.Location = new System.Drawing.Point(86, 101);
            this.lblv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(409, 14);
            this.lblv.TabIndex = 6;
            this.lblv.Text = "Votar.1 = José da Silva, 2 = Maria Juruma e 3 = João da Tapioca.";
            this.lblv.Click += new System.EventHandler(this.lblv_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.btnencerrar.Location = new System.Drawing.Point(442, 167);
            this.btnencerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(100, 28);
            this.btnencerrar.TabIndex = 7;
            this.btnencerrar.Text = "Encerrar";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // txtr
            // 
            this.txtr.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.txtr.Location = new System.Drawing.Point(89, 262);
            this.txtr.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(629, 22);
            this.txtr.TabIndex = 8;
            this.txtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnr
            // 
            this.btnr.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.btnr.Location = new System.Drawing.Point(212, 337);
            this.btnr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(100, 28);
            this.btnr.TabIndex = 9;
            this.btnr.Text = "Reiniciar";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Verdana", 8.75F);
            this.btnvoltar.Location = new System.Drawing.Point(442, 337);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 28);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.btnvotar);
            this.Controls.Add(this.txtv);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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