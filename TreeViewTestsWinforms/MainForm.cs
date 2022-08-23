using System;
using System.Drawing;
using System.Windows.Forms;

namespace TreeViewTestsWinforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Winforms
        }

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var tv = (TreeView) sender;
            tv.DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            var tv = (TreeView) sender;
            var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the co-ordinates of the mouse
            var destinationNode = tv.GetNodeAt(position); //Get the node at the current mouse position

            tv.SelectedNode = destinationNode; //Highlight the node in relations to the mouse position

            e.Effect = DragDropEffects.Move;
        }

        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                //Continue only if the item being dragged is a TreeNode object

                var tv = (TreeView) sender;
                var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the mouse co-ordinates
                var dropNode = tv.GetNodeAt(position);
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
    }
}