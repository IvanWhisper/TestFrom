namespace 大华测试项目
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMachinelink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMachinelink
            // 
            this.BtnMachinelink.Location = new System.Drawing.Point(12, 12);
            this.BtnMachinelink.Name = "BtnMachinelink";
            this.BtnMachinelink.Size = new System.Drawing.Size(75, 23);
            this.BtnMachinelink.TabIndex = 0;
            this.BtnMachinelink.Text = "设备接入";
            this.BtnMachinelink.UseVisualStyleBackColor = true;
            this.BtnMachinelink.Click += new System.EventHandler(this.BtnMachinelink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 467);
            this.Controls.Add(this.BtnMachinelink);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMachinelink;
    }
}

