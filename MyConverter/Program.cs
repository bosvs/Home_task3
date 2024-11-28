using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть курс обміну для USD до UAH: ");
            decimal usdRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введіть курс обміну для EUR до UAH: ");
            decimal eurRate = Convert.ToDecimal(Console.ReadLine());

            var converter = new Converter(usdRate, eurRate);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nОберіть варіант конвертації:");
                Console.WriteLine("1. Конвертувати UAH в USD");
                Console.WriteLine("2. Конвертувати UAH в EUR");
                Console.WriteLine("3. Конвертувати USD в UAH");
                Console.WriteLine("4. Конвертувати EUR в UAH");
                Console.WriteLine("5. Вихід");
                Console.Write("Ваш вибір: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть суму в UAH: ");
                        decimal amountInUahToUsd = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Еквівалент в USD: {converter.ConvertFromUahToUsd(amountInUahToUsd)}");
                        break;
                    case 2:
                        Console.Write("Введіть суму в UAH: ");
                        decimal amountInUahToEur = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Еквівалент в EUR: {converter.ConvertFromUahToEur(amountInUahToEur)}");
                        break;
                    case 3:
                        Console.Write("Введіть суму в USD: ");
                        decimal amountInUsd = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Еквівалент в UAH: {converter.ConvertFromUsdToUah(amountInUsd)}");
                        break;
                    case 4:
                        Console.Write("Введіть суму в EUR: ");
                        decimal amountInEur = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Еквівалент в UAH: {converter.ConvertFromEurToUah(amountInEur)}");
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                        break;
                }
            }

            Console.WriteLine("Дякуємо за використання конвертера валют. До побачення!");
        }
    }
}
    
