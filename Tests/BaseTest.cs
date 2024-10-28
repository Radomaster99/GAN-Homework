using GAN.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAN.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
        public HomePage homePage;
        public RegisterPage registerPage;

        [OneTimeSetUp] 
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);

            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);

            homePage.NavigateToHomePage();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            driver.Dispose();
        }





    }

}
