namespace Componentes
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbn_remover = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.Obter = new System.Windows.Forms.Button();
            this.tb_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(120, 225);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(138, 45);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 20);
            this.tb_carro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carro";
            // 
            // tbn_remover
            // 
            this.tbn_remover.Location = new System.Drawing.Point(142, 73);
            this.tbn_remover.Name = "tbn_remover";
            this.tbn_remover.Size = new System.Drawing.Size(96, 23);
            this.tbn_remover.TabIndex = 3;
            this.tbn_remover.Text = "Adicionar";
            this.tbn_remover.UseVisualStyleBackColor = true;
            this.tbn_remover.Click += new System.EventHandler(this.tbn_remover_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(142, 102);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(96, 23);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // Obter
            // 
            this.Obter.Location = new System.Drawing.Point(142, 131);
            this.Obter.Name = "Obter";
            this.Obter.Size = new System.Drawing.Size(96, 23);
            this.Obter.TabIndex = 5;
            this.Obter.Text = "Obter";
            this.Obter.UseVisualStyleBackColor = true;
            this.Obter.Click += new System.EventHandler(this.Obter_Click);
            // 
            // tb_limpar
            // 
            this.tb_limpar.Location = new System.Drawing.Point(142, 161);
            this.tb_limpar.Name = "tb_limpar";
            this.tb_limpar.Size = new System.Drawing.Size(96, 23);
            this.tb_limpar.TabIndex = 6;
            this.tb_limpar.Text = "Limpar";
            this.tb_limpar.UseVisualStyleBackColor = true;
            this.tb_limpar.Click += new System.EventHandler(this.tb_limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.tb_limpar);
            this.Controls.Add(this.Obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.tbn_remover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbn_remover;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button Obter;
        private System.Windows.Forms.Button tb_limpar;
    }
}