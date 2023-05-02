using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class DomacinstvoPage : BaseClass
    {
        private IWebDriver driver;

        public DomacinstvoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // element spalna
        public IWebElement SpalnaElement => driver.FindElement(By.XPath("//a[@class='level3'][contains(text(),'Спална')]"));


        public void SpalnaClick()
        {
            SpalnaElement.Click();
        }
    }
}