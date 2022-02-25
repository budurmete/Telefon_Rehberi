
namespace Telefon__Rehberi
{
    partial class txt_SOYAD
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
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.txt_SOY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD: ";
            // 
            // txt_AD
            // 
            this.txt_AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AD.Location = new System.Drawing.Point(203, 122);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(163, 26);
            this.txt_AD.TabIndex = 2;
            // 
            // txt_SOY
            // 
            this.txt_SOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SOY.Location = new System.Drawing.Point(203, 168);
            this.txt_SOY.Name = "txt_SOY";
            this.txt_SOY.Size = new System.Drawing.Size(163, 26);
            this.txt_SOY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "REHBER KİŞİ KAYIT";
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kayit.Location = new System.Drawing.Point(171, 271);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(209, 47);
            this.btn_Kayit.TabIndex = 5;
            this.btn_Kayit.Text = "Kayıt ";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFON NO : ";
            // 
            // maskTxtTelefon
            // 
            this.maskTxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskTxtTelefon.Location = new System.Drawing.Point(203, 214);
            this.maskTxtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.maskTxtTelefon.Mask = " 000-000-00-00";
            this.maskTxtTelefon.Name = "maskTxtTelefon";
            this.maskTxtTelefon.Size = new System.Drawing.Size(163, 28);
            this.maskTxtTelefon.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(387, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numaranızın Başına \"0\" Koymadan GİRİŞ YAPINIZ!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(647, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Uygulamayı Kapa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SOYAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskTxtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SOY);
            this.Controls.Add(this.txt_AD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txt_SOYAD";
            this.Text = "Rehber Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.TextBox txt_SOY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox maskTxtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

