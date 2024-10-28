using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAN.Pages
{
    public class RegisterPage : HomePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement dropdownElement => driver.FindElement(By.Id("title"));
        public IWebElement firstName => driver.FindElement(By.Id("forename"));
        public IWebElement lastName => driver.FindElement(By.XPath("//input[@name='map(lastName)']"));
        public IWebElement checkbox => driver.FindElement(By.XPath("//input[@name='map(terms)']"));
        public IWebElement registerButton => driver.FindElement(By.XPath("//input[@id='form']"));
        public IWebElement dobError => driver.FindElement(By.XPath("//label[@for='dob']"));
   
        public void SelectElementFromDropdown(string elementName)
        {
            SelectElement select = new SelectElement(dropdownElement);
            select.SelectByText(elementName);
        }
        public void FillFirstAndLastName(string foreName, string familyName)
        {
            firstName.SendKeys(foreName);
            lastName.SendKeys(familyName);
        }
        public void ClickCheckboxIfNotClicked()
        {
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
        }


    }

}