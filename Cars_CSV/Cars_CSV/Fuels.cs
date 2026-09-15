using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    public class Fuels
    {
        private static int nextId = 1;
        public string name;
        public int id { get; }

        public Fuels(string Name)
        {
            name = Name;
            id = nextId++;
        }
    }
}
