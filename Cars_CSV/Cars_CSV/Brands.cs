using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    public class Brands
    {
        private static int nextId = 1;
        public string name;
        public int id { get; }

        public Brands(string brandName)
        {
            name = brandName;
            id = nextId++;
        }
    }
}
