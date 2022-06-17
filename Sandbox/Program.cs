using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 7; // Constant Integer (Cannot be reassigned)

            int number = 123; // Whole
            double ver = 1.0; // Decimal
            bool online = false; // Boolean
            char letter = 'a';  // One Character
            String user = "Pinkhron"; // String

            int a = 0;
            double b = Convert.ToDouble(a); // Converting

            Console.WriteLine(num);
            Console.WriteLine(b + $" {a.GetType()}");
            Console.ReadKey();
        }
    }
}
