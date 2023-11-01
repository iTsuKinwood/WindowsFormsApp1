namespace WindowsFormsApp1
{
    partial class Form2
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
            this.acesso = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Label();
            this.textus = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acesso
            // 
            this.acesso.Location = new System.Drawing.Point(88, 73);
            this.acesso.Name = "acesso";
            this.acesso.Size = new System.Drawing.Size(75, 23);
            this.acesso.TabIndex = 0;
            this.acesso.Text = "Acesso";
            this.acesso.UseVisualStyleBackColor = true;
            this.acesso.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(26, 24);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuário";
            this.usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textus
            // 
            this.textus.Location = new System.Drawing.Point(75, 21);
            this.textus.Name = "textus";
            this.textus.Size = new System.Drawing.Size(100, 20);
            this.textus.TabIndex = 2;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(75, 47);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(31, 46);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(38, 13);
            this.senha.TabIndex = 4;
            this.senha.Text = "Senha";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 141);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.textus);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.acesso);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acesso;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox textus;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label senha;
    }
}