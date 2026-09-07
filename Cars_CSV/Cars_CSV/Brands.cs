using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    internal class Brands
    {
        private static int nextId = 0;
        string name;
        public int id { get; }

        public Brands(string brandName)
        {
            name = brandName;
            id = nextId++;
        }
    }
}
