namespace ProjetoProway.forms.paginas
{
    partial class LoginForm
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbErro = new System.Windows.Forms.Label();
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCadastroLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCadastroEmail = new System.Windows.Forms.TextBox();
            this.tbCadastroSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCadastroSenha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCadastroNome = new System.Windows.Forms.TextBox();
            this.tabLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(93, 17);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(93, 111);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(239, 25);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(95, 33);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(237, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(95, 85);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(237, 20);
            this.tbSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(93, 69);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.ForeColor = System.Drawing.Color.Crimson;
            this.lbErro.Location = new System.Drawing.Point(13, 264);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(95, 13);
            this.lbErro.TabIndex = 13;
            this.lbErro.Text = "Mensagem de erro";
            this.lbErro.Visible = false;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabPage1);
            this.tabLogin.Controls.Add(this.tabPage2);
            this.tabLogin.Location = new System.Drawing.Point(12, 12);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(467, 249);
            this.tabLogin.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btEntrar);
            this.tabPage1.Controls.Add(this.lbLogin);
            this.tabPage1.Controls.Add(this.tbSenha);
            this.tabPage1.Controls.Add(this.tbLogin);
            this.tabPage1.Controls.Add(this.lbSenha);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbCadastroLogin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbCadastroEmail);
            this.tabPage2.Controls.Add(this.tbCadastroSenha);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbCadastroSenha2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btCadastrar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbCadastroNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Login";
            // 
            // tbCadastroLogin
            // 
            this.tbCadastroLogin.Location = new System.Drawing.Point(94, 71);
            this.tbCadastroLogin.Name = "tbCadastroLogin";
            this.tbCadastroLogin.Size = new System.Drawing.Size(237, 20);
            this.tbCadastroLogin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // tbCadastroEmail
            // 
            this.tbCadastroEmail.Location = new System.Drawing.Point(231, 25);
            this.tbCadastroEmail.Name = "tbCadastroEmail";
            this.tbCadastroEmail.Size = new System.Drawing.Size(215, 20);
            this.tbCadastroEmail.TabIndex = 8;
            // 
            // tbCadastroSenha
            // 
            this.tbCadastroSenha.Location = new System.Drawing.Point(94, 110);
            this.tbCadastroSenha.Name = "tbCadastroSenha";
            this.tbCadastroSenha.PasswordChar = '*';
            this.tbCadastroSenha.Size = new System.Drawing.Size(237, 20);
            this.tbCadastroSenha.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // tbCadastroSenha2
            // 
            this.tbCadastroSenha2.Location = new System.Drawing.Point(94, 149);
            this.tbCadastroSenha2.Name = "tbCadastroSenha2";
            this.tbCadastroSenha2.PasswordChar = '*';
            this.tbCadastroSenha2.Size = new System.Drawing.Size(237, 20);
            this.tbCadastroSenha2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirmar Senha";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(93, 175);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(239, 25);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // tbCadastroNome
            // 
            this.tbCadastroNome.Location = new System.Drawing.Point(6, 25);
            this.tbCadastroNome.Name = "tbCadastroNome";
            this.tbCadastroNome.Size = new System.Drawing.Size(215, 20);
            this.tbCadastroNome.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 286);
            this.ControlBox = false;
            this.Controls.Add(this.tabLogin);
            this.Controls.Add(this.lbErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "LoginForm";
            this.Text = "Segurança";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCadastroNome;
        private System.Windows.Forms.TextBox tbCadastroSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCadastroSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCadastroLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCadastroEmail;
    }
}