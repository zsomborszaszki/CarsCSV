using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    internal class Cars
    {
        private static int nextId = 0;
        public int id { get; }
        int modellId;
        int price;
        int co2;

        public Cars(int ModellId, int Price, int Co2)
        {
            id = nextId++;
            modellId = ModellId;
            price = Price;
            co2 = Co2;
        }

    }
}
