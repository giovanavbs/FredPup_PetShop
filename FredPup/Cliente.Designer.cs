﻿namespace FredPup
{
    partial class Cliente
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
            btnNovo = new Button();
            lblEmail = new Label();
            picImage = new PictureBox();
            dgvCliente = new DataGridView();
            btnSalvar = new Button();
            btnALterar = new Button();
            btnEcluir = new Button();
            brnCarregar = new Button();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            txtCodCli = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(117, 372);
            btnNovo.Margin = new Padding(4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 46);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(123, 106);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "EMAIL:";
            // 
            // picImage
            // 
            picImage.Location = new Point(494, 56);
            picImage.Margin = new Padding(4);
            picImage.Name = "picImage";
            picImage.Size = new Size(116, 124);
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(111, 244);
            dgvCliente.Margin = new Padding(4);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(447, 110);
            dgvCliente.TabIndex = 3;
            dgvCliente.MouseDoubleClick += dgvCliente_MouseDoubleClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(223, 372);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 46);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnALterar
            // 
            btnALterar.Location = new Point(334, 372);
            btnALterar.Margin = new Padding(4);
            btnALterar.Name = "btnALterar";
            btnALterar.Size = new Size(88, 46);
            btnALterar.TabIndex = 5;
            btnALterar.Text = "ALTERAR";
            btnALterar.UseVisualStyleBackColor = true;
            btnALterar.Click += btnALterar_Click;
            // 
            // btnEcluir
            // 
            btnEcluir.Location = new Point(443, 372);
            btnEcluir.Margin = new Padding(4);
            btnEcluir.Name = "btnEcluir";
            btnEcluir.Size = new Size(88, 46);
            btnEcluir.TabIndex = 6;
            btnEcluir.Text = "EXCLUIR";
            btnEcluir.UseVisualStyleBackColor = true;
            btnEcluir.Click += btnEcluir_Click;
            // 
            // brnCarregar
            // 
            brnCarregar.Location = new Point(494, 182);
            brnCarregar.Margin = new Padding(4);
            brnCarregar.Name = "brnCarregar";
            brnCarregar.Size = new Size(116, 26);
            brnCarregar.TabIndex = 7;
            brnCarregar.Text = "carregar...";
            brnCarregar.UseVisualStyleBackColor = true;
            brnCarregar.Click += brnCarregar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 99);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(196, 146);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(197, 23);
            txtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(123, 154);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 15);
            lblTelefone.TabIndex = 10;
            lblTelefone.Text = "TELEFONE";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(196, 59);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(123, 62);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "NOME:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(277, 203);
            txtPesquisar.Margin = new Padding(4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(116, 23);
            txtPesquisar.TabIndex = 16;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(186, 211);
            lblPesquisar.Margin = new Padding(4, 0, 4, 0);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(70, 15);
            lblPesquisar.TabIndex = 17;
            lblPesquisar.Text = "PESQUISAR:";
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(-2, 497);
            txtCodCli.Margin = new Padding(4);
            txtCodCli.Name = "txtCodCli";
            txtCodCli.ReadOnly = true;
            txtCodCli.Size = new Size(10, 23);
            txtCodCli.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(187, 50);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 516);
            Controls.Add(dataGridView1);
            Controls.Add(txtCodCli);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(brnCarregar);
            Controls.Add(btnEcluir);
            Controls.Add(btnALterar);
            Controls.Add(btnSalvar);
            Controls.Add(dgvCliente);
            Controls.Add(picImage);
            Controls.Add(lblEmail);
            Controls.Add(btnNovo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnALterar;
        private System.Windows.Forms.Button btnEcluir;
        private System.Windows.Forms.Button brnCarregar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtCodCli;
        private DataGridView dataGridView1;
    }
}