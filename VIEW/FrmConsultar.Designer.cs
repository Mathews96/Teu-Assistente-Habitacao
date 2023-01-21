namespace Teu_Assistente_HABITACAO
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbLinksUteis = new System.Windows.Forms.Label();
            this.pnlLinksUteis = new System.Windows.Forms.Panel();
            this.btnNissLinkUteis = new System.Windows.Forms.Button();
            this.btnCadmutLinkUteis = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.rdBtmConCadastrado = new System.Windows.Forms.RadioButton();
            this.rdBtmConAgendado = new System.Windows.Forms.RadioButton();
            this.cmbBxConsultarPor = new System.Windows.Forms.ComboBox();
            this.btnConConsultar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtGrdViewConsultas = new System.Windows.Forms.DataGridView();
            this.btnConEditar = new System.Windows.Forms.Button();
            this.btnConExcluir = new System.Windows.Forms.Button();
            this.txtBxConBarraConsulta = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnConVoltarFrm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.pnlLinksUteis.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewConsultas)).BeginInit();
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
            // lbLinksUteis
            // 
            this.lbLinksUteis.AutoSize = true;
            this.lbLinksUteis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinksUteis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLinksUteis.Location = new System.Drawing.Point(111, 133);
            this.lbLinksUteis.Name = "lbLinksUteis";
            this.lbLinksUteis.Size = new System.Drawing.Size(84, 13);
            this.lbLinksUteis.TabIndex = 1;
            this.lbLinksUteis.Text = "LINKS ÚTEIS";
            // 
            // pnlLinksUteis
            // 
            this.pnlLinksUteis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLinksUteis.Controls.Add(this.btnNissLinkUteis);
            this.pnlLinksUteis.Controls.Add(this.btnCadmutLinkUteis);
            this.pnlLinksUteis.Location = new System.Drawing.Point(12, 149);
            this.pnlLinksUteis.Name = "pnlLinksUteis";
            this.pnlLinksUteis.Size = new System.Drawing.Size(285, 53);
            this.pnlLinksUteis.TabIndex = 2;
            // 
            // btnNissLinkUteis
            // 
            this.btnNissLinkUteis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNissLinkUteis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNissLinkUteis.Location = new System.Drawing.Point(185, 8);
            this.btnNissLinkUteis.Name = "btnNissLinkUteis";
            this.btnNissLinkUteis.Size = new System.Drawing.Size(84, 33);
            this.btnNissLinkUteis.TabIndex = 4;
            this.btnNissLinkUteis.Text = "NISS";
            this.btnNissLinkUteis.UseVisualStyleBackColor = true;
            this.btnNissLinkUteis.Click += new System.EventHandler(this.btnNissLinkUteis_Click);
            // 
            // btnCadmutLinkUteis
            // 
            this.btnCadmutLinkUteis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadmutLinkUteis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadmutLinkUteis.Location = new System.Drawing.Point(15, 8);
            this.btnCadmutLinkUteis.Name = "btnCadmutLinkUteis";
            this.btnCadmutLinkUteis.Size = new System.Drawing.Size(84, 33);
            this.btnCadmutLinkUteis.TabIndex = 3;
            this.btnCadmutLinkUteis.Text = "CADMUT";
            this.btnCadmutLinkUteis.UseVisualStyleBackColor = true;
            this.btnCadmutLinkUteis.Click += new System.EventHandler(this.btnCadmutLinkUteis_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendar.Location = new System.Drawing.Point(12, 228);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(285, 62);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "AGENDA";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 296);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(285, 62);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRO";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 364);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(285, 62);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "CONSULTA";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConsultar.Controls.Add(this.rdBtmConCadastrado);
            this.pnlConsultar.Controls.Add(this.rdBtmConAgendado);
            this.pnlConsultar.Controls.Add(this.cmbBxConsultarPor);
            this.pnlConsultar.Controls.Add(this.btnConConsultar);
            this.pnlConsultar.Controls.Add(this.dataGridView2);
            this.pnlConsultar.Controls.Add(this.dtGrdViewConsultas);
            this.pnlConsultar.Controls.Add(this.btnConEditar);
            this.pnlConsultar.Controls.Add(this.btnConExcluir);
            this.pnlConsultar.Controls.Add(this.txtBxConBarraConsulta);
            this.pnlConsultar.Controls.Add(this.lblCadastro);
            this.pnlConsultar.Location = new System.Drawing.Point(303, 12);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(650, 414);
            this.pnlConsultar.TabIndex = 5;
            // 
            // rdBtmConCadastrado
            // 
            this.rdBtmConCadastrado.AutoSize = true;
            this.rdBtmConCadastrado.Checked = true;
            this.rdBtmConCadastrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdBtmConCadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtmConCadastrado.Location = new System.Drawing.Point(520, 35);
            this.rdBtmConCadastrado.Name = "rdBtmConCadastrado";
            this.rdBtmConCadastrado.Size = new System.Drawing.Size(109, 17);
            this.rdBtmConCadastrado.TabIndex = 24;
            this.rdBtmConCadastrado.TabStop = true;
            this.rdBtmConCadastrado.Text = "CADASTRADO";
            this.rdBtmConCadastrado.UseVisualStyleBackColor = false;
            this.rdBtmConCadastrado.CheckedChanged += new System.EventHandler(this.rdBtmConCadastrado_CheckedChanged);
            // 
            // rdBtmConAgendado
            // 
            this.rdBtmConAgendado.AutoSize = true;
            this.rdBtmConAgendado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdBtmConAgendado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtmConAgendado.Location = new System.Drawing.Point(520, 11);
            this.rdBtmConAgendado.Name = "rdBtmConAgendado";
            this.rdBtmConAgendado.Size = new System.Drawing.Size(94, 17);
            this.rdBtmConAgendado.TabIndex = 23;
            this.rdBtmConAgendado.Text = "AGENDADO";
            this.rdBtmConAgendado.UseVisualStyleBackColor = true;
            this.rdBtmConAgendado.CheckedChanged += new System.EventHandler(this.rdBtmConAgendado_CheckedChanged);
            // 
            // cmbBxConsultarPor
            // 
            this.cmbBxConsultarPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBxConsultarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxConsultarPor.FormattingEnabled = true;
            this.cmbBxConsultarPor.Items.AddRange(new object[] {
            "",
            "CPF",
            "NIS",
            "NOME_COMPLETO",
            "DATA_DE_NASCIMENTO",
            "ESTADO_CIVIL",
            "EMAIL",
            "TELEFONE",
            "WHATSAPP",
            "NOME_DA_MAE",
            "DATA_CADASTRO"});
            this.cmbBxConsultarPor.Location = new System.Drawing.Point(497, 61);
            this.cmbBxConsultarPor.Name = "cmbBxConsultarPor";
            this.cmbBxConsultarPor.Size = new System.Drawing.Size(142, 21);
            this.cmbBxConsultarPor.TabIndex = 22;
            // 
            // btnConConsultar
            // 
            this.btnConConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConConsultar.Location = new System.Drawing.Point(368, 61);
            this.btnConConsultar.Name = "btnConConsultar";
            this.btnConConsultar.Size = new System.Drawing.Size(123, 21);
            this.btnConConsultar.TabIndex = 21;
            this.btnConConsultar.Text = "CONSULTAR";
            this.btnConConsultar.UseVisualStyleBackColor = true;
            this.btnConConsultar.Click += new System.EventHandler(this.btnConConsultar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(645, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 20;
            // 
            // dtGrdViewConsultas
            // 
            this.dtGrdViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGrdViewConsultas.Location = new System.Drawing.Point(-2, 88);
            this.dtGrdViewConsultas.Name = "dtGrdViewConsultas";
            this.dtGrdViewConsultas.Size = new System.Drawing.Size(650, 270);
            this.dtGrdViewConsultas.TabIndex = 19;
            this.dtGrdViewConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdViewConsultas_CellClick);
            // 
            // btnConEditar
            // 
            this.btnConEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConEditar.Location = new System.Drawing.Point(471, 364);
            this.btnConEditar.Name = "btnConEditar";
            this.btnConEditar.Size = new System.Drawing.Size(168, 43);
            this.btnConEditar.TabIndex = 8;
            this.btnConEditar.Text = "EDITAR";
            this.btnConEditar.UseVisualStyleBackColor = true;
            this.btnConEditar.Click += new System.EventHandler(this.btnConEditar_Click);
            // 
            // btnConExcluir
            // 
            this.btnConExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConExcluir.Location = new System.Drawing.Point(8, 364);
            this.btnConExcluir.Name = "btnConExcluir";
            this.btnConExcluir.Size = new System.Drawing.Size(168, 43);
            this.btnConExcluir.TabIndex = 8;
            this.btnConExcluir.Text = "EXCLUIR";
            this.btnConExcluir.UseVisualStyleBackColor = true;
            this.btnConExcluir.Click += new System.EventHandler(this.btnConExcluir_Click);
            // 
            // txtBxConBarraConsulta
            // 
            this.txtBxConBarraConsulta.Location = new System.Drawing.Point(3, 62);
            this.txtBxConBarraConsulta.MaxLength = 100;
            this.txtBxConBarraConsulta.Name = "txtBxConBarraConsulta";
            this.txtBxConBarraConsulta.Size = new System.Drawing.Size(359, 20);
            this.txtBxConBarraConsulta.TabIndex = 18;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCadastro.Location = new System.Drawing.Point(3, 18);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(145, 25);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "CONSULTAR";
            // 
            // btnConVoltarFrm
            // 
            this.btnConVoltarFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConVoltarFrm.Location = new System.Drawing.Point(952, 198);
            this.btnConVoltarFrm.Name = "btnConVoltarFrm";
            this.btnConVoltarFrm.Size = new System.Drawing.Size(12, 32);
            this.btnConVoltarFrm.TabIndex = 25;
            this.btnConVoltarFrm.Text = "<";
            this.btnConVoltarFrm.UseVisualStyleBackColor = true;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnConVoltarFrm);
            this.Controls.Add(this.pnlConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.pnlLinksUteis);
            this.Controls.Add(this.lbLinksUteis);
            this.Controls.Add(this.pctBoxLogo);
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.pnlLinksUteis.ResumeLayout(false);
            this.pnlConsultar.ResumeLayout(false);
            this.pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lbLinksUteis;
        private System.Windows.Forms.Panel pnlLinksUteis;
        private System.Windows.Forms.Button btnNissLinkUteis;
        private System.Windows.Forms.Button btnCadmutLinkUteis;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlConsultar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnConEditar;
        private System.Windows.Forms.Button btnConExcluir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dtGrdViewConsultas;
        private System.Windows.Forms.TextBox txtBxConBarraConsulta;
        private System.Windows.Forms.Button btnConConsultar;
        private System.Windows.Forms.RadioButton rdBtmConAgendado;
        private System.Windows.Forms.ComboBox cmbBxConsultarPor;
        private System.Windows.Forms.RadioButton rdBtmConCadastrado;
        private System.Windows.Forms.Button btnConVoltarFrm;
    }
}

