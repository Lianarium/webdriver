using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary
{
	public class Logger
	{
		public static string LOGFILE = "Log.txt";

		public static void WriteLog(string information)
		{
			using (StreamWriter w = File.AppendText(LOGFILE))
			{
				Log("Incorrect data: " + information, w);
			}
		}

		public static void Log(string logMessage, TextWriter w)
		{
			w.Write("\r\nLog Entry : ");
			w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
				DateTime.Now.ToLongDateString());
			w.WriteLine("  :");
			w.WriteLine("  :{0}", logMessage);
			w.WriteLine("-------------------------------");
		}
	}
}
