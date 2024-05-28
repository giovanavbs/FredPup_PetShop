using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Macs;
using System.Drawing;

namespace FredPup
{
    public partial class login : Form
    {
        Conexao con = new Conexao();
        //MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dados;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuario e senha inválidos");
            }
            else
            {
                try
                {
                    string sql = "select * from tblogin where email=@email and senha=@senha";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                    dados = cmd.ExecuteReader();

                    if (dados.HasRows)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        MessageBox.Show("Seja bem Vindo ao sistema");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha invalidos");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    con.DesConnectarBD();
                }

            }

        }
    }
}
