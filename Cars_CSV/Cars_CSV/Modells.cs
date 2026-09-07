using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_CSV
{
    internal class Modells
    {
        private static int nextId = 0;
        string name;
        public int id { get; }
        int brandId;
        int fuelId;
        int performance;
        int manufYear;

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
