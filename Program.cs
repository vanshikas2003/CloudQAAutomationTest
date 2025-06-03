using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

class Program
{
    static void Main()
    {
        ChromeOptions options = new ChromeOptions();
        using (IWebDriver driver = new ChromeDriver(options))
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                // ✅ Switch into iframe (correct ID)
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id("iframeId")));

                // First Name
                var firstName = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Name']")));
                firstName.SendKeys("Vanshika");

                // Last Name
                var lastName = wait.Until(d => d.FindElement(By.XPath("//input[@placeholder='Surname']")));
                lastName.SendKeys("Singh");

                // ✅ Gender: Select Female radio button using ID
                var femaleRadio = wait.Until(d => d.FindElement(By.Id("female")));
                femaleRadio.Click();

                // ✅ Mobile: Use ID for better targeting
                var mobile = wait.Until(d => d.FindElement(By.Id("mobile")));
                mobile.SendKeys("9876543210");

                Console.WriteLine("Form fields inside iframe filled successfully.");
                System.Threading.Thread.Sleep(5000); // Optional pause to view
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
