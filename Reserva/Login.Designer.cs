namespace Reserva
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbLogin = new System.Windows.Forms.Label();
            this.LbSenha = new System.Windows.Forms.Label();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.CadUser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEntrar.Location = new System.Drawing.Point(130, 300);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(85, 25);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LbLogin.Location = new System.Drawing.Point(75, 180);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(43, 17);
            this.LbLogin.TabIndex = 2;
            this.LbLogin.Text = "Login";
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LbSenha.Location = new System.Drawing.Point(75, 240);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(49, 17);
            this.LbSenha.TabIndex = 3;
            this.LbSenha.Text = "Senha";
            // 
            // TbUsuario
            // 
            this.TbUsuario.AccessibleDescription = "";
            this.TbUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TbUsuario.Location = new System.Drawing.Point(75, 200);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(200, 20);
            this.TbUsuario.TabIndex = 7;
            // 
            // TbSenha
            // 
            this.TbSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TbSenha.Location = new System.Drawing.Point(75, 260);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.PasswordChar = '*';
            this.TbSenha.Size = new System.Drawing.Size(200, 20);
            this.TbSenha.TabIndex = 8;
            // 
            // CadUser
            // 
            this.CadUser.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CadUser.AutoSize = true;
            this.CadUser.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CadUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CadUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CadUser.Location = new System.Drawing.Point(127, 340);
            this.CadUser.Name = "CadUser";
            this.CadUser.Size = new System.Drawing.Size(88, 13);
            this.CadUser.TabIndex = 9;
            this.CadUser.TabStop = true;
            this.CadUser.Text = "Cadastro Usuario";
            this.CadUser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CadUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadUser_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.BtnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.CadUser);
            this.Controls.Add(this.TbSenha);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.TextBox TbSenha;
        private System.Windows.Forms.LinkLabel CadUser;
    }
}

