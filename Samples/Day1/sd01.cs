using System;

namespace InterstellarLynx.Samples.Day1
{
    class Sd01
    {

        static string name = "Lynx";
        static int num1 = 2;
        static int num2 = 10;

        static Boolean output = true;

        public static void sdx01() {
            Console.WriteLine($"Hello, {name}!");
            if(output == true) {
                Console.WriteLine((num1 + num2));
                Console.WriteLine("SQL Sample | User : {0} <---> Pass : {1}", name, (num1+ num2));
                Console.WriteLine(DateTime.UtcNow);
            }
        }
    }
}
