using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIZIDE_KAC_ADET_AYNI_ELEMANDAN_VAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cities = new string[]
                {
                "İstanbul","Ankara","Bursa","İzmir","Ankara","Samsun","Ordu","Muğla","Antalya","Ankara","İstanbul","Bursa","Çanakkale"
                };
            String searchCity = String.Empty;
            Console.WriteLine("Arayacağınız Şehir Bilgisini Giriniz: ");
            searchCity = Console.ReadLine();

            Console.WriteLine(cities.Count(sehir => sehir == searchCity));


        }
    }
}
