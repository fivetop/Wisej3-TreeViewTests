namespace TreeViewTestsWisej
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.TreeNode treeNode1 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode2 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode3 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode4 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode5 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode6 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode7 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode8 = new Wisej.Web.TreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Wisej.Web.ImageListEntry imageListEntry1 = new Wisej.Web.ImageListEntry(((System.Drawing.Image)(resources.GetObject("imageList.Images"))), "Node.png");
            Wisej.Web.ImageListEntry imageListEntry2 = new Wisej.Web.ImageListEntry(((System.Drawing.Image)(resources.GetObject("imageList.Images1"))), "NodeSelected.png");
            Wisej.Web.ImageListEntry imageListEntry3 = new Wisej.Web.ImageListEntry(((System.Drawing.Image)(resources.GetObject("imageList.Images2"))), "ReadOnlyNode.png");
            Wisej.Web.ImageListEntry imageListEntry4 = new Wisej.Web.ImageListEntry(((System.Drawing.Image)(resources.GetObject("imageList.Images3"))), "ReadOnlyNodeSelected.png");
            this.treeView = new Wisej.Web.TreeView();
            this.imageList = new Wisej.Web.ImageList(this.components);
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrag = true;
            this.treeView.AllowDrop = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(25, 25);
            this.treeView.Name = "treeView";
            treeNode1.Name = "treeNode1";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "treeNode11";
            treeNode2.OpenedImageIndex = 3;
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "1.1. abc";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "treeNode12";
            treeNode3.OpenedImageIndex = 3;
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "1.2. def";
            treeNode1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode2,
            treeNode3});
            treeNode1.Text = "1. ABC";
            treeNode4.Name = "treeNode2";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "treeNode21";
            treeNode5.OpenedImageIndex = 3;
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "2.1. def";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "treeNode22";
            treeNode6.OpenedImageIndex = 3;
            treeNode6.SelectedImageIndex = 3;
            treeNode6.Text = "2.2. jkl";
            treeNode4.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode5,
            treeNode6});
            treeNode4.Text = "2. DEF";
            treeNode7.Name = "treeNode3";
            treeNode7.Text = "3. GHI";
            treeNode8.Name = "treeNode4";
            treeNode8.Text = "4. JKL";
            this.treeView.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView.OpenedImageIndex = 1;
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(250, 350);
            this.treeView.TabIndex = 0;
            this.treeView.ItemDrag += new Wisej.Web.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.DragDrop += new Wisej.Web.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragOver += new Wisej.Web.DragEventHandler(this.treeView_DragOver);
            // 
            // imageList
            // 
            this.imageList.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry1,
            imageListEntry2,
            imageListEntry3,
            imageListEntry4});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(769, 492);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TreeView treeView;
        private Wisej.Web.ImageList imageList;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button3;
    }
}

