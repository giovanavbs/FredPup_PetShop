﻿namespace FredPup
{
    partial class Pote
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
            chkRed = new CheckBox();
            chkBlue = new CheckBox();
            chkGreen = new CheckBox();
            chkBlack = new CheckBox();
            grpCores = new GroupBox();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            dgv_Racao = new DataGridView();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnNovo = new Button();
            btnCalcular = new Button();
            btnSalvar = new Button();
            btnSair = new Button();
            lblSabor = new Label();
            txtCor = new TextBox();
            lblMarca = new Label();
            txtTipo = new TextBox();
            label1 = new Label();
            txtTamanho = new TextBox();
            cmbTipo = new ComboBox();
            CodPote = new TextBox();
            grpCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Racao).BeginInit();
            SuspendLayout();
            // 
            // cmbTamanho
            // 
            cmbTamanho.FormattingEnabled = true;
            cmbTamanho.Location = new Point(75, 22);
            cmbTamanho.Name = "cmbTamanho";
            cmbTamanho.Size = new Size(151, 28);
            cmbTamanho.TabIndex = 24;
            cmbTamanho.Text = "TAMANHO DO POTE";
            // 
            // chkRed
            // 
            chkRed.AutoSize = true;
            chkRed.Location = new Point(16, 27);
            chkRed.Name = "chkRed";
            chkRed.Size = new Size(94, 24);
            chkRed.TabIndex = 0;
            chkRed.Text = "Vermelho";
            chkRed.UseVisualStyleBackColor = true;
            // 
            // chkBlue
            // 
            chkBlue.AutoSize = true;
            chkBlue.Location = new Point(13, 57);
            chkBlue.Name = "chkBlue";
            chkBlue.Size = new Size(60, 24);
            chkBlue.TabIndex = 1;
            chkBlue.Text = "Azul";
            chkBlue.UseVisualStyleBackColor = true;
            // 
            // chkGreen
            // 
            chkGreen.AutoSize = true;
            chkGreen.Location = new Point(13, 86);
            chkGreen.Name = "chkGreen";
            chkGreen.Size = new Size(69, 24);
            chkGreen.TabIndex = 2;
            chkGreen.Text = "Verde";
            chkGreen.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            chkBlack.AutoSize = true;
            chkBlack.Location = new Point(13, 116);
            chkBlack.Name = "chkBlack";
            chkBlack.Size = new Size(66, 24);
            chkBlack.TabIndex = 3;
            chkBlack.Text = "Preto";
            chkBlack.UseVisualStyleBackColor = true;
            // 
            // grpCores
            // 
            grpCores.Controls.Add(chkBlack);
            grpCores.Controls.Add(chkGreen);
            grpCores.Controls.Add(chkBlue);
            grpCores.Controls.Add(chkRed);
            grpCores.Location = new Point(14, 71);
            grpCores.Name = "grpCores";
            grpCores.Size = new Size(227, 152);
            grpCores.TabIndex = 25;
            grpCores.TabStop = false;
            grpCores.Text = "Escolha a cor:";
            grpCores.Enter += grpCores_Enter;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(538, 401);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(73, 20);
            lblPesquisar.TabIndex = 26;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(628, 398);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 27;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgv_Racao
            // 
            dgv_Racao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Racao.Location = new Point(14, 233);
            dgv_Racao.Name = "dgv_Racao";
            dgv_Racao.RowHeadersWidth = 51;
            dgv_Racao.Size = new Size(748, 147);
            dgv_Racao.TabIndex = 29;
            dgv_Racao.CellContentClick += dgv_Racao_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(663, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 20);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "TOTAL A PAGAR:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(663, 45);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 32;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(18, 398);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 33;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(138, 398);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 34;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(268, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 35;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(403, 398);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 36;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblSabor
            // 
            lblSabor.AutoSize = true;
            lblSabor.Location = new Point(486, 157);
            lblSabor.Name = "lblSabor";
            lblSabor.Size = new Size(114, 20);
            lblSabor.TabIndex = 37;
            lblSabor.Text = "VALOR DA COR:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(486, 187);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(125, 27);
            txtCor.TabIndex = 38;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(491, 85);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(117, 20);
            lblMarca.TabIndex = 39;
            lblMarca.Text = "VALOR DO TIPO:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(491, 108);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(125, 27);
            txtTipo.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 41;
            label1.Text = "VALOR DO TAMANHO:\r\n";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(486, 45);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(125, 27);
            txtTamanho.TabIndex = 42;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(250, 22);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 43;
            cmbTipo.Text = "TIPO DO POTE";
            // 
            // CodPote
            // 
            CodPote.Location = new Point(12, 15);
            CodPote.Name = "CodPote";
            CodPote.ReadOnly = true;
            CodPote.Size = new Size(43, 27);
            CodPote.TabIndex = 44;
            // 
            // Pote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CodPote);
            Controls.Add(cmbTipo);
            Controls.Add(txtTamanho);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(lblMarca);
            Controls.Add(txtCor);
            Controls.Add(lblSabor);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(btnCalcular);
            Controls.Add(btnNovo);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(dgv_Racao);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(grpCores);
            Controls.Add(cmbTamanho);
            Name = "Pote";
            Text = "Pote";
            Load += Pote_Load;
            grpCores.ResumeLayout(false);
            grpCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Racao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTamanho;
        private CheckBox chkRed;
        private CheckBox chkBlue;
        private CheckBox chkGreen;
        private CheckBox chkBlack;
        private GroupBox grpCores;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private DataGridView dgv_Racao;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnNovo;
        private Button btnCalcular;
        private Button btnSalvar;
        private Button btnSair;
        private Label lblSabor;
        private TextBox txtCor;
        private Label lblMarca;
        private TextBox txtTipo;
        private Label label1;
        private TextBox txtTamanho;
        private ComboBox cmbTipo;
        private TextBox CodPote;
    }
}