using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.Models
{
	public class Issue
	{
		 

		public Issue(string subjval,string numval)
		{
			this.Subject = subjval;
		    this.Number = numval;
		}

		public string Subject { get; set; }
	    public string Number { get; set; }

        public override bool Equals(object obj)
	    {
	        if (obj.GetType() != this.GetType()) return false;

	        Issue issue = (Issue)obj;
	        return (this.Subject == issue.Subject && this.Number == issue.Number);
	    }

    }
}
