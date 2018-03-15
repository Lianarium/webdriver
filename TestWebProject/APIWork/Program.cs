using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWork
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new Client();
			client.EndPoint = @"http://icerow.com/issues.xml?key=b3f95764010f8b141fa9c27a559376ec00eb69a7";
			client.Method = Verb.GET;
			var pdata = client.PostData;
			var response = client.Request("");
		}
	}
}
