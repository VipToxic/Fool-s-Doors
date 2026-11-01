namespace daun_doors
{
    internal class Program
    {

        static int money = 0;   // общее состояние игры
        static int life = 0;

        /// <summary>
        /// Метод считает монеты и жизни
        /// То что выиграл игрок
        /// Все рандомно
        /// </summary>
        static (int money, int life) MoneyLife()
        {

            int random = Random.Shared.Next(1, 7);
            
            if (random == 1 || random == 2)
            {
                Console.WriteLine("Вы выжили и получили 50 монет");
                money += 50;
            }
            else if (random == 3)
            {
                Console.WriteLine("Вы получили 1 жизнь");
                life += 1;
            }
            else if (random == 4) { Console.WriteLine("Вы выжили но ничего не получили"); }
            else if (random == 5)
            {
                Console.WriteLine("Вы получили 100 монет и 1 жизнь");
                money += 100;
                life += 1;
            }
            else
            {
                string[] message = {
                    "К сожелению", "Вы проигали мне жаль :(",
                    "Попытайте удачу следующий раз...", "...",
                    "Ах да...", "Ты же сдох..", "...", "ХАХАХАХАХА",
                    "Давай пока ЛОХ"
                };

                for (int i = 0; i < message.Length; i++)
                {
                    if (life > 0)
                    {
                        Console.WriteLine($"Вы проиграли но у вас еще {life} жизней");
                        life -= 1;
                        break;
                    }
                    Thread.Sleep(2000);
                    Console.WriteLine(message[i]);
                    if (message[i] == message[4])
                    {
                        Thread.Sleep(2000);
                    }
                }
                return (0, 0);

            }

            return (money, life);
        }

        /// <summary>
        /// Метод для определение номера двери
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Doors(int number)
        {
            if (number == 1)
            {
                Console.WriteLine($"Вы выбрали дверь под номером {number}\n");
                MoneyLife();
                Result();
            }
            if (number == 2)
            {
                Console.WriteLine($"Вы выбрали дверь под номером {number}\n");
                MoneyLife();
                Result();
            }
            return 0;
        }

        /// <summary>
        /// Получаем данные об монетах и об жизни
        /// </summary>
        /// <param name="money"></param>
        /// <param name="life"></param>
        static void Result()
        {
            Console.WriteLine($"Твои награды: {money}, {life}");
        }



        static void Main(string[] args)
        {
            /* 
             * Игра даунские двери
             * Главная идея игры в том что вы в консоли выбираете число 1 или 2 таким образом выбираете 
             * 1 или 2 дверь
             * после чего вы получите награждение или смерть или же ничего
             */

            // Код:

            // Заправшиваем у пользователя ввезти 1 или 2

            int count = 0;
            try
            {
                while (true)
                {
                    count++;
                    if (count >= 25)
                    {
                        Console.WriteLine("===ПОЗДРАВЛЯЕМ===");
                        Console.WriteLine("Вы выжили");
                        Console.WriteLine("Монету не дадим так как оно вам нахуй не нужен");
                        Console.WriteLine("До свидание :)\n");


                        Result();
                        return;
                    }
                    Console.WriteLine("==== Введите \"0\" если хотите выйти ====\n");
                    Console.Write("Введите число 1 или 2 для выбора двери: ");
                    string number = Console.ReadLine();
                    if (int.TryParse(number, out int result))
                    {
                        if (result == 0)
                        {
                            Console.WriteLine("Удачного дня");
                            return;
                        }
                        else if (result > 2 || result < 0)
                        {
                            Console.WriteLine("\n\t=== ОШИБКА ===");
                            Console.WriteLine("=== Введите число 1 или 2 ==\n");
                            continue;
                        }
                        Doors(result);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! не удалось обработать данные...");
                        Console.WriteLine("Введите коректные данные!");
                        continue;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("КРИТИЧЕСКАЯ ОШИБКА: " + ex.Message);
            }
        }
    }
}
