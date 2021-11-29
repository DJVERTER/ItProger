using System;

namespace ItProger
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot();
            bot.setValues("Bot", 800, new byte[] { 0, 0, 0 });
            bot.printValues();
            

            Robot killer = new Robot();
            killer.setValues("Killer", 1000, new byte[] { 0, 0, 10 });
            killer.printValues();
        }
    }
}
