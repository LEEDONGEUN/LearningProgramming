namespace VideoRecord
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PStart = new System.Windows.Forms.ToolStripButton();
            this.PStop = new System.Windows.Forms.ToolStripButton();
            this.PNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.PStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CStart = new System.Windows.Forms.ToolStripMenuItem();
            this.CStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.CMini = new System.Windows.Forms.ToolStripMenuItem();
            this.CExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.PStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewPanel.Location = new System.Drawing.Point(0, 28);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(624, 353);
            this.ViewPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PStart,
            this.PStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PStart
            // 
            this.PStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PStart.Image = ((System.Drawing.Image)(resources.GetObject("PStart.Image")));
            this.PStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PStart.Name = "PStart";
            this.PStart.Size = new System.Drawing.Size(63, 22);
            this.PStart.Text = "녹화 시작";
            // 
            // PStop
            // 
            this.PStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PStop.Image = ((System.Drawing.Image)(resources.GetObject("PStop.Image")));
            this.PStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PStop.Name = "PStop";
            this.PStop.Size = new System.Drawing.Size(63, 22);
            this.PStop.Text = "녹화 정지";
            // 
            // PNotify
            // 
            this.PNotify.ContextMenuStrip = this.PStrip;
            this.PNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("PNotify.Icon")));
            this.PNotify.Text = "전체 화면 녹화";
            this.PNotify.Visible = true;
            // 
            // PStrip
            // 
            this.PStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CStart,
            this.CStop,
            this.toolStripSeparator1,
            this.CSetting,
            this.종료ToolStripMenuItem,
            this.CMini,
            this.CExit});
            this.PStrip.Name = "PStrip";
            this.PStrip.Size = new System.Drawing.Size(153, 148);
            // 
            // CStart
            // 
            this.CStart.Name = "CStart";
            this.CStart.Size = new System.Drawing.Size(152, 22);
            this.CStart.Text = "녹화 시작";
            // 
            // CStop
            // 
            this.CStop.Name = "CStop";
            this.CStop.Size = new System.Drawing.Size(152, 22);
            this.CStop.Text = "녹화 중지";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // CSetting
            // 
            this.CSetting.Name = "CSetting";
            this.CSetting.Size = new System.Drawing.Size(152, 22);
            this.CSetting.Text = "녹화 설정";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // CMini
            // 
            this.CMini.Enabled = false;
            this.CMini.Name = "CMini";
            this.CMini.Size = new System.Drawing.Size(152, 22);
            this.CMini.Text = "최소화";
            // 
            // CExit
            // 
            this.CExit.Name = "CExit";
            this.CExit.Size = new System.Drawing.Size(152, 22);
            this.CExit.Text = "종료";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ViewPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PStart;
        private System.Windows.Forms.ToolStripButton PStop;
        private System.Windows.Forms.NotifyIcon PNotify;
        private System.Windows.Forms.ContextMenuStrip PStrip;
        private System.Windows.Forms.ToolStripMenuItem CStart;
        private System.Windows.Forms.ToolStripMenuItem CStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CSetting;
        private System.Windows.Forms.ToolStripSeparator 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMini;
        private System.Windows.Forms.ToolStripMenuItem CExit;
        public System.Windows.Forms.Panel ViewPanel;

    }
}

