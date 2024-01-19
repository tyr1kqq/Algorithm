namespace Algorithm
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

      
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();

            user1.Login = "Makaka";
            user1.Name = "Daniil0";
            user1.IsPremium = false;

            user2.Login = "Gora";
            user2.Name = "Igor";
            user2.IsPremium = true;

            user3.Login = "NeeilStudio";
            user3.Name = "Snegana";
            user3.IsPremium = true;

            Console.WriteLine("Hello" + user1.Name);
            if (!user1.IsPremium)
            {
                ShowAds();
            }
            else
            {
                Console.WriteLine("У вас есть премиум подписка");
            }
            Console.WriteLine("");

            Console.WriteLine("Hello" + user2.Name);
            if (!user2.IsPremium)
            {
                ShowAds();
            }
            else
            {
                Console.WriteLine("У вас есть премиум подписка");
            }

            Console.WriteLine("");
            Console.WriteLine("Hello"+ user3.Name);
            if (!user3.IsPremium)
            {
                ShowAds();
            }
            else
            {
                Console.WriteLine("У вас есть премиум подписка");
            }



        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}