using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    internal class Modells
    {
        private static int nextId = 0;
        public string name;
        public int id { get; }
        public int brandId;
        public int fuelId;
        public int performance;
        public int manufYear;

        public Modells(string Name, int BrandId, int FuelId, int Performance, int ManufYear)
        {
            id = nextId++;
            name = Name;
            brandId = BrandId;
            fuelId = FuelId;
            performance = Performance;
            manufYear = ManufYear;

        }
    }
}
