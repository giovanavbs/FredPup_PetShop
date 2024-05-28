namespace FredPup
{
    partial class Menu
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
            pnMenu = new Panel();
            btnRacao = new Button();
            btnPotes = new Button();
            btnSair = new Button();
            btnCliente = new Button();
            pnConteudo = new Panel();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(btnRacao);
            pnMenu.Controls.Add(btnPotes);
            pnMenu.Controls.Add(btnSair);
            pnMenu.Controls.Add(btnCliente);
            pnMenu.Location = new Point(71, 14);
            pnMenu.Margin = new Padding(4, 5, 4, 5);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(177, 583);
            pnMenu.TabIndex = 0;
            // 
            // btnRacao
            // 
            btnRacao.Location = new Point(28, 124);
            btnRacao.Margin = new Padding(4, 5, 4, 5);
            btnRacao.Name = "btnRacao";
            btnRacao.Size = new Size(123, 75);
            btnRacao.TabIndex = 4;
            btnRacao.Text = "RAÇÃO";
            btnRacao.UseVisualStyleBackColor = true;
            btnRacao.Click += btnRacao_Click;
            // 
            // btnPotes
            // 
            btnPotes.Location = new Point(28, 209);
            btnPotes.Margin = new Padding(4, 5, 4, 5);
            btnPotes.Name = "btnPotes";
            btnPotes.Size = new Size(123, 75);
            btnPotes.TabIndex = 3;
            btnPotes.Text = "POTES";
            btnPotes.UseVisualStyleBackColor = true;
            btnPotes.Click += btnPotes_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(28, 515);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(123, 71);
            btnSair.TabIndex = 2;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(28, 39);
            btnCliente.Margin = new Padding(4, 5, 4, 5);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(123, 75);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "CLIENTE";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // pnConteudo
            // 
            pnConteudo.BackColor = SystemColors.ButtonHighlight;
            pnConteudo.Location = new Point(256, 14);
            pnConteudo.Margin = new Padding(4, 5, 4, 5);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(785, 596);
            pnConteudo.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 623);
            Controls.Add(pnConteudo);
            Controls.Add(pnMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load_1;
            pnMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnConteudo;
        private Button button2;
        private Button btnPotes;
        private Button btnRacao;
    }
}