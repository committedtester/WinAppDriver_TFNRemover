using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using WinAppDriver_TFNRemover.MethodController;

namespace WinAppDriver_TFNRemover
{
    public class TestSetupTFNRemover
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TFNRemoverInstallLocation = @"C:\Program Files (x86)\FinSuite\TFNRemover\TFNRemover.exe";

        protected static WindowsDriver<WindowsElement> session;
        protected static WindowsElement menubar;

        public static HelperMethods helperMethods = new MethodController.HelperMethods();
        public static WindowsFileDialogMethods windowsFileDialogMethods = new MethodController.WindowsFileDialogMethods();



        public static void Setup(TestContext context)
        {
            // Launch a new instance of TFNRemover application
            if (session == null)
            {
                // Create a new session to TFNRemover application
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", TFNRemoverInstallLocation);
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(session);
                Assert.IsNotNull(session.SessionId);
                Assert.AreEqual("FinSuite - TFN Remover", session.Title, @"Verify that TFNRemover is started with the standard title");

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1.5)); //Default was 1.5 seconds

                //Keep track of the edit box to be used throughout the session
                menubar = session.FindElementByName("menuStrip1");
                Assert.IsNotNull(menubar);
            }


        }


        public static void TearDown()
        {
            // Close the application and delete the session
            if (session != null)
            {
                session.Close();

                try
                {
                    // Dismiss Save dialog if it is blocking the exit                    
                    //session.FindElementByName("Don't Save").Click();
                }
                catch { }

                session.Quit();
                session = null;
            }
        }


        [TestInitialize]
        public void TestInitialize()
        {
            // Select all text and delete to clear the edit box
            //editBox.SendKeys(Keys.Control + "a" + Keys.Control);
            //editBox.SendKeys(Keys.Delete);
            //Assert.AreEqual(string.Empty, editBox.Text);
        }


    }
}
