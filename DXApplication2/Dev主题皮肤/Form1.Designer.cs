namespace Dev主题皮肤
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
            this.components = new System.ComponentModel.Container();
            this.toolboxControl1 = new DevExpress.XtraToolbox.ToolboxControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolboxGroup1 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.toolboxItem1 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem2 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem3 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem4 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem5 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxGroup2 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.toolboxItem6 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem7 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem8 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem9 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem10 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem11 = new DevExpress.XtraToolbox.ToolboxItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolboxControl1
            // 
            this.toolboxControl1.Groups.Add(this.toolboxGroup1);
            this.toolboxControl1.Groups.Add(this.toolboxGroup2);
            this.toolboxControl1.Location = new System.Drawing.Point(12, 48);
            this.toolboxControl1.Name = "toolboxControl1";
            this.toolboxControl1.SelectedGroup = this.toolboxGroup2;
            this.toolboxControl1.SelectedGroupIndex = 1;
            this.toolboxControl1.Size = new System.Drawing.Size(319, 504);
            this.toolboxControl1.TabIndex = 0;
            this.toolboxControl1.Click += new System.EventHandler(this.toolboxControl1_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar1.Text = "Tools";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "1";
            this.barSubItem2.Id = 1;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1076, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Size = new System.Drawing.Size(1076, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1076, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // toolboxGroup1
            // 
            this.toolboxGroup1.Caption = "收藏夹";
            this.toolboxGroup1.Items.Add(this.toolboxItem1);
            this.toolboxGroup1.Items.Add(this.toolboxItem2);
            this.toolboxGroup1.Items.Add(this.toolboxItem3);
            this.toolboxGroup1.Items.Add(this.toolboxItem4);
            this.toolboxGroup1.Items.Add(this.toolboxItem5);
            this.toolboxGroup1.Name = "toolboxGroup1";
            // 
            // toolboxItem1
            // 
            this.toolboxItem1.BeginGroup = false;
            this.toolboxItem1.BeginGroupCaption = null;
            this.toolboxItem1.Caption = "toolboxItem1";
            this.toolboxItem1.Name = "toolboxItem1";
            // 
            // toolboxItem2
            // 
            this.toolboxItem2.BeginGroup = false;
            this.toolboxItem2.BeginGroupCaption = null;
            this.toolboxItem2.Caption = "toolboxItem2";
            this.toolboxItem2.Name = "toolboxItem2";
            // 
            // toolboxItem3
            // 
            this.toolboxItem3.BeginGroup = false;
            this.toolboxItem3.BeginGroupCaption = null;
            this.toolboxItem3.Caption = "toolboxItem3";
            this.toolboxItem3.Name = "toolboxItem3";
            // 
            // toolboxItem4
            // 
            this.toolboxItem4.BeginGroup = false;
            this.toolboxItem4.BeginGroupCaption = null;
            this.toolboxItem4.Caption = "toolboxItem4";
            this.toolboxItem4.Name = "toolboxItem4";
            // 
            // toolboxItem5
            // 
            this.toolboxItem5.BeginGroup = false;
            this.toolboxItem5.BeginGroupCaption = null;
            this.toolboxItem5.Caption = "toolboxItem5";
            this.toolboxItem5.Name = "toolboxItem5";
            // 
            // toolboxGroup2
            // 
            this.toolboxGroup2.Caption = "历史记录";
            this.toolboxGroup2.Items.Add(this.toolboxItem6);
            this.toolboxGroup2.Items.Add(this.toolboxItem7);
            this.toolboxGroup2.Items.Add(this.toolboxItem8);
            this.toolboxGroup2.Items.Add(this.toolboxItem9);
            this.toolboxGroup2.Items.Add(this.toolboxItem10);
            this.toolboxGroup2.Items.Add(this.toolboxItem11);
            this.toolboxGroup2.Name = "toolboxGroup2";
            // 
            // toolboxItem6
            // 
            this.toolboxItem6.BeginGroup = false;
            this.toolboxItem6.BeginGroupCaption = null;
            this.toolboxItem6.Caption = "toolboxItem1";
            this.toolboxItem6.Name = "toolboxItem6";
            // 
            // toolboxItem7
            // 
            this.toolboxItem7.BeginGroup = false;
            this.toolboxItem7.BeginGroupCaption = null;
            this.toolboxItem7.Caption = "toolboxItem7";
            this.toolboxItem7.Name = "toolboxItem7";
            // 
            // toolboxItem8
            // 
            this.toolboxItem8.BeginGroup = false;
            this.toolboxItem8.BeginGroupCaption = null;
            this.toolboxItem8.Caption = "toolboxItem8";
            this.toolboxItem8.Name = "toolboxItem8";
            // 
            // toolboxItem9
            // 
            this.toolboxItem9.BeginGroup = false;
            this.toolboxItem9.BeginGroupCaption = null;
            this.toolboxItem9.Caption = "toolboxItem9";
            this.toolboxItem9.Name = "toolboxItem9";
            // 
            // toolboxItem10
            // 
            this.toolboxItem10.BeginGroup = false;
            this.toolboxItem10.BeginGroupCaption = null;
            this.toolboxItem10.Caption = "toolboxItem10";
            this.toolboxItem10.Name = "toolboxItem10";
            // 
            // toolboxItem11
            // 
            this.toolboxItem11.BeginGroup = false;
            this.toolboxItem11.BeginGroupCaption = null;
            this.toolboxItem11.Caption = "toolboxItem11";
            this.toolboxItem11.Name = "toolboxItem11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 564);
            this.Controls.Add(this.toolboxControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraToolbox.ToolboxControl toolboxControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup1;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem1;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem2;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem3;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem4;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem5;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup2;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem6;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem7;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem8;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem9;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem10;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem11;
    }
}

