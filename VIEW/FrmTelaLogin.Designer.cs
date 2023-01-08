namespace Teu_Assistente_HABITACAO
{
    partial class FrmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaLogin));
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlLinksUteis = new System.Windows.Forms.Panel();
            this.lkLblLogLinkedinDevMathews = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEsqueciSenha = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.pnlLinksUteis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.BackColor = System.Drawing.SystemColors.MenuText;
            this.pctBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxLogo.Image")));
            this.pctBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(285, 96);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 0;
            this.pctBoxLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUsuario.Location = new System.Drawing.Point(84, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(115, 21);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUÁRIO(A):";
            // 
            // pnlLinksUteis
            // 
            this.pnlLinksUteis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLinksUteis.Controls.Add(this.maskedTextBox1);
            this.pnlLinksUteis.Controls.Add(this.lkLblLogLinkedinDevMathews);
            this.pnlLinksUteis.Controls.Add(this.textBox2);
            this.pnlLinksUteis.Controls.Add(this.lblSenha);
            this.pnlLinksUteis.Controls.Add(this.lblUsuario);
            this.pnlLinksUteis.Location = new System.Drawing.Point(12, 114);
            this.pnlLinksUteis.Name = "pnlLinksUteis";
            this.pnlLinksUteis.Size = new System.Drawing.Size(285, 153);
            this.pnlLinksUteis.TabIndex = 2;
            // 
            // lkLblLogLinkedinDevMathews
            // 
            this.lkLblLogLinkedinDevMathews.AutoSize = true;
            this.lkLblLogLinkedinDevMathews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLblLogLinkedinDevMathews.LinkColor = System.Drawing.Color.White;
            this.lkLblLogLinkedinDevMathews.Location = new System.Drawing.Point(113, -1);
            this.lkLblLogLinkedinDevMathews.Name = "lkLblLogLinkedinDevMathews";
            this.lkLblLogLinkedinDevMathews.Size = new System.Drawing.Size(170, 13);
            this.lkLblLogLinkedinDevMathews.TabIndex = 26;
            this.lkLblLogLinkedinDevMathews.TabStop = true;
            this.lkLblLogLinkedinDevMathews.Text = "(82)9 9990-1016 - Freire M.B";
            this.lkLblLogLinkedinDevMathews.VisitedLinkColor = System.Drawing.Color.White;
            this.lkLblLogLinkedinDevMathews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLblLogLinkedinDevMathews_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(3, 107);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "DIGITE SUA SENHA...";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSenha.Location = new System.Drawing.Point(101, 84);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 21);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "SENHA:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(12, 275);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(285, 30);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueciSenha.Location = new System.Drawing.Point(12, 311);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(285, 30);
            this.btnEsqueciSenha.TabIndex = 5;
            this.btnEsqueciSenha.Text = "ESQUECI A SENHA";
            this.btnEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 50);
            this.maskedTextBox1.Mask = "000.000.000.-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(271, 20);
            this.maskedTextBox1.TabIndex = 27;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 353);
            this.Controls.Add(this.btnEsqueciSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pnlLinksUteis);
            this.Controls.Add(this.pctBoxLogo);
            this.Name = "FrmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelaLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.pnlLinksUteis.ResumeLayout(false);
            this.pnlLinksUteis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlLinksUteis;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEsqueciSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel lkLblLogLinkedinDevMathews;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

