using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Pregled na kosnicka
        public IWebElement SuccesMessageForCard => driver.FindElement(By.CssSelector("li[class='success-msg'] ul li span"));
    }
}