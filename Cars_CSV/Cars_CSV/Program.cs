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


        static void Main(string[] args)
        {
            var path = "auto_adatok.csv";
            var csvRows = System.IO.File.ReadAllLines(path).ToList();


            foreach(var row in csvRows)
            {

                Console.WriteLine(row);
            }

            List<Brands> brandsList = new List<Brands>();
            List<Modells> modellsList = new List<Modells>();
            List<Fuels> fuelsList = new List<Fuels>();
            List<Cars> carsList = new List<Cars>();


            foreach(var row in csvRows.Skip(1))
            {
                var columns = row.Split(",");
                Console.WriteLine(columns[0]);
            }
            
            

            dbConnection();

        }
    }
}
