namespace FredPup
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
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(134, 496);
            btnNovo.Margin = new Padding(4, 5, 4, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(100, 61);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(141, 142);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "EMAIL:";
            // 
            // picImage
            // 
            picImage.Location = new Point(564, 75);
            picImage.Margin = new Padding(4, 5, 4, 5);
            picImage.Name = "picImage";
            picImage.Size = new Size(133, 165);
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(127, 325);
            dgvCliente.Margin = new Padding(4, 5, 4, 5);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(511, 146);
            dgvCliente.TabIndex = 3;
            dgvCliente.MouseDoubleClick += dgvCliente_MouseDoubleClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(255, 496);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 61);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnALterar
            // 
            btnALterar.Location = new Point(382, 496);
            btnALterar.Margin = new Padding(4, 5, 4, 5);
            btnALterar.Name = "btnALterar";
            btnALterar.Size = new Size(100, 61);
            btnALterar.TabIndex = 5;
            btnALterar.Text = "ALTERAR";
            btnALterar.UseVisualStyleBackColor = true;
            btnALterar.Click += btnALterar_Click;
            // 
            // btnEcluir
            // 
            btnEcluir.Location = new Point(506, 496);
            btnEcluir.Margin = new Padding(4, 5, 4, 5);
            btnEcluir.Name = "btnEcluir";
            btnEcluir.Size = new Size(100, 61);
            btnEcluir.TabIndex = 6;
            btnEcluir.Text = "EXCLUIR";
            btnEcluir.UseVisualStyleBackColor = true;
            btnEcluir.Click += btnEcluir_Click;
            // 
            // brnCarregar
            // 
            brnCarregar.Location = new Point(564, 242);
            brnCarregar.Margin = new Padding(4, 5, 4, 5);
            brnCarregar.Name = "brnCarregar";
            brnCarregar.Size = new Size(133, 35);
            brnCarregar.TabIndex = 7;
            brnCarregar.Text = "carregar...";
            brnCarregar.UseVisualStyleBackColor = true;
            brnCarregar.Click += brnCarregar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(224, 132);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(224, 195);
            txtTelefone.Margin = new Padding(4, 5, 4, 5);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(225, 27);
            txtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(141, 206);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 20);
            lblTelefone.TabIndex = 10;
            lblTelefone.Text = "TELEFONE";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(224, 79);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 27);
            txtNome.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(141, 82);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 20);
            lblNome.TabIndex = 14;
            lblNome.Text = "NOME:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(317, 271);
            txtPesquisar.Margin = new Padding(4, 5, 4, 5);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(132, 27);
            txtPesquisar.TabIndex = 16;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(213, 281);
            lblPesquisar.Margin = new Padding(4, 0, 4, 0);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(88, 20);
            lblPesquisar.TabIndex = 17;
            lblPesquisar.Text = "PESQUISAR:";
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(224, 19);
            txtCodCli.Margin = new Padding(4, 5, 4, 5);
            txtCodCli.Name = "txtCodCli";
            txtCodCli.ReadOnly = true;
            txtCodCli.Size = new Size(84, 27);
            txtCodCli.TabIndex = 18;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 688);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
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
    }
}