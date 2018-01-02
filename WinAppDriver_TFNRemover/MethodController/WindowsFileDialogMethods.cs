using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver_TFNRemover.MethodController
{
    public class WindowsFileDialogMethods: TestSetupTFNRemover
    {
        protected static WindowsElement windowsDialog; 

        public void OpenFile(string filename)
        {
            windowsDialog = session.FindElementByName("Open File(s) for TFN Removal");

            var fileName = windowsDialog.FindElementByClassName("Edit");            
            fileName.SendKeys(filename + Keys.Enter);
        }

        public void SaveFile(string filename)
        {
            windowsDialog = session.FindElementByName("Save TFN Removed File");

            var fileName = windowsDialog.FindElementByClassName("Edit");
            fileName.SendKeys(filename + Keys.Enter);
        }

    }
}
