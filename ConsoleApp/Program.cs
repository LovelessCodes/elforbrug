namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Repository repo = new Repository();
            //repo.Load();
            //Console.ReadLine(); 

            Measurement measurement = new Measurement();
            DateTime date1 = new DateTime(2020,10,13);
            DateTime date2 = new DateTime(2021, 10, 20);
            MeasurementRepo mp = new MeasurementRepo();
            mp.Load(); 
            var measurements = mp.Get(123456789012345000, date1, date2);

            foreach (Measurement measurementss in measurements)
            {
            Console.WriteLine(measurementss.ToString());

            }

        }
    }
}