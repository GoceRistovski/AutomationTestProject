using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class Homepage : BaseClass
    {
        private IWebDriver driver { get; set; }

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //element domacinstvo
        public IWebElement Domacinstvo => driver.FindElement(By.XPath("//span[contains(text(),'Домаќинство')]"));

        public IWebElement TitleDomacinstvo => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));

        //element kujna
        public IWebElement Kujna => driver.FindElement(By.XPath("//span[contains(text(),'Kујна')]"));

        //dokaz deka e kliknata kujna
        public IWebElement KujnaKliknata => driver.FindElement(By.CssSelector("div[class='page-title category-title clearfix'] h1"));

        //Element da se klikne registracija/login
        public IWebElement Registracija => driver.FindElement(By.CssSelector(".sign-in.header-over-block.top-nav-shadow "));

        // registrirajse kopce
        public IWebElement RegistracijaKopce => driver.FindElement(By.CssSelector("a[title='Register ']"));

        //element za najava na korisnik
        public IWebElement Najava => driver.FindElement(By.CssSelector("a[title='Најавете се']"));

        public DomacinstvoPage DomacinstvoKlik()
        {
            Domacinstvo.Click();
            return new DomacinstvoPage(driver);
        }
        public KujnaPage KujnaKlik()
        {
            Kujna.Click();
            return new KujnaPage(driver);
        }
        //Funkcija za registracija
        public RegistracijaPage registracijaKlik()
        {
            Registracija.Click();
            RegistracijaKopce.Click();
            return new RegistracijaPage(driver);
        }

        //Funckija za najava
        public LoginPage NajavaClick()
        {
            Registracija.Click();
            Najava.Click();
            return new LoginPage(driver);
        }
    }
}