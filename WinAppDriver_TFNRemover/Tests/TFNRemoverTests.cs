using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using WinAppDriver_TFNRemover.MethodController;

namespace WinAppDriver_TFNRemover
{
    [TestClass]
    public class TFNRemoverTests : TestSetupTFNRemover
    {
        [TestMethod]
        public void ValidateVersion()
        {
            MainGUIMethods.ClickMenuBar(MainGUIMethods.MenuBar.Help);
            MainGUIMethods.ClickMenuItem(MainGUIMethods.MenuItem.Help_About);

            string actualVersionNumber = AboutDialogMethods.getVersionNumber();
            string expectedVersionNumber = "18.2.6533.26165";
            Assert.AreEqual(actualVersionNumber, expectedVersionNumber, 
                "Validate that the expected version number of "+expectedVersionNumber +" matches the actual of "+actualVersionNumber);
            AboutDialogMethods.clickOK();            

        }

        [TestMethod]
        public void LoadAndSaveNonProcessedPDF()
        {            
            MainGUIMethods.ClickMenuBar(MainGUIMethods.MenuBar.File);
            MainGUIMethods.ClickMenuItem(MainGUIMethods.MenuItem.Open);
            windowsFileDialogMethods.OpenFile("C:\\temp\\PDF1.pdf");
            helperMethods.ExtendElementTimeout();
            session.FindElementByName("PDF1.pdf").Click();
            helperMethods.ResetElementTimeout();


            MainGUIMethods.ClickMenuBar(MainGUIMethods.MenuBar.File);
            MainGUIMethods.ClickMenuItem(MainGUIMethods.MenuItem.Save_Output);
            windowsFileDialogMethods.SaveFile("PDF2.pdf");        
            
        }

       







        [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        Setup(context);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        TearDown();
    }
}

}
