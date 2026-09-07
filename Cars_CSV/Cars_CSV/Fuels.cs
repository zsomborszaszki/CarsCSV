using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    internal class Fuels
    {
        private static int nextId = 0;
        string name;
        public int id { get; }

        public Fuels(string Name)
        {
            name = Name;
            id = nextId++;
        }
    }
}
