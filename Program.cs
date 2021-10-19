using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "6";
            String b = "9";
            String c = "4";

            String aacb = a + a + c + b;
            String bca = b + c + a;
            String bcbc = b + c + b + c;

            Console.WriteLine("aacb= " + aacb);
            Console.WriteLine("bca= " + bca);
            Console.WriteLine("bcbc= " + bcbc);

        }
    }
}
