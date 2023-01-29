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
    public partial class frmPricipal : Form
    {
        public frmPricipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha a aplicaçao
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //deslogar

            //fecha este form e volta ao form de login
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnGalo_Click(object sender, EventArgs e)
        {
            //fecha este form e abre o form do jogo do galo
            this.Close();
            frmGalo frmGalo= new frmGalo();
            frmGalo.Show();
        }

        private void frmPricipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            //fecha este form e abre o form do snake
            this.Close();
            frmSnake frmSnake = new frmSnake();
            frmSnake.Show();
        }
    }
}
