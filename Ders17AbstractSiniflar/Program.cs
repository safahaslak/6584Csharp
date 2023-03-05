namespace Ders17AbstractSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract - Sınıflar!");
            // DataBase database = new DataBase(); // abstract classlarda bu şekilde nesne oluşturulmaz.
            DataBase sqlServer = new SqlServer(); // abstract class'dan nesne oluşturmak için miras alan sınıftan örnek oluşturulur.
            sqlServer.Add();
            sqlServer.Delete();
            DataBase mySql = new MySql();  // miras alan her sınıf bu şekilde örneklendirilebilir.
            mySql.Delete();
            mySql.Update();
        }
    }
    abstract class DataBase
    {
        public void Add() // ortak ekleme metodu
        {
            Console.WriteLine("Ekleme metodu çalıştı.");
        }
        public abstract void Delete();
        public abstract void Update();
        public abstract void Get();
    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Delete metodu çalıştı.");
        }

        public override void Get()
        {
            Console.WriteLine("Get metodu çalıştı.");
        }

        public override void Update()
        {
            Console.WriteLine("Update metodu çalıştı.");
        }

    }
    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle Delete metodu çalıştı.");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı.");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı.");
        }
    }
    class MySql : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("MySql Delete metodu çalıştı.");
        }

        public override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı.");
        }

        public override void Update()
        {
            Console.WriteLine("MySql Update metodu çalıştı.");
        }
    }
}