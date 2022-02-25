using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon__Rehberi
{
    public partial class txt_SOYAD : Form
    {
        string KAYİTyol= @"C:\Users\BİLGİSAYAR İSMİ \Desktop\PROJENİN KAYITLI OLDUĞU YER\NUMARALARIN KAYIT OLACAĞI YER.txt";
        string Ad, Soyad, Numara;
        

        public txt_SOYAD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            Ad = txt_AD.Text;
            Soyad = txt_SOY.Text;
            Numara = maskTxtTelefon.Text;


        
            if(Ad == "")
            {
                MessageBox.Show("Lütfen Ad Kısmını Doldurun");
                return;

            }

            if (Soyad == "")
            {
                MessageBox.Show("Lütfen SOYAD Kısmını Doldurun");
                return;

            }
            if (!maskTxtTelefon.MaskFull)
            {
                MessageBox.Show("Telefon numarasını düzgün giriniz.");
                return;
            }

            string[] dize = File.ReadAllLines(KAYİTyol);
            foreach (string satir in dize)
            {
                string[] bilgiler = satir.Split(',');
                if (bilgiler[0] == Ad || bilgiler[1]==Soyad || bilgiler[2]==Numara)
                {
                    MessageBox.Show("Böyle Bir Kişi REHBERDE Mevcut");
                    return;
                    

                }
              if (bilgiler[2]==Numara)
                {
                    MessageBox.Show("Böyle Bir Numara REHBERDE Mevcut");
                    return;
                    
                }
                else
                {

                    //Kayıt Yap
                    using (StreamWriter dosya = new StreamWriter(KAYİTyol, true))
                    {
                        string satirr;
                        satirr = Ad + "," + Soyad + "," + Numara;
                        dosya.WriteLine(satirr);
                    }
                    MessageBox.Show("KAYIT BAŞARILI");
                    if (MessageBox.Show("Kayıt İşlemine Devam Etemk İstiyorsanız EVET,   Çıkış İçin HAYIR basın ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txt_AD.Text= "";
                        txt_SOY.Text = "";
                        maskTxtTelefon.Text = "";
                        return;
                    }

                    else
                    {
                        this.Close();
                    }
                }
            }




          

        }
    }
}
