using System;
using Wisej.Web;

namespace TreeViewTestsWisej
{
    public partial class MainForm : Page
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Wisej
        }

        #region // treeview
        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var tv = (TreeView) sender;
            tv.DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            var tv = (TreeView) sender;
            var destinationNode = e.DropTarget as TreeNode;
            tv.SelectedNode = destinationNode; //Highlight the node in relations to the mouse position

            e.Effect = DragDropEffects.Move;
        }

        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                //Continue only if the item being dragged is a TreeNode object

                var tv = (TreeView) sender;
                var dropNode = e.DropTarget as TreeNode;
                var dragNode = (TreeNode) e.Data.GetData(typeof(TreeNode));

                if (dragNode != null)
                {
                    // now you can drag

                    if (dropNode != null)
                    {
                        // dropNode is a TreeNode
                        tv.SelectedNode = dropNode;
                        dropNode.EnsureVisible();

                        ChangeParent(dragNode, dropNode);
                        dropNode.Expand();
                    }
                    else if (e.Data.GetData(typeof(TreeNode)) != null)
                    {
                        // dropNode is the TreeView's root
                        tv.SelectedNode = dragNode;
                        tv.SelectedNode.EnsureVisible();

                        ChangeParentToRoot(tv, dragNode);
                        tv.ExpandAll();
                    }
                }
            }
        }

        private void ChangeParent(TreeNode childNode, TreeNode parentNode)
        {
            childNode.Remove();
            parentNode.Nodes.Add(childNode);
        }

        private void ChangeParentToRoot(TreeView tv, TreeNode childNode)
        {
            childNode.Remove();
            tv.Nodes.Add(childNode);
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page1 p1 = new Page1();
            p1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Page2 p1 = new Page2();
            p1.Show();

        }
    }
}