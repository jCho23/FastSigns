using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace FastSigns
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void FirstTest()
		{
			app.Tap("button_accept_terms");
			app.Screenshot("Lets Tap on the 'Accept' Button");

			app.Tap("alertIcon");
			app.Screenshot("Then we will Tap on the 'Alert' Icon");

			app.Back();
			app.Screenshot("We Tapped the Back Button");

			app.Tap(x => x.Class("android.widget.TextView").Index(1));
			app.Screenshot("Next, we will Tap on the 'About' Icon");

			app.Back();
			app.Screenshot("We Tapped the Back Button");

			app.Tap(x => x.Class("android.widget.TextView").Index(2));
			app.Screenshot("Then we Tap on the Sales Summit");

			app.Tap("email");
			app.Screenshot("We Tapped on the E-Mail Text Field");
			app.EnterText("FastSigns@microsoft.com");
			app.Screenshot("Then, we entered our E-Mail");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("password");
			app.Screenshot("We Tapped on the password field");
			app.EnterText("love");
			app.Screenshot("Then, we entered in our password");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("btn_login");
			app.Screenshot("Next, we Tapped on the Login Button");

			app.Tap("button1");
			app.Screenshot("We Tapped on the Ok Button");

			app.Tap("forgot_password");
			app.Screenshot("Then, we Tapped on the 'Forget Password' Button");

			app.Tap("email");
			app.Screenshot("We Tapped on the E-Mail Text Field");
			app.EnterText("FastSigns@microsoft.com");
			app.Screenshot("Then, we entered our E-Mail");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("btn_submit");
			app.Screenshot("Then, we Tapped on the Submit Button");
		}

	}
}
