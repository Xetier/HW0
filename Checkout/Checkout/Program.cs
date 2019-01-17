using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
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
        }
    }
}
