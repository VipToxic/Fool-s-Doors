namespace C__урок
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           

            // Мини игра "Двери не двери иди мара вара"

            Console.WriteLine("\t\t\t*---ПРАВИЛА---*");
            Console.WriteLine("Вы должны выбрать дверь '1' левая дверь '2' правая дверь");
            Console.WriteLine("После выбора вам могут выпасть либо вознаграждение ввиде золото или убить монстр или доп жизнь \nИли вообще ничего");
            Console.WriteLine("Игра закончиться тогда когда вы умрете");

            int money = 0;
            int life = 0;

            while (true)
            {
                Console.Write("Если готовы введитие \"0\": ");

                // Процесс
                string input = Console.ReadLine();

                if (int.TryParse(input, out int ready))
                {

                    if (ready == 0)
                    {
                        Console.Write("Выберите дверь 1 или 2: ");
                        string input2 = Console.ReadLine();
                        if (int.TryParse(input2, out int doors1))
                        {
                            if (doors1 == 1)
                            {
                                Console.WriteLine("Вы выжили и заработали 20 золотых монет!");
                                money = 20;
                                Console.Write("Выберите следюший дверь (1 или 2): ");
                                string input3 = Console.ReadLine();
                                if (int.TryParse(input3, out int doors2))
                                {
                                    if (doors2 == 1)
                                    {
                                        Console.WriteLine("Вы выжили и получили доп жизнь");
                                        life = 1;
                                        Console.WriteLine($"Количество жизней {life}");

                                        Console.Write("Выберите следуюший дверь (1 или 2): ");
                                        string input5 = Console.ReadLine();
                                        if (int.TryParse(input5, out int doors4))
                                        {
                                            if (doors4 == 2)
                                            {
                                                Console.WriteLine("Вы выжили!!");
                                                Console.Write("Выберите следющий дверь (1 или 2)");
                                                string input6 = Console.ReadLine();
                                                if (int.TryParse(input6, out int doors5))
                                                {
                                                    if (doors5 == 2)
                                                    {
                                                        Console.WriteLine("ВЫ ВЫЖИЛИ И СБЕЖАЛИ С ЗДАНИЕ!");
                                                        Console.WriteLine($"Вы заработали {money} монет.");
                                                        Console.WriteLine($"У вас еще остался {life} жизней.");
                                                        break;
                                                    }
                                                    else if (doors5 == 1)
                                                    {
                                                        Console.WriteLine($"Вы погибли но у вас еще {life} жизней");
                                                        life -= 1;
                                                        Console.Write("Выберите следуюший дверь (1 или 2): ");
                                                        string input7 = Console.ReadLine();
                                                        if (int.TryParse(input7, out int doors6))
                                                        {
                                                            if (doors6 == 1)
                                                            {
                                                                Console.WriteLine("Вы погибли от шипов..");
                                                                Console.WriteLine($"Вы потеряли {money} денег");
                                                                Console.WriteLine($"Остаток жизни {life}");
                                                                break;
                                                            }
                                                            else if (doors6 == 2)
                                                            {
                                                                Console.WriteLine("ВЫ СБЕЖАЛИ ИЗ ЗДАНИЕ!!!");
                                                                Console.WriteLine($"Вы заработали {money} денег");
                                                                Console.WriteLine($"Остаток жизни {life}");
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Вы ввели {input6} введите коректные данные или 1 или 2");
                                                }
                                            }
                                            else if (doors4 == 1)
                                            {
                                                Console.WriteLine($"Ксожелению вы погибли от рук монстра но у вас была {life} жизней");
                                                life -= 1;
                                                Console.Write("Выберите следуюший дверь (1 или 2): ");
                                                string input8 = Console.ReadLine();
                                                if (int.TryParse(input8, out int doors7))
                                                {
                                                    if (doors7 == 1)
                                                    {
                                                        Console.WriteLine("ВЫ СБЕЖАЛИ ИЗ ЗДАНИЕ!!!");
                                                        Console.WriteLine($"Вы заработали {money} денег");
                                                        Console.WriteLine($"Остаток жизни {life}");
                                                        break;
                                                    }
                                                    else if (doors7 == 2)
                                                    {
                                                        Console.WriteLine("Вы погибли от динамита..");
                                                        Console.WriteLine($"Вы потеряли {money} денег");
                                                        Console.WriteLine($"Остаток жизни {life}");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Вы ввели {input8} введите коректные данные или 1 или 2");
                                                }

                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Вы ввели {input5} введите коректные данные или 1 или 2");
                                        }
                                    }
                                    else if (doors2 == 2)
                                    {
                                        Console.WriteLine("Вы погибли от летаюших носков..");
                                        Console.WriteLine($"Вы потеряли {money} денег");
                                        Console.WriteLine($"Остаток жизни {life}");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Вы ввели {input3} введите коректные данные или 1 или 2");
                                }

                            } 
                            else if (doors1 == 2)
                            {
                                Console.WriteLine("Вы выжили!!");
                                Console.Write("Выберите следющий дверь (1 или 2)");
                                string input4 = Console.ReadLine();
                                if (int.TryParse(input4, out int doors3))
                                {
                                    if (doors3 == 1)
                                    {
                                        Console.WriteLine("Вы погибли от санта клауса..");
                                        Console.WriteLine($"Вы потеряли {money} денег");
                                        Console.WriteLine($"Остаток жизни {life}");
                                        break;
                                    }
                                    else if (doors3 == 2)
                                    {
                                        Console.WriteLine("Вы выжили и получили 50 монет");
                                        money = 50;
                                        Console.Write("Выберите следющий дверь (1 или 2)");
                                        string input5 = Console.ReadLine();
                                        if (int.TryParse(input5, out int doors4))
                                        {
                                            if (doors4 == 2)
                                            {
                                                Console.WriteLine("Вы погибли от от танка из вафел..");
                                                Console.WriteLine($"Вы потеряли {money} денег");
                                                Console.WriteLine($"Остаток жизни {life}");
                                                break;
                                            }
                                            else if ( doors4 == 1)
                                            {
                                                Console.WriteLine("ВЫ СБЕЖАЛИ ИЗ ЗДАНИЕ!!! и получили 1000 монет");
                                                money += 1000;
                                                Console.WriteLine($"Вы заработали {money} денег");
                                                Console.WriteLine($"Остаток жизни {life}");
                                                break;
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Вы ввели {input4} введите коректные данные или 1 или 2");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Вы ввели {input2} введите коректные данные или 1 или 2");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Вы ввели {ready} введите 0");
                    }
                }
                else
                {
                    Console.WriteLine("Введите коректные данные!");
                }

            }

         

        }
    }
}
    