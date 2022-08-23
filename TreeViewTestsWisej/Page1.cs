
using System;
using Wisej.Web;

namespace TreeViewTestsWisej
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private Control Selected
		{
			get { return this._selected; }
			set
			{
				if (this._selected != value)
				{
					if (this._selected != null)
						this.styleSheet.SetCssClass(this._selected, "");

					this._selected = value;

					if (this._selected != null)
						this.styleSheet.SetCssClass(this._selected, "selected");

					this.button1.Enabled 
						= this.button2.Enabled
							= this._selected != null;
				}
			}
		}
		private Control _selected;

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			this.Selected = (Control)sender;
		}

		private void Page1_MouseDown(object sender, MouseEventArgs e)
		{
			this.Selected = null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Selected?.SendToBack();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Selected?.BringToFront();
		}
	}
}
