//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp
//{
//    public class Repository
//    {

//        private List<DateTime> _dateFrom = new List<DateTime>();
//        public List<DateTime> DateFrom
//        {
//            get { return _dateFrom; }
//            set { _dateFrom = value; }
//        }

//        private List<DateTime> _dateTo = new List<DateTime>();
//        public List<DateTime> DateTo
//        {
//            get { return _dateTo; }
//            set { _dateTo = value; }
//        }

//        private List<float> _value = new List<float>();

//        public List<float> Value
//        {
//            get { return _value; }
//            set { _value = value; }
//        }

//        private Int64 _number;

//        public Int64 Number
//        {
//            get { return _number; }
//            set { _number = value; }
//        }

//        //public Repository(int number, List<DateTime> dateFrom, List<DateTime> dateTo, List<float> value)
//        //{
//        //    _number = number;
//        //    _dateFrom = dateFrom;
//        //    _dateTo = dateTo;
//        //    _value = value;
//        //}


//        public void Load()
//        {
//            using (StreamReader sr = new StreamReader("Måledata-2 år.csv"))
//            {
//                string text;
//                int count = 0;
//                while ((text = sr.ReadLine()) != null)
//                {
//                    string[] data = text.Split(";", StringSplitOptions.RemoveEmptyEntries);
//                    if (data[0] == "MeterID")
//                    {
//                        continue; 
//                    }

//                    if (count == 0)
//                    {
//                        Number = Int64.Parse(data[0]);
//                        count++;
//                    }
                    
//                    DateFrom.Add(DateTime.ParseExact(data[1], "yyyy-MM-dd HH,mm", null));
//                    DateTo.Add(DateTime.ParseExact(data[2], "yyyy-MM-dd HH,mm", null));
//                    Value.Add(float.Parse(data[3]));
//                }
//            }
//        }

//        public void Menu()
//        {
//            int choices;
//            switch (choices)
//            {
//                case 0:
//                    break;
//                case 1:
//                    break;
//                case 2:
//                    break; 
//            }

//        }



//    }
//}
     


