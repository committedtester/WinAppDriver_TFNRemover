# To replicate locally 
* Install https://github.com/Microsoft/WinAppDriver (version 1.0 tested)
* Run "C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe" as an administrator

# UI Automation (using inspect.exe)
| Client API                   | Locator Strategy | Matched Attribute in inspect.exe        | Example       |
|------------------------------|------------------|-----------------------------------------|---------------|
| FindElementByAccessibilityId | accessibility id | AutomationId                            | AppNameTitle  |
| FindElementByClassName       | class name       | ClassName                               | TextBlock     |
| FindElementById              | id               | RuntimeId (decimal)                     | 42.333896.3.1 |
| FindElementByName            | name             | Name                                    | Calculator    |
| FindElementByTagName         | tag name         | LocalizedControlType (upper camel case) | Text          |
| FindElementByXPath           | xpath            | Any                                     | //Button[0]   |