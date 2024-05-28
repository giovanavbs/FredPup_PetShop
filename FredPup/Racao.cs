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
    public partial class Racao : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Racao()
        {
            InitializeComponent();
        }

        private void Racao_Load(object sender, EventArgs e)
        {
            cmbTamanho.Items.Add("1Kg - R$20,00");
            cmbTamanho.Items.Add("5Kg - R$40,00");
            cmbTamanho.Items.Add("10Kg - R$80,00");
            cmbTamanho.Items.Add("15Kg - R$100,00");

            cmbMarca.Items.Add("Pedigree - R$20,00");
            cmbMarca.Items.Add("Golden -R$30,00");
            cmbMarca.Items.Add("Special Dog -R$ 50,00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorRacao = 0, valorSabor = 0, valorMarca = 0, valorTipo = 0, Total = 0;

            if (cmbTamanho.SelectedIndex == 0)
            {
                valorRacao = 20;
            }
            else if (cmbTamanho.SelectedIndex == 1)
            {
                valorRacao = 30;
            }
            else if (cmbTamanho.SelectedIndex == 2)
            {
                valorRacao = 40;
            }
            else if (cmbTamanho.SelectedIndex == 3)
            {
                valorRacao = 50;
            }

            if (cmbMarca.SelectedIndex == 0)
            {
                valorMarca = 20;
            }
            else if (cmbMarca.SelectedIndex == 1)
            {
                valorMarca = 30;
            }
            else if (cmbMarca.SelectedIndex == 2)
            {
                valorMarca = 50;
            }

            if (chkFrango.Checked == true)
            {
                valorSabor = valorSabor + 5;
            }
            if (chkCarne.Checked == true)
            {
                valorSabor = valorSabor + 5;
            }
            if (chkAmbos.Checked == true)
            {
                valorSabor = valorSabor + 6;
            }
            if (chkVegetais.Checked == true)
            {
                valorSabor = valorSabor + 3;

            }

            if (chkCachorro.Checked == true)
            {
                valorTipo = valorTipo + 80;
            }
            if (chkGato.Checked == true)
            {
                valorTipo = valorTipo + 60;
            }
            if (chkCoelho.Checked == true)
            {
                valorTipo = valorTipo + 40;
            }
            if (chkPassaro.Checked == true)
            {
                valorTipo = valorTipo + 20;

            }
            else
            {
                //MessageBox.Show("Calculo");
            }
            Total = valorRacao + valorSabor + valorMarca + valorTipo;


            txtTamanho.Text = Convert.ToString(valorRacao);
            txtMarca.Text = Convert.ToString(valorMarca);
            txtSabor.Text = Convert.ToString(valorSabor);
            txtAnimal.Text = Convert.ToString(valorTipo);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void grpSabores_Enter(object sender, EventArgs e)
        {
            cmbTamanho.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            chkFrango.Checked = false;
            chkCarne.Checked = false;
            chkAmbos.Checked = false;
            chkVegetais.Checked = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtSabor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo valor");
                txtSabor.Focus();
            }
            else if (txtSabor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo sabor");
                txtSabor.Focus();
            }
            else if (txtAnimal.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tipo");
                txtAnimal.Focus();
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
                    string sql = "insert into tbRacao(tamanho,sabor,marca, animal,total)values(@tamanho,@sabor,@marca,@animal,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tamanho", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@sabor", MySqlDbType.Text).Value = txtSabor.Text;
                    cmd.Parameters.Add("@animal", MySqlDbType.Text).Value = txtAnimal.Text;
                    cmd.Parameters.Add("@marca", MySqlDbType.Text).Value = cmbMarca.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotal.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    txtTamanho.Text = "";
                    txtMarca.Text = "";
                    txtSabor.Text = "";
                    txtAnimal.Text = "";
                    txtTotal.Text = "";
                    cmbMarca.Text = "";
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSabor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo valor");
                txtSabor.Focus();
            }
            else if (txtSabor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo sabor");
                txtSabor.Focus();
            }
            else if (txtAnimal.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tipo");
                txtAnimal.Focus();
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
                    string sql = "insert into tbRacao(tamanho,sabor,marca, animal,total)values(@tamanho,@sabor,@marca,@animal,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tamanho", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@sabor", MySqlDbType.Text).Value = txtSabor.Text;
                    cmd.Parameters.Add("@animal", MySqlDbType.Text).Value = txtAnimal.Text;
                    cmd.Parameters.Add("@marca", MySqlDbType.Text).Value = cmbMarca.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotal.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    txtTamanho.Text = "";
                    txtMarca.Text = "";
                    txtSabor.Text = "";
                    txtAnimal.Text = "";
                    txtTotal.Text = "";
                    cmbMarca.Text = "";
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

        private void carregarRacao()
        {
            try
            {
                con.ConnectarBD();
                CodRacao.Text = dgv_Racao.SelectedRows[0].Cells[0].Value.ToString();
                txtTamanho.Text = dgv_Racao.SelectedRows[0].Cells[1].Value.ToString();
                txtSabor.Text = dgv_Racao.SelectedRows[0].Cells[2].Value.ToString();
                txtMarca.Text = dgv_Racao.SelectedRows[0].Cells[3].Value.ToString();
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
            carregarRacao();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbRacao";

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
