using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAN.Tests
{
    public class RegisterTests : BaseTest
    {

        [Test]
        public void RegisterForm_DisplaysDOBRequiredError()
        {
            homePage.JoinNowButton.Click();
            registerPage.SelectElementFromDropdown("Mr");
            registerPage.FillFirstAndLastName("Radoslav", "Stoyanov");
            registerPage.ClickCheckboxIfNotClicked();
            registerPage.registerButton.Click();

            Assert.That(registerPage.dobError.Text, Is.EqualTo("This field is required"));
        }
        //TEST%20TEST%20
    }
}
