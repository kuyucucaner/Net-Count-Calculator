namespace NetCount_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.txtMatYanlis = new System.Windows.Forms.TextBox();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.txtFizDogru = new System.Windows.Forms.TextBox();
            this.txtFizYanlis = new System.Windows.Forms.TextBox();
            this.txtFizNet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fizik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-2, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Matematik";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Türkçe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(119, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(181, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(242, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "NET";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(124, 253);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(163, 35);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(124, 102);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(40, 20);
            this.txtTurkceDogru.TabIndex = 17;
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(186, 102);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(40, 20);
            this.txtTurkceYanlis.TabIndex = 18;
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Enabled = false;
            this.txtTurkceNet.Location = new System.Drawing.Point(247, 102);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.Size = new System.Drawing.Size(40, 20);
            this.txtTurkceNet.TabIndex = 19;
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(124, 157);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(40, 20);
            this.txtMatDogru.TabIndex = 20;
            // 
            // txtMatYanlis
            // 
            this.txtMatYanlis.Location = new System.Drawing.Point(186, 158);
            this.txtMatYanlis.Name = "txtMatYanlis";
            this.txtMatYanlis.Size = new System.Drawing.Size(40, 20);
            this.txtMatYanlis.TabIndex = 21;
            // 
            // txtMatNet
            // 
            this.txtMatNet.Enabled = false;
            this.txtMatNet.Location = new System.Drawing.Point(247, 157);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.Size = new System.Drawing.Size(40, 20);
            this.txtMatNet.TabIndex = 22;
            // 
            // txtFizDogru
            // 
            this.txtFizDogru.Location = new System.Drawing.Point(124, 209);
            this.txtFizDogru.Name = "txtFizDogru";
            this.txtFizDogru.Size = new System.Drawing.Size(40, 20);
            this.txtFizDogru.TabIndex = 23;
            // 
            // txtFizYanlis
            // 
            this.txtFizYanlis.Location = new System.Drawing.Point(186, 209);
            this.txtFizYanlis.Name = "txtFizYanlis";
            this.txtFizYanlis.Size = new System.Drawing.Size(40, 20);
            this.txtFizYanlis.TabIndex = 24;
            // 
            // txtFizNet
            // 
            this.txtFizNet.Enabled = false;
            this.txtFizNet.Location = new System.Drawing.Point(247, 209);
            this.txtFizNet.Name = "txtFizNet";
            this.txtFizNet.Size = new System.Drawing.Size(40, 20);
            this.txtFizNet.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(412, 341);
            this.Controls.Add(this.txtFizNet);
            this.Controls.Add(this.txtFizYanlis);
            this.Controls.Add(this.txtFizDogru);
            this.Controls.Add(this.txtMatNet);
            this.Controls.Add(this.txtMatYanlis);
            this.Controls.Add(this.txtMatDogru);
            this.Controls.Add(this.txtTurkceNet);
            this.Controls.Add(this.txtTurkceYanlis);
            this.Controls.Add(this.txtTurkceDogru);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetCount Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.TextBox txtMatYanlis;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.TextBox txtFizDogru;
        private System.Windows.Forms.TextBox txtFizYanlis;
        private System.Windows.Forms.TextBox txtFizNet;
    }
}

