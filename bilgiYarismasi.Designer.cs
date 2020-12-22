namespace WindowsFormsApp15
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.numYanlıs = new System.Windows.Forms.Label();
            this.numDogru = new System.Windows.Forms.Label();
            this.numSoru = new System.Windows.Forms.Label();
            this.lblYanlıs = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(-1, 339);
            this.btnA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(242, 41);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(278, 339);
            this.btnB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(243, 41);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(-1, 414);
            this.btnc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(242, 41);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(278, 414);
            this.btnD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(243, 41);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 339);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSonraki);
            this.panel1.Controls.Add(this.numYanlıs);
            this.panel1.Controls.Add(this.numDogru);
            this.panel1.Controls.Add(this.numSoru);
            this.panel1.Controls.Add(this.lblYanlıs);
            this.panel1.Controls.Add(this.lblDogru);
            this.panel1.Controls.Add(this.lblSoru);
            this.panel1.Location = new System.Drawing.Point(553, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 300);
            this.panel1.TabIndex = 6;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(128, 167);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(123, 33);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // numYanlıs
            // 
            this.numYanlıs.AutoSize = true;
            this.numYanlıs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numYanlıs.Location = new System.Drawing.Point(231, 122);
            this.numYanlıs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numYanlıs.Name = "numYanlıs";
            this.numYanlıs.Size = new System.Drawing.Size(20, 24);
            this.numYanlıs.TabIndex = 5;
            this.numYanlıs.Text = "0";
            // 
            // numDogru
            // 
            this.numDogru.AutoSize = true;
            this.numDogru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDogru.Location = new System.Drawing.Point(231, 83);
            this.numDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numDogru.Name = "numDogru";
            this.numDogru.Size = new System.Drawing.Size(20, 24);
            this.numDogru.TabIndex = 4;
            this.numDogru.Text = "0";
            // 
            // numSoru
            // 
            this.numSoru.AutoSize = true;
            this.numSoru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSoru.Location = new System.Drawing.Point(231, 42);
            this.numSoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numSoru.Name = "numSoru";
            this.numSoru.Size = new System.Drawing.Size(20, 24);
            this.numSoru.TabIndex = 3;
            this.numSoru.Text = "0";
            // 
            // lblYanlıs
            // 
            this.lblYanlıs.AutoSize = true;
            this.lblYanlıs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlıs.Location = new System.Drawing.Point(124, 122);
            this.lblYanlıs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYanlıs.Name = "lblYanlıs";
            this.lblYanlıs.Size = new System.Drawing.Size(69, 24);
            this.lblYanlıs.TabIndex = 2;
            this.lblYanlıs.Text = "Yanlış :";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.Location = new System.Drawing.Point(121, 83);
            this.lblDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(72, 24);
            this.lblDogru.TabIndex = 1;
            this.lblDogru.Text = "Doğru :";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(105, 42);
            this.lblSoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(88, 24);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Soru No :";
            this.lblSoru.Click += new System.EventHandler(this.lblSoru_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 339);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 300);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 503);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Label numYanlıs;
        private System.Windows.Forms.Label numDogru;
        private System.Windows.Forms.Label numSoru;
        private System.Windows.Forms.Label lblYanlıs;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

