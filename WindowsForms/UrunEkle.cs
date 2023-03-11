using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc; //MessageBox.Show metodunun geri dönüş türü DialogResult'tur.
            sonuc = MessageBox.Show("Kapatmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
                this.Close(); //bu Formu kapat, kapatma metodu. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kapatmak istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)  //  MessageBoxIcon.Exclamation pencereye ikon ekleyebilmemizi sağlar.
            {
                Application.Exit(); // Uygulamadan çıkma metodu.
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer a çift click yaparak etkinleştirabiliriz
            Random random = new Random(); // C# da rastgele değer üreten yapı.
            //this.BackColor = Color.FromArgb(random.Next(1,100), random.Next(1, 100), random.Next(1, 100)); //bu ekranın arkaplan rengini Color yapısı içindeki FromArgb metoduna random nesnesini kullanarak 1 ile 100 arasında rastgele oluşacak değerler gönderiyoruz, bu değerler de renk kodu olarak kullanılıyor. RBG (RED,GREEN,BLUE) ana renklerin karışımı kullanılıyor.

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //burada ürün bilgileri veri tabanına kaydedilir.
            if (string.IsNullOrEmpty(txtUrunAdi.Text)) //eğer boşsa
            {
                MessageBox.Show("ürün adı boş geçilemez");
            }
            //DialogResult sonuc;
            //sonuc = MessageBox.Show("");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font("Arial",(float)numericUpDown1.Value); // Oklarla sayıları değiştirdiğimizde label'ın yazı boyutunu değiştir.
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            lblResim.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }
        private void UrunEkle_Load(object sender, EventArgs e) // Formdaki herhangi bir boş alana çift click yaparak load eventi oluşturulabilir.
        {
            //
            // Form yüklenirken domainUpDown1 e for un içindeki verileri ekle.
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name); // sistemdeki fontlardan domainUpDown1 e ekleme yaptık.
            }
            domainUpDown1.Wrap = true; // liste sonunda başa dön

        }
    }
}
