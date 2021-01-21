using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer musteri)
        {
            Console.WriteLine("Müşteri Numarası : " +musteri.Id);
            Console.WriteLine("Müşteri Adı : "+musteri.CustomerName);
            Console.WriteLine("Müşteri Soyadı : "+ musteri.CustomerSurname);
            Console.WriteLine("Doğum Tarihi : "+musteri.BirthDate);
            Console.WriteLine("Doğum Yeri : "+musteri.BirthPlace);
        }
        public void Sil (Customer musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi :" + musteri.CustomerName+" "+musteri.CustomerSurname);
        }

        public void Listele(Customer[] musteri)
        {
            Console.WriteLine("--------Müşteri Listesi-----------");
            foreach (Customer x in musteri)
            {
                Console.WriteLine("Müşteri Numarası : " + x.Id);
                Console.WriteLine("Ad ve Soyad : " + x.CustomerName + " " + x.CustomerSurname);

            }
        }

        
        
    }
}
