using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Models
{
	public class Note
	{

		public Note(string text)
		{
			this.Text = text;
		}

		public string Text { get; set; }

	}
}
