using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForms
{
    public partial class FrmModernDark : Form
    {
        private const string userPlaceholder = "Usuário";
        private const string passPlaceholder = "password";

        public FrmModernDark()
        {
            InitializeComponent();
        }

        private void FrmModernDark_Load(object sender, EventArgs e)
        {
            tbUser.Text = userPlaceholder;
            tbPass.Text = passPlaceholder;
        }

        /// <summary>
        /// Mostra e oculta a senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bViewPass_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '\0')
            {
                tbPass.PasswordChar = '●';
                bViewPass.Image = Properties.Resources.eye_24x24;
            }
            else
            {
                tbPass.PasswordChar = '\0';
                bViewPass.Image = Properties.Resources.eye_hidden_24x24;
            }
        }

        #region PlaceHolder

        /// <summary>
        /// Remove o placeholder ao entrar no campo do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == userPlaceholder)
            {
                tbUser.Text = string.Empty;
            }
        }

        /// <summary>
        /// Se sair do campo com ele em branco, adiciona o placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text))
            {
                tbUser.Text = userPlaceholder;
            }
        }

        /// <summary>
        /// Remove o placeholder ao entrar no campo da senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == passPlaceholder)
            {
                tbPass.Text = string.Empty;
            }
        }

        /// <summary>
        /// Se sair do campo com ele em branco, adiciona o placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                tbPass.Text = passPlaceholder;
            }
        }

        #endregion

        #region Eventos da Tela

        /// <summary>
        /// Botão Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botão Logar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            /*
             * ... Realiza verificações do login ...
             * 
             */

            //Após realizar o login, abre o Menu Principal
            MessageBox.Show("Acesso liberado");

            //Após fechar o principal, finalizar o programa
            this.Close();
        }

        #endregion
    }
}
