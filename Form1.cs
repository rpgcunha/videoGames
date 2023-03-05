using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_avaliacao_cs
{
    public partial class frmLogin : Form
    {
        public static string strConn = "data source = localhost\\SQLEXPRESS;Initial Catalog = games;User Id=admin;Password = 123.Abc;";

        public string utilizador;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha aplicação
            Application.Exit();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //esconde este form e abre o form para criar utilizador
            this.Hide();
            frmCriarUser frmCriarUser = new frmCriarUser();
            frmCriarUser.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text!=string.Empty && txtPass.Text!=string.Empty)
            {
                //verificar se o user existe
                SqlConnection C = new SqlConnection(strConn);
                C.Open();
                //criar comando SQL para extrair os dados pretendidos:
                SqlCommand command = C.CreateCommand();
                command.CommandText = "select pass from dbo.utilizador where nick = '" + txtUser.Text + "'";                 //trazer os dados da tabela especificada para uma "tabela" em memória:
                string password = (string)command.ExecuteScalar();
                C.Close();
                if (password != txtPass.Text)
                {
                    MessageBox.Show("Username ou password incorretos!");
                    txtPass.Text = string.Empty;
                    return;
                }
                utilizador = txtUser.Text;

                //verificar se a pass esta correta
                this.Hide();
                frmPricipal frmPricipal=new frmPricipal();
                frmPricipal.Show();
            }
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //verifica se a pass tem 6 chars
            if (txtPass.Text.Length < 6)
            {
                int posX1 = 150 - 88, posY1 = 251, posX2 = 150 + 88, posY2 = 251;
                if (btnLogin.Right > 150)
                {
                    btnLogin.Location= new Point(posX1, posY1);
                }
                else
                {
                    btnLogin.Location = new Point(posX2, posY2);
                }
            }
        }
    }
}
