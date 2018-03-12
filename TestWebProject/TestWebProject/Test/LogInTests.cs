using System.Reflection.Emit;
using NUnit.Framework;
using TestWebLibrary.Models;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{

	[TestFixture]
	[Parallelizable(ParallelScope.All)]
	public class LogInTests:BaseTest
	{
		public LogInTests()
		{
			IsLoginRequired = false;
		}

		 
		[Test]
		public void LogInTest()
		{
			User user = new User(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
			SetUp.LoginCondition = true;
			CheckLogInSteps step = new CheckLogInSteps();
			PageTitle actualTitle = step.LogIn(user).GetTitle();
			Assert.AreEqual(step.GetExpectedHomePage().GetTitle().TitleText, actualTitle.TitleText);
		}

	}
}