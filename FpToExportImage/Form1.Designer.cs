namespace FpToExportImage
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
            this.btn_capturar = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_gerate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ptb_fp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(349, 12);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(138, 47);
            this.btn_capturar.TabIndex = 0;
            this.btn_capturar.Text = "Capturar";
            this.btn_capturar.UseVisualStyleBackColor = true;
            this.btn_capturar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(349, 363);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Salvar Imagem";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(193, 392);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(446, 140);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // btn_gerate
            // 
            this.btn_gerate.Location = new System.Drawing.Point(334, 538);
            this.btn_gerate.Name = "btn_gerate";
            this.btn_gerate.Size = new System.Drawing.Size(119, 23);
            this.btn_gerate.TabIndex = 5;
            this.btn_gerate.Text = "Gerar Imagem";
            this.btn_gerate.UseVisualStyleBackColor = true;
            this.btn_gerate.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 47);
            this.button3.TabIndex = 0;
            this.button3.Text = "Capturar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ptb_fp
            // 
            this.ptb_fp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ptb_fp.Location = new System.Drawing.Point(295, 65);
            this.ptb_fp.Name = "ptb_fp";
            this.ptb_fp.Size = new System.Drawing.Size(248, 292);
            this.ptb_fp.TabIndex = 1;
            this.ptb_fp.TabStop = false;
            this.ptb_fp.Click += new System.EventHandler(this.Ptb_fp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_gerate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.ptb_fp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_capturar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_gerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox ptb_fp;
    }
}

