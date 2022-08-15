using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_Face.UI
{
    public partial class ManagerProfile : Form
    {
        public ManagerProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.CreateProfileForm f = new UI.CreateProfileForm();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dtgInfo1.Rows.Count; rows++)
            {
               

                //Bat profile va login
                string ProfileName = dtgInfo1.Rows[rows].Cells[4].Value.ToString();
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
                //options.AddArguments("--user-data-dir=C:/Users/htlvn/AppData/Local/Google/Chrome/User Data/");
                //options.AddArguments("--profile-directory=Profile 2");
                IWebDriver browser = new ChromeDriver(cService, options);

             



                Thread.Sleep(2000);
                if (checkBox1.Checked == true)
                {
                    joinGroup(browser);
                }
                if (checkBox2.Checked == true)
                {
                    shareLink(browser);
                }
                browser.Close();
                browser.Quit();
            }
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
                    Thread.Sleep(2000);
                    string grTemp = "//*[.=\"" + gr + "\"]";
                    string checjkpoint_share = "true";
                    try
                    {
                        var SpanTag3 = brower.FindElement(By.XPath(grTemp));
                        if (SpanTag3!=null)
                        {
                            SpanTag3.Click();
                        }
                        else
                        {
                            checjkpoint_share="false";
                            brower.Navigate().GoToUrl(link);
                            Thread.Sleep(2000);
                            continue;
                        }
                       
                    }
                    catch (Exception)
                    {

                        
                    }
                  
                    Thread.Sleep(1000);
                    var SpanTag4 = brower.FindElement(By.XPath("//*[.=\"Post\"]"));
                    SpanTag4.Click();
                    Thread.Sleep(Int32.Parse(tmShare));


                }
                Thread.Sleep(1000);
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

                Thread.Sleep(2000);

                foreach (string s in grJoinArr)
                {
                    brower.Navigate().GoToUrl(s);
                    Thread.Sleep(2000);
                    try
                    {
                        brower.FindElement(By.CssSelector("[aria-label='Joined']")).Click();
                        continue;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    brower.FindElement(By.CssSelector("[aria-label='Join Group']")).Click();
                    Thread.Sleep(3000);
                    try
                    {
                        brower.FindElement(By.CssSelector("[aria-label='Not Now']")).Click();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    Thread.Sleep(Int32.Parse(tmJoin));
                }


                brower.FindElement(By.CssSelector("[class='j83agx80 l9j0dhe7']")).Click();
                Thread.Sleep(1000);
                brower.FindElement(By.CssSelector("[aria-label='Switch Profiles']")).Click();
                Thread.Sleep(1000);
                brower.Navigate().GoToUrl("https://www.facebook.com/pages/?category=your_pages");
                Thread.Sleep(2000);

            }

        }

        private void ManageProfile_Load(object sender, EventArgs e)
        {
            //Load Profile
            DirectoryInfo info = new DirectoryInfo("Profile");
            foreach (var d in info.GetDirectories())
            {
                dtgInfo1.Rows.Add(d.Name);
            }
        }
        private void timeJoin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
