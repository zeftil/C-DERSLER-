using System;

namespace CONSOLE_READLINE_ARRAY_DİZİ
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + ". sayıyı giriniz.");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
   
   

