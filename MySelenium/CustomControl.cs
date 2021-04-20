

using OpenQA.Selenium;

namespace MySelenium
{
    public class CustomControl: DriverHelper
    {
        public static void comboControl(string controlName, string value)
        {
            IWebElement comboBox = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboBox.Clear();
            comboBox.SendKeys(value);

            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
