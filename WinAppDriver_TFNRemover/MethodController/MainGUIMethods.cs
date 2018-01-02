using OpenQA.Selenium;

namespace WinAppDriver_TFNRemover.MethodController
{
    class MainGUIMethods:TestSetupTFNRemover
    {
        public static void ClickHelpMenuBar()
        {
            menubar.FindElementByName("Help").Click();
        }


        public static void ClickMenuBar(MenuBar menuBar)
        {
            menubar.FindElementByName(menuBar.ToString()).Click();
        }

        public enum MenuBar{
            File,
            Settings,
            Help
        };


        public enum MenuItem
        {
            Open,
            Open_From_Scanner_Via_FlatBed,
            Open_From_Scanner_Via_DocumentFeeder,
            Save_Output,
            Print,
            Exit,
            Help_About
        };

        public static void ClickMenuItem(MenuItem menuitem)            
        {
            //using Keyboard approach as a result of winforms incompatibility
            switch (menuitem)
            {
                case MenuItem.Open:
                    menubar.SendKeys(Keys.ArrowDown + Keys.Enter);
                    break;
                case MenuItem.Open_From_Scanner_Via_FlatBed:
                    break;
                case MenuItem.Open_From_Scanner_Via_DocumentFeeder:
                    break;
                case MenuItem.Save_Output:
                    menubar.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
                    break;
                case MenuItem.Print:
                    break;
                case MenuItem.Exit:
                    break;
                case MenuItem.Help_About:
                    menubar.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
                    break;
                default:
                    break;
            }
        }  

    }
}
