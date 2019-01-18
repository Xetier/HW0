using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SignIn.Steps
{
    class SignInSteps
    {
        IWebDriver _driver = Hooks.WebDriver;

        [Step("Go to <url>")]
        public void GoToAutomationpractice(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }

        [Step("Click to button SingIn ")]
        public void ClickToButtonSingIn()
        {
            _driver.FindElement(By.ClassName("login")).Click();
        }

        [Step("Fill email_create with <email>")]
        public void FillEmailCreate(string email)
        {
            _driver.FindElement(By.Id("email_create")).SendKeys(email);
        }
        [Step("Click on Submit Create")]
        public void ClickOnSubmitCreate()
        {
            _driver.FindElement(By.Id("SubmitCreate")).Click();
        }

        [Step("I wait <seconds> seconds")]
        public void WaitFor(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        [Step("Click on Mr")]
        public void ClickOnMr()
        {
            _driver.FindElements(By.Name("id_gender"))[0].Click();
        }

        [Step("Fill first name in customer_firstname field with <firstName>")]
        public void FillFirstNameField(string firstName)
        {
            _driver.FindElement(By.Id("customer_firstname")).SendKeys(firstName);
        }

        [Step("Fill last name in customer_lastname field with <lastName>")]
        public void FillLasttNameField(string lastName)
        {
            _driver.FindElement(By.Id("customer_lastname")).SendKeys(lastName);
        }

        [Step("Fill password in passwd field with <password>")]
        public void FillPasswordField(string password)
        {
            _driver.FindElement(By.Id("passwd")).SendKeys(password);
        }
        [Step("Pick day <day> in birthday day combobox")]
        public void PickBirthDayDay(string day)
        {
            var cbxBirthDays = _driver.FindElement(By.Id("days"));
            var selectElementBirthDays = new SelectElement(cbxBirthDays);
            selectElementBirthDays.SelectByText(day);
        }

        [Step("Pick month <month> in birthday month combobox")]
        public void PickBirthDayMonth(string month)
        {
            var cbxBirthMonth = _driver.FindElement(By.Id("months"));
            var selectElementBirthMonth = new SelectElement(cbxBirthMonth);
            selectElementBirthMonth.SelectByText(month);
        }

        [Step("Pick year <year> in birthday year combobox")]
        public void PickBirthDayYear(string year)
        {
            var cbxBirthYear = _driver.FindElement(By.Id("years"));
            var selectElementBirthYear = new SelectElement(cbxBirthYear);
            selectElementBirthYear.SelectByText(year);
        }
        [Step("Check Sign up for our newsletter! and Receive special offers from our partners!")]
        public void CheckNewsletterAndSO()
        {
            _driver.FindElement(By.Id("newsletter")).Click();
            _driver.FindElement(By.Id("optin")).Click();
        }
    }
}
