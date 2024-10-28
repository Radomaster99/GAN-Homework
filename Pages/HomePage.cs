using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAN.Pages
{
    public class HomePage : BasePage
    {
        protected const string BaseUrl = "https://moneygaming.qa.gameaccount.com/";


        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement JoinNowButton => driver.FindElement(By.XPath("//a[@class='newUser green']"));

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

    }
}
