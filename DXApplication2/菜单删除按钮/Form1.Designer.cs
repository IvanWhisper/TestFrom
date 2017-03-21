namespace 菜单删除按钮
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxControl1 = new DevExpress.XtraToolbox.ToolboxControl();
            this.toolboxGroup1 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.toolboxGroup2 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.toolboxGroup3 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.toolboxItem4 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem5 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem6 = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxItem7 = new DevExpress.XtraToolbox.ToolboxItem();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 1";
            this.bar1.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(772, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(772, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(772, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
            // 
            // toolStrip1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.toolStrip1, DevExpress.Utils.DefaultBoolean.Default);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(739, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(33, 362);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem3.Text = "1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolboxControl1
            // 
            this.toolboxControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolboxControl1.Groups.Add(this.toolboxGroup1);
            this.toolboxControl1.Groups.Add(this.toolboxGroup2);
            this.toolboxControl1.Groups.Add(this.toolboxGroup3);
            this.toolboxControl1.Location = new System.Drawing.Point(489, 29);
            this.toolboxControl1.Name = "toolboxControl1";
            this.toolboxControl1.SelectedGroup = this.toolboxGroup1;
            this.toolboxControl1.SelectedGroupIndex = 0;
            this.toolboxControl1.Size = new System.Drawing.Size(250, 362);
            this.toolboxControl1.TabIndex = 1;
            this.toolboxControl1.Click += new System.EventHandler(this.toolboxControl1_Click);
            // 
            // toolboxGroup1
            // 
            this.toolboxGroup1.Caption = "toolboxGroup1";
            this.toolboxGroup1.Name = "toolboxGroup1";
            // 
            // toolboxGroup2
            // 
            this.toolboxGroup2.Caption = "toolboxGroup2";
            this.toolboxGroup2.Name = "toolboxGroup2";
            // 
            // toolboxGroup3
            // 
            this.toolboxGroup3.Caption = "toolboxGroup3";
            this.toolboxGroup3.Items.Add(this.toolboxItem4);
            this.toolboxGroup3.Items.Add(this.toolboxItem5);
            this.toolboxGroup3.Items.Add(this.toolboxItem6);
            this.toolboxGroup3.Items.Add(this.toolboxItem7);
            this.toolboxGroup3.Name = "toolboxGroup3";
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
            // toolboxItem6
            // 
            this.toolboxItem6.BeginGroup = false;
            this.toolboxItem6.BeginGroupCaption = null;
            this.toolboxItem6.Caption = "toolboxItem6";
            this.toolboxItem6.Name = "toolboxItem6";
            // 
            // toolboxItem7
            // 
            this.toolboxItem7.BeginGroup = false;
            this.toolboxItem7.BeginGroupCaption = null;
            this.toolboxItem7.Caption = "toolboxItem7";
            this.toolboxItem7.Name = "toolboxItem7";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // Form1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 391);
            this.Controls.Add(this.toolboxControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraToolbox.ToolboxControl toolboxControl1;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup1;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup2;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup3;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem4;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem5;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem6;
        private DevExpress.XtraToolbox.ToolboxItem toolboxItem7;
    }
}

