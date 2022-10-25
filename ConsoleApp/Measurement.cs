using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Measurement
    {
		private Int64 _meterId;

		public Int64 MeterId
		{
			get { return _meterId; }
			set { _meterId = value; }
		}

		private DateTime _from;

		public DateTime From
		{
			get { return _from; }
			set { _from = value; }
		}

		private DateTime _to;

		public DateTime To
		{
			get { return _to; }
			set { _to = value; }
		}

		private float _value;

		public float Value
		{
			get { return _value; }
			set { _value = value; }
		}

		public override string ToString()
		{
			return $"{MeterId};{From};{To};{Value}";
		}




	}
}
