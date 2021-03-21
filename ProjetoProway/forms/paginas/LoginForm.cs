using ProjetoProway.Model.Repositorio;
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
            //if (ValidarCampos() && ValidarMock())
            if (ValidarCampos(true) && Validar(true))
                Entrar();
            else
                InformarErro("Falha ao logar, verifique as informações e tente novamente.");

        }
        private bool ValidarCampos(bool entrar)
        {
            ResetarMensagemdeErro();
            if (entrar)
            {
                if (string.IsNullOrWhiteSpace(tbLogin.Text))
                    return InformarErro("Favor preencher o campo Login");
                if (string.IsNullOrWhiteSpace(tbSenha.Text))
                    return InformarErro("Favor preencher o campo Senha");
            }
            else
            {

                if (string.IsNullOrWhiteSpace(tbCadastroNome.Text))
                    return InformarErro("Favor preencher o campo Nome");
                if (string.IsNullOrWhiteSpace(tbCadastroEmail.Text))
                    return InformarErro("Favor preencher o campo Email");
                if (string.IsNullOrWhiteSpace(tbCadastroLogin.Text))
                    return InformarErro("Favor preencher o campo Login");
                if (string.IsNullOrWhiteSpace(tbCadastroSenha.Text))
                    return InformarErro("Favor preencher o campo Senha");
                if (string.IsNullOrWhiteSpace(tbCadastroSenha2.Text))
                    return InformarErro("Favor preencher o campo Confirmar Senha");

            }

            return true;
        }
        private bool ValidarMock()
        {
            if (!tbLogin.Text.Equals("1"))
                return InformarErro("Login inválido");
            if (!tbSenha.Text.Equals("1"))
                return InformarErro("Senha incorreta");

            return true;
        }

        private bool Validar(bool entrar)
        {
            if (!entrar && VerificarExistente())
            {
                return InformarErro("Já existe um usuário com esse login, favor informe outro para prosseguir com o cadastro."); ;
            }
            var Novo = new Usuario()
            {
                Nome = tbCadastroNome.Text,
                Email = tbCadastroEmail.Text,
                Logon = tbCadastroLogin.Text,
                Senha = tbCadastroSenha.Text,
                Perfil = Repositorios.PerfilPadrao()

            };
            Repositorios.banco.Usuario.Add(Novo);
            Repositorios.Salvar();

            var select = Repositorios.banco.Usuario
                     .Where(s => s.Logon.Equals(entrar ? tbLogin.Text : tbCadastroLogin.Text))
                     .Where(s => s.Senha.Equals(entrar ? tbSenha.Text : tbCadastroSenha.Text))
                     .FirstOrDefault<Usuario>();


            if (select != null)
            {
                Repositorios.UsuarioLogado = select;
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool VerificarExistente()
        {
            var select = Repositorios.banco.Usuario
                     .Where(s => s.Logon.Equals(tbCadastroLogin.Text))
                     .FirstOrDefault<Usuario>();


            if (select != null)
            {
                Repositorios.UsuarioLogado = select;
                return true;
            }
            else
            {
                return false;
            }
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
            f.Text = $"ProwayFlix - {Repositorios.UsuarioLogado.Nome} ";
            this.Close();

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(false) && Validar(false))
                Entrar();

        }
    }
}
