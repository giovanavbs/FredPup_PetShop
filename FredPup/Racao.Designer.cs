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
            cmbTamanho.Location = new Point(48, 25);
            cmbTamanho.Name = "cmbTamanho";
            cmbTamanho.Size = new Size(151, 28);
            cmbTamanho.TabIndex = 0;
            cmbTamanho.Text = "TAMANHO DA RAÇÃO";
            // 
            // grpSabores
            // 
            grpSabores.Controls.Add(chkVegetais);
            grpSabores.Controls.Add(chkAmbos);
            grpSabores.Controls.Add(chkCarne);
            grpSabores.Controls.Add(chkFrango);
            grpSabores.Location = new Point(12, 72);
            grpSabores.Name = "grpSabores";
            grpSabores.Size = new Size(227, 152);
            grpSabores.TabIndex = 1;
            grpSabores.TabStop = false;
            grpSabores.Text = "Escolha o sabor:";
            grpSabores.Enter += grpSabores_Enter;
            // 
            // chkVegetais
            // 
            chkVegetais.AutoSize = true;
            chkVegetais.Location = new Point(13, 116);
            chkVegetais.Name = "chkVegetais";
            chkVegetais.Size = new Size(87, 24);
            chkVegetais.TabIndex = 3;
            chkVegetais.Text = "Vegetais";
            chkVegetais.UseVisualStyleBackColor = true;
            // 
            // chkAmbos
            // 
            chkAmbos.AutoSize = true;
            chkAmbos.Location = new Point(13, 86);
            chkAmbos.Name = "chkAmbos";
            chkAmbos.Size = new Size(131, 24);
            chkAmbos.TabIndex = 2;
            chkAmbos.Text = "Carne e Frango";
            chkAmbos.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            chkCarne.AutoSize = true;
            chkCarne.Location = new Point(13, 57);
            chkCarne.Name = "chkCarne";
            chkCarne.Size = new Size(121, 24);
            chkCarne.TabIndex = 1;
            chkCarne.Text = "Carne e Arroz";
            chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkFrango
            // 
            chkFrango.AutoSize = true;
            chkFrango.Location = new Point(16, 27);
            chkFrango.Name = "chkFrango";
            chkFrango.Size = new Size(129, 24);
            chkFrango.TabIndex = 0;
            chkFrango.Text = "Frango e Arroz";
            chkFrango.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(536, 402);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(73, 20);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(626, 399);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 3;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgv_Racao
            // 
            dgv_Racao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Racao.Location = new Point(12, 234);
            dgv_Racao.Name = "dgv_Racao";
            dgv_Racao.RowHeadersWidth = 51;
            dgv_Racao.Size = new Size(748, 147);
            dgv_Racao.TabIndex = 4;
            dgv_Racao.CellContentClick += dgv_Racao_CellContentClick;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(221, 25);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(151, 28);
            cmbMarca.TabIndex = 7;
            cmbMarca.Text = "MARCA DA RAÇÃO";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(553, 186);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(553, 163);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "TOTAL A PAGAR:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(16, 399);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(136, 399);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(266, 399);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(401, 399);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 13;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtSabor
            // 
            txtSabor.Location = new Point(466, 48);
            txtSabor.Name = "txtSabor";
            txtSabor.Size = new Size(125, 27);
            txtSabor.TabIndex = 15;
            // 
            // lblSabor
            // 
            lblSabor.AutoSize = true;
            lblSabor.Location = new Point(457, 25);
            lblSabor.Name = "lblSabor";
            lblSabor.Size = new Size(133, 20);
            lblSabor.TabIndex = 14;
            lblSabor.Text = "VALOR DO SABOR:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(466, 115);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 19;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(457, 92);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(136, 20);
            lblMarca.TabIndex = 18;
            lblMarca.Text = "VALOR DA MARCA:";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(635, 48);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(125, 27);
            txtTamanho.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 25);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 20;
            label1.Text = "VALOR DO TAMANHO:\r\n";
            // 
            // grpAnimal
            // 
            grpAnimal.Controls.Add(chkPassaro);
            grpAnimal.Controls.Add(chkCoelho);
            grpAnimal.Controls.Add(chkGato);
            grpAnimal.Controls.Add(chkCachorro);
            grpAnimal.Location = new Point(245, 72);
            grpAnimal.Name = "grpAnimal";
            grpAnimal.Size = new Size(180, 152);
            grpAnimal.TabIndex = 4;
            grpAnimal.TabStop = false;
            grpAnimal.Text = "Escolha o tipo:";
            // 
            // chkPassaro
            // 
            chkPassaro.AutoSize = true;
            chkPassaro.Location = new Point(13, 116);
            chkPassaro.Name = "chkPassaro";
            chkPassaro.Size = new Size(80, 24);
            chkPassaro.TabIndex = 3;
            chkPassaro.Text = "Passaro";
            chkPassaro.UseVisualStyleBackColor = true;
            // 
            // chkCoelho
            // 
            chkCoelho.AutoSize = true;
            chkCoelho.Location = new Point(13, 86);
            chkCoelho.Name = "chkCoelho";
            chkCoelho.Size = new Size(78, 24);
            chkCoelho.TabIndex = 2;
            chkCoelho.Text = "Coelho";
            chkCoelho.UseVisualStyleBackColor = true;
            // 
            // chkGato
            // 
            chkGato.AutoSize = true;
            chkGato.Location = new Point(13, 57);
            chkGato.Name = "chkGato";
            chkGato.Size = new Size(63, 24);
            chkGato.TabIndex = 1;
            chkGato.Text = "Gato";
            chkGato.UseVisualStyleBackColor = true;
            // 
            // chkCachorro
            // 
            chkCachorro.AutoSize = true;
            chkCachorro.Location = new Point(16, 27);
            chkCachorro.Name = "chkCachorro";
            chkCachorro.Size = new Size(91, 24);
            chkCachorro.TabIndex = 0;
            chkCachorro.Text = "Cachorro";
            chkCachorro.UseVisualStyleBackColor = true;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(635, 115);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(125, 27);
            txtAnimal.TabIndex = 23;
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Location = new Point(626, 92);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(117, 20);
            lblAnimal.TabIndex = 22;
            lblAnimal.Text = "VALOR DO TIPO:";
            // 
            // CodRacao
            // 
            CodRacao.Location = new Point(12, 18);
            CodRacao.Name = "CodRacao";
            CodRacao.ReadOnly = true;
            CodRacao.Size = new Size(24, 27);
            CodRacao.TabIndex = 45;
            // 
            // Racao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Racao";
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