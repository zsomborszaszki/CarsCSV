namespace Cars_CSV
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var path = "C:\\Users\\szaszkisql\\Desktop\\nig\\CarsCSV\\Cars_CSV\\Cars_CSV\\bin\\auto_adatok.csv";
            var csvRows = System.IO.File.ReadAllLines(path, System.Text.Encoding.UTF8).ToList();


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

        }
    }
}
