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
            panel1 = new Panel();
            txtCadastrarUsuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnCadastrar = new Button();
            txtCadastrarSenha = new TextBox();
            label4 = new Label();
            txtCadastrarEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtCadastrarUsuario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
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
            panel1.Size = new Size(505, 460);
            panel1.TabIndex = 5;
            // 
            // txtCadastrarUsuario
            // 
            txtCadastrarUsuario.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            txtCadastrarUsuario.ForeColor = Color.DimGray;
            txtCadastrarUsuario.Location = new Point(29, 150);
            txtCadastrarUsuario.Name = "txtCadastrarUsuario";
            txtCadastrarUsuario.Size = new Size(444, 22);
            txtCadastrarUsuario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(29, 115);
            label6.Name = "label6";
            label6.Size = new Size(112, 17);
            label6.TabIndex = 9;
            label6.Text = "Nome de Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(171, 370);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 8;
            label5.Text = "Mensagem de erro/validação";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkMagenta;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(29, 310);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(444, 43);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCadastrarSenha
            // 
            txtCadastrarSenha.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            txtCadastrarSenha.ForeColor = Color.DimGray;
            txtCadastrarSenha.Location = new Point(29, 260);
            txtCadastrarSenha.Name = "txtCadastrarSenha";
            txtCadastrarSenha.PasswordChar = '*';
            txtCadastrarSenha.Size = new Size(444, 22);
            txtCadastrarSenha.TabIndex = 6;
            txtCadastrarSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(29, 230);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // txtCadastrarEmail
            // 
            txtCadastrarEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            txtCadastrarEmail.ForeColor = Color.DimGray;
            txtCadastrarEmail.Location = new Point(29, 205);
            txtCadastrarEmail.Name = "txtCadastrarEmail";
            txtCadastrarEmail.Size = new Size(444, 22);
            txtCadastrarEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(29, 175);
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
            label1.Location = new Point(124, 34);
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
            label2.Location = new Point(171, 71);
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
            ClientSize = new Size(563, 524);
            Controls.Add(panel1);
            Name = "F_Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Cadastro";
            Load += F_Cadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btnCadastrar;
        private TextBox txtCadastrarSenha;
        private Label label4;
        private TextBox txtCadastrarEmail;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtCadastrarUsuario;
        private Label label6;
    }
}