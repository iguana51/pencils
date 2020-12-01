using System;

namespace pencils
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2020, 12, 14, 10, 00, 00);
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("До возвразения моих карандашей осталось:");
            Console.WriteLine(date.Subtract(dateNow));
        }
    }
}
