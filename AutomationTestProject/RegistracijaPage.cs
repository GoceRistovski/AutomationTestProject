using OpenQA.Selenium;

namespace AutomationTestProject
{
    internal class RegistracijaPage
    {
        private IWebDriver driver;

        public RegistracijaPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement PageTitleDokaz => driver.FindElement(By.CssSelector("div[class='page-title clearfix'] h1"));

        // element za ime
        public IWebElement Name => driver.FindElement(By.Id("firstname"));

        //element za prezime
        public IWebElement Surname => driver.FindElement(By.Id("lastname"));

        //element za email adresa
        public IWebElement Email => driver.FindElement(By.Id("email_address"));

        //element za adresa
        public IWebElement Adress => driver.FindElement(By.Id("street_1"));

        //element za zipkod
        public IWebElement PostenskiBroj => driver.FindElement(By.Id("zip"));

        //element za grad
        public IWebElement City => driver.FindElement(By.Id("city"));

        //element za telefon
        public IWebElement Telephone => driver.FindElement(By.Id("telephoneCustom"));

        //element za lozinka
        public IWebElement Lozinka => driver.FindElement(By.Id("password"));

        //element za potvrda lozinka
        public IWebElement LozinkaConfirm => driver.FindElement(By.Id("confirmation"));

        //element za klikanje na registracija
        public IWebElement RegistrationButton => driver.FindElement(By.Id("createacc"));

        //dokaz deka e uspesna registracija
        public IWebElement RegistrationSuccess => driver.FindElement(By.CssSelector("li[class='success-msg'] ul li span"));
        


        //funkcija za vnes na ime
        public void EnterName(string na)
        {
            Name.Click();
            Name.SendKeys(na);
        }
        public void EnterSurname(string su)
        {
            Surname.Click();
            Surname.SendKeys(su);
        }
        public void EnterEmail(string em)
        {
            Email.Click();
            Email.SendKeys(em);
        }
        public void EnterAdress(string ad)
        {
            Adress.Click();
            Adress.SendKeys(ad);
        }
        public void EnterPostenski(string po)
        {
            PostenskiBroj.Click();
            PostenskiBroj.SendKeys(po);
        }
        public void EnterCity(string cy)
        {
            City.Click();
            City.SendKeys(cy);
        }
        public void EnterPhone(string po)
        {
            Telephone.Click();
            Telephone.SendKeys(po);
        }
        public void EnterPass(string pa)
        {
            Lozinka.Click();
            Lozinka.SendKeys(pa);
        }
        public void EnterPassConf(string paconf)
        {
            LozinkaConfirm.Click();
            LozinkaConfirm.SendKeys(paconf);
        }
        //klikanje na registracija buttonot
        public void RegistrationClick()
        {
            RegistrationButton.Click();
        }




    }
}