namespace ProjetoProway
{
    partial class HomeForm
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
            this.listViewSeries = new System.Windows.Forms.ListView();
            this.lbTop5Filmes = new System.Windows.Forms.Label();
            this.lbTop5Series = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.HideSelection = false;
            this.listViewFilmes.Location = new System.Drawing.Point(13, 22);
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(576, 115);
            this.listViewFilmes.TabIndex = 0;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewSeries
            // 
            this.listViewSeries.HideSelection = false;
            this.listViewSeries.Location = new System.Drawing.Point(13, 186);
            this.listViewSeries.Name = "listViewSeries";
            this.listViewSeries.Size = new System.Drawing.Size(576, 115);
            this.listViewSeries.TabIndex = 1;
            this.listViewSeries.UseCompatibleStateImageBehavior = false;
            // 
            // lbTop5Filmes
            // 
            this.lbTop5Filmes.AutoSize = true;
            this.lbTop5Filmes.Location = new System.Drawing.Point(13, 3);
            this.lbTop5Filmes.Name = "lbTop5Filmes";
            this.lbTop5Filmes.Size = new System.Drawing.Size(67, 13);
            this.lbTop5Filmes.TabIndex = 2;
            this.lbTop5Filmes.Text = "Top 5 Filmes";
            // 
            // lbTop5Series
            // 
            this.lbTop5Series.AutoSize = true;
            this.lbTop5Series.Location = new System.Drawing.Point(13, 167);
            this.lbTop5Series.Name = "lbTop5Series";
            this.lbTop5Series.Size = new System.Drawing.Size(67, 13);
            this.lbTop5Series.TabIndex = 3;
            this.lbTop5Series.Text = "Top 5 Series";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbTop5Series);
            this.Controls.Add(this.lbTop5Filmes);
            this.Controls.Add(this.listViewSeries);
            this.Controls.Add(this.listViewFilmes);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ListView listViewSeries;
        private System.Windows.Forms.Label lbTop5Filmes;
        private System.Windows.Forms.Label lbTop5Series;
    }
}