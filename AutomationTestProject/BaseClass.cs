using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestProject
{
    public class BaseClass
    {
        public IWebDriver driver;
        public string webpage = "https://www.topshop.com.mk/";
        public WebDriverWait wait;
        internal Homepage page;
        internal KujnaPage pageKujna;
        internal DomacinstvoPage pageDomacinstvo;
        internal RegistracijaPage pageRegis;
        internal LoginPage pageLogin;
        internal CartPage pageCart;
        internal Random rnd;
        internal CostumerPage pageCostumer ;


        [SetUp]
        public void setiranje()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(webpage);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            page = new Homepage(driver);
            pageKujna = new KujnaPage(driver);
            pageDomacinstvo = new DomacinstvoPage(driver);
            pageRegis = new RegistracijaPage(driver);
            pageLogin = new LoginPage(driver);
            pageCart = new CartPage(driver);
            rnd = new Random();
            pageCostumer = new CostumerPage(driver);



        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}