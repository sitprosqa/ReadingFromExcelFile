namespace ReadingFromExcelFile
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.periodDate = new System.Windows.Forms.TextBox();
            this.NodeName = new System.Windows.Forms.TextBox();
            this.filenameTxt = new System.Windows.Forms.TextBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.cmdNew = new System.Windows.Forms.RibbonButton();
            this.cmdExist = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.Save = new System.Windows.Forms.RibbonButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(20, 60);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 75);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1377, 162);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Text = "";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton4);
            this.ribbonPanel1.Text = "";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "New";
            this.ribbonButton4.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton5);
            this.ribbonPanel2.Text = "";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Import";
            this.ribbonButton5.Click += new System.EventHandler(this.CmdExist_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton6);
            this.ribbonPanel3.Text = "";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "Export";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton7);
            this.ribbonPanel4.Text = "";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "Save";
            this.ribbonButton7.Click += new System.EventHandler(this.RibbonButton4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 517);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.metroTabControl2);
            this.panel2.Controls.Add(this.metroTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 517);
            this.panel2.TabIndex = 3;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(207, 0);
            this.metroTabControl2.Margin = new System.Windows.Forms.Padding(5);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.Size = new System.Drawing.Size(1170, 517);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(207, 517);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Visible = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage2.Controls.Add(this.treeView1);
            this.metroTabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = true;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.metroTabPage2.Size = new System.Drawing.Size(199, 475);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Table Browser";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.LineColor = System.Drawing.Color.SkyBlue;
            this.treeView1.Location = new System.Drawing.Point(0, 10);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(199, 465);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect_1);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.periodDate);
            this.metroTabPage1.Controls.Add(this.NodeName);
            this.metroTabPage1.Controls.Add(this.filenameTxt);
            this.metroTabPage1.Controls.Add(this.treeView2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = true;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.metroTabPage1.Size = new System.Drawing.Size(199, 475);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Project structure";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // periodDate
            // 
            this.periodDate.Location = new System.Drawing.Point(19, 309);
            this.periodDate.Name = "periodDate";
            this.periodDate.Size = new System.Drawing.Size(100, 20);
            this.periodDate.TabIndex = 5;
            this.periodDate.Text = "Period Ended 30/06/2017";
            this.periodDate.Visible = false;
            // 
            // NodeName
            // 
            this.NodeName.Location = new System.Drawing.Point(49, 227);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(100, 20);
            this.NodeName.TabIndex = 4;
            this.NodeName.Visible = false;
            // 
            // filenameTxt
            // 
            this.filenameTxt.Location = new System.Drawing.Point(48, 144);
            this.filenameTxt.Name = "filenameTxt";
            this.filenameTxt.Size = new System.Drawing.Size(100, 20);
            this.filenameTxt.TabIndex = 3;
            this.filenameTxt.Visible = false;
            // 
            // treeView2
            // 
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.ForeColor = System.Drawing.Color.Black;
            this.treeView2.LineColor = System.Drawing.Color.SkyBlue;
            this.treeView2.Location = new System.Drawing.Point(0, 10);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(199, 465);
            this.treeView2.TabIndex = 2;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Import Excel";
            // 
            // cmdNew
            // 
            this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
            this.cmdNew.MaximumSize = new System.Drawing.Size(70, 120);
            this.cmdNew.MinimumSize = new System.Drawing.Size(5, 5);
            this.cmdNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdNew.SmallImage")));
            this.cmdNew.Text = "New File";
            this.cmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // cmdExist
            // 
            this.cmdExist.Image = ((System.Drawing.Image)(resources.GetObject("cmdExist.Image")));
            this.cmdExist.MaximumSize = new System.Drawing.Size(70, 120);
            this.cmdExist.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdExist.SmallImage")));
            this.cmdExist.Text = "Import Excel";
            this.cmdExist.Click += new System.EventHandler(this.CmdExist_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.DropDownItems.Add(this.ribbonButton3);
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.MaximumSize = new System.Drawing.Size(70, 120);
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Export Excel";
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.MaximumSize = new System.Drawing.Size(70, 120);
            this.Save.SmallImage = ((System.Drawing.Image)(resources.GetObject("Save.SmallImage")));
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.RibbonButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " Redwood - K-Helix";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox NodeName;
        private System.Windows.Forms.TextBox filenameTxt;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton cmdNew;
        private System.Windows.Forms.RibbonButton cmdExist;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton Save;
        private System.Windows.Forms.TextBox periodDate;
    }
}