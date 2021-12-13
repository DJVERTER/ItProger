using System;

namespace ItProger
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 800, new byte[] { 0, 0, 0 });
            bot.PrintValues();
            Robot.MacheAction();
            

            Robot killer = new Robot("Killer", 1000, new byte[] { 0, 0, 10 });
            killer.PrintValues();
            Robot.MacheAction();
            bot.Weight = 600;
            Console.WriteLine(bot.Weight);
            bot.Width = 100;
            Console.WriteLine(bot.Width);
        }
    }
}
