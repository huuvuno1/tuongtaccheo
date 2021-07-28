
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuongTacCheo
{
    public partial class Form1 : Form
    {
        enum Misson
        {
            FOLLOW, LIKE_PAGE
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jdkslfjasld");
            System.IO.Stream ms = File.OpenWrite("data.txt");
            BinaryFormatter formatter = new BinaryFormatter();
            List<Info> infos = new List<Info>();
            for (int i = 0; i < listInfo.Rows.Count - 1; i++)
            {
                string username = listInfo.Rows[i].Cells["txtUsername"].Value.ToString();
                string password = listInfo.Rows[i].Cells["txtPassword"].Value.ToString();
                string cookie = listInfo.Rows[i].Cells["txtCookie"].Value.ToString();
                new Thread(() => Start(username, password, GetCookies(cookie))).Start();
                infos.Add(new Info(username, password, cookie));
            }
            if (infos != null)
                formatter.Serialize(ms, infos);
            ms.Flush();
            ms.Close();
        }

        private void Start(String username, String password, List<Cookie> cookies)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var chromeOption = new ChromeOptions();
            chromeOption.AddArgument("--disable-popup-blocking");
            ChromeDriver driver = new ChromeDriver(driverService, chromeOption, TimeSpan.FromSeconds(80.0));
            driver.Manage().Window.Size = new Size(500, 700);
            driver.Navigate().GoToUrl("https://facebook.com");

            foreach (Cookie cookie in cookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }
            driver.Navigate().Refresh();

            driver.Navigate().GoToUrl("https://tuongtaccheo.com/");
            driver.FindElementByXPath("//*[@id='memberModal']/div/div/div[1]/button/span").Click();
            driver.FindElementById("name").SendKeys(username);
            driver.FindElementById("password").SendKeys(password);
            driver.FindElementByXPath("//*[@id='login']/div/div[2]/form/input[3]").Click();
            DoMisson(driver, Misson.LIKE_PAGE);
        }


        private void DoMisson(ChromeDriver driver, Misson misson)
        {
            var menu = driver.FindElementByXPath("/html/body/div[1]/div/nav/div/div[1]/button");
            if (menu != null)
                menu.Click();
            Thread.Sleep(1000);
            driver.FindElementByXPath("//*[@id='navbar']/ul[1]/li[2]/a").Click();
            Thread.Sleep(1000);
            switch (misson)
            {
                case Misson.LIKE_PAGE:
                    driver.FindElementByCssSelector("#navbar > ul:nth-child(1) > li.dropdown.open > ul > li:nth-child(7) > a").Click();
                    break;
            }
            Thread.Sleep(5000);
            var buttons = driver.FindElementsByCssSelector(".btn.btn-default");
            if (buttons == null)
            {
                Thread.Sleep(5000);
                buttons = driver.FindElementsByCssSelector(".btn.btn-default");
            }
            foreach (var button in buttons)
            {
                button.Click();
                Thread.Sleep(7000);
                var buttonFb = driver.FindElementByCssSelector(".a8c37x1j.ni8dbmo4.stjgntxs.l9j0dhe7.ltmttdrg.g0qnabr5");
                if (buttonFb == null)
                {
                    Thread.Sleep(5000);
                    buttonFb = driver.FindElementByCssSelector(".a8c37x1j.ni8dbmo4.stjgntxs.l9j0dhe7.ltmttdrg.g0qnabr5 ");
                }
                buttonFb.Click();
                Thread.Sleep(3000);
                driver.Close();
                Thread.Sleep(3000);
                // test one
                //break;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<Cookie> GetCookies(String txtCookie)
        {
            txtCookie = txtCookie.Trim();
            List<Cookie> cookies = new List<Cookie>();
            foreach (String text in txtCookie.Split(';'))
            {
                String[] str = text.Trim().Split('=');
                Cookie cookie = new Cookie(str[0], str[1]);
                cookies.Add(cookie);
            }
            return cookies;
        }
    }
}
