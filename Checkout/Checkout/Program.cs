using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeout = 60;
            IWebDriver _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            _driver.Url = "http://automationpractice.com/index.php";
            _driver.Manage().Window.Maximize();

            var btnSingIn = _driver.FindElement(By.ClassName("login"));
            Console.WriteLine(btnSingIn.Text);
            btnSingIn.Click();

            var txtEmail = _driver.FindElement(By.Id("email"));
            txtEmail.Clear();
            txtEmail.SendKeys("email1@mail.com");

            var txtPasswd = _driver.FindElement(By.Id("passwd"));
            txtPasswd.Clear();
            txtPasswd.SendKeys("123456");

            var btnSubmitLogin = _driver.FindElement(By.Id("SubmitLogin"));
            Console.WriteLine(btnSubmitLogin.Text);
            btnSubmitLogin.Click();


            var btnWomen = _driver.FindElement(By.CssSelector("[href*='http://automationpractice.com/index.php?id_category=3&controller=category']"));
            Console.WriteLine(btnWomen.Text);
            btnWomen.Click();


            var lnkFadedShortSleeveT_shirts = _driver.FindElement(By.XPath("(//a[@title='Faded Short Sleeve T-shirts'])[2]"));
            Console.WriteLine(lnkFadedShortSleeveT_shirts.GetAttribute("title"));
            lnkFadedShortSleeveT_shirts.Click();

            var btnAddToCart = _driver.FindElement(By.Id("add_to_cart"));
            Console.WriteLine(btnAddToCart.Text);
            btnAddToCart.Click();

            var btnProceedToCheckout1 = _driver.FindElement(By.XPath("(//a[@title='Proceed to checkout'])"));
            Console.WriteLine("Proceed to checkout 1");
            btnProceedToCheckout1.Click();

            var btnProceedToCheckout2 = _driver.FindElement(By.XPath("(//a[@title='Proceed to checkout'])[2]"));
            Console.WriteLine("Proceed to checkout 2");
            btnProceedToCheckout2.Click();

            var btnProceedToCheckout3 = _driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));
            Console.WriteLine("Proceed to checkout 3");
            btnProceedToCheckout3.Click();

            var chbxTermsAndService = _driver.FindElement(By.Id("cgv"));
            Console.WriteLine("I agree to the terms of service and will adhere to them unconditionally.");
            chbxTermsAndService.Click();

            var btnProceedToCheckout4 = _driver.FindElement(By.XPath("//*[@id='form']/p/button"));
            Console.WriteLine("Proceed to checkout 4");
            btnProceedToCheckout4.Click();




            try
            {

                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            


        }
    }
}
