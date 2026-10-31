namespace C__урок
{
    internal class Program
    {
        /// <summary>
        /// Метод считает монеты и жизни
        /// То что выиграл игрок
        /// Все рандомно
        /// </summary>
        static (int money, int life) MoneyLife()
        {
            int money = 0;
            int life = 0;
            Random random = new Random();
            int random_2 = random.Next(1, 5 + 1);
            if (random_2 == 1 || random_2 == 2)
            {
                Console.WriteLine("Вы выжили и получили 50 монет");
                money += 50;
            }
            else if (random_2 == 3)
            {
                Console.WriteLine("Вы получили 1 жизнь");
                life += 1;
            }
            else if (random_2 == 4) { Console.WriteLine("Вы выжили но ничего не получили"); }
            else if (random_2 == 5)
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
                    if (money > 0)
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
            }
            if (number == 2)
            {
                Console.WriteLine($"Вы выбрали дверь под номером {number}\n");
                MoneyLife();
            }

            return 0;
        }
        /// <summary>
        /// Главный метод
        /// </summary>
        /// <param name="args"></param>
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
                    if (count == 25)
                    {
                        Console.WriteLine("===ПОЗДРАВЛЯЕМ===");
                        Console.WriteLine("Вы выжили");
                        Console.WriteLine("Монету не дадим так как оно вам нахуй не нужен");
                        Console.WriteLine("До свидание :)\n");

                        var reward = MoneyLife();

                        Console.WriteLine($"Твои награды: {reward.money}, {reward.life}");
                        return;
                    }
                    Console.WriteLine("==== Введите \"0\" если хотите выйти ====\n");
                    Console.Write("Введите число 1 или 2 для выбора двери: ");
                    string number = Console.ReadLine();
                    int cnt = Convert.ToInt32(number);
                    if (cnt == 0)
                    {
                        Console.WriteLine("Удачного дня");
                        return;
                    }
                    else if (cnt > 2)
                    {
                        Console.WriteLine("\n\t=== ОШИБКА ===");
                        Console.WriteLine("=== Введите число 1 или 2 ==\n");
                        continue;
                    }
                    Doors(cnt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("КРИТИЧЕСКАЯ ОШИБКА: " + ex.Message);
            }
        }
    }
}
    