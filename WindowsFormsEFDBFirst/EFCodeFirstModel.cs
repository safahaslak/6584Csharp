using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsEFDBFirst
{
    public partial class EFCodeFirstModel : DbContext
    {
        public EFCodeFirstModel()
            : base("name=EFCodeFirstModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
