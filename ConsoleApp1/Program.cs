namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // оператор обьединение с NULL "??"

            // Этот оператор нужен чтобы давать значение по умалчанию если переменное равен к null

            string str = null ?? string.Empty;


            Console.WriteLine(str.Length);

            // Оператор ??= нужна если переменная равени к null то присвоить значение

            string? result = null;

            result ??= "Игрок";
            Console.WriteLine(result);

            /*
             * В чем отличие? 
             * Оператор ?? оно просто дает новому переменному другое значение например
             * если name равен null то с помощью ?? мы можем только проверить на null и изменить
             * значение друрого переменного
             * А ??= оно непосредственно изменяет значение той самой name 
             * Тоесть если name == null то с помощью ??= мы можем поменять его на например
             * "Игрок" или еще к чему то
             */

            // Оператор ?.

            string? name_2 = null;
            Console.WriteLine(name_2?.Length);

            // Метод ToUpper() увеличивает все значение String на CAPS
            string? name_3 = "Иди нахуй";
            Console.WriteLine(name_3?.ToUpper());

            // ?[] то же самое только для масивов

            int[]? numbers = null;

            Console.WriteLine(numbers?[0]);



        }
    }
}
