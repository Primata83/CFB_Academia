namespace CFB_Academia
{
    partial class F_Login
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
            this.UserName = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.Logar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(12, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(55, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(3, 25);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(164, 20);
            this.tb_userName.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(15, 52);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(3, 68);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(164, 20);
            this.tb_senha.TabIndex = 3;
            // 
            // Logar
            // 
            this.Logar.Location = new System.Drawing.Point(3, 95);
            this.Logar.Name = "Logar";
            this.Logar.Size = new System.Drawing.Size(164, 23);
            this.Logar.TabIndex = 4;
            this.Logar.Text = "Logar";
            this.Logar.UseVisualStyleBackColor = true;
            this.Logar.Click += new System.EventHandler(this.Logar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(3, 124);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(164, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 182);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Logar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.UserName);
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button Logar;
        private System.Windows.Forms.Button Cancelar;
    }
}