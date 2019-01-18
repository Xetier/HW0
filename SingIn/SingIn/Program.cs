using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingIn
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Url = "http://automationpractice.com/index.php";
            _driver.Manage().Window.Maximize();

            var btnSignIn = _driver.FindElement(By.ClassName("login"));
            Console.WriteLine(btnSignIn.Text);
            btnSignIn.Click();

            var txtEmailCreate = _driver.FindElement(By.Id("email_create"));
            txtEmailCreate.Clear();
            txtEmailCreate.SendKeys("email123@mail.com");

            var btnCreateAccount = _driver.FindElement(By.Id("SubmitCreate"));
            Console.WriteLine(btnCreateAccount.Text);
            btnCreateAccount.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var rbtnTittle = _driver.FindElements(By.Name("id_gender"));
            if (rbtnTittle[0].GetAttribute("value").Equals("1"))
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Mrs.");
            }
            rbtnTittle[0].Click();

            var txtFirstName = _driver.FindElement(By.Id("customer_firstname"));
            txtFirstName.SendKeys("FirstName");

            var txtLastName = _driver.FindElement(By.Id("customer_lastname"));
            txtLastName.Clear();
            txtLastName.SendKeys("LastName");

            var txtPassword = _driver.FindElement(By.Id("passwd"));
            txtPassword.Clear();
            txtPassword.SendKeys("123456");

            var cbxBirthDays = _driver.FindElement(By.Id("days"));
            var selectElementBirthDays = new SelectElement(cbxBirthDays);
            selectElementBirthDays.SelectByValue("7");
            Console.WriteLine("Day: " + selectElementBirthDays.SelectedOption.Text);

            var cbxBirthMonth = _driver.FindElement(By.Id("months"));
            var selectElementBirthMonth = new SelectElement(cbxBirthMonth);
            selectElementBirthMonth.SelectByValue("7");
            Console.WriteLine("Month: " + selectElementBirthMonth.SelectedOption.Text);

            var cbxBirthYear = _driver.FindElement(By.Id("years"));
            var selectElementBirthYear = new SelectElement(cbxBirthYear);
            selectElementBirthYear.SelectByValue("1955");
            Console.WriteLine("Year: " + selectElementBirthYear.SelectedOption.Text);

            var chbxNewsLetter = _driver.FindElement(By.Id("newsletter"));
            chbxNewsLetter.Click();
            Console.WriteLine("Checked: Sign up for our newsletter!");

            var chbxOptin = _driver.FindElement(By.Id("optin"));
            chbxOptin.Click();
            Console.WriteLine("Checked: Receive special offers from our partners!");

            var txtCompany = _driver.FindElement(By.Id("company"));
            txtCompany.Clear();
            txtCompany.SendKeys("CompanyTest");

            var txtAddress1 = _driver.FindElement(By.Id("address1"));
            txtAddress1.Clear();
            txtAddress1.SendKeys("Address1");

            var txtAddress2 = _driver.FindElement(By.Id("address2"));
            txtAddress2.Clear();
            txtAddress2.SendKeys("Address2");

            var txtCity = _driver.FindElement(By.Id("city"));
            txtCity.Clear();
            txtCity.SendKeys("Juliet");

            var cbxState = _driver.FindElement(By.Id("id_state"));
            var selectElementState = new SelectElement(cbxState);
            selectElementState.SelectByText("California");
            Console.WriteLine("State: " + selectElementState.SelectedOption.Text);

            var txtPostcode = _driver.FindElement(By.Id("postcode"));
            txtPostcode.Clear();
            txtPostcode.SendKeys("12345");

            var cbxCountry = _driver.FindElement(By.Id("id_country"));
            var selectElementCountry = new SelectElement(cbxCountry);
            selectElementCountry.SelectByText("United States");
            Console.WriteLine("Country: " + selectElementCountry.SelectedOption.Text);

            var txtaOther = _driver.FindElement(By.Id("other"));
            txtaOther.Clear();
            txtaOther.SendKeys("Additional Test");

            var txtPhone = _driver.FindElement(By.Id("phone"));
            txtPhone.Clear();
            txtPhone.SendKeys("+51 0123456789");

            var txtPhoneMobile = _driver.FindElement(By.Id("phone_mobile"));
            txtPhoneMobile.Clear();
            txtPhoneMobile.SendKeys("+51 999123456");

            var txtAlias = _driver.FindElement(By.Id("alias"));
            txtAlias.Clear();
            txtAlias.SendKeys("My address");

            var btnSubmitAccount = _driver.FindElement(By.Id("submitAccount"));
            Console.WriteLine(btnSubmitAccount.Text);
            btnSubmitAccount.Click();

            var Name = _driver.FindElement(By.ClassName("account"));
            var Logout = _driver.FindElement(By.ClassName("logout"));

            Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();

            if (Name.Text.Equals("FirstName LastName") &&
                _driver.Url.Equals("http://automationpractice.com/index.php?controller=my-account") &&
                Logout.Text.Equals("Sign out"))
            {
                
                //Cambiar lugar de screenshots 
                screenshot.SaveAsFile("C:\\PitDevelop\\C#\\HW0\\HW0\\SingIn\\Screenshot\\SingIn.jpg");
            }
            else
            {
                screenshot.SaveAsFile("C:\\PitDevelop\\C#\\HW0\\HW0\\SingIn\\Screenshot\\FAILSingIn.jpg");
            }
        }
    }
}
