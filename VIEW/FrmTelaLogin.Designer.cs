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
            this.lblTelaLoginUsuario = new System.Windows.Forms.Label();
            this.pnlLinksUteis = new System.Windows.Forms.Panel();
            this.btnTelaLoginInfoContato = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.mkdTxtBxTelaLoginUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtBxTelaLoginSenha = new System.Windows.Forms.TextBox();
            this.lblTelaLoginSenha = new System.Windows.Forms.Label();
            this.btnTelaLoginEntrar = new System.Windows.Forms.Button();
            this.btnTelaLoginEsqueciSenha = new System.Windows.Forms.Button();
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
            // lblTelaLoginUsuario
            // 
            this.lblTelaLoginUsuario.AutoSize = true;
            this.lblTelaLoginUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaLoginUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTelaLoginUsuario.Location = new System.Drawing.Point(84, 27);
            this.lblTelaLoginUsuario.Name = "lblTelaLoginUsuario";
            this.lblTelaLoginUsuario.Size = new System.Drawing.Size(115, 21);
            this.lblTelaLoginUsuario.TabIndex = 1;
            this.lblTelaLoginUsuario.Text = "USUÁRIO(A):";
            // 
            // pnlLinksUteis
            // 
            this.pnlLinksUteis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLinksUteis.Controls.Add(this.btnTelaLoginInfoContato);
            this.pnlLinksUteis.Controls.Add(this.lblVersao);
            this.pnlLinksUteis.Controls.Add(this.mkdTxtBxTelaLoginUsuario);
            this.pnlLinksUteis.Controls.Add(this.txtBxTelaLoginSenha);
            this.pnlLinksUteis.Controls.Add(this.lblTelaLoginSenha);
            this.pnlLinksUteis.Controls.Add(this.lblTelaLoginUsuario);
            this.pnlLinksUteis.Location = new System.Drawing.Point(12, 114);
            this.pnlLinksUteis.Name = "pnlLinksUteis";
            this.pnlLinksUteis.Size = new System.Drawing.Size(285, 153);
            this.pnlLinksUteis.TabIndex = 2;
            // 
            // btnTelaLoginInfoContato
            // 
            this.btnTelaLoginInfoContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaLoginInfoContato.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaLoginInfoContato.Location = new System.Drawing.Point(252, -2);
            this.btnTelaLoginInfoContato.Name = "btnTelaLoginInfoContato";
            this.btnTelaLoginInfoContato.Size = new System.Drawing.Size(31, 30);
            this.btnTelaLoginInfoContato.TabIndex = 6;
            this.btnTelaLoginInfoContato.Text = "?";
            this.btnTelaLoginInfoContato.UseVisualStyleBackColor = true;
            this.btnTelaLoginInfoContato.Click += new System.EventHandler(this.btnInfoContato_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(0, 135);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(29, 13);
            this.lblVersao.TabIndex = 6;
            this.lblVersao.Text = "v1.0";
            // 
            // mkdTxtBxTelaLoginUsuario
            // 
            this.mkdTxtBxTelaLoginUsuario.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdTxtBxTelaLoginUsuario.Location = new System.Drawing.Point(3, 50);
            this.mkdTxtBxTelaLoginUsuario.Mask = "000.000.000.-00";
            this.mkdTxtBxTelaLoginUsuario.Name = "mkdTxtBxTelaLoginUsuario";
            this.mkdTxtBxTelaLoginUsuario.Size = new System.Drawing.Size(271, 22);
            this.mkdTxtBxTelaLoginUsuario.TabIndex = 27;
            this.mkdTxtBxTelaLoginUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxTelaLoginSenha
            // 
            this.txtBxTelaLoginSenha.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTelaLoginSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBxTelaLoginSenha.Location = new System.Drawing.Point(3, 107);
            this.txtBxTelaLoginSenha.MaxLength = 20;
            this.txtBxTelaLoginSenha.Name = "txtBxTelaLoginSenha";
            this.txtBxTelaLoginSenha.Size = new System.Drawing.Size(271, 22);
            this.txtBxTelaLoginSenha.TabIndex = 4;
            this.txtBxTelaLoginSenha.Text = "DIGITE SUA SENHA...";
            this.txtBxTelaLoginSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxTelaLoginSenha.UseSystemPasswordChar = true;
            // 
            // lblTelaLoginSenha
            // 
            this.lblTelaLoginSenha.AutoSize = true;
            this.lblTelaLoginSenha.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaLoginSenha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTelaLoginSenha.Location = new System.Drawing.Point(101, 84);
            this.lblTelaLoginSenha.Name = "lblTelaLoginSenha";
            this.lblTelaLoginSenha.Size = new System.Drawing.Size(71, 21);
            this.lblTelaLoginSenha.TabIndex = 2;
            this.lblTelaLoginSenha.Text = "SENHA:";
            // 
            // btnTelaLoginEntrar
            // 
            this.btnTelaLoginEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaLoginEntrar.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaLoginEntrar.Location = new System.Drawing.Point(12, 275);
            this.btnTelaLoginEntrar.Name = "btnTelaLoginEntrar";
            this.btnTelaLoginEntrar.Size = new System.Drawing.Size(285, 30);
            this.btnTelaLoginEntrar.TabIndex = 4;
            this.btnTelaLoginEntrar.Text = "ENTRAR";
            this.btnTelaLoginEntrar.UseVisualStyleBackColor = true;
            this.btnTelaLoginEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnTelaLoginEsqueciSenha
            // 
            this.btnTelaLoginEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaLoginEsqueciSenha.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaLoginEsqueciSenha.Location = new System.Drawing.Point(12, 311);
            this.btnTelaLoginEsqueciSenha.Name = "btnTelaLoginEsqueciSenha";
            this.btnTelaLoginEsqueciSenha.Size = new System.Drawing.Size(285, 30);
            this.btnTelaLoginEsqueciSenha.TabIndex = 5;
            this.btnTelaLoginEsqueciSenha.Text = "ESQUECI A SENHA";
            this.btnTelaLoginEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // FrmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 353);
            this.Controls.Add(this.btnTelaLoginEsqueciSenha);
            this.Controls.Add(this.btnTelaLoginEntrar);
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
        private System.Windows.Forms.Label lblTelaLoginUsuario;
        private System.Windows.Forms.Panel pnlLinksUteis;
        private System.Windows.Forms.Button btnTelaLoginEntrar;
        private System.Windows.Forms.Button btnTelaLoginEsqueciSenha;
        private System.Windows.Forms.Label lblTelaLoginSenha;
        private System.Windows.Forms.TextBox txtBxTelaLoginSenha;
        private System.Windows.Forms.MaskedTextBox mkdTxtBxTelaLoginUsuario;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnTelaLoginInfoContato;
    }
}

