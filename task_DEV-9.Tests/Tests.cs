using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace task_DEV9.Tests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl("https://vk.com");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email.SendKeys("375445150780");
            loginPage.Password.SendKeys("password");
            loginPage.Login.Click();
        }

        [Test]
        public void LastFeed()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.goToPage();
            loginPage.Email.SendKeys("375445150780");
            loginPage.Password.SendKeys("password");
            loginPage.Login.Click();

            FeedPage feedPage = new FeedPage(driver);
            feedPage.goToPage();
            feedPage.LastFeed.Click();
        }

        [Test]
        public void LastMessage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.goToPage();
            loginPage.Email.SendKeys("375445150780");
            loginPage.Password.SendKeys("password");
            loginPage.Login.Click();

            DialoguesPage dialoguesPage = new DialoguesPage(driver);
            dialoguesPage.goToPage();
            dialoguesPage.LastMessage.Click();
        }

        [Test]
        public void Friends()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.goToPage();
            loginPage.Email.SendKeys("375445150780");
            loginPage.Password.SendKeys("password");
            loginPage.Login.Click();

            FeedPage feedPage = new FeedPage(driver);
            feedPage.goToPage();
            feedPage.Friends.Click();
        }

        [Test]
        public void Photos()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.goToPage();
            loginPage.Email.SendKeys("375445150780");
            loginPage.Password.SendKeys("password");
            loginPage.Login.Click();

            FeedPage feedPage = new FeedPage(driver);
            feedPage.goToPage();
            feedPage.Photos.Click();
        }
    }
}
