using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Models
{
	public class Project
	{
		private string name;
		private string id;

		public Project(string name)
		{
			this.Name = name;
			 
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		 
		 

	}
}
