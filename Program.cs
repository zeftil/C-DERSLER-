using System;

namespace PRATİK_ÖRNEK_EXAMPLE_METODLAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan aldığımız sayinin karesini alalım eğer karesi 25 ten büyükse ;
            // karesi 25 'den büyüktür
            //değilse karesi 25'ten küçüktür yazdırsın.

            Console.WriteLine("birinci sayiyi giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            int kareDeger = kareAl(sayi1);
            if (kareDeger > 25)
            {
                Console.WriteLine("karesi 25 ten büyüktür.");    
            }
            while (kareDeger < 25)
            {
                Console.WriteLine("karesi 25 ten küçüktür.");
            }

            Console.ReadLine();
            
        }
        static int kareAl (int a)
        {
            return a * a;
        }
    }
}
