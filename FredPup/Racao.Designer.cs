namespace FredPup
{
    partial class Racao
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
            cmbTamanho = new ComboBox();
            grpSabores = new GroupBox();
            chkVegetais = new CheckBox();
            chkAmbos = new CheckBox();
            chkCarne = new CheckBox();
            chkFrango = new CheckBox();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            dgv_Racao = new DataGridView();
            cmbMarca = new ComboBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnNovo = new Button();
            btnCalcular = new Button();
            btnSalvar = new Button();
            btnSair = new Button();
            txtSabor = new TextBox();
            lblSabor = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtTamanho = new TextBox();
            label1 = new Label();
            grpAnimal = new GroupBox();
            chkPassaro = new CheckBox();
            chkCoelho = new CheckBox();
            chkGato = new CheckBox();
            chkCachorro = new CheckBox();
            txtAnimal = new TextBox();
            lblAnimal = new Label();
            CodRacao = new TextBox();
            grpSabores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Racao).BeginInit();
            grpAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTamanho
            // 
            cmbTamanho.FormattingEnabled = true;
            cmbTamanho.Location = new Point(27, 61);
            cmbTamanho.Margin = new Padding(3, 2, 3, 2);
            cmbTamanho.Name = "cmbTamanho";
            cmbTamanho.Size = new Size(148, 23);
            cmbTamanho.TabIndex = 0;
            cmbTamanho.Text = "TAMANHO DA RAÇÃO";
            // 
            // grpSabores
            // 
            grpSabores.BackColor = Color.Transparent;
            grpSabores.Controls.Add(chkVegetais);
            grpSabores.Controls.Add(chkAmbos);
            grpSabores.Controls.Add(chkCarne);
            grpSabores.Controls.Add(chkFrango);
            grpSabores.Location = new Point(13, 96);
            grpSabores.Margin = new Padding(3, 2, 3, 2);
            grpSabores.Name = "grpSabores";
            grpSabores.Padding = new Padding(3, 2, 3, 2);
            grpSabores.Size = new Size(199, 114);
            grpSabores.TabIndex = 1;
            grpSabores.TabStop = false;
            grpSabores.Text = "Escolha o sabor:";
            grpSabores.Enter += grpSabores_Enter;
            // 
            // chkVegetais
            // 
            chkVegetais.AutoSize = true;
            chkVegetais.Location = new Point(11, 87);
            chkVegetais.Margin = new Padding(3, 2, 3, 2);
            chkVegetais.Name = "chkVegetais";
            chkVegetais.Size = new Size(69, 19);
            chkVegetais.TabIndex = 3;
            chkVegetais.Text = "Vegetais";
            chkVegetais.UseVisualStyleBackColor = true;
            // 
            // chkAmbos
            // 
            chkAmbos.AutoSize = true;
            chkAmbos.Location = new Point(11, 64);
            chkAmbos.Margin = new Padding(3, 2, 3, 2);
            chkAmbos.Name = "chkAmbos";
            chkAmbos.Size = new Size(106, 19);
            chkAmbos.TabIndex = 2;
            chkAmbos.Text = "Carne e Frango";
            chkAmbos.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            chkCarne.AutoSize = true;
            chkCarne.Location = new Point(11, 43);
            chkCarne.Margin = new Padding(3, 2, 3, 2);
            chkCarne.Name = "chkCarne";
            chkCarne.Size = new Size(97, 19);
            chkCarne.TabIndex = 1;
            chkCarne.Text = "Carne e Arroz";
            chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkFrango
            // 
            chkFrango.AutoSize = true;
            chkFrango.Location = new Point(14, 20);
            chkFrango.Margin = new Padding(3, 2, 3, 2);
            chkFrango.Name = "chkFrango";
            chkFrango.Size = new Size(103, 19);
            chkFrango.TabIndex = 0;
            chkFrango.Text = "Frango e Arroz";
            chkFrango.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Location = new Point(485, 413);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(551, 410);
            txtPesquisar.Margin = new Padding(3, 2, 3, 2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(110, 23);
            txtPesquisar.TabIndex = 3;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgv_Racao
            // 
            dgv_Racao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Racao.Location = new Point(13, 230);
            dgv_Racao.Margin = new Padding(3, 2, 3, 2);
            dgv_Racao.Name = "dgv_Racao";
            dgv_Racao.RowHeadersWidth = 51;
            dgv_Racao.Size = new Size(654, 139);
            dgv_Racao.TabIndex = 4;
            dgv_Racao.CellContentClick += dgv_Racao_CellContentClick;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(196, 61);
            cmbMarca.Margin = new Padding(3, 2, 3, 2);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(133, 23);
            cmbMarca.TabIndex = 7;
            cmbMarca.Text = "MARCA DA RAÇÃO";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(487, 182);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Location = new Point(487, 164);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "TOTAL A PAGAR:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(23, 397);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(83, 36);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 397);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 36);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(242, 397);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 36);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(360, 397);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(80, 36);
            btnSair.TabIndex = 13;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtSabor
            // 
            txtSabor.Location = new Point(411, 78);
            txtSabor.Margin = new Padding(3, 2, 3, 2);
            txtSabor.Name = "txtSabor";
            txtSabor.Size = new Size(110, 23);
            txtSabor.TabIndex = 15;
            // 
            // lblSabor
            // 
            lblSabor.AutoSize = true;
            lblSabor.BackColor = Color.Transparent;
            lblSabor.Location = new Point(403, 61);
            lblSabor.Name = "lblSabor";
            lblSabor.Size = new Size(106, 15);
            lblSabor.TabIndex = 14;
            lblSabor.Text = "VALOR DO SABOR:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(411, 128);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 19;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.Location = new Point(403, 111);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(110, 15);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "VALOR DA MARCA:";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(559, 78);
            txtTamanho.Margin = new Padding(3, 2, 3, 2);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(110, 23);
            txtTamanho.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(551, 61);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 20;
            label1.Text = "VALOR DO TAMANHO:\r\n";
            // 
            // grpAnimal
            // 
            grpAnimal.BackColor = Color.Transparent;
            grpAnimal.Controls.Add(chkPassaro);
            grpAnimal.Controls.Add(chkCoelho);
            grpAnimal.Controls.Add(chkGato);
            grpAnimal.Controls.Add(chkCachorro);
            grpAnimal.Location = new Point(217, 96);
            grpAnimal.Margin = new Padding(3, 2, 3, 2);
            grpAnimal.Name = "grpAnimal";
            grpAnimal.Padding = new Padding(3, 2, 3, 2);
            grpAnimal.Size = new Size(158, 114);
            grpAnimal.TabIndex = 4;
            grpAnimal.TabStop = false;
            grpAnimal.Text = "Escolha o tipo:";
            // 
            // chkPassaro
            // 
            chkPassaro.AutoSize = true;
            chkPassaro.Location = new Point(11, 87);
            chkPassaro.Margin = new Padding(3, 2, 3, 2);
            chkPassaro.Name = "chkPassaro";
            chkPassaro.Size = new Size(66, 19);
            chkPassaro.TabIndex = 3;
            chkPassaro.Text = "Passaro";
            chkPassaro.UseVisualStyleBackColor = true;
            // 
            // chkCoelho
            // 
            chkCoelho.AutoSize = true;
            chkCoelho.Location = new Point(11, 64);
            chkCoelho.Margin = new Padding(3, 2, 3, 2);
            chkCoelho.Name = "chkCoelho";
            chkCoelho.Size = new Size(64, 19);
            chkCoelho.TabIndex = 2;
            chkCoelho.Text = "Coelho";
            chkCoelho.UseVisualStyleBackColor = true;
            // 
            // chkGato
            // 
            chkGato.AutoSize = true;
            chkGato.Location = new Point(11, 43);
            chkGato.Margin = new Padding(3, 2, 3, 2);
            chkGato.Name = "chkGato";
            chkGato.Size = new Size(51, 19);
            chkGato.TabIndex = 1;
            chkGato.Text = "Gato";
            chkGato.UseVisualStyleBackColor = true;
            // 
            // chkCachorro
            // 
            chkCachorro.AutoSize = true;
            chkCachorro.Location = new Point(14, 20);
            chkCachorro.Margin = new Padding(3, 2, 3, 2);
            chkCachorro.Name = "chkCachorro";
            chkCachorro.Size = new Size(75, 19);
            chkCachorro.TabIndex = 0;
            chkCachorro.Text = "Cachorro";
            chkCachorro.UseVisualStyleBackColor = true;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(559, 128);
            txtAnimal.Margin = new Padding(3, 2, 3, 2);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(110, 23);
            txtAnimal.TabIndex = 23;
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.BackColor = Color.Transparent;
            lblAnimal.Location = new Point(551, 111);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(94, 15);
            lblAnimal.TabIndex = 22;
            lblAnimal.Text = "VALOR DO TIPO:";
            // 
            // CodRacao
            // 
            CodRacao.Location = new Point(-3, 325);
            CodRacao.Margin = new Padding(3, 2, 3, 2);
            CodRacao.Name = "CodRacao";
            CodRacao.ReadOnly = true;
            CodRacao.Size = new Size(10, 23);
            CodRacao.TabIndex = 45;
            // 
            // Racao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(684, 461);
            Controls.Add(CodRacao);
            Controls.Add(txtAnimal);
            Controls.Add(lblAnimal);
            Controls.Add(grpAnimal);
            Controls.Add(txtTamanho);
            Controls.Add(label1);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(txtSabor);
            Controls.Add(lblSabor);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNovo);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(cmbMarca);
            Controls.Add(dgv_Racao);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(grpSabores);
            Controls.Add(cmbTamanho);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Racao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Racao";
            Load += Racao_Load;
            grpSabores.ResumeLayout(false);
            grpSabores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Racao).EndInit();
            grpAnimal.ResumeLayout(false);
            grpAnimal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTamanho;
        private GroupBox grpSabores;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private DataGridView dgv_Racao;
        private ComboBox cmbMarca;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnNovo;
        private Button btnCalcular;
        private Button btnSalvar;
        private Button btnSair;
        private CheckBox chkVegetais;
        private CheckBox chkAmbos;
        private CheckBox chkCarne;
        private CheckBox chkFrango;
        private TextBox txtSabor;
        private Label lblSabor;
        private TextBox txtMarca;
        private Label lblMarca;
        private TextBox txtTamanho;
        private Label label1;
        private GroupBox grpAnimal;
        private CheckBox chkPassaro;
        private CheckBox chkCoelho;
        private CheckBox chkGato;
        private CheckBox chkCachorro;
        private TextBox txtAnimal;
        private Label lblAnimal;
        private TextBox CodRacao;
    }
}