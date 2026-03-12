namespace SistenaLogin
{
    partial class F_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnCadastre = new Button();
            label5 = new Label();
            btnLogin = new Button();
            txtSenha = new TextBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(161, 144);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(192, 181);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 2;
            label2.Text = "Autenticação de Usuários";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(20, 236);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 3;
            label3.Text = "Usuário";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCadastre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(26, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 519);
            panel1.TabIndex = 4;
            // 
            // btnCadastre
            // 
            btnCadastre.BackColor = Color.DarkMagenta;
            btnCadastre.FlatStyle = FlatStyle.Popup;
            btnCadastre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastre.ForeColor = Color.Transparent;
            btnCadastre.Location = new Point(20, 411);
            btnCadastre.Name = "btnCadastre";
            btnCadastre.Size = new Size(507, 43);
            btnCadastre.TabIndex = 9;
            btnCadastre.Text = "Cadastre-se";
            btnCadastre.UseVisualStyleBackColor = false;
            btnCadastre.Click += btnCadastre_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(190, 469);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 8;
            label5.Text = "Mensagem de erro/validação";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkMagenta;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(20, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(507, 43);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            txtSenha.ForeColor = Color.DimGray;
            txtSenha.Location = new Point(20, 314);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(507, 22);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(20, 290);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(20, 260);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(507, 22);
            txtUsuario.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(600, 573);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox txtSenha;
        private Label label4;
        private TextBox txtUsuario;
        private Label label5;
        private Button btnLogin;
        private Button btnCadastre;
    }
}
