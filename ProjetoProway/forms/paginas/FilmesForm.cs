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
    public partial class FilmesForm : Form
    {
        public FilmesForm()
        {
            InitializeComponent();
        }

        private void FilmesForm_Load(object sender, EventArgs e)
        {
            listViewFilmes.Items.Clear();
          
            listViewFilmes.View = View.Details;

            listViewFilmes.GridLines = true;
            foreach (var item in Repositorios.banco.Filme)
            {
                listViewFilmes.Items.Add(new ListViewItem(new string[] { item.IdFilme.ToString(), item.Nome, item.Ano.ToString(), item.Categoria.Nome }));
            }

        }

        private void listViewSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewFilmes_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listViewFilmes.SelectedItems[0].SubItems[0].Text);

        }
    }
}
