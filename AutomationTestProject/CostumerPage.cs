using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationTestProject
{
    internal class CostumerPage : BaseClass
    {
        private IWebDriver driver;

        public CostumerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //element za dokaz deka korisnikot e logiran
        public IWebElement DokazDekaELogiran => driver.FindElement(By.CssSelector("div[class='account-box'] div[class='account-hdr account-hdr-row-one clearfix'] h2"));

        //element za sport i rekreacija
        public IWebElement SportIRekreacija => driver.FindElement(By.XPath("//span[contains(text(),'Спорт и рекреација')]"));



        //Element Poveke za EMS TONER
        public IWebElement EMSTonerPoveke => driver.FindElement(By.Id("product-collection-image-215077"));

        //Element za klik na VO KOSNICKA
        public IWebElement Vokosnicka => driver.FindElement(By.CssSelector(".button.btn-cart"));


        public IWebElement Cookiee => driver.FindElement(By.Id("c-p-bn"));

        //funckija za klik na sport i rekreacija
        public void SportKlik()
        {
            SportIRekreacija.Click();
        }
        //funckija za klik na poveke za EMS TONER POVEKE
        public void EMSTonerPovekeKlik()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(22));
            wait.Until(ExpectedConditions.ElementToBeClickable(EMSTonerPoveke)).Click();
        }
        //klik na kosnicka
        public CartPage KosnickaKlik()
        {
            Vokosnicka.Click();
            return new CartPage(driver);
        }
        public void CookieeKlik()
        {
            
            Cookiee.Click();
        }
        
    }



}