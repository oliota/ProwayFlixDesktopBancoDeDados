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
    public partial class SeriesForm : Form
    {
        public SeriesForm()
        {
            InitializeComponent();
        }
        public enum Formulario
        {
            Serie,
            Temporada,
            Episodio
        }
        public Serie SerieItem;
        public Temporada TemporadaItem;
        public Episodio EpisodioItem;

        public Formulario cadastro;

        private void SeriesForm_Load(object sender, EventArgs e)
        {
            gbForm.Visible = false;
            listViewSeries.Items.Clear();
            listViewTemporadas.Items.Clear();
            listViewEpisodios.Items.Clear();
            listViewSeries.View = View.Details;

            listViewSeries.GridLines = true;
            ListarSeries();
            ListarCategorias();
            btAddTemporada.Visible = false;
            btAddEpisodio.Visible = false;
        }

        private void ListarCategorias()
        {
            cbCategorias.Items.Clear();
            foreach (var item in Repositorios.banco.Categoria)
            {
                cbCategorias.Items.Add(item.Nome);
            }
        }

        #region Serie

        public void ListarSeries()
        {
            listViewSeries.Items.Clear();
            foreach (var item in Repositorios.banco.Serie.OrderBy(x => x.Nome))
            {
                listViewSeries.Items.Add(new ListViewItem(new string[] { item.IdSerie.ToString(), item.Nome, item.Ano.ToString(), item.Categoria.Nome }));
            }
        }

        private void listViewSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro = Formulario.Serie;
            listViewEpisodios.Items.Clear();
            listViewTemporadas.Items.Clear();
            listViewTemporadas.View = View.Details;

            listViewTemporadas.GridLines = true;

            int index = 0;
            if (this.listViewSeries.SelectedItems.Count > 0)
                index = this.listViewSeries.SelectedIndices[0];

            var serie = listViewSeries.Items[index].SubItems[0];

            SerieItem = Repositorios.banco.Serie.Where(x => x.IdSerie.ToString().Equals(serie.Text)).FirstOrDefault();

            TemporadaItem = null;
            ListarTemporadas();
            OcultarTabas();
            ExibirTab(tabPageSerie, false);


        }

        #endregion

        #region Temporada
        public void ListarTemporadas()
        {
            listViewTemporadas.Items.Clear();
            listViewEpisodios.Items.Clear();
            btAddEpisodio.Visible = false;

            if (SerieItem == null || SerieItem.IdSerie == 0)
            {
                btAddTemporada.Visible = false;
                return;
            }
            btAddTemporada.Visible = true;

            foreach (var item in Repositorios.banco.Temporada.Where(x => x.Serie.IdSerie.ToString().Equals(SerieItem.IdSerie.ToString())).OrderBy(x => x.Sequencial))
            {
                listViewTemporadas.Items.Add(new ListViewItem(new string[] { item.IdTemporada.ToString(), item.Sequencial.ToString() }));
            }
        }
        private void listViewTemporadas_SelectedIndexChanged(object sender, EventArgs e)
        {

            cadastro = Formulario.Temporada;
            listViewEpisodios.Items.Clear();
            listViewEpisodios.View = View.Details;

            listViewEpisodios.GridLines = true;

            int index = 0;
            if (this.listViewTemporadas.SelectedItems.Count > 0)
                index = this.listViewTemporadas.SelectedIndices[0];

            var temporada = listViewTemporadas.Items[index].SubItems[0];

            TemporadaItem = Repositorios.banco.Temporada.Where(x => x.IdTemporada.ToString().Equals(temporada.Text)).FirstOrDefault();

            EpisodioItem = null;
            ListarEpisodios();
            OcultarTabas();
            ExibirTab(tabPageTemporada, false);
        }

        #endregion

        #region Episodio
        public void ListarEpisodios()
        {
            listViewEpisodios.Items.Clear();
            if (TemporadaItem == null || TemporadaItem.IdTemporada == 0)
            {
                btAddEpisodio.Visible = false;
                return;
            }
            btAddEpisodio.Visible = true;

            foreach (var item in Repositorios.banco.Episodio.Where(x => x.Temporada.IdTemporada.ToString().Equals(TemporadaItem.IdTemporada.ToString())).OrderBy(x => x.Sequencial))
            {
                listViewEpisodios.Items.Add(new ListViewItem(new string[] { item.IdEpisodio.ToString(), item.Nome, item.Sinopse }));
            }
        }

        private void listViewEpisodios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro = Formulario.Episodio;

            int index = 0;
            if (this.listViewEpisodios.SelectedItems.Count > 0)
                index = this.listViewEpisodios.SelectedIndices[0];

            var episodio = listViewEpisodios.Items[index].SubItems[0];

            EpisodioItem = Repositorios.banco.Episodio.Where(x => x.IdEpisodio.ToString().Equals(episodio.Text)).FirstOrDefault();

            OcultarTabas();
            ExibirTab(tabPageEpisodio, false);
        }
        #endregion

        #region Tabs
        private void ExibirTab(TabPage tab, bool zerar)
        {
            gbForm.Visible = true;
            tabForms.TabPages.Insert(0, tab);

            switch (cadastro)
            {
                case Formulario.Serie:
                    tbSerie.Text = zerar ? string.Empty : SerieItem.Nome;
                    tbAnoSerie.Text = zerar ? string.Empty : SerieItem.Ano.ToString();
                    tbSinopseSerie.Text = zerar ? string.Empty : SerieItem.Sinopse;
                    cbCategorias.SelectedIndex = zerar ? -1 : cbCategorias.FindStringExact(SerieItem.Categoria.Nome);
                    break;
                case Formulario.Temporada:
                    tbSequencialTemporada.Text = zerar ? string.Empty : TemporadaItem.Sequencial.ToString();
                    break;
                case Formulario.Episodio:
                    tbEpisodio.Text = zerar ? string.Empty : EpisodioItem.Nome;
                    tbSequencialEpisodio.Text = zerar ? string.Empty : EpisodioItem.Sequencial.ToString();
                    tbSinopseEpisodio.Text = zerar ? string.Empty : EpisodioItem.Sinopse;
                    break;
            }
            tab.Show();

        }

        private void OcultarTabas()
        {
            tabPageSerie.Hide();
            tabPageTemporada.Hide();
            tabPageEpisodio.Hide();
            tabForms.TabPages.Remove(tabPageSerie);
            tabForms.TabPages.Remove(tabPageTemporada);
            tabForms.TabPages.Remove(tabPageEpisodio);
        }
        #endregion

        #region Buttons

        private void btDeletar_Click(object sender, EventArgs e)
        {


            switch (cadastro)
            {
                case Formulario.Serie:
                    Repositorios.banco.Serie.Remove(SerieItem);
                    break;
                case Formulario.Temporada:
                    Repositorios.banco.Temporada.Remove(TemporadaItem);
                    break;
                case Formulario.Episodio:
                    Repositorios.banco.Episodio.Remove(EpisodioItem);
                    break;
            }

            gbForm.Visible = false;
            Salvar();

        }

        private void Salvar()
        {
            Repositorios.Salvar();
            ListarSeries();
            ListarTemporadas();
            ListarEpisodios();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            switch (cadastro)
            {
                case Formulario.Serie:

                    SerieItem.Nome = tbSerie.Text;
                    SerieItem.Ano = Int32.Parse(tbAnoSerie.Text);
                    SerieItem.Sinopse = tbSinopseSerie.Text;
                    SerieItem.Categoria = Repositorios.banco.Categoria
                        .Where(x => x.Nome.Equals(cbCategorias.SelectedItem.ToString()))
                        .FirstOrDefault();
                    if (SerieItem.IdSerie == 0)
                        Repositorios.banco.Serie.Add(SerieItem);
                    break;
                case Formulario.Temporada:
                    TemporadaItem.Serie = SerieItem;
                    TemporadaItem.Sequencial = Int32.Parse(tbSequencialTemporada.Text);
                    if (TemporadaItem.IdTemporada == 0)
                        Repositorios.banco.Temporada.Add(TemporadaItem);
                    break;
                case Formulario.Episodio:
                    EpisodioItem.Temporada = TemporadaItem;
                    EpisodioItem.Nome = tbEpisodio.Text;
                    EpisodioItem.Sequencial = Int32.Parse(tbSequencialEpisodio.Text);
                    EpisodioItem.Sinopse = tbSinopseEpisodio.Text;
                    if (EpisodioItem.IdEpisodio == 0)
                        Repositorios.banco.Episodio.Add(EpisodioItem);
                    break;
            }
            Salvar();
        }

        private void btAddSerie_Click(object sender, EventArgs e)
        {
            cadastro = Formulario.Serie;
            SerieItem = new Serie();
            OcultarTabas();
            ExibirTab(tabPageSerie, true);
            listViewTemporadas.Clear();
            listViewEpisodios.Clear();
        }

        private void btAddTemporada_Click(object sender, EventArgs e)
        {

            cadastro = Formulario.Temporada;
            TemporadaItem = new Temporada();
            OcultarTabas();
            ExibirTab(tabPageTemporada, true);
            listViewEpisodios.Clear();

        }

        private void btAddEpisodio_Click(object sender, EventArgs e)
        {

            cadastro = Formulario.Episodio;
            EpisodioItem = new Episodio();
            OcultarTabas();
            ExibirTab(tabPageEpisodio, true);
        }



        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
