namespace TreeViewTestsWisej
{
    partial class Page1
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
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.pictureBox4 = new Wisej.Web.PictureBox();
            this.styleSheet = new Wisej.Web.StyleSheet(this.components);
            this.panel1 = new Wisej.Web.Panel();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = "Images\\Cosine-200.png";
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Movable = true;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox1.MouseDown += new Wisej.Web.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageSource = "Images\\fecher-logo.png";
            this.pictureBox2.Location = new System.Drawing.Point(114, 39);
            this.pictureBox2.Movable = true;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox2.MouseDown += new Wisej.Web.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageSource = "Images\\icons8-eye-180.png";
            this.pictureBox3.Location = new System.Drawing.Point(34, 100);
            this.pictureBox3.Movable = true;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox3.MouseDown += new Wisej.Web.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageSource = "Images\\Wisej-Logo-64x64.png";
            this.pictureBox4.Location = new System.Drawing.Point(102, 131);
            this.pictureBox4.Movable = true;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox4.MouseDown += new Wisej.Web.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // styleSheet
            // 
            this.styleSheet.Styles = ".selected {\r\n    \r\n    border: 1px solid green;\r\n    \r\n}\r\n\r\n.round {\r\n    border-" +
    "radius: 100%;\r\n}";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.styleSheet.SetCssClass(this.panel1, "round");
            this.panel1.Location = new System.Drawing.Point(253, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(37, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send to Back";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(37, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bring to Front";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(769, 492);
            this.Text = "Page1";
            this.MouseDown += new Wisej.Web.MouseEventHandler(this.Page1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.PictureBox pictureBox3;
        private Wisej.Web.PictureBox pictureBox4;
        private Wisej.Web.StyleSheet styleSheet;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
    }
}

