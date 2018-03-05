using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Utils
{
	public class SetUp
	{

		private static bool _logincondition;


		public static bool LoginCondition
		{
			get
			{
				return _logincondition;
			}

			set
			{
				_logincondition = value;
			}
		}
	}
}
