using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Models
{
	public class Issue
	{
		private string subject;

		public Issue(string val)
		{
			this.Subject = val;
		}

		public string Subject//auto prop
		{
			get
			{
				return subject;
			}

			set
			{
				subject = value;
			}
		}

		
	}
}
