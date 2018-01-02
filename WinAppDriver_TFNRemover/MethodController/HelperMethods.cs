using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using System;
using System.Resources;

namespace WinAppDriver_TFNRemover.MethodController
{
    public class HelperMethods : TestSetupTFNRemover
    {
        public void ExtendElementTimeout(double seconds=5)
        {
            session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds)); 
        }

        public void ResetElementTimeout(double seconds =1.5)
        {
            session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(seconds)); 
        }


        #region Experimental

        public Byte getPDFResourceByName(string name)
        {
            string resourceName = "WinAppDriver_TFNRemover.Resources.PDF_Files.resx";
            ResourceManager rm = new ResourceManager(resourceName, GetType().Assembly);
            return (Byte)rm.GetObject(name);
        }

        public bool ElementDisplayed(AppiumWebElement elementName)
        {
            try
            {
                if (elementName.GetAttribute("Displayed") == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool ElementOffScreen(AppiumWebElement elementName)
        {
            try
            {
                if (elementName.GetAttribute("IsOffscreen") == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ElementOnScreen(AppiumWebElement elementName)
        {
            try
            {
                if (elementName.GetAttribute("IsOffscreen") == "false")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            } 
        }

        public void WaitUntilElementDisplayed(AppiumWebElement elementName, int iteration = 5)
        {
            int counter = 0;
            while (counter < iteration)
            {

                if (ElementDisplayed(elementName))
                {
                    return;
                }
                Console.WriteLine(DateTime.Now + "Waiting until element " + elementName + " is visible... " + counter);
                counter++;
            }
            Assert.IsTrue(ElementDisplayed(elementName), "Validating element is visible for element: " + elementName);
        }

        public void WaitUntilElementOnScreen(AppiumWebElement elementName, int iteration=5)
        {
            int counter = 0;
            while (counter < iteration)
            {

                if (ElementOnScreen(elementName))
                {
                    return;
                }
                Console.WriteLine(DateTime.Now + "Waiting until element " + elementName + " is visible... " + counter);
                counter++;
            }
            Assert.IsTrue(ElementOnScreen(elementName), "Validating element is visible for element: " + elementName);           
        }
        #endregion

    }

}
