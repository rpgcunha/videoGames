using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_avaliacao_cs
{
    public partial class frmLogin : Form
    {
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
