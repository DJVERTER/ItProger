using System;

namespace ItProger
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 800, new byte[] { 0, 0, 0 });
            bot.printValues();
            bot.macheAction();
            

            Robot killer = new Robot("Killer", 1000, new byte[] { 0, 0, 10 });
            killer.printValues();
            killer.macheAction();
        }
    }
}
