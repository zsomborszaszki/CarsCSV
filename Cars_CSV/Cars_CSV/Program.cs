using MySqlConnector;

namespace Cars_CSV
{
    internal class Program
    {

        static void dbConnection()
        {
            var connString = "Server=localhost;Port=3307;User ID=root;Password=;Database=cars_csv";
            using (var connection = new MySqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine("Connected to MySql successfully!");
            }
        }

        static List<Brands> BrandsToList(List<string>csvRows, List<Brands> brandsList)
        {
            foreach (var row in csvRows.Skip(1))
            {
                bool init = false;

                var brand = row.Split(",")[1];

                foreach (var LBrand in brandsList)
                {
                    if (brand == LBrand.name)
                    {
                        init = true; break;
                    }
                }
                if (init == false)
                {
                    brandsList.Add(new Brands(brand));
                }

            }

            return brandsList;
        }


        static List<Fuels> FuelsToList(List<string> csvRows, List<Fuels> fuelsList)
        {
            foreach (var row in csvRows.Skip(1))
            {
                bool init = false;

                var fuel = row.Split(",")[3];

                foreach (var LFuel in fuelsList)
                {
                    if (fuel == LFuel.name)
                    {
                        init = true; break;
                    }
                }
                if (init == false)
                {
                    fuelsList.Add(new Fuels(fuel));
                }

            }

            return fuelsList;
        }

        static List<Modells> ModellsToList(List<string> csvRows, List<Modells> modellsList, List<Brands> brandsList, List<Fuels> fuelsList)
        {
            foreach (var row in csvRows.Skip(1))
            {
                var currRow = row.Split(",");

                var currName = currRow[2];
                int currBrandId = 0;
                int currManufyear = Convert.ToInt32(currRow[6]);
                int currPerformance = Convert.ToInt32(currRow[4]);
                int currFuelId = 0;

                foreach (var LBrand in brandsList)
                {

                    if (LBrand.name == currRow[1])
                    {
                        currBrandId = LBrand.id;
                        break;
                    }
                }



                foreach (var LFuel in fuelsList)
                {

                    if (LFuel.name == currRow[1])
                    {
                        currFuelId = LFuel.id;
                        break;
                    }
                }


                modellsList.Add(new Modells(currName, currBrandId, currFuelId, currPerformance, currManufyear));


            }
            return modellsList;
        }

        static void Main(string[] args)
        {
            var path = "auto_adatok.csv";
            var csvRows = System.IO.File.ReadAllLines(path).ToList();

            List<Brands> brandsList = new List<Brands>();
            List<Modells> modellsList = new List<Modells>();
            List<Fuels> fuelsList = new List<Fuels>();
            List<Cars> carsList = new List<Cars>();


            
            BrandsToList(csvRows, brandsList);
            FuelsToList(csvRows, fuelsList);


            dbConnection();

        }
    }
}
