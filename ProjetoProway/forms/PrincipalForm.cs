using ProjetoProway.forms;
using ProjetoProway.forms.paginas;
using ProjetoProway.forms.utils;
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

namespace ProjetoProway
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            VisibilidadeMenu(false);
            SubirJanela(new LoginForm());


            //var banco = new BancoProwayEntities(); 
            //var query = from st in banco.perfis
            //            where st.nome == "Usuário"
            //            select st;

            //var perfil = query.FirstOrDefault<perfi>();

            //var usuario = new usuario()
            //{
            //    nome = "Teste",
            //    email = "teste1@gmail.com",
            //    login = "teste1",
            //    senha = "123",
            //    perfil = perfil.id_perfil
            //};

            //banco.usuarios.Add(usuario);
            //banco.SaveChanges();
        }

        private void VisibilidadeMenu(bool visivel)
        {
            this.menuSuperior.Visible= visivel;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaFilha(new HomeForm()); 
        }

      

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaFilha(new FilmesForm()); 
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaFilha(new SeriesForm()); 

        }

        private void JanelaFilha(Form form)
        { 
            // Maximiza o formulário filho
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
            // Define quem o pai desta janela
            form.MdiParent = this;
            form.Show();

        }

        private void SubirJanela(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AllowDrop = false;
            form.ImeMode = ImeMode.Disable;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.ControlBox = false;
            form.Show();
        }

        public void Entrar()
        {
            VisibilidadeMenu(true);
            JanelaFilha(new HomeForm());
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg;
            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
            {
                dg = MessageBox.Show(this,
                    "Tem certeza que deseja sair?",
                    "Encerrar programa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                SegurancaForm f = Application.OpenForms["SegurancaForm"] as SegurancaForm;

                f.Close();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

            SegurancaForm f = Application.OpenForms["SegurancaForm"] as SegurancaForm;
           
            f.Show();
             


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            JanelaFilha(new UsuarioForm());
        }
    }
}
