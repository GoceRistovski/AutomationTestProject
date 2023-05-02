using System;
using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class KujnaPage
    {
        private IWebDriver driver;

        public KujnaPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement ElektrickiAparatiElement => driver.FindElement(By.XPath("//a[@class='level3'][contains(text(),'Електрични апарати')]"));

        //dokaz deka e otvorena strana elektricni aparati
        public IWebElement OtvoreniElektricni => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));

        internal void ElektrickiAparatiClick()
        {
            ElektrickiAparatiElement.Click();
        }
    }
}