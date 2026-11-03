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
        }
    }
}
