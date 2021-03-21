namespace ProjetoProway.forms.paginas
{
    partial class FilmesForm
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
            this.listViewFilmes = new System.Windows.Forms.ListView();
            this.FilmeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilmeId,
            this.Nome,
            this.Ano,
            this.Categoria});
            this.listViewFilmes.HideSelection = false;
            this.listViewFilmes.Location = new System.Drawing.Point(12, 12);
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(500, 200);
            this.listViewFilmes.TabIndex = 3;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.SelectedIndexChanged += new System.EventHandler(this.listViewSeries_SelectedIndexChanged);
            this.listViewFilmes.DoubleClick += new System.EventHandler(this.listViewFilmes_DoubleClick);
            // 
            // FilmeId
            // 
            this.FilmeId.DisplayIndex = 3;
            this.FilmeId.Text = "Id";
            this.FilmeId.Width = 0;
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
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.listViewFilmes);
            this.Name = "FilmesForm";
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.FilmesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ColumnHeader FilmeId;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Categoria;
    }
}