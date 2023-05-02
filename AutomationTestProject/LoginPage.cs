using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // element za username
        public IWebElement UsernameField => driver.FindElement(By.Name("login[username]"));

        //element za pass
        public IWebElement PassField => driver.FindElement(By.Id("pass"));

        //element za loginButton
        public IWebElement SubmitButton => driver.FindElement(By.Id("send2"));

       

        //funkcija za sumit na formata
        public CostumerPage LoginSubmit(string userName, string passWord)
        {
            UsernameField.Click();
            UsernameField.SendKeys(userName);
            PassField.Click();
            PassField.SendKeys(passWord);
            SubmitButton.Click();
            return new CostumerPage(driver);


        }

    }
}