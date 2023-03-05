namespace Entities
{
    public class Urun : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Kategori Kategori { get; set; } // Ürün ile Kategori class'ı arasında ilişki kurabiliriz. Tıpkı bir property gibi tanımlayabiliyoruz ve bu şekilde ilişki kurulabilir.
    }
}
