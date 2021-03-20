using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProway.forms.paginas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && ValidarMock())
                Entrar();
            
        }
        private bool ValidarCampos()
        {
            ResetarMensagemdeErro();
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
                return InformarErro("Favor preencher o campo Login");
            if (string.IsNullOrWhiteSpace(tbSenha.Text))
                return InformarErro("Favor preencher o campo Senha");

            return true;
        }
        private bool ValidarMock()
        {
            BancoEntities.U
            if (!tbLogin.Text.Equals("1"))
                return InformarErro("Login inválido");
            if (!tbSenha.Text.Equals("1"))
                return InformarErro("Senha incorreta"); 

            return true;
        }

        private void ResetarMensagemdeErro()
        {
            lbErro.Visible = false;
            lbErro.Text = "";
        }

        private bool InformarErro(string mensagem)
        {
            lbErro.Visible = true;
            lbErro.Text = mensagem;
            return false;
        }

        private void Entrar()
        {
            PrincipalForm f = Application.OpenForms["PrincipalForm"] as PrincipalForm; 
            f.Entrar();
            this.Close();
        }
 
    }
}
