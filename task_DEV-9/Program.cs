using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using task_DEV_9.PageObject;

namespace task_DEV9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input login:");
            string login = Console.ReadLine();
            Console.WriteLine("Input password:");
            string password = Console.ReadLine();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://vk.com");
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email.SendKeys(login);
            loginPage.Password.SendKeys(password);
            loginPage.Login.Click();

            FeedPage feedPage = new FeedPage(driver);
            feedPage.goToPage();
            Console.WriteLine(feedPage.LastFeed.Text);
            feedPage.Photos.Click();

            DialoguesPage dialoguesPage = new DialoguesPage(driver);
            dialoguesPage.goToPage();
            dialoguesPage.LastMessage.Click();
            Console.WriteLine(dialoguesPage.LastMessage.Text);

            FriendsPage friendsPage = new FriendsPage(driver);
            friendsPage.goToPage();
            Console.WriteLine(friendsPage.FriendsList.Text);

            driver.Close();
            driver.Quit();
        }
    }

}