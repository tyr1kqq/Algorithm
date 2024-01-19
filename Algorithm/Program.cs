namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возвраст - ");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 13)
            {
                Console.WriteLine("Вы успешно авторизовались");
            }
            else
            {
                Console.WriteLine("Мудила ты еще маленький");
            }
        }
    }
}