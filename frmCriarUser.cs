using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_avaliacao_cs
{
    public partial class frmCriarUser : Form
    {
        public frmCriarUser()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //fecha este form e volta ao form de login
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa todas as caixas de texto
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPass1.Text = string.Empty;
            txtPass2.Text = string.Empty;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int idade;
            //verifica se existe alguma textbox vazia
            if (txtNome.Text==string.Empty || txtSobrenome.Text==string.Empty || txtIdade.Text==string.Empty || txtUser.Text==string.Empty || txtPass1.Text==string.Empty||txtPass2.Text==string.Empty)
            {
                //verifica se o nome esta vazio e exibe mensagem de erro
                if (txtNome.Text==string.Empty)
                {
                    lblErroNome.Visible = true;
                }
                else
                {
                    lblErroNome.Visible = false;
                }
                //verifica se o sobrenome esta vazio e exibe mensagem de erro
                if (txtSobrenome.Text==string.Empty)
                {
                    lblErroSobre.Visible = true;
                }
                else
                {
                    lblErroSobre.Visible= false;
                }
                //verifica se a idade esta vazio e exibe mensagem de erro
                if (txtIdade.Text==string.Empty)
                {
                    lblErroIdade.Visible = true;
                }
                else
                {
                    lblErroIdade.Visible= false;
                }
                //verifica se o utilizador esta vazio e exibe mensagem de erro
                if (txtUser.Text==string.Empty)
                {
                    lblErroUser.Visible = true;
                }
                else
                {
                    lblErroUser.Visible= false;
                }
                //verifica se a senha1 esta vazio e exibe mensagem de erro
                if (txtPass1.Text==string.Empty)
                {
                    lblErroPass1.Visible = true;
                }
                else
                {
                    lblErroPass1.Visible= false;
                }
                //verifica se a senha2 esta vazio e exibe mensagem de erro
                if (txtPass2.Text==string.Empty)
                {
                    lblErroPass2.Visible = true;
                }
                else
                {
                    lblErroPass2.Visible=false;
                }
            }
            else
            {
                //verifica se o valor na txtidade é numerico
                try
                {
                    idade =Convert.ToInt16( txtIdade.Text);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Valores intruduzidos na caixa idade inválidos!");
                    return;
                }
                //verificar se utilizador ja existe na bd

                //verifica se a pass tem tamanho de no minimo 6 char
                if (txtPass1.Text.Length<6)
                {
                    System.Windows.Forms.MessageBox.Show("Senha demasiado curta! Tem que usar no minimo 6 caracteres.");
                    txtPass1.Text = string.Empty;
                    txtPass2.Text = string.Empty;
                }
                //verifica se as duas pass sao iguais
                if (txtPass1.Text!=txtPass2.Text)
                {
                    System.Windows.Forms.MessageBox.Show("Senhas diferentes!");
                    txtPass1.Text = string.Empty;
                    txtPass2.Text = string.Empty;
                    return;
                }
                //criar utilizador na base de dados
                //apresentar mensagem de user criado com sucesso

                //fecha o form e volta ao form de login
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }
    }
}
