﻿using System;
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

        public void printValues()
        {
            Console.WriteLine(name + " weight " + weight + ". Coordinates: ");
            foreach (byte el in coordinates)
                Console.WriteLine(el);
        }
    }
}
