namespace AdamAsmacaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incorrect1 = new System.Windows.Forms.PictureBox();
            this.incorrect2 = new System.Windows.Forms.PictureBox();
            this.incorrect3 = new System.Windows.Forms.PictureBox();
            this.incorrect4 = new System.Windows.Forms.PictureBox();
            this.incorrect5 = new System.Windows.Forms.Label();
            this.incorrect6 = new System.Windows.Forms.PictureBox();
            this.incorrect7 = new System.Windows.Forms.PictureBox();
            this.incorrect8 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(478, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 492);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // incorrect1
            // 
            this.incorrect1.BackColor = System.Drawing.Color.Black;
            this.incorrect1.Location = new System.Drawing.Point(510, 466);
            this.incorrect1.Name = "incorrect1";
            this.incorrect1.Size = new System.Drawing.Size(136, 20);
            this.incorrect1.TabIndex = 1;
            this.incorrect1.TabStop = false;
            // 
            // incorrect2
            // 
            this.incorrect2.BackColor = System.Drawing.Color.Black;
            this.incorrect2.Location = new System.Drawing.Point(543, 66);
            this.incorrect2.Name = "incorrect2";
            this.incorrect2.Size = new System.Drawing.Size(20, 400);
            this.incorrect2.TabIndex = 2;
            this.incorrect2.TabStop = false;
            // 
            // incorrect3
            // 
            this.incorrect3.BackColor = System.Drawing.Color.Black;
            this.incorrect3.Location = new System.Drawing.Point(562, 66);
            this.incorrect3.Name = "incorrect3";
            this.incorrect3.Size = new System.Drawing.Size(159, 20);
            this.incorrect3.TabIndex = 3;
            this.incorrect3.TabStop = false;
            // 
            // incorrect4
            // 
            this.incorrect4.BackColor = System.Drawing.Color.Black;
            this.incorrect4.Location = new System.Drawing.Point(701, 85);
            this.incorrect4.Name = "incorrect4";
            this.incorrect4.Size = new System.Drawing.Size(20, 33);
            this.incorrect4.TabIndex = 4;
            this.incorrect4.TabStop = false;
            // 
            // incorrect5
            // 
            this.incorrect5.AutoSize = true;
            this.incorrect5.BackColor = System.Drawing.Color.White;
            this.incorrect5.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.incorrect5.Location = new System.Drawing.Point(632, 90);
            this.incorrect5.Name = "incorrect5";
            this.incorrect5.Size = new System.Drawing.Size(169, 153);
            this.incorrect5.TabIndex = 5;
            this.incorrect5.Text = "O";
            // 
            // incorrect6
            // 
            this.incorrect6.BackColor = System.Drawing.Color.Black;
            this.incorrect6.Location = new System.Drawing.Point(700, 214);
            this.incorrect6.Name = "incorrect6";
            this.incorrect6.Size = new System.Drawing.Size(20, 138);
            this.incorrect6.TabIndex = 6;
            this.incorrect6.TabStop = false;
            // 
            // incorrect7
            // 
            this.incorrect7.Image = ((System.Drawing.Image)(resources.GetObject("incorrect7.Image")));
            this.incorrect7.Location = new System.Drawing.Point(628, 214);
            this.incorrect7.Name = "incorrect7";
            this.incorrect7.Size = new System.Drawing.Size(164, 98);
            this.incorrect7.TabIndex = 7;
            this.incorrect7.TabStop = false;
            // 
            // incorrect8
            // 
            this.incorrect8.Image = ((System.Drawing.Image)(resources.GetObject("incorrect8.Image")));
            this.incorrect8.Location = new System.Drawing.Point(628, 347);
            this.incorrect8.Name = "incorrect8";
            this.incorrect8.Size = new System.Drawing.Size(164, 72);
            this.incorrect8.TabIndex = 8;
            this.incorrect8.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yeni Oyun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.YeniOyun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Skor : ";
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor.Location = new System.Drawing.Point(299, 17);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(18, 20);
            this.skor.TabIndex = 11;
            this.skor.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 438);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 516);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incorrect8);
            this.Controls.Add(this.incorrect6);
            this.Controls.Add(this.incorrect4);
            this.Controls.Add(this.incorrect3);
            this.Controls.Add(this.incorrect2);
            this.Controls.Add(this.incorrect1);
            this.Controls.Add(this.incorrect5);
            this.Controls.Add(this.incorrect7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Adam Asmaca Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorrect8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox incorrect1;
        private System.Windows.Forms.PictureBox incorrect2;
        private System.Windows.Forms.PictureBox incorrect3;
        private System.Windows.Forms.PictureBox incorrect4;
        private System.Windows.Forms.Label incorrect5;
        private System.Windows.Forms.PictureBox incorrect6;
        private System.Windows.Forms.PictureBox incorrect7;
        private System.Windows.Forms.PictureBox incorrect8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

