
using OpenQA.Selenium.Appium.Windows;
using System;

namespace WinAppDriver_TFNRemover.MethodController
{
    class AboutDialogMethods: TestSetupTFNRemover
    {
        private static WindowsElement aboutDialogElement()
        {
            return session.FindElementByName("About TFN Remover");
        }

        public static string getVersionNumber()
        {
            var versionNumber = aboutDialogElement().FindElementByAccessibilityId("label2").GetAttribute("Name");
            Console.WriteLine(versionNumber);
            return versionNumber;
        }

        public static void clickOK()
        {
            aboutDialogElement().FindElementByName("OK").Click();
        }

        



    }
}
