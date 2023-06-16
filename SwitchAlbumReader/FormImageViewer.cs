using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchAlbumReader
{
    public partial class FormImageViewer : Form
    {
        public FormImageViewer()
        {
            InitializeComponent();
        }

        public void UpdateWebUrl(string newUrl)
        {
            //webBrowser1.Url = new Uri(newUrl);
            //webBrowser1.Refresh();
            webBrowser1.Navigate(new Uri(newUrl));
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            ResetElementMarginPadding("body");
            //MessageBox.Show(webBrowser1.Document.GetElementsByTagName("body")[0].Style);
        }

        public void ResetElementMarginPadding(string elementName)
        {
            webBrowser1.Document.GetElementsByTagName(elementName)[0].Style = "margin:0px;padding:0px";
            /*string[] styles = webBrowser1.Document.GetElementsByTagName(elementName)[0].Style.Split(';');
            string marginStyle = "";
            string paddingStyle = "";

            for (int i = 0; i < styles.Length; i++)
            {
                string[] stylePair = styles[i].Split(':');
                if (stylePair[0].ToLower() == "margin")
                {
                    marginStyle = styles[i];
                }
                else if (stylePair[0].ToLower() == "padding")
                {
                    paddingStyle = styles[i];
                }
            }

            if(marginStyle == "")
            {
                marginStyle = "margin:0px";
            }
            if(paddingStyle == "")
            {
                paddingStyle = "padding:0px";
            }*/
        }

        private void FormImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing")
            {
                e.Cancel = true;
                //this.Visible = false;
                this.Hide();
            }
            //MessageBox.Show(e.CloseReason.ToString());
        }
    }
}
