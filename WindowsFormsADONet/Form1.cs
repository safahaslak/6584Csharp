﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDAL urunDAL = new UrunDAL();
        private void Form1_Load(object sender, EventArgs e) //burada veritabanına bağlanıp işlemlerimizi yapacağız
        {
            // dgvUrunler.DataSource = urunDAL.UrunleriGetir();
            dgvUrunler.DataSource = urunDAL.UrunleriDataTableileGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try // hata yakalama işlemi
            {
                // çalışmasını beklediğimiz kodlar bu bloğa
                var sonuc = urunDAL.Add(new Urun()
                {
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
                });
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = urunDAL.UrunleriDataTableileGetir();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                // hata oluştuğunda çalıştıracağımız kodlar buraya yazılır.
                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }
            
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // tablodan textboxlara 
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();  
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try // hata yakalama işlemi
            {
                // çalışmasını beklediğimiz kodlar bu bloğa
                var sonuc = urunDAL.Update(new Urun()
                {
                    Id = int.Parse(dgvUrunler.CurrentRow.Cells[0].Value.ToString()),
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text)
                }); 
                if (sonuc > 0)
                {
                    dgvUrunler.DataSource = urunDAL.UrunleriDataTableileGetir();
                    btnGuncelle.Enabled = false;
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                // hata oluştuğunda çalıştıracağımız kodlar buraya yazılır.
                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var urunId = int.Parse(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
                var sonuc = urunDAL.Delete(urunId);
                {
                    if (sonuc > 0)
                    {
                        dgvUrunler.DataSource = urunDAL.UrunleriDataTableileGetir();
                        btnSil.Enabled = false;
                        MessageBox.Show("Kayıt Silme Başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silme Başarısız!");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu!\n" + hata.Message);
            }
        }
    }
}
