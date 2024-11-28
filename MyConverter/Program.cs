using System;

namespace MyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Оберіть напрямок конвертації:");
            Console.WriteLine("   1 - з гривні в долари");
            Console.WriteLine("   2 - з гривні в євро");
            Console.WriteLine("   3 - з доларів в гривні");
            Console.WriteLine("   4 - з євро в гривні");

            Converter сonverter = new Converter();

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введіть суму в гривнях:");
                    decimal amountHryvniaToDollars = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Сума в доларах: {сonverter.ConvertToDollars(amountHryvniaToDollars)}");
                    break;

                case 2:
                    Console.WriteLine("Введіть суму в гривнях:");
                    decimal amountHryvniaToEuros = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Сума в євро: {сonverter.ConvertToEuros(amountHryvniaToEuros)}");
                    break;

                case 3:
                    Console.WriteLine("Введіть суму в доларах:");
                    decimal amountDollars = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Сума в гривнях: {сonverter.ConvertFromDollars(amountDollars)}");
                    break;

                case 4:
                    Console.WriteLine("Введіть суму в євро:");
                    decimal amountEuros = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Сума в гривнях: {сonverter.ConvertFromEuros(amountEuros)}");
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }
        }
    }
}
