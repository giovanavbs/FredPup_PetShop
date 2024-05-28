using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredPup
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirNovaJanela(object abrirnovajanela)
        {
            if (this.pnConteudo.Controls.Count > 0)
                this.pnConteudo.Controls.RemoveAt(0);
            Form tela = abrirnovajanela as Form;
            tela.TopLevel = false;
            tela.Dock = DockStyle.Fill;
            this.pnConteudo.Controls.Add(tela);
            this.pnConteudo.Tag = tela;
            tela.Show();

        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Cliente());
        }

        private void btnRacao_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Racao());
        }

        private void btnPotes_Click(object sender, EventArgs e)
        {
            AbrirNovaJanela(new Pote());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Sair", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
