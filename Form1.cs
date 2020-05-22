using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSource
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        string currentDirectory;
        HtmlElement mainElement;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            webBrowser1.Navigate(new Uri($"file://{currentDirectory}\\View\\main.html"));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Info",new String[] {"green"});
            HtmlElement elem;
            elem = webBrowser1.Document.CreateElement("div");
            elem.InnerText = $"{DateTime.Now}";
            string tmpr = mainElement.InnerHtml;
            mainElement.InnerHtml = $"<div>{DateTime.Now}</div>" + tmpr;
            Genstr gen = new Genstr("");

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            try
            {
                mainElement = webBrowser1.Document.GetElementById("app");
                mainElement.InnerHtml = "";
            }
            catch
            {

            }
        }
    }
}
