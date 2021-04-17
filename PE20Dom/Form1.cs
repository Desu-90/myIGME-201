using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

            

        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "My UFO Page";
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "My UFO Info";
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "My UFO Pictures";
            htmlElement = htmlElementCollection[2];
            htmlElement.InnerHtml = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #800000;";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "<a href:http://www.nuforc.org >Report your UFO sightings here</a>";
            htmlElement.Style += "color: 'green'; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "";
            htmlElement = htmlElementCollection[2];
            htmlElement.InnerHtml = "<img src=\"https://images.unsplash.com/photo-1589817327185-d6502a579376?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80\" alt = UFO width = 450px height = 450px >";

            //htmlElementCollection = webBrowser.Document.GetElementsByTagName("footer");
            //htmlElement = htmlElementCollection[0];
            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy"+ " 2021 " + "Dennis Olmedo";
            webBrowser.Document.Body.AppendChild(htmlElement);


        }
    }
}
