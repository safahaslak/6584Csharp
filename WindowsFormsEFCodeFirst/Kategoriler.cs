namespace WindowsFormsEFCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.InteropServices;

    [Table("Kategoriler")]
    public partial class Kategori
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string KategoriAdi { get; set; }
        
    }
}
