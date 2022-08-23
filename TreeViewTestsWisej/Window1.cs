
using System;
using System.Text;
using Wisej.Web;

namespace TreeViewTestsWisej
{
    public partial class Window1 : Form
    {

        private string[] items = { "James", "Henry", "Phillip", "Colin", "Michael", "Mark" };   

        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
                        
            // add a bunch of string items formatted as URLs into listLinkItems ListBox
            foreach (string item in items)
            {
                this.listLinkItems.Items.Add(string.Format("<a href=''>{0}</a>", item));
            }


            /*  
                create multiple input boxes that will display each of the text values
                include 'onclick='this.select();' which will select the whole text item so it can be dragged into CKEditor.
                if 'this.select()' is not used, then the user would have to manually highlight the text to drag.
                set readonly so the input box doesn't enter an edit mode.
            */
            for (int i = 0; i < 50; i++)
            {
                sb.Append(string.Format("<input style='width: 100%; border: none;' readonly onclick='this.select();' value='{0}'/>", "Item-" + i.ToString()));
            }

            // listLinkItems must be set to AllowHtml
            this.listLinkItems.AllowHtml = true;

            // add the HTML for the input boxes into the htmlPanel control
            this.htmlPanel1.Html = sb.ToString();

            
            this.ckEditor1.AllowDrop = true;
                        


        }

        
    }
}
