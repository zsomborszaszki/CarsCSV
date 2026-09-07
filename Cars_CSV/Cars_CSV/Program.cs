using MySqlConnector;

namespace Cars_CSV
{
    internal class Program
    {

        static void dbConnection()
        {
            var connString = "Server=localhost;Port=3307;User ID=root;Password=;Database=test";
            using (var connection = new MySqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine("Connected to MySql successfully!");
            }
        }


        static void Main(string[] args)
        {
            var path = "C:\\Users\\szaszi228\\Desktop\\nig\\CarsCSV\\Cars_CSV\\Cars_CSV\\bin\\auto_adatok.csv";
            var csvRows = System.IO.File.ReadAllLines(path).ToList();


            foreach(var row in csvRows)
            {
                var columns = row.Split(';');

                var field1 = columns[0];

                Console.WriteLine(field1);
            }

            List<Brands> brandsList = new List<Brands>();
            List<Modells> modellsList = new List<Modells>();
            List<Fuels> fuelsList = new List<Fuels>();
            List<Cars> carsList = new List<Cars>();

            foreach(var row in csvRows.Skip(1))
            {
                var splitRow = row.Split();

                bool init = false;

                foreach( var brand in brandsList)
                {
                    if (splitRow[2] == brand.name)
                    {

                    }
                }

            }

            dbConnection();

        }
    }
}
