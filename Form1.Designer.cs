namespace Matematik
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnbuyuk = new System.Windows.Forms.Button();
            this.btntoplam = new System.Windows.Forms.Button();
            this.btnkucuk = new System.Windows.Forms.Button();
            this.btncift = new System.Windows.Forms.Button();
            this.btntek = new System.Windows.Forms.Button();
            this.btnort = new System.Windows.Forms.Button();
            this.listtek = new System.Windows.Forms.ListBox();
            this.listcift = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblort = new System.Windows.Forms.Label();
            this.lblkck = new System.Windows.Forms.Label();
            this.lblbyk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.listngtf = new System.Windows.Forms.ListBox();
            this.listpztf = new System.Windows.Forms.ListBox();
            this.btnngtf = new System.Windows.Forms.Button();
            this.btnpztf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.IndianRed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Transparent;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(192, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 304);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.IndianRed;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(12, 53);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 49);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnbuyuk
            // 
            this.btnbuyuk.BackColor = System.Drawing.Color.IndianRed;
            this.btnbuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbuyuk.Location = new System.Drawing.Point(12, 108);
            this.btnbuyuk.Name = "btnbuyuk";
            this.btnbuyuk.Size = new System.Drawing.Size(174, 49);
            this.btnbuyuk.TabIndex = 3;
            this.btnbuyuk.Text = "EN BÜYÜK";
            this.btnbuyuk.UseVisualStyleBackColor = false;
            this.btnbuyuk.Click += new System.EventHandler(this.btnbuyuk_Click);
            // 
            // btntoplam
            // 
            this.btntoplam.BackColor = System.Drawing.Color.IndianRed;
            this.btntoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoplam.Location = new System.Drawing.Point(12, 218);
            this.btntoplam.Name = "btntoplam";
            this.btntoplam.Size = new System.Drawing.Size(174, 49);
            this.btntoplam.TabIndex = 5;
            this.btntoplam.Text = "TOPLAM";
            this.btntoplam.UseVisualStyleBackColor = false;
            this.btntoplam.Click += new System.EventHandler(this.btntoplam_Click);
            // 
            // btnkucuk
            // 
            this.btnkucuk.BackColor = System.Drawing.Color.IndianRed;
            this.btnkucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkucuk.Location = new System.Drawing.Point(12, 163);
            this.btnkucuk.Name = "btnkucuk";
            this.btnkucuk.Size = new System.Drawing.Size(174, 49);
            this.btnkucuk.TabIndex = 4;
            this.btnkucuk.Text = "EN KÜÇÜK";
            this.btnkucuk.UseVisualStyleBackColor = false;
            this.btnkucuk.Click += new System.EventHandler(this.btnkucuk_Click);
            // 
            // btncift
            // 
            this.btncift.BackColor = System.Drawing.Color.IndianRed;
            this.btncift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncift.Location = new System.Drawing.Point(12, 380);
            this.btncift.Name = "btncift";
            this.btncift.Size = new System.Drawing.Size(174, 49);
            this.btncift.TabIndex = 8;
            this.btncift.Text = "ÇİFT";
            this.btncift.UseVisualStyleBackColor = false;
            this.btncift.Click += new System.EventHandler(this.btncift_Click);
            // 
            // btntek
            // 
            this.btntek.BackColor = System.Drawing.Color.IndianRed;
            this.btntek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntek.Location = new System.Drawing.Point(12, 325);
            this.btntek.Name = "btntek";
            this.btntek.Size = new System.Drawing.Size(174, 49);
            this.btntek.TabIndex = 7;
            this.btntek.Text = "TEK";
            this.btntek.UseVisualStyleBackColor = false;
            this.btntek.Click += new System.EventHandler(this.btntek_Click);
            // 
            // btnort
            // 
            this.btnort.BackColor = System.Drawing.Color.IndianRed;
            this.btnort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnort.Location = new System.Drawing.Point(12, 270);
            this.btnort.Name = "btnort";
            this.btnort.Size = new System.Drawing.Size(174, 49);
            this.btnort.TabIndex = 6;
            this.btnort.Text = "ORTALAMA";
            this.btnort.UseVisualStyleBackColor = false;
            this.btnort.Click += new System.EventHandler(this.btnort_Click);
            // 
            // listtek
            // 
            this.listtek.BackColor = System.Drawing.Color.IndianRed;
            this.listtek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listtek.ForeColor = System.Drawing.Color.Transparent;
            this.listtek.FormattingEnabled = true;
            this.listtek.ItemHeight = 25;
            this.listtek.Location = new System.Drawing.Point(192, 325);
            this.listtek.Name = "listtek";
            this.listtek.Size = new System.Drawing.Size(160, 104);
            this.listtek.TabIndex = 9;
            // 
            // listcift
            // 
            this.listcift.BackColor = System.Drawing.Color.IndianRed;
            this.listcift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listcift.ForeColor = System.Drawing.Color.Transparent;
            this.listcift.FormattingEnabled = true;
            this.listcift.ItemHeight = 25;
            this.listcift.Location = new System.Drawing.Point(358, 325);
            this.listcift.Name = "listcift";
            this.listcift.Size = new System.Drawing.Size(161, 104);
            this.listcift.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "En Büyük:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(339, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "En Küçük:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(339, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(339, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ortalama:";
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.BackColor = System.Drawing.Color.IndianRed;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltop.ForeColor = System.Drawing.Color.Transparent;
            this.lbltop.Location = new System.Drawing.Point(467, 218);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(0, 25);
            this.lbltop.TabIndex = 18;
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.BackColor = System.Drawing.Color.IndianRed;
            this.lblort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblort.ForeColor = System.Drawing.Color.Transparent;
            this.lblort.Location = new System.Drawing.Point(467, 273);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(0, 25);
            this.lblort.TabIndex = 17;
            // 
            // lblkck
            // 
            this.lblkck.AutoSize = true;
            this.lblkck.BackColor = System.Drawing.Color.IndianRed;
            this.lblkck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkck.ForeColor = System.Drawing.Color.Transparent;
            this.lblkck.Location = new System.Drawing.Point(467, 163);
            this.lblkck.Name = "lblkck";
            this.lblkck.Size = new System.Drawing.Size(0, 25);
            this.lblkck.TabIndex = 16;
            // 
            // lblbyk
            // 
            this.lblbyk.AutoSize = true;
            this.lblbyk.BackColor = System.Drawing.Color.IndianRed;
            this.lblbyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbyk.ForeColor = System.Drawing.Color.Transparent;
            this.lblbyk.Location = new System.Drawing.Point(467, 108);
            this.lblbyk.Name = "lblbyk";
            this.lblbyk.Size = new System.Drawing.Size(0, 25);
            this.lblbyk.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(320, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Formüllere Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.IndianRed;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(106, 53);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(80, 49);
            this.btnsil.TabIndex = 20;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // listngtf
            // 
            this.listngtf.BackColor = System.Drawing.Color.IndianRed;
            this.listngtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listngtf.ForeColor = System.Drawing.Color.Transparent;
            this.listngtf.FormattingEnabled = true;
            this.listngtf.ItemHeight = 25;
            this.listngtf.Location = new System.Drawing.Point(358, 435);
            this.listngtf.Name = "listngtf";
            this.listngtf.Size = new System.Drawing.Size(161, 104);
            this.listngtf.TabIndex = 24;
            // 
            // listpztf
            // 
            this.listpztf.BackColor = System.Drawing.Color.IndianRed;
            this.listpztf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listpztf.ForeColor = System.Drawing.Color.Transparent;
            this.listpztf.FormattingEnabled = true;
            this.listpztf.ItemHeight = 25;
            this.listpztf.Location = new System.Drawing.Point(192, 435);
            this.listpztf.Name = "listpztf";
            this.listpztf.Size = new System.Drawing.Size(160, 104);
            this.listpztf.TabIndex = 23;
            // 
            // btnngtf
            // 
            this.btnngtf.BackColor = System.Drawing.Color.IndianRed;
            this.btnngtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnngtf.Location = new System.Drawing.Point(12, 490);
            this.btnngtf.Name = "btnngtf";
            this.btnngtf.Size = new System.Drawing.Size(174, 49);
            this.btnngtf.TabIndex = 22;
            this.btnngtf.Text = "NEGATİF";
            this.btnngtf.UseVisualStyleBackColor = false;
            this.btnngtf.Click += new System.EventHandler(this.btnngtf_Click);
            // 
            // btnpztf
            // 
            this.btnpztf.BackColor = System.Drawing.Color.IndianRed;
            this.btnpztf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpztf.Location = new System.Drawing.Point(12, 435);
            this.btnpztf.Name = "btnpztf";
            this.btnpztf.Size = new System.Drawing.Size(174, 49);
            this.btnpztf.TabIndex = 21;
            this.btnpztf.Text = "POZİTİF";
            this.btnpztf.UseVisualStyleBackColor = false;
            this.btnpztf.Click += new System.EventHandler(this.btnpztf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 546);
            this.Controls.Add(this.listngtf);
            this.Controls.Add(this.listpztf);
            this.Controls.Add(this.btnngtf);
            this.Controls.Add(this.btnpztf);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lblort);
            this.Controls.Add(this.lblkck);
            this.Controls.Add(this.lblbyk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listcift);
            this.Controls.Add(this.listtek);
            this.Controls.Add(this.btncift);
            this.Controls.Add(this.btntek);
            this.Controls.Add(this.btnort);
            this.Controls.Add(this.btntoplam);
            this.Controls.Add(this.btnkucuk);
            this.Controls.Add(this.btnbuyuk);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MATEMATİK_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnbuyuk;
        private System.Windows.Forms.Button btntoplam;
        private System.Windows.Forms.Button btnkucuk;
        private System.Windows.Forms.Button btncift;
        private System.Windows.Forms.Button btntek;
        private System.Windows.Forms.Button btnort;
        private System.Windows.Forms.ListBox listtek;
        private System.Windows.Forms.ListBox listcift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.Label lblkck;
        private System.Windows.Forms.Label lblbyk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ListBox listngtf;
        private System.Windows.Forms.ListBox listpztf;
        private System.Windows.Forms.Button btnngtf;
        private System.Windows.Forms.Button btnpztf;
    }
}

