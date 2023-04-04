namespace Leonardo___Nickolas
{
    partial class frm4
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
            this.btnw = new System.Windows.Forms.Button();
            this.txtx = new System.Windows.Forms.TextBox();
            this.lblx = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnfor = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnw
            // 
            this.btnw.Location = new System.Drawing.Point(142, 273);
            this.btnw.Name = "btnw";
            this.btnw.Size = new System.Drawing.Size(113, 23);
            this.btnw.TabIndex = 0;
            this.btnw.Text = "Calcular while";
            this.btnw.UseVisualStyleBackColor = true;
            this.btnw.Click += new System.EventHandler(this.btnw_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(340, 98);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 1;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(139, 98);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(175, 13);
            this.lblx.TabIndex = 2;
            this.lblx.Text = "Qual número você quer a tabuada?";
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(139, 138);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(55, 13);
            this.lblr.TabIndex = 3;
            this.lblr.Text = "Resultado";
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(200, 138);
            this.txtr.Multiline = true;
            this.txtr.Name = "txtr";
            this.txtr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtr.Size = new System.Drawing.Size(85, 58);
            this.txtr.TabIndex = 4;
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(308, 273);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(113, 23);
            this.btnfor.TabIndex = 5;
            this.btnfor.Text = "Calcular For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(475, 273);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(113, 23);
            this.btndowhile.TabIndex = 6;
            this.btndowhile.Text = "Calcular Do...While";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(391, 366);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(113, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(215, 366);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(113, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.btnw);
            this.Name = "frm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnw;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}