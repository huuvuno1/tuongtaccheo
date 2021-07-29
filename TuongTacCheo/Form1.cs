
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
        public enum Misson
        {
            FOLLOW, LIKE_PAGE, LIKE_POST
        }

        static string DOM_LIKE_PAGE = "div > div:nth-child(1) > div > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.l9j0dhe7.dp1hu0rb.cbu4d94t.j83agx80 > div.rq0escxv.lpgh02oy.du4w35lb.rek2kq2y > div > div > div > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.cbu4d94t.pfnyh3mw.d2edcug0.hpfvmrgz.o8rfisnq > div > div > div.oajrlxb2.g5ia77u1.qu0x051f.esr5mh6w.e9989ue4.r7d6kgcz.rq0escxv.nhd2j8a9.pq6dq46d.p7hjln8o.kvgmc6g5.cxmmr5t8.oygrvhab.hcukyx3x.jb3vyjys.rz4wbd8a.qt6c0cv9.a8nywdso.i1ao9s8h.esuyzwwr.f1sip0of.lzcic4wl.l9j0dhe7.abiwlrkh.p8dawk7l.cbu4d94t.taijpn5t.k4urcfbm > div > div.bp9cbjyn.j83agx80.taijpn5t.c4xchbtz.by2jbhx6.a0jftqn4 > div:nth-child(2) > span > span";
        static string DOM_LIKE_POST = "div > div:nth-child(1) > div > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.dp1hu0rb.d2edcug0.taijpn5t.j83agx80.gs1a9yip > div > div > div > div > div > div > div > div > div > div > div > div > div > div:nth-child(2) > div > div:nth-child(4) > div > div > div:nth-child(1) > div > div.tvfksri0.ozuftl9m > div > div:nth-child(1) > div.oajrlxb2.gs1a9yip.g5ia77u1.mtkw9kbi.tlpljxtp.qensuy8j.ppp5ayq2.goun2846.ccm00jje.s44p3ltw.mk2mc5f4.rt8b4zig.n8ej3o3l.agehan2d.sk4xxmp2.rq0escxv.nhd2j8a9.pq6dq46d.mg4g778l.btwxx1t3.pfnyh3mw.p7hjln8o.kvgmc6g5.cxmmr5t8.oygrvhab.hcukyx3x.tgvbjcpo.hpfvmrgz.jb3vyjys.rz4wbd8a.qt6c0cv9.a8nywdso.l9j0dhe7.i1ao9s8h.esuyzwwr.f1sip0of.du4w35lb.lzcic4wl.abiwlrkh.p8dawk7l > div.n00je7tq.arfg74bv.qs9ysxi8.k77z8yql.i09qtzwb.n7fi1qx3.b5wmifdl.hzruof5a.pmk7jnqg.j9ispegn.kr520xx4.c5ndavph.art1omkt.ot9fgl3s.rnr61an3";
        static string DOM_FOLLOW = "div > div:nth-child(1) > div > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.j83agx80.cbu4d94t.dp1hu0rb > div > div > div.rq0escxv.lpgh02oy.du4w35lb.rek2kq2y > div > div > div > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.cbu4d94t.pfnyh3mw.d2edcug0.hpfvmrgz.o8rfisnq > div > div > div > div:nth-child(1) > div";
        public Form1()
        {
            InitializeComponent();
            List<Info> infos = Form1.ReadFromBinaryFile<List<Info>>("data.txt");
            if (infos != null)
            {
                foreach (var info in infos)
                {
                    int i = listInfo.Rows.Add();
                    listInfo.Rows[i].Cells["txtUsername"].Value = info.Username;
                    listInfo.Rows[i].Cells["txtPassword"].Value = info.Password;
                    listInfo.Rows[i].Cells["txtCookie"].Value = info.Cookie;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ToolUtils.GetListMisson(checkFollow, checkLikePage, checkLikePost).Count == 0)
            {
                MessageBox.Show("Phải tích ít nhất một nhiệm vụ!");
                return;
            }    
            List<Info> infos = new List<Info>();
            for (int i = 0; i < listInfo.Rows.Count - 1; i++)
            {
                string username = listInfo.Rows[i].Cells["txtUsername"].Value.ToString();
                string password = listInfo.Rows[i].Cells["txtPassword"].Value.ToString();
                string cookie = listInfo.Rows[i].Cells["txtCookie"].Value.ToString();
                int index = i;
                new Thread(() => Start(username, password, GetCookies(cookie), index)).Start();
                infos.Add(new Info(username, password, cookie));
            }
            writeFile(infos);
        }

        private void writeFile(List<Info> infos)
        {
            using (Stream stream = File.Open("data.txt", FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, infos);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    return (T)binaryFormatter.Deserialize(stream);
                }
                catch
                {
                    return default(T); 
                }
            }
        }

        private void Start(String username, String password, List<Cookie> cookies, int i)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
            options.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;
            ChromeDriver driver = new ChromeDriver(driverService, options);
            WriteLog("Đang đọc cookie hàng thứ " + (i+1));
            driver.Navigate().GoToUrl("https://facebook.com");

            foreach (Cookie cookie in cookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }
            driver.Navigate().Refresh();
            var title = driver.FindElementByTagName("title").GetAttribute("innerText");
            if ("Facebook".Equals(title))
            {
                driver.Navigate().GoToUrl("https://tuongtaccheo.com/");
                driver.FindElementByXPath("//*[@id='memberModal']/div/div/div[1]/button/span").Click();
                
                driver.FindElementById("name").SendKeys(username);
                driver.FindElementById("password").SendKeys(password);
                driver.FindElementByXPath("//*[@id='login']/div/div[2]/form/input[3]").Click();
                
                UpdateGridView(driver, "Đang chạy", i);
                WriteLog("=>> Đăng nhập thành công");
                List<Misson> missons = ToolUtils.GetListMisson(checkFollow, checkLikePage, checkLikePost);
                int n = 0;
                while (true)
                {
                    DoMisson(driver, missons[n], i);
                    n++;
                    if (n >= missons.Count) {
                        n = 0;
                    }
                }
            }
            else
            {
                WriteLog("=>> Đăng nhập thất bại");
                UpdateGridView(driver, "Login Fail", i);
            }
        }

        private void WriteLog(String text)
        {
            if (ControlInvokeRequired(txtLog, () => WriteLog(text))) return;
            txtLog.Text += text + "\n";
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }

        private void UpdateGridView(ChromeDriver driver, string status, int i)
        {
            try
            {
                var money = driver.FindElementById("soduchinh").GetAttribute("innerText");
                listInfo.Rows[i].Cells["txtMoney"].Value = money;
            }
            catch
            {
                listInfo.Rows[i].Cells["txtMoney"].Value = "Error";
            }
            finally
            {
                listInfo.Rows[i].Cells["txtStatus"].Value = status;
            }
        }
        private void DoMisson(ChromeDriver driver, Misson misson, int i)
        {
            try
            {
                var menu = driver.FindElementByXPath("/html/body/div[1]/div/nav/div/div[1]/button");
                if (menu != null)
                    menu.Click();
            }
            catch
            {

            }
            
            Thread.Sleep(1000);
            driver.FindElementByXPath("//*[@id='navbar']/ul[1]/li[2]/a").Click();
            Thread.Sleep(1000);
            switch (misson)
            {
                case Misson.LIKE_PAGE:
                    CloseX(driver);
                    driver.FindElementByCssSelector("#navbar > ul:nth-child(1) > li.dropdown.open > ul > li:nth-child(7) > a").Click();
                    break;
                case Misson.FOLLOW:
                    driver.FindElementByCssSelector("#navbar > ul:nth-child(1) > li.dropdown.open > ul > li:nth-child(5) > a").Click();
                    break;
                case Misson.LIKE_POST:
                    driver.FindElementByCssSelector("#navbar > ul:nth-child(1) > li.dropdown.open > ul > li:nth-child(1) > a").Click();
                    break;
            }
            Thread.Sleep(5000);

            int n = 10;
            int.TryParse(txtNumRun.Text, out n);
            for (int k = 0; k < n; k++)
            {
                var button = driver.FindElementByCssSelector(".btn.btn-default");
                if (button == null)
                {
                    Thread.Sleep(5000);
                    button = driver.FindElementByCssSelector(".btn.btn-default");
                }
                CloseX(driver);
                button.Click();
                WriteLog("Running task: " + misson);
                Thread.Sleep(7000);
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                switch (misson)
                {
                    case Misson.LIKE_PAGE:
                        var buttonFb = driver.FindElementByCssSelector(DOM_LIKE_PAGE);
                        if (buttonFb == null)
                        {
                            Thread.Sleep(5000);
                            buttonFb = driver.FindElementByCssSelector(DOM_LIKE_PAGE);
                        }
                        buttonFb.Click();
                        break;
                    case Misson.FOLLOW:
                        var buttonFb2 = driver.FindElementByCssSelector(DOM_FOLLOW);
                        if (buttonFb2 == null)
                        {
                            Thread.Sleep(5000);
                            buttonFb = driver.FindElementByCssSelector(DOM_FOLLOW);
                        }
                        buttonFb2.Click();
                        break;
                    case Misson.LIKE_POST:
                        var buttonFb3 = driver.FindElementByCssSelector(DOM_LIKE_POST);
                        if (buttonFb3 == null)
                        {
                            Thread.Sleep(5000);
                            buttonFb3 = driver.FindElementByCssSelector(DOM_LIKE_POST);
                        }
                        buttonFb3.Click();
                        break;
                }
                
                Thread.Sleep(3000);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles[0]);
                driver.FindElementByCssSelector(".btn.btn-success").Click();
                WriteLog("Done task: " + misson);
                WriteLog("Updating monney...");
                UpdateGridView(driver, "Đang chạy", i);
                int sleep = 5;
                int.TryParse(txtTime.Text, out sleep);
                Thread.Sleep(1000 * sleep);
                // test one
                //break;
            }

        }

        private void CloseX(ChromeDriver driver)
        {
            try
            {
                var x = driver.FindElementByXPath("//*[@id='tawk-mpreview-close'']/i");
                x.Click();
            }
            catch
            {

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

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
