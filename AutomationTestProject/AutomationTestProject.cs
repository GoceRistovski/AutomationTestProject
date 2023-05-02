using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTestProject
{
    [TestFixture]
    public class TestCases : BaseClass

    {
        [Test]
        public void DomacinstvoElements()
        {
            page.DomacinstvoKlik();
            Assert.IsTrue(page.TitleDomacinstvo.Text.Contains("Домаќинство"));
        }
        [Test]
        public void KujnaElement()
        {
            page.KujnaKlik();
            Assert.IsTrue(page.KujnaKliknata.Text.Contains("Kујна"));
        }
        [Test]
        public void ElektricniAparati()
        {
            page.KujnaKlik();
            pageKujna.ElektrickiAparatiClick();
            Assert.AreEqual("Електрични апарати", pageKujna.OtvoreniElektricni.Text);
        }
        [Test]
        public void SpalnaImaElementi()
        {
            page.DomacinstvoKlik();
            pageDomacinstvo.SpalnaClick();
            Assert.IsTrue(driver.Url.Contains("spalna"));

        }
        [Test]
        public void RegistracijaUserSeOtvara()
        {
            page.DomacinstvoKlik();
            page.registracijaKlik();
            Assert.IsTrue(pageRegis.PageTitleDokaz.Text.Contains("Креирајте корисничка сметка"));
        }
        [Test]
        public void Registracijaforma()
        {
            int num = rnd.Next();
            string userName1 = "gocetestautomation" + num  *1000+ "@gmail.com";
            page.DomacinstvoKlik();
            page.registracijaKlik();
            pageRegis.EnterName("Goce");
            pageRegis.EnterSurname("Ristovski");
            pageRegis.EnterEmail(userName1);
            pageRegis.EnterAdress("Ulica i broj");
            pageRegis.EnterPostenski("1000");
            pageRegis.EnterPhone("070233305");
            pageRegis.EnterPass("dragonwarrior");
            pageRegis.EnterPassConf("dragonwarrior");
            pageRegis.RegistrationClick();

            

            Assert.AreEqual("Ви благодариме што се регистриравте.", pageRegis.RegistrationSuccess.Text, "The User Is Not Registered");
        }
        [Test]
        public void LoginForma()
        {
            page.NajavaClick();
            pageLogin.LoginSubmit("gocetestautomation@gmail.com", "dragonwarrior");
            Assert.AreEqual("Информации за корисничката сметка", pageCostumer.DokazDekaELogiran.Text, "The user is NOT logged in");
        }
        [Test]
        public void LoginThenAddToChart()
        {
            page.NajavaClick();
            pageLogin.LoginSubmit("GoceTestAutomation@google.com", "dragonwarrior");
            pageCostumer.SportKlik();
            Thread.Sleep(2000);
            pageCostumer.CookieeKlik();
            pageCostumer.EMSTonerPovekeKlik();
            pageCostumer.KosnickaKlik();
            Assert.IsTrue(pageCart.SuccesMessageForCard.Text.Contains("е додаден во вашата кошничка"));
        }
    }
}


