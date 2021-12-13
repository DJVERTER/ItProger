using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItProger
{
    class Robot
    {
        private string name;
        private int weight;
        private byte[] coordinates;

        public void setValues(string Name, int Weight, byte[] Coordinates)
        {
            name = Name;
            weight = Weight;
            coordinates = Coordinates;
        }

        public Robot(string Name, int Weight, byte[] Coordinates)
        {
            Console.WriteLine("Robot has been created");
            setValues(Name, Weight, Coordinates);
        }

        public void PrintValues()
        {
            Console.WriteLine(name + " weight " + weight + ". Coordinates: ");
            foreach (byte el in coordinates)
                Console.WriteLine(el);
        }

        public static void MacheAction()
        {
            Console.WriteLine("Robot is mooving");
        }

        public int Weight
        {
            get
            {
                Console.Write("Result: ");
                return this.weight;
            }
            set
            {
                if (value < 1)
                    weight = 1;
                else if (value > 500)
                    weight = 500;
                else
                    weight = value;
            }
        }   
         public int Width { get; set; }
    }
}

