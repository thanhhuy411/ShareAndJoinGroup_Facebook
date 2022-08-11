using DR_Library.HttpRequest;
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
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dtgInfo.Rows.Count; rows++)
            {
                string Email = dtgInfo.Rows[rows].Cells[1].Value.ToString(); ;
                string Password = dtgInfo.Rows[rows].Cells[2].Value.ToString(); ;
                string _2FA = dtgInfo.Rows[rows].Cells[3].Value.ToString(); ;
                
                 //Bat profile va login
            string ProfileName = Email;
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
            IWebDriver browser = new ChromeDriver(cService, options);

            //Viet code Dang nhap o day
           
            browser.Navigate().GoToUrl("https://mbasic.facebook.com/");


            Thread.Sleep(2000);
            browser.FindElement(By.Id("m_login_email")).SendKeys(Email);
            Thread.Sleep(500);
            browser.FindElement(By.Name("pass")).SendKeys(Password);
            Thread.Sleep(500);
            browser.FindElement(By.Name("login")).Click();
            Thread.Sleep(2000);
                // string checklogin= browser.FindElement(By.ClassName("r")).Text;
               
                try
                {
                    var checklogin = browser.FindElement(By.Name("login"));
                    if (checklogin!=null)
                    {
                        browser.Close();
                        browser.Quit();
                        continue;
                    }
                }
                catch (Exception)
                {

                 
                }
                
                
             
            string faCode = DR_Get2FACodeHelper.Get2FA(_2FA);
            browser.FindElement(By.Id("approvals_code")).SendKeys(faCode);
            Thread.Sleep(2000);
            browser.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
            Thread.Sleep(2000);
                try
                {
                    var check2fa = browser.FindElement(By.ClassName("approvals_code"));

                    if (check2fa!=null)
                    {
                        browser.Close();
                        browser.Quit();
                        continue;
                    }
                }
                catch (Exception)
                {

                   
                }
                browser.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                Thread.Sleep(2000);
                //Dang nhap xong thi dong browser vao la xong
                browser.Close();
            browser.Quit();
            }
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                dtgInfo.Rows.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    int Count = 1;
                    while ((line = r.ReadLine()) != null)
                    {
                        dtgInfo.Rows.Add(Count, line.Split('|')[0], line.Split('|')[1], line.Split('|')[2]);
                        Count++;
                    }
                }
            }
        }
    }
}
