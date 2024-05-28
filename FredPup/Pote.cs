using MySql.Data.MySqlClient;
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
    public partial class Pote : Form
    {

        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Pote()
        {
            InitializeComponent();
        }


        private void Pote_Load(object sender, EventArgs e)
        {
            cmbTamanho.Items.Add("pequena - R$20,00");
            cmbTamanho.Items.Add("media - R$35,00");
            cmbTamanho.Items.Add("grande - R$50,00");

            cmbTipo.Items.Add("baixa - R$10,00");
            cmbTipo.Items.Add("alta - R$20,00");
            cmbTipo.Items.Add("com supurte - R$ 40,00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorTamanho = 0, valorTipo = 0, valorCor = 0, Total = 0;

            if (cmbTamanho.SelectedIndex == 0)
            {
                valorTamanho = 20;
            }
            else if (cmbTamanho.SelectedIndex == 1)
            {
                valorTamanho = 35;
            }
            else if (cmbTamanho.SelectedIndex == 2)
            {
                valorTamanho = 50;
            }

            if (cmbTipo.SelectedIndex == 0)
            {
                valorTipo = 10;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                valorTipo = 20;
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                valorTipo = 40;
            }

            if (chkRed.Checked == true)
            {
                valorCor = valorCor + 1;
            }
            if (chkBlue.Checked == true)
            {
                valorCor = valorCor + 2;
            }
            if (chkGreen.Checked == true)
            {
                valorCor = valorCor + 3;
            }
            if (chkBlack.Checked == true)
            {
                valorCor = valorCor + 4;

            }
            else
            {
                //MessageBox.Show("Calculo");
            }
            Total = valorTamanho + valorTipo + valorCor;

            txtTamanho.Text = Convert.ToString(valorTamanho);
            txtTipo.Text = Convert.ToString(valorTipo);
            txtCor.Text = Convert.ToString(valorCor);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void grpCores_Enter(object sender, EventArgs e)
        {
            cmbTamanho.SelectedIndex = -1;
            chkRed.Checked = false;
            chkBlue.Checked = false;
            chkGreen.Checked = false;
            chkBlack.Checked = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtTamanho.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tamanho");
                txtTamanho.Focus();
            }
            else if (txtTipo.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tipo");
                txtTipo.Focus();
            }
            else if (txtCor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo cor");
                txtCor.Focus();
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo total");
                txtTotal.Focus();
            }

            else
            {

                try
                {
                    //insere no banco de dados
                    string sql = "insert into tbPote(tamanho,tipo,cor,total)values(@tamanho,@tipo,@cor,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tamanho", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@tipo", MySqlDbType.Text).Value = cmbTipo.Text;
                    cmd.Parameters.Add("@cor", MySqlDbType.Text).Value = txtCor.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotal.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    txtTamanho.Text = "";
                    txtTipo.Text = "";
                    txtCor.Text = "";
                    txtTotal.Text = "";
                    cmbTamanho.Text = "";
                    cmbTipo.Text = "";
                    cmbTamanho.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTamanho.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tamanho");
                txtTamanho.Focus();
            }
            else if (txtTipo.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tipo");
                txtTipo.Focus();
            }
            else if (txtCor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo cor");
                txtCor.Focus();
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo total");
                txtTotal.Focus();
            }
            else
            {

                try
                {
                    //insere no banco de dados
                    string sql = "insert into tbPote(tamanho,tipo,cor,total)values(@tamanho,@tipo,@cor,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tamanho", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@tipo", MySqlDbType.Text).Value = txtTipo.Text;
                    cmd.Parameters.Add("@cor", MySqlDbType.Text).Value = txtCor.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotal.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    txtTamanho.Text = "";
                    txtTipo.Text = "";
                    txtCor.Text = "";
                    txtTotal.Text = "";
                    cmbTipo.Text = "";
                    cmbTamanho.Text = "";
                    cmbTamanho.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);

                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Sair", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void carregarPote()
        {
            try
            {
                con.ConnectarBD();
                CodPote.Text = dgv_Racao.SelectedRows[0].Cells[0].Value.ToString();
                txtTamanho.Text = dgv_Racao.SelectedRows[0].Cells[1].Value.ToString();
                txtTipo.Text = dgv_Racao.SelectedRows[0].Cells[2].Value.ToString();
                txtCor.Text = dgv_Racao.SelectedRows[0].Cells[3].Value.ToString();
                txtTotal.Text = dgv_Racao.SelectedRows[0].Cells[4].Value.ToString();
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void dgv_Racao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarPote();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPote";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_Racao.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgv_Racao.DataSource = null;

            }
        }
    }
}

