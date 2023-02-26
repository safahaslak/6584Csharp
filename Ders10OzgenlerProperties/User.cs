namespace Ders10OzgenlerProperties
{
    internal class User
    {
        public string Name { get; set; } // property'lerin kapalı kullanılabilen hali.
        public string Password { get; set; } //uygulama geliştirirken bu property'leri kullanırız.
        public string Email { get; set; }
        public string Telefon { get; set; } //prop ayzıp tab a iki kez basarak kısayolla oluşturabiliriz.

        public DateTime KayitTarihi { get; set; }

        public bool kullaniciGiris(string mail, string sifre)
        {
            string dbDekiEmail = "alp@arslan.net";
            string dbDekiSifre = "2023";
            if (mail == dbDekiEmail && sifre == dbDekiSifre)
            {
                return true;
            }
            return false;
        }
        /*public bool user(string email, string parola)
        {
            string veritabanimail = "user@google.com";
            string veritabanisifre = "2020";
            if (email == veritabanimail && parola == veritabanisifre)
            {
                return true;
            }
            return false; 
        }*/
    }
}
