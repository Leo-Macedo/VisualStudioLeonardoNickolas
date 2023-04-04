namespace Leonardo___Nickolas
{
    partial class frm2
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
            this.lblc = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lbll = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(294, 88);
            this.lblc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(352, 17);
            this.lblc.TabIndex = 0;
            this.lblc.Text = "Qual o tipo de combustível? g para gasolina, a para álcool";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(294, 197);
            this.lblt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(36, 17);
            this.lblt.TabIndex = 1;
            this.lblt.Text = "Total";
            // 
            // lbll
            // 
            this.lbll.AutoSize = true;
            this.lbll.Location = new System.Drawing.Point(294, 139);
            this.lbll.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(177, 17);
            this.lbll.TabIndex = 2;
            this.lbll.Text = "Quantos litros você colocou?";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(730, 83);
            this.txtc.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(139, 25);
            this.txtc.TabIndex = 3;
            this.txtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(730, 193);
            this.txtt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(139, 25);
            this.txtt.TabIndex = 4;
            this.txtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(730, 134);
            this.txtl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(139, 25);
            this.txtl.TabIndex = 5;
            this.txtl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(298, 265);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(105, 27);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(765, 265);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(105, 27);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(513, 265);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(105, 27);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 589);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lbll);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lblc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lbll;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}