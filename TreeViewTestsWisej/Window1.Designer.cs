namespace TreeViewTestsWisej
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.panel1 = new Wisej.Web.Panel();
            this.listLinkItems = new Wisej.Web.ListBox();
            this.panel2 = new Wisej.Web.Panel();
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
            this.splitContainer2 = new Wisej.Web.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Focusable = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(191, 509);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listLinkItems);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(189, 227);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "Link Items";
            // 
            // listLinkItems
            // 
            this.listLinkItems.Dock = Wisej.Web.DockStyle.Fill;
            this.listLinkItems.Location = new System.Drawing.Point(0, 0);
            this.listLinkItems.Name = "listLinkItems";
            this.listLinkItems.Size = new System.Drawing.Size(189, 199);
            this.listLinkItems.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.htmlPanel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(189, 272);
            this.panel2.TabIndex = 0;
            this.panel2.Text = "Text Items";
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(189, 244);
            // 
            // ckEditor1
            // 
            this.ckEditor1.Dock = Wisej.Web.DockStyle.Fill;
            this.ckEditor1.Location = new System.Drawing.Point(0, 0);
            this.ckEditor1.Name = "ckEditor1";
            this.ckEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.ckEditor1.Size = new System.Drawing.Size(630, 507);
            this.ckEditor1.TabIndex = 1;
            this.ckEditor1.Text = "ckEditor1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer2.Focusable = false;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ckEditor1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(829, 509);
            this.splitContainer2.SplitterDistance = 632;
            this.splitContainer2.TabIndex = 2;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 509);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Window1";
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ListBox listLinkItems;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Ext.CKEditor.CKEditor ckEditor1;
        private Wisej.Web.SplitContainer splitContainer2;
        private Wisej.Web.HtmlPanel htmlPanel1;
    }
}

