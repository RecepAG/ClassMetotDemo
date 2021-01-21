using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();
            musteri1.Id = 11111111;
            musteri1.CustomerName = "Mehmet";
            musteri1.CustomerSurname = "Çavdar";
            musteri1.BirthDate = "10.02.1985";
            musteri1.BirthPlace = "İzmir";

            Customer musteri2 = new Customer();
            musteri2.Id = 22222222;
            musteri2.CustomerName = "Ahmet";
            musteri2.CustomerSurname = "Uslu";
            musteri2.BirthDate = "01.12.1985";
            musteri2.BirthPlace = "İstanbul";

            Customer[] musteriler = new Customer[] { musteri1,musteri2 };

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Listele(musteriler);


            Console.WriteLine("--------Müşteri Detayları----------");


            CustomerManager musteriManager1 = new CustomerManager();
            musteriManager1.Ekle(musteri1);
            Console.WriteLine("-----------------------------------");
            musteriManager1.Ekle(musteri2);
            Console.WriteLine("-----------------------------------");
            musteriManager1.Sil(musteri1);
            Console.WriteLine("-----------------------------------");
            musteriManager1.Sil(musteri2);




        }

    } 
}
