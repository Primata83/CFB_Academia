namespace Componentes
{
    partial class F_TabControl
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
            this.tb_nomeNovaTab = new System.Windows.Forms.TextBox();
            this.btn_novaTab = new System.Windows.Forms.Button();
            this.btn_removerTabAtual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_componentes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nomeNovaTab
            // 
            this.tb_nomeNovaTab.Location = new System.Drawing.Point(12, 13);
            this.tb_nomeNovaTab.Name = "tb_nomeNovaTab";
            this.tb_nomeNovaTab.Size = new System.Drawing.Size(196, 20);
            this.tb_nomeNovaTab.TabIndex = 1;
            // 
            // btn_novaTab
            // 
            this.btn_novaTab.Location = new System.Drawing.Point(215, 9);
            this.btn_novaTab.Name = "btn_novaTab";
            this.btn_novaTab.Size = new System.Drawing.Size(181, 23);
            this.btn_novaTab.TabIndex = 2;
            this.btn_novaTab.Text = "Nova Tab";
            this.btn_novaTab.UseVisualStyleBackColor = true;
            this.btn_novaTab.Click += new System.EventHandler(this.btn_novaTab_Click);
            // 
            // btn_removerTabAtual
            // 
            this.btn_removerTabAtual.Location = new System.Drawing.Point(403, 9);
            this.btn_removerTabAtual.Name = "btn_removerTabAtual";
            this.btn_removerTabAtual.Size = new System.Drawing.Size(187, 23);
            this.btn_removerTabAtual.TabIndex = 3;
            this.btn_removerTabAtual.Text = "Remover Tab Atual";
            this.btn_removerTabAtual.UseVisualStyleBackColor = true;
            this.btn_removerTabAtual.Click += new System.EventHandler(this.btn_removerTabAtual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(192, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.Location = new System.Drawing.Point(215, 36);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(181, 23);
            this.btn_posicionarTab.TabIndex = 5;
            this.btn_posicionarTab.Text = "Posicionar na Tab";
            this.btn_posicionarTab.UseVisualStyleBackColor = true;
            this.btn_posicionarTab.Click += new System.EventHandler(this.btn_posicionarTab_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 372);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_componentes
            // 
            this.tab_componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_componentes.Name = "tab_componentes";
            this.tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_componentes.Size = new System.Drawing.Size(764, 346);
            this.tab_componentes.TabIndex = 0;
            this.tab_componentes.Text = "Componentes";
            this.tab_componentes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTabAtual);
            this.Controls.Add(this.btn_novaTab);
            this.Controls.Add(this.tb_nomeNovaTab);
            this.Name = "F_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nomeNovaTab;
        private System.Windows.Forms.Button btn_novaTab;
        private System.Windows.Forms.Button btn_removerTabAtual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionarTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_componentes;
        private System.Windows.Forms.TabPage tabPage2;
    }
}