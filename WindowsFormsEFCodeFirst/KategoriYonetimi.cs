 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEFCodeFirst
{
    public partial class KategoriYonetimi : Form
    {
        EFCodeFirstModel model = new EFCodeFirstModel();
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*var kategori = new Kategori()
            {
                KategoriAdi = txtKategoriAdi.Text
            };
            model.Kategoriler.Add(kategori);
            var islemsonucu = model.SaveChanges();
            if (islemsonucu > 0)
            {
                dgvKategoriler.DataSource = model.Kategoriler.ToList();
                MessageBox.Show("Kayıt Başarılı!");
            }*/ // benim yaptığım.
            if (string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return; // dön, aşağıdaki kdları çalıştırma.
            }
            var kategori = new Kategori()
            {
                KategoriAdi = txtKategoriAdi.Text
            };
            model.Kategoriler.Add(kategori);
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty; 
        }
        
        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            txtKategoriAdi.Text = kategori.KategoriAdi;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return; 
            }
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            kategori.KategoriAdi = txtKategoriAdi.Text;
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value.ToString());
            var kategori = model.Kategoriler.Find(id);
            model.Kategoriler.Remove(kategori);
            model.SaveChanges();
            dgvKategoriler.DataSource = model.Kategoriler.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = string.Empty;
        }
    }
}
