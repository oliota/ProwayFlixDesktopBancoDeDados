namespace ProjetoProway.forms.paginas
{
    partial class SeriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewSeries = new System.Windows.Forms.ListView();
            this.SerieId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTemporadas = new System.Windows.Forms.ListView();
            this.TempotradaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temporada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEpisodios = new System.Windows.Forms.ListView();
            this.EpisodioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episodio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sinopse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabPageSerie = new System.Windows.Forms.TabPage();
            this.tbSinopseSerie = new System.Windows.Forms.TextBox();
            this.lbSinopse = new System.Windows.Forms.Label();
            this.tbAnoSerie = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.lbSerie = new System.Windows.Forms.Label();
            this.tabPageTemporada = new System.Windows.Forms.TabPage();
            this.tbSequencialTemporada = new System.Windows.Forms.TextBox();
            this.lbSequencial = new System.Windows.Forms.Label();
            this.tabPageEpisodio = new System.Windows.Forms.TabPage();
            this.tbSinopseEpisodio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSequencialEpisodio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEpisodio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddEpisodio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddTemporada = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAddSerie = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbForm.SuspendLayout();
            this.tabForms.SuspendLayout();
            this.tabPageSerie.SuspendLayout();
            this.tabPageTemporada.SuspendLayout();
            this.tabPageEpisodio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSeries
            // 
            this.listViewSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerieId,
            this.Nome,
            this.Ano,
            this.Categoria});
            this.listViewSeries.HideSelection = false;
            this.listViewSeries.Location = new System.Drawing.Point(1, 16);
            this.listViewSeries.Name = "listViewSeries";
            this.listViewSeries.Size = new System.Drawing.Size(500, 182);
            this.listViewSeries.TabIndex = 2;
            this.listViewSeries.UseCompatibleStateImageBehavior = false;
            this.listViewSeries.SelectedIndexChanged += new System.EventHandler(this.listViewSeries_SelectedIndexChanged);
            // 
            // SerieId
            // 
            this.SerieId.DisplayIndex = 3;
            this.SerieId.Text = "Id";
            this.SerieId.Width = 0;
            // 
            // Nome
            // 
            this.Nome.DisplayIndex = 0;
            this.Nome.Text = "Serie";
            this.Nome.Width = 300;
            // 
            // Ano
            // 
            this.Ano.DisplayIndex = 1;
            this.Ano.Text = "Ano";
            this.Ano.Width = 50;
            // 
            // Categoria
            // 
            this.Categoria.DisplayIndex = 2;
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 150;
            // 
            // listViewTemporadas
            // 
            this.listViewTemporadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TempotradaId,
            this.Temporada});
            this.listViewTemporadas.HideSelection = false;
            this.listViewTemporadas.Location = new System.Drawing.Point(1, 27);
            this.listViewTemporadas.Name = "listViewTemporadas";
            this.listViewTemporadas.Size = new System.Drawing.Size(500, 99);
            this.listViewTemporadas.TabIndex = 3;
            this.listViewTemporadas.UseCompatibleStateImageBehavior = false;
            this.listViewTemporadas.SelectedIndexChanged += new System.EventHandler(this.listViewTemporadas_SelectedIndexChanged);
            // 
            // TempotradaId
            // 
            this.TempotradaId.DisplayIndex = 1;
            this.TempotradaId.Text = "Id";
            this.TempotradaId.Width = 0;
            // 
            // Temporada
            // 
            this.Temporada.DisplayIndex = 0;
            this.Temporada.Text = "Temporada";
            this.Temporada.Width = 260;
            // 
            // listViewEpisodios
            // 
            this.listViewEpisodios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EpisodioId,
            this.Episodio,
            this.Sinopse});
            this.listViewEpisodios.HideSelection = false;
            this.listViewEpisodios.Location = new System.Drawing.Point(0, 29);
            this.listViewEpisodios.Name = "listViewEpisodios";
            this.listViewEpisodios.Size = new System.Drawing.Size(500, 133);
            this.listViewEpisodios.TabIndex = 4;
            this.listViewEpisodios.UseCompatibleStateImageBehavior = false;
            this.listViewEpisodios.SelectedIndexChanged += new System.EventHandler(this.listViewEpisodios_SelectedIndexChanged);
            // 
            // EpisodioId
            // 
            this.EpisodioId.DisplayIndex = 2;
            this.EpisodioId.Text = "Id";
            this.EpisodioId.Width = 0;
            // 
            // Episodio
            // 
            this.Episodio.DisplayIndex = 0;
            this.Episodio.Text = "Episodio";
            this.Episodio.Width = 300;
            // 
            // Sinopse
            // 
            this.Sinopse.DisplayIndex = 1;
            this.Sinopse.Text = "Sinopse";
            this.Sinopse.Width = 476;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.tabForms);
            this.gbForm.Controls.Add(this.btSalvar);
            this.gbForm.Controls.Add(this.btDeletar);
            this.gbForm.Location = new System.Drawing.Point(519, 34);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(280, 485);
            this.gbForm.TabIndex = 6;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Formulário";
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabPageSerie);
            this.tabForms.Controls.Add(this.tabPageTemporada);
            this.tabForms.Controls.Add(this.tabPageEpisodio);
            this.tabForms.Location = new System.Drawing.Point(9, 59);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(269, 420);
            this.tabForms.TabIndex = 6;
            // 
            // tabPageSerie
            // 
            this.tabPageSerie.Controls.Add(this.label1);
            this.tabPageSerie.Controls.Add(this.cbCategorias);
            this.tabPageSerie.Controls.Add(this.tbSinopseSerie);
            this.tabPageSerie.Controls.Add(this.lbSinopse);
            this.tabPageSerie.Controls.Add(this.tbAnoSerie);
            this.tabPageSerie.Controls.Add(this.lbAno);
            this.tabPageSerie.Controls.Add(this.tbSerie);
            this.tabPageSerie.Controls.Add(this.lbSerie);
            this.tabPageSerie.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerie.Name = "tabPageSerie";
            this.tabPageSerie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerie.Size = new System.Drawing.Size(261, 394);
            this.tabPageSerie.TabIndex = 0;
            this.tabPageSerie.Text = "Serie";
            this.tabPageSerie.UseVisualStyleBackColor = true;
            // 
            // tbSinopseSerie
            // 
            this.tbSinopseSerie.Location = new System.Drawing.Point(6, 114);
            this.tbSinopseSerie.Multiline = true;
            this.tbSinopseSerie.Name = "tbSinopseSerie";
            this.tbSinopseSerie.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSinopseSerie.Size = new System.Drawing.Size(248, 242);
            this.tbSinopseSerie.TabIndex = 5;
            // 
            // lbSinopse
            // 
            this.lbSinopse.AutoSize = true;
            this.lbSinopse.Location = new System.Drawing.Point(2, 97);
            this.lbSinopse.Name = "lbSinopse";
            this.lbSinopse.Size = new System.Drawing.Size(45, 13);
            this.lbSinopse.TabIndex = 4;
            this.lbSinopse.Text = "Sinopse";
            // 
            // tbAnoSerie
            // 
            this.tbAnoSerie.Location = new System.Drawing.Point(6, 67);
            this.tbAnoSerie.Name = "tbAnoSerie";
            this.tbAnoSerie.Size = new System.Drawing.Size(58, 20);
            this.tbAnoSerie.TabIndex = 3;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(3, 51);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(26, 13);
            this.lbAno.TabIndex = 2;
            this.lbAno.Text = "Ano";
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(6, 23);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(248, 20);
            this.tbSerie.TabIndex = 1;
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.Location = new System.Drawing.Point(2, 6);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(31, 13);
            this.lbSerie.TabIndex = 0;
            this.lbSerie.Text = "Serie";
            // 
            // tabPageTemporada
            // 
            this.tabPageTemporada.Controls.Add(this.tbSequencialTemporada);
            this.tabPageTemporada.Controls.Add(this.lbSequencial);
            this.tabPageTemporada.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemporada.Name = "tabPageTemporada";
            this.tabPageTemporada.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemporada.Size = new System.Drawing.Size(261, 394);
            this.tabPageTemporada.TabIndex = 1;
            this.tabPageTemporada.Text = "Temporada";
            this.tabPageTemporada.UseVisualStyleBackColor = true;
            // 
            // tbSequencialTemporada
            // 
            this.tbSequencialTemporada.Location = new System.Drawing.Point(6, 24);
            this.tbSequencialTemporada.Name = "tbSequencialTemporada";
            this.tbSequencialTemporada.Size = new System.Drawing.Size(248, 20);
            this.tbSequencialTemporada.TabIndex = 7;
            // 
            // lbSequencial
            // 
            this.lbSequencial.AutoSize = true;
            this.lbSequencial.Location = new System.Drawing.Point(2, 7);
            this.lbSequencial.Name = "lbSequencial";
            this.lbSequencial.Size = new System.Drawing.Size(60, 13);
            this.lbSequencial.TabIndex = 6;
            this.lbSequencial.Text = "Sequencial";
            // 
            // tabPageEpisodio
            // 
            this.tabPageEpisodio.Controls.Add(this.tbSinopseEpisodio);
            this.tabPageEpisodio.Controls.Add(this.label4);
            this.tabPageEpisodio.Controls.Add(this.tbSequencialEpisodio);
            this.tabPageEpisodio.Controls.Add(this.label5);
            this.tabPageEpisodio.Controls.Add(this.tbEpisodio);
            this.tabPageEpisodio.Controls.Add(this.label6);
            this.tabPageEpisodio.Location = new System.Drawing.Point(4, 22);
            this.tabPageEpisodio.Name = "tabPageEpisodio";
            this.tabPageEpisodio.Size = new System.Drawing.Size(261, 394);
            this.tabPageEpisodio.TabIndex = 2;
            this.tabPageEpisodio.Text = "Episodio";
            this.tabPageEpisodio.UseVisualStyleBackColor = true;
            // 
            // tbSinopseEpisodio
            // 
            this.tbSinopseEpisodio.Location = new System.Drawing.Point(5, 114);
            this.tbSinopseEpisodio.Multiline = true;
            this.tbSinopseEpisodio.Name = "tbSinopseEpisodio";
            this.tbSinopseEpisodio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSinopseEpisodio.Size = new System.Drawing.Size(248, 277);
            this.tbSinopseEpisodio.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sinopse";
            // 
            // tbSequencialEpisodio
            // 
            this.tbSequencialEpisodio.Location = new System.Drawing.Point(5, 67);
            this.tbSequencialEpisodio.Name = "tbSequencialEpisodio";
            this.tbSequencialEpisodio.Size = new System.Drawing.Size(58, 20);
            this.tbSequencialEpisodio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sequencial";
            // 
            // tbEpisodio
            // 
            this.tbEpisodio.Location = new System.Drawing.Point(5, 23);
            this.tbEpisodio.Name = "tbEpisodio";
            this.tbEpisodio.Size = new System.Drawing.Size(248, 20);
            this.tbEpisodio.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Episodio";
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(9, 20);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(130, 23);
            this.btDeletar.TabIndex = 0;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(144, 20);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(130, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddEpisodio);
            this.groupBox1.Controls.Add(this.listViewEpisodios);
            this.groupBox1.Location = new System.Drawing.Point(12, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Episodios";
            // 
            // btAddEpisodio
            // 
            this.btAddEpisodio.Location = new System.Drawing.Point(401, 0);
            this.btAddEpisodio.Name = "btAddEpisodio";
            this.btAddEpisodio.Size = new System.Drawing.Size(99, 23);
            this.btAddEpisodio.TabIndex = 8;
            this.btAddEpisodio.Text = "Novo Episódio";
            this.btAddEpisodio.UseVisualStyleBackColor = true;
            this.btAddEpisodio.Click += new System.EventHandler(this.btAddEpisodio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAddTemporada);
            this.groupBox2.Controls.Add(this.listViewTemporadas);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temporadas";
            // 
            // btAddTemporada
            // 
            this.btAddTemporada.Location = new System.Drawing.Point(401, 0);
            this.btAddTemporada.Name = "btAddTemporada";
            this.btAddTemporada.Size = new System.Drawing.Size(99, 23);
            this.btAddTemporada.TabIndex = 8;
            this.btAddTemporada.Text = "Nova Temporada";
            this.btAddTemporada.UseVisualStyleBackColor = true;
            this.btAddTemporada.Click += new System.EventHandler(this.btAddTemporada_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAddSerie);
            this.groupBox3.Controls.Add(this.listViewSeries);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 204);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Series";
            // 
            // btAddSerie
            // 
            this.btAddSerie.Location = new System.Drawing.Point(401, 0);
            this.btAddSerie.Name = "btAddSerie";
            this.btAddSerie.Size = new System.Drawing.Size(99, 23);
            this.btAddSerie.TabIndex = 8;
            this.btAddSerie.Text = "Nova Serie";
            this.btAddSerie.UseVisualStyleBackColor = true;
            this.btAddSerie.Click += new System.EventHandler(this.btAddSerie_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(88, 67);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(166, 21);
            this.cbCategorias.TabIndex = 6;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoria";
            // 
            // SeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbForm);
            this.Name = "SeriesForm";
            this.Text = "Series";
            this.Load += new System.EventHandler(this.SeriesForm_Load);
            this.gbForm.ResumeLayout(false);
            this.tabForms.ResumeLayout(false);
            this.tabPageSerie.ResumeLayout(false);
            this.tabPageSerie.PerformLayout();
            this.tabPageTemporada.ResumeLayout(false);
            this.tabPageTemporada.PerformLayout();
            this.tabPageEpisodio.ResumeLayout(false);
            this.tabPageEpisodio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSeries;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ListView listViewTemporadas;
        private System.Windows.Forms.ColumnHeader Temporada;
        private System.Windows.Forms.ListView listViewEpisodios;
        private System.Windows.Forms.ColumnHeader Episodio;
        private System.Windows.Forms.ColumnHeader Sinopse;
        private System.Windows.Forms.ColumnHeader SerieId;
        private System.Windows.Forms.ColumnHeader TempotradaId;
        private System.Windows.Forms.ColumnHeader EpisodioId;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.TabPage tabPageSerie;
        private System.Windows.Forms.TextBox tbSinopseSerie;
        private System.Windows.Forms.Label lbSinopse;
        private System.Windows.Forms.TextBox tbAnoSerie;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label lbSerie;
        private System.Windows.Forms.TabPage tabPageTemporada;
        private System.Windows.Forms.TextBox tbSequencialTemporada;
        private System.Windows.Forms.Label lbSequencial;
        private System.Windows.Forms.TabPage tabPageEpisodio;
        private System.Windows.Forms.TextBox tbSinopseEpisodio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSequencialEpisodio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEpisodio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddEpisodio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddTemporada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategorias;
    }
}