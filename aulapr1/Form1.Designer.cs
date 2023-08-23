namespace aulapr1
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcsenha = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbcsenha = new System.Windows.Forms.TextBox();
            this.txbname = new System.Windows.Forms.TextBox();
            this.btncadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(296, 127);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblemail.Location = new System.Drawing.Point(295, 230);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 16);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "E-mail:";
            // 
            // lblcsenha
            // 
            this.lblcsenha.AutoSize = true;
            this.lblcsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblcsenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcsenha.Location = new System.Drawing.Point(296, 330);
            this.lblcsenha.Name = "lblcsenha";
            this.lblcsenha.Size = new System.Drawing.Size(107, 16);
            this.lblcsenha.TabIndex = 2;
            this.lblcsenha.Text = "Confirmar senha:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusuario.Location = new System.Drawing.Point(296, 179);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(54, 16);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsenha.Location = new System.Drawing.Point(296, 281);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(49, 16);
            this.lblsenha.TabIndex = 4;
            this.lblsenha.Text = "Senha:";
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(299, 300);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(256, 22);
            this.txbsenha.TabIndex = 5;
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(299, 198);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(256, 22);
            this.txbuser.TabIndex = 6;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(299, 249);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(256, 22);
            this.txbemail.TabIndex = 7;
            // 
            // txbcsenha
            // 
            this.txbcsenha.Location = new System.Drawing.Point(299, 349);
            this.txbcsenha.Name = "txbcsenha";
            this.txbcsenha.PasswordChar = '*';
            this.txbcsenha.Size = new System.Drawing.Size(256, 22);
            this.txbcsenha.TabIndex = 8;
            this.txbcsenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(299, 146);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(256, 22);
            this.txbname.TabIndex = 9;
            this.txbname.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(377, 377);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(108, 23);
            this.btncadastro.TabIndex = 10;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::aulapr1.Properties.Resources.Infinity_Cifra__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 479);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aulapr1.Properties.Resources.Infinity_Cifra__1_;
            this.ClientSize = new System.Drawing.Size(851, 479);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.txbcsenha);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.txbuser);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcsenha;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbcsenha;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

