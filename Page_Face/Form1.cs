using DR_Library.HttpRequest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_Face
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // khởi tạo và login
            string acc = account.Text;
            string[] accArr = acc.Split('\n');
            string ProfileName = "Profile 2";


            // khởi tạo setup chorme
            ChromeDriverService cService = ChromeDriverService.CreateDefaultService();
            cService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--disable-popup-blocking");
            options.AddExcludedArgument("enable-automation");
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disable-dev-shm-usage");
            options.AddArguments("--user-data-dir=" + Application.StartupPath + $"\\Profile\\{ProfileName}");


            // mở face và đăng nhập
            IWebDriver brower = new ChromeDriver(cService, options);
            brower.Navigate().GoToUrl("https://www.facebook.com/");


            Thread.Sleep(2000);
            brower.FindElement(By.Id("email")).SendKeys("100051369319922");
            Thread.Sleep(500);
            brower.FindElement(By.Id("pass")).SendKeys("HDvia@8888");
            Thread.Sleep(500);
            brower.FindElement(By.Name("login")).Click();
            Thread.Sleep(2000);
            string faCode = DR_Get2FACodeHelper.Get2FA("ZJIN4ENSPVWZWH6M7EK43VTENLDDROWJ");
            brower.FindElement(By.Id("approvals_code")).SendKeys("123");
            Thread.Sleep(2000);
            brower.FindElement(By.Id("checkpointSubmitButton")).Click();
            Thread.Sleep(2000);
            //click và lấy toàn bộ profile

            //////////////


            /////////////////////////////////////
            ///


        }
        public void shareLink(IWebDriver brower)
        {
            string tmShare = timeShare.Text;
            string link = linkShare.Text;
            string grShare = groupShare.Text;
            string[] grShareArr = grShare.Split('\n');
            brower.Navigate().GoToUrl("https://www.facebook.com/pages/?category=your_pages");

            List<IWebElement> SwitchButtonElement = new List<IWebElement>();
           
            Thread.Sleep(2000);

            var SpanTag = brower.FindElements(By.CssSelector("[aria-label='Switch Now']"));

            int count = 0;
            foreach (var s in SpanTag)
            {

                SwitchButtonElement.Add(s);

            }

            for (int i = 0; i < SwitchButtonElement.Count;)
            {
                if (count == SwitchButtonElement.Count)
                {
                    break;
                }
                Thread.Sleep(1000);
                brower.FindElements(By.CssSelector("[aria-label='Switch Now']"))[count].Click();
                count++;
                Thread.Sleep(1000);
                brower.Navigate().GoToUrl(link);
                Thread.Sleep(2000);







                foreach (string gr in grShareArr)
                {
                    var SpanTag1 = brower.FindElement(By.XPath("//*[.=\"Share\"]"));
                    SpanTag1.Click();
                    Thread.Sleep(1000);
                    var SpanTag2 = brower.FindElement(By.XPath("//*[.=\"Share to a group\"]"));
                    SpanTag2.Click();
                    Thread.Sleep(1000);

                    brower.FindElement(By.CssSelector("input[aria-label='Search for groups'][placeholder='Search for groups']")).SendKeys(gr);
                    string grTemp = "//*[.=\"" + gr + "\"]";
                    var SpanTag3 = brower.FindElement(By.XPath(grTemp));
                    SpanTag3.Click();
                    Thread.Sleep(1000);
                    var SpanTag4 = brower.FindElement(By.XPath("//*[.=\"Post\"]"));
                    SpanTag4.Click();
                    Thread.Sleep(Int32.Parse(tmShare));


                }
                brower.FindElement(By.CssSelector("[class='j83agx80 l9j0dhe7']")).Click();
                Thread.Sleep(1000);
                brower.FindElement(By.CssSelector("[aria-label='Switch Profiles']")).Click();
                Thread.Sleep(1000);
                brower.Navigate().GoToUrl("https://www.facebook.com/pages/?category=your_pages");
                Thread.Sleep(2000);

            }

        }
        public void joinGroup(IWebDriver brower) 
        {
            string grJoin = groupJoin.Text;

            string tmJoin = timeJoin.Text;
           string[] grJoinArr = grJoin.Split('\n');


            List<IWebElement> SwitchButtonElement = new List<IWebElement>();

            Thread.Sleep(2000);

            var SpanTag = brower.FindElements(By.CssSelector("[aria-label='Switch Now']"));

            int count = 0;
            foreach (var s in SpanTag)
            {

                SwitchButtonElement.Add(s);

            }

            for (int i = 0; i < SwitchButtonElement.Count;)
            {
                if (count == SwitchButtonElement.Count)
                {
                    break;
                }
                Thread.Sleep(1000);
                brower.FindElements(By.CssSelector("[aria-label='Switch Now']"))[count].Click();
                count++;

                Thread.Sleep(2000);

                foreach (string s in grJoinArr)
                {
                    brower.Navigate().GoToUrl(s);


                }


                brower.FindElement(By.CssSelector("[class='j83agx80 l9j0dhe7']")).Click();
                Thread.Sleep(1000);
                brower.FindElement(By.CssSelector("[aria-label='Switch Profiles']")).Click();
                Thread.Sleep(1000);
                brower.Navigate().GoToUrl("https://www.facebook.com/pages/?category=your_pages");
                Thread.Sleep(2000);

            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //foreach (IWebElement ele in brower.FindElements(By.CssSelector("[aria-checked='false'][class='oajrlxb2 gs1a9yip g5ia77u1 mtkw9kbi tlpljxtp qensuy8j ppp5ayq2 goun2846 ccm00jje s44p3ltw mk2mc5f4 rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv nhd2j8a9 mg4g778l pfnyh3mw p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x tgvbjcpo hpfvmrgz jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso l9j0dhe7 i1ao9s8h esuyzwwr f1sip0of du4w35lb btwxx1t3 abiwlrkh p8dawk7l lzcic4wl ue3kfks5 pw54ja7n uo3d90p7 l82x9zwi a8c37x1j']")))
            //{

            //    string page = ele.FindElement(By.CssSelector("[class='d2edcug0 hpfvmrgz qv66sw1b c1et5uql lr9zc1uh a8c37x1j fe6kdd0r mau55g9w c8b282yb keod5gw0 nxhoafnm aigsh9s9 d3f4x2em iv3no6db jq4qci2q a3bd9o3v ekzkrbhg oo9gr5id hzawbc8m']")).Text;


            //    eleArr.Add(page);
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.CreateProfileForm f = new UI.CreateProfileForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
