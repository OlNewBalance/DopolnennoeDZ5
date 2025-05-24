namespace HomeWorkNumb2;

internal class Task5X
{
    public void Execute()
    {
        const string CommandExit = "Exit";
        const int EuroDollarDiff = 14;
        const int EuroRubleDiff = 46;
        const int DollarRubleDiff = 83;
        int ruble = 1000;
        int dollar = 1000;
        int euro = 1000;
        int toConvert = 0;
        Console.WriteLine("Добро пожаловать в обменник валют, чтобы продолжить, нажмите \"Enter\". Для выхода из программы писать - \"Exit\" ");
        while (true)
        {
            string input = Console.ReadLine(); 
            if (input?.ToLower() == "exit") //Весь этот if - Подсказка Чата
            {
                Console.WriteLine("Завершение конвертера...");
                Environment.Exit(0);
            }
            if (input == "")
            {
                Console.WriteLine("Ваш выбор конвертации:");
                Console.WriteLine("1. Рубли в доллары.");
                Console.WriteLine("2. Рубли в евро.");
                Console.WriteLine("3. Доллары в рубли.");
                Console.WriteLine("4. Доллары в евро.");
                Console.WriteLine("5. Евро в доллары.");
                Console.WriteLine("6. Евро в рубли");
                Console.WriteLine("Просто нажмите цифру нужного действия.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1: // Скопировал твою подсказку, и модифицировал её
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько рублей хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            ruble -= toConvert; // с баланса рублей вычитаем введённое с консоли колво рублей для перевода ТВОЕ
                            int dollarDelta = toConvert / DollarRubleDiff; // вычисляем сколько из введённых рублей получится долларов ТВОЕ
                            dollar +=  dollarDelta; // прибавляем к доллару счёту полученные из рублей доллары ТВОЕ
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {dollar} долларов...");
                            Console.WriteLine("Чтобы продолжить, нажмите \"Enter\"");
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько рублей хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            ruble -= toConvert;
                            int euroDelta = toConvert / EuroRubleDiff;
                            euro += euroDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {euro} евро...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько долларов хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            dollar -= toConvert;
                            int rubleDelta = toConvert / DollarRubleDiff;
                            ruble += rubleDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {ruble} рублей...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");
                        }

                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько долларов хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            dollar -= toConvert;
                            int euroDelta = toConvert / EuroDollarDiff;
                            euro += euroDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {euro} евро...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");
                        }

                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько евро хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            euro -= toConvert;
                            int dollarDelta = toConvert / EuroDollarDiff;
                            dollar += dollarDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {dollar} долларов...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");
                        }

                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine(" ");
                        Console.WriteLine("Введите, сколько евро хотите конвертировать...");
                        toConvert = int.Parse(Console.ReadLine());
                        if (toConvert > 0)
                        {
                            euro -= toConvert;
                            int rubleDelta = toConvert / EuroRubleDiff;
                            ruble += rubleDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {ruble} рублей...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");
                            break;
                        }
                        break;
                }
            }
        }
    }
}