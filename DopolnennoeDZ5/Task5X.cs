namespace HomeWorkNumb2;

internal class Task5X
{
    public enum Currency
            {
                JPY,
                USD,
                EUR
            }
    public void Execute()
    {
        var wallet = new Dictionary<Currency, float>
        {
            [Currency.JPY] = 1000f,
            [Currency.USD] = 1000f,
            [Currency.EUR] = 1000f
        };
        var currencyDiffs = new Dictionary<(Currency from, Currency to), float>
        {
            [(Currency.JPY, Currency.USD)] = 1.20f,
            [(Currency.JPY, Currency.EUR)] = 0.76f,
            [(Currency.USD, Currency.EUR)] = 5.41f,
            [(Currency.USD, Currency.JPY)] = 3.7f,
            [(Currency.EUR, Currency.JPY)] = 8.6f,
            [(Currency.EUR, Currency.USD)] = 12.56f
        };
        const string CommandExit = "Exit";
        int toConvert = 0;
        string input1;
        Console.WriteLine("Добро пожаловать в обменник валют, чтобы продолжить, нажмите \"Enter\". Для выхода из программы писать - \"exit\" ");
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
                Console.WriteLine("Деньги на счету:");
                Console.WriteLine($"Йена - {wallet [Currency.JPY]}");
                Console.WriteLine($"Доллар - {wallet [Currency.USD]}");
                Console.WriteLine($"Евро - {wallet [Currency.EUR]}");
                Console.WriteLine("Индексы валют:");
                Console.WriteLine("JPY - йена");
                Console.WriteLine("USD - доллар");
                Console.WriteLine("EUR - евро");
                Console.WriteLine("Чтобы конвертировать, введите сначала \"индекс\" валюты ИЗ которой хотите конвертировать,");
                Console.WriteLine("... затем валюты В которую, и количество, все через запятую. 1 - ИЗ, 2 - В, 3 - СКОЛЬКО.");
                input1 = Console.ReadLine();
                string[] parts = input1.Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3)
                {
                    string from = parts[0].Trim();
                    string to = parts[1].Trim();
                    if (int.TryParse(parts[2].Trim(), out int amount))
                    {
                        if (from == "JPY" && to == "EUR" && amount > 0)
                        {
                            Console.WriteLine(" ");
                            toConvert = int.Parse(Console.ReadLine());
                            if (toConvert > 0)
                            {
                                wallet [Currency.JPY] -= amount;
                                float diff = currencyDiffs[(Currency.JPY, Currency.EUR)];
                                float eurDelta = amount / diff;
                                wallet [Currency.EUR] += eurDelta;
                                Console.WriteLine(" ");
                                Console.WriteLine($"У вас {wallet [Currency.EUR]} евро...");
                                Console.WriteLine("Для повтора, жать \"Enter\".");
                            }
                        }
                        if (from == "JPY" && to == "USD" && amount > 0)
                        {
                            wallet [Currency.JPY] -= amount;
                            float diff = currencyDiffs[(Currency.JPY, Currency.USD)];
                            float usdDelta = amount / diff;
                            wallet [Currency.USD] += usdDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {wallet [Currency.USD]} долларов...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");                                    
                        }
                        if (from == "USD" && to == "JPY" && amount > 0)
                        {
                            wallet [Currency.USD] -= amount;
                            float diff = currencyDiffs[(Currency.USD, Currency.JPY)];
                            float jpyDelta = amount / diff;
                            wallet [Currency.JPY] += jpyDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {wallet [Currency.JPY]} йен...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");                                   
                        }
                        if (from == "USD" && to == "EUR" && amount > 0)
                        {
                            wallet [Currency.USD] -= amount;
                            float diff = currencyDiffs[(Currency.USD, Currency.EUR)];
                            float eurDelta = amount / diff;
                            wallet [Currency.JPY] += eurDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {wallet [Currency.EUR]} евро...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");                                    
                        }
                        if (from == "EUR" && to == "JPY" && amount > 0)
                        {
                            wallet [Currency.EUR] -= amount;
                            float diff = currencyDiffs[(Currency.EUR, Currency.JPY)];
                            float jpyDelta = amount / diff;
                            wallet [Currency.JPY] += jpyDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {wallet [Currency.JPY]} йен...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");                                    
                        }
                        if (from == "EUR" && to == "USD" && amount > 0)
                        {
                            wallet [Currency.EUR] -= amount;
                            float diff = currencyDiffs[(Currency.EUR, Currency.USD)];
                            float usdDelta = amount / diff;
                            wallet [Currency.JPY] += usdDelta;
                            Console.WriteLine(" ");
                            Console.WriteLine($"У вас {wallet [Currency.USD]} долларов...");
                            Console.WriteLine("Для повтора, жать \"Enter\".");                                    
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Ошибка! Напишите - 1) Валюту ИЗ; 2) Валюту В; 3) Количество для перевода. Все это через запятую.");
                }
                
            }
        }
    }
}
