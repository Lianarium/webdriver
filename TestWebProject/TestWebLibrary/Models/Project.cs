using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Models
{
	public class Project
	{
		private string _name;
		 

		public Project(string name)
		{
			this.Name = name;
			 
		}

		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
			}
		}

		 
		 

	}
}
