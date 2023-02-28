using System;

namespace EuclideanAlgorithm
{
    class Program
    {

        public static int gcdWithRecursive(int n1, int n2)
        {
            if(n2 == 0)
                return n1;
            else
                return gcdWithRecursive(n2, n1 % n2); //n2 sıfır değilse, mod al ve fonksiyon çağrısına devam et.
        }

        public static int gcd(int n1, int n2)
        {
            //n2 değeri sıfır olana kadar devam et.
            while(n2 != 0)
            {
                int r = n1 % n2;
                n1 = n2;
                n2 = r;
            }
            return n1;
        }

        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;

            //Kullanıcıdan girdi değerlerini alalım.
            Console.Write("enter the number1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Girdi değerlerini fonksiyonlara gönderelim.
            Console.WriteLine(gcdWithRecursive(n1, n2));
            Console.WriteLine(gcd(n1, n2));
        }
    }
}