using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Url = "http://automationpractice.com/index.php";
            _driver.Manage().Window.Maximize();

            var btnSingIn = _driver.FindElement(By.ClassName("login"));
            Console.WriteLine(btnSingIn.Text);
            btnSingIn.Click();

            var txtEmail = _driver.FindElement(By.Id("email"));
            txtEmail.Clear();
            txtEmail.SendKeys("email12@mail.com");

            var txtPasswd = _driver.FindElement(By.Id("passwd"));
            txtPasswd.Clear();
            txtPasswd.SendKeys("123456");

            var btnSubmitLogin = _driver.FindElement(By.Id("SubmitLogin"));
            Console.WriteLine(btnSubmitLogin.Text);
            btnSubmitLogin.Click();

            var Name = _driver.FindElement(By.ClassName("account"));
            var Logout = _driver.FindElement(By.ClassName("logout"));

            if (Name.Text.Equals("FirstName LastName") &&
                _driver.Url.Equals("http://automationpractice.com/index.php?controller=my-account") &&
                Logout.Text.Equals("Sign out"))
            {
                Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                //Cambiar lugar de screenshots 
                screenshot.SaveAsFile("C:\\PitDevelop\\C#\\HW0\\HW0\\LogIn\\Screenshot\\LogIn.jpg");
            }
        }
    }
}
