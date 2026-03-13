namespace SistenaLogin
{
    partial class F_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cadastro));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtCadastrarUsuario = new TextBox();
            label6 = new Label();
            btnCadastrar = new Button();
            txtCadastrarSenha = new TextBox();
            label4 = new Label();
            txtCadastrarEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtCadastrarUsuario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtCadastrarSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCadastrarEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(29, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 521);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtCadastrarUsuario
            // 
            txtCadastrarUsuario.BackColor = Color.FromArgb(40, 40, 55);
            txtCadastrarUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtCadastrarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtCadastrarUsuario.ForeColor = Color.FromArgb(200, 200, 210);
            txtCadastrarUsuario.Location = new Point(26, 273);
            txtCadastrarUsuario.Name = "txtCadastrarUsuario";
            txtCadastrarUsuario.PlaceholderText = "seu.usuario";
            txtCadastrarUsuario.Size = new Size(346, 25);
            txtCadastrarUsuario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(26, 253);
            label6.Name = "label6";
            label6.Size = new Size(112, 17);
            label6.TabIndex = 9;
            label6.Text = "Nome de Usuário";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkMagenta;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(26, 447);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(346, 43);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCadastrarSenha
            // 
            txtCadastrarSenha.BackColor = Color.FromArgb(40, 40, 55);
            txtCadastrarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtCadastrarSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtCadastrarSenha.ForeColor = Color.FromArgb(200, 200, 210);
            txtCadastrarSenha.Location = new Point(26, 387);
            txtCadastrarSenha.Name = "txtCadastrarSenha";
            txtCadastrarSenha.PasswordChar = '*';
            txtCadastrarSenha.PlaceholderText = "Crie uma senha...";
            txtCadastrarSenha.Size = new Size(346, 25);
            txtCadastrarSenha.TabIndex = 6;
            txtCadastrarSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(26, 367);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // txtCadastrarEmail
            // 
            txtCadastrarEmail.BackColor = Color.FromArgb(40, 40, 55);
            txtCadastrarEmail.BorderStyle = BorderStyle.FixedSingle;
            txtCadastrarEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            txtCadastrarEmail.ForeColor = Color.FromArgb(200, 200, 210);
            txtCadastrarEmail.Location = new Point(26, 328);
            txtCadastrarEmail.Name = "txtCadastrarEmail";
            txtCadastrarEmail.PlaceholderText = "usuario@email.com";
            txtCadastrarEmail.Size = new Size(346, 25);
            txtCadastrarEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(26, 308);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(74, 149);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(111, 186);
            label2.Name = "label2";
            label2.Size = new Size(177, 17);
            label2.TabIndex = 2;
            label2.Text = "Cadastro de Novos Usuários";
            // 
            // F_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(455, 573);
            Controls.Add(panel1);
            Name = "F_Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Cadastro";
            Load += F_Cadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCadastrar;
        private TextBox txtCadastrarSenha;
        private Label label4;
        private TextBox txtCadastrarEmail;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtCadastrarUsuario;
        private Label label6;
        private PictureBox pictureBox1;
    }
}