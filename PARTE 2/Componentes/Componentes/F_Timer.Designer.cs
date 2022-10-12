namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.img_goku = new System.Windows.Forms.PictureBox();
            this.timer_goku = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_goku)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(94, 11);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "Parar";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar_t1
            // 
            this.btn_reiniciar_t1.Location = new System.Drawing.Point(176, 11);
            this.btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            this.btn_reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar_t1.TabIndex = 3;
            this.btn_reiniciar_t1.Text = "Reiniciar";
            this.btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_reiniciar_t1.Click += new System.EventHandler(this.btn_reiniciar_t1_Click);
            // 
            // img_goku
            // 
            this.img_goku.Image = ((System.Drawing.Image)(resources.GetObject("img_goku.Image")));
            this.img_goku.Location = new System.Drawing.Point(15, 104);
            this.img_goku.Name = "img_goku";
            this.img_goku.Size = new System.Drawing.Size(100, 50);
            this.img_goku.TabIndex = 4;
            this.img_goku.TabStop = false;
            // 
            // timer_goku
            // 
            this.timer_goku.Interval = 500;
            this.timer_goku.Tick += new System.EventHandler(this.timer_goku_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Parar Foguete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img_goku);
            this.Controls.Add(this.btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_goku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar_t1;
        private System.Windows.Forms.PictureBox img_goku;
        private System.Windows.Forms.Timer timer_goku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}