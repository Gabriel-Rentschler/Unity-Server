using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Super Server";
            Server.Start(25, 25565);

            Console.ReadKey();
        }
    }
}
