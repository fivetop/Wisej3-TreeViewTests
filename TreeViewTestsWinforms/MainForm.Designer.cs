namespace TreeViewTestsWinforms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("1.1. abc", 2, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("1.2. def", 2, 3);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1. ABC", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("2.2. ghi", 2, 3);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("2.1. jkl", 2, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2. DEF", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3. GHI");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4. JKL");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(25, 25);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView.Name = "treeView";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "treeNode11";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "1.1. abc";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "treeNode12";
            treeNode12.SelectedImageIndex = 3;
            treeNode12.Text = "1.2. def";
            treeNode1.Name = "treeNode1";
            treeNode1.Text = "1. ABC";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "treeNode22";
            treeNode22.SelectedImageIndex = 3;
            treeNode22.Text = "2.2. ghi";
            treeNode21.ImageIndex = 2;
            treeNode21.Name = "treeNode21";
            treeNode21.SelectedImageIndex = 3;
            treeNode21.Text = "2.1. jkl";
            treeNode2.Name = "treeNode2";
            treeNode2.Text = "2. DEF";
            treeNode3.Name = "treeNode3";
            treeNode3.Text = "3. GHI";
            treeNode4.Name = "treeNode4";
            treeNode4.Text = "4. JKL";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView.SelectedImageIndex = 1;
            this.treeView.Size = new System.Drawing.Size(250, 350);
            this.treeView.TabIndex = 0;
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Node.png");
            this.imageList.Images.SetKeyName(1, "NodeSelected.png");
            this.imageList.Images.SetKeyName(2, "ReadOnlyNode.png");
            this.imageList.Images.SetKeyName(3, "ReadOnlyNodeSelected.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.treeView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
    }
}

