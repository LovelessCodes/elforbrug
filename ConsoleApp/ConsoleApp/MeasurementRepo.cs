using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MeasurementRepo
    {
        private List<Measurement> measurements = new List<Measurement>();
        Measurement mea = new Measurement(); 
        public List<Measurement> Get(Int64 meterId, DateTime from, DateTime to)
        {
            List<Measurement> meas = new List<Measurement>(); 

            foreach (Measurement mea in measurements)
            {
                if (mea.From >= from && mea.To <= to && mea.MeterId == meterId)
                {
                    meas.Add(mea);
                }
            }

            return meas; 
        }

        public void Save(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Measurement meassurement in measurements)
                {
                    if(measurements != null)
                    {
                        string measurement = ($"{mea.MeterId}, {mea.From}, {mea.To}");
                        sw.WriteLine(meassurement);
                       
                    }
                }
            }
        }

        public void Load()
        {
            using (StreamReader sr = new StreamReader("Måledata-2 år.csv"))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    string[] data = text.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    if (data[0] == "MeterID")
                    {
                        continue;
                    }
                    Measurement measurement = new Measurement();
                    measurement.MeterId = Int64.Parse(data[0]);
                    measurement.From = DateTime.ParseExact(data[1], "yyyy-MM-dd HH,mm", null);
                    measurement.To = DateTime.ParseExact(data[2], "yyyy-MM-dd HH,mm", null);
                    measurement.Value = float.Parse(data[3]);
                    measurements.Add(measurement);
                   
                } 
              
            }
        }

    }

}
