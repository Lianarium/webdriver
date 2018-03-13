using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using NUnit.Framework.Internal;

namespace TestWebLibrary
{
	public class Logger:ILogger
	{
		 
		   private static ILog log = LogManager.GetLogger("LOGGER");
		   private ILogger _loggerImplementation;


		public static ILog Log
			{
				get { return log; }
			}

			public static void InitLogger()
			{
				XmlConfigurator.Configure();
			}

		public void Error(string message)
		{
			throw new NotImplementedException();
		}

		public void Error(string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warning(string message)
		{
			throw new NotImplementedException();
		}

		public void Warning(string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info(string message)
		{
			throw new NotImplementedException();
		}

		public void Info(string message, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message)
		{
			throw new NotImplementedException();
		}

		public void Debug(string message, params object[] args)
		{
			throw new NotImplementedException();
		}
	}



	}
	

