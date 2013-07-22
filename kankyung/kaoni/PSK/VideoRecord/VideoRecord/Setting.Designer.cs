namespace VideoRecord
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PFullMode = new System.Windows.Forms.RadioButton();
            this.PWindow = new System.Windows.Forms.RadioButton();
            this.PMute = new System.Windows.Forms.CheckBox();
            this.PMousePointer = new System.Windows.Forms.CheckBox();
            this.PSubSound = new System.Windows.Forms.ComboBox();
            this.PCkSubSound = new System.Windows.Forms.CheckBox();
            this.PMainSound = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PQuality = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PFrame = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PDir = new System.Windows.Forms.Button();
            this.PDirText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.POk = new System.Windows.Forms.Button();
            this.PCancel = new System.Windows.Forms.Button();
            this.PDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PMute);
            this.groupBox1.Controls.Add(this.PMousePointer);
            this.groupBox1.Controls.Add(this.PSubSound);
            this.groupBox1.Controls.Add(this.PCkSubSound);
            this.groupBox1.Controls.Add(this.PMainSound);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PQuality);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PFrame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PDir);
            this.groupBox1.Controls.Add(this.PDirText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "녹화 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PFullMode);
            this.groupBox2.Controls.Add(this.PWindow);
            this.groupBox2.Location = new System.Drawing.Point(7, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 52);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "녹화 범위";
            // 
            // PFullMode
            // 
            this.PFullMode.AutoSize = true;
            this.PFullMode.Location = new System.Drawing.Point(76, 21);
            this.PFullMode.Name = "PFullMode";
            this.PFullMode.Size = new System.Drawing.Size(75, 16);
            this.PFullMode.TabIndex = 1;
            this.PFullMode.TabStop = true;
            this.PFullMode.Text = "전체 화면";
            this.PFullMode.UseVisualStyleBackColor = true;
            // 
            // PWindow
            // 
            this.PWindow.AutoSize = true;
            this.PWindow.Enabled = false;
            this.PWindow.Location = new System.Drawing.Point(7, 21);
            this.PWindow.Name = "PWindow";
            this.PWindow.Size = new System.Drawing.Size(63, 16);
            this.PWindow.TabIndex = 0;
            this.PWindow.TabStop = true;
            this.PWindow.Text = "창 모드";
            this.PWindow.UseVisualStyleBackColor = true;
            // 
            // PMute
            // 
            this.PMute.AutoSize = true;
            this.PMute.Location = new System.Drawing.Point(228, 153);
            this.PMute.Name = "PMute";
            this.PMute.Size = new System.Drawing.Size(116, 16);
            this.PMute.TabIndex = 16;
            this.PMute.Text = "사운드 녹음 안함";
            this.PMute.UseVisualStyleBackColor = true;
            // 
            // PMousePointer
            // 
            this.PMousePointer.AutoSize = true;
            this.PMousePointer.Location = new System.Drawing.Point(384, 153);
            this.PMousePointer.Name = "PMousePointer";
            this.PMousePointer.Size = new System.Drawing.Size(128, 16);
            this.PMousePointer.TabIndex = 15;
            this.PMousePointer.Text = "마우스 포인터 녹화";
            this.PMousePointer.UseVisualStyleBackColor = true;
            // 
            // PSubSound
            // 
            this.PSubSound.Enabled = false;
            this.PSubSound.FormattingEnabled = true;
            this.PSubSound.Location = new System.Drawing.Point(126, 90);
            this.PSubSound.Name = "PSubSound";
            this.PSubSound.Size = new System.Drawing.Size(407, 20);
            this.PSubSound.TabIndex = 14;
            // 
            // PCkSubSound
            // 
            this.PCkSubSound.AutoSize = true;
            this.PCkSubSound.Location = new System.Drawing.Point(9, 92);
            this.PCkSubSound.Name = "PCkSubSound";
            this.PCkSubSound.Size = new System.Drawing.Size(116, 16);
            this.PCkSubSound.TabIndex = 13;
            this.PCkSubSound.Text = "보조 사운드 장치";
            this.PCkSubSound.UseVisualStyleBackColor = true;
            // 
            // PMainSound
            // 
            this.PMainSound.FormattingEnabled = true;
            this.PMainSound.Location = new System.Drawing.Point(95, 53);
            this.PMainSound.Name = "PMainSound";
            this.PMainSound.Size = new System.Drawing.Size(438, 20);
            this.PMainSound.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "주 사운드 장치";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // PQuality
            // 
            this.PQuality.Location = new System.Drawing.Point(430, 119);
            this.PQuality.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.PQuality.Name = "PQuality";
            this.PQuality.Size = new System.Drawing.Size(82, 21);
            this.PQuality.TabIndex = 9;
            this.PQuality.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "녹화 품질";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "fps";
            // 
            // PFrame
            // 
            this.PFrame.Location = new System.Drawing.Point(228, 119);
            this.PFrame.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.PFrame.Name = "PFrame";
            this.PFrame.Size = new System.Drawing.Size(79, 21);
            this.PFrame.TabIndex = 6;
            this.PFrame.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "프레임";
            // 
            // PDir
            // 
            this.PDir.Location = new System.Drawing.Point(458, 16);
            this.PDir.Name = "PDir";
            this.PDir.Size = new System.Drawing.Size(75, 23);
            this.PDir.TabIndex = 4;
            this.PDir.Text = "찾아보기";
            this.PDir.UseVisualStyleBackColor = true;
            // 
            // PDirText
            // 
            this.PDirText.Location = new System.Drawing.Point(95, 18);
            this.PDirText.Name = "PDirText";
            this.PDirText.ReadOnly = true;
            this.PDirText.Size = new System.Drawing.Size(357, 21);
            this.PDirText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "저장 디렉토리";
            // 
            // POk
            // 
            this.POk.Location = new System.Drawing.Point(396, 199);
            this.POk.Name = "POk";
            this.POk.Size = new System.Drawing.Size(75, 23);
            this.POk.TabIndex = 1;
            this.POk.Text = "확인";
            this.POk.UseVisualStyleBackColor = true;
            // 
            // PCancel
            // 
            this.PCancel.Location = new System.Drawing.Point(476, 199);
            this.PCancel.Name = "PCancel";
            this.PCancel.Size = new System.Drawing.Size(75, 23);
            this.PCancel.TabIndex = 2;
            this.PCancel.Text = "취소";
            this.PCancel.UseVisualStyleBackColor = true;
            // 
            // PDefault
            // 
            this.PDefault.Location = new System.Drawing.Point(12, 199);
            this.PDefault.Name = "PDefault";
            this.PDefault.Size = new System.Drawing.Size(75, 23);
            this.PDefault.TabIndex = 3;
            this.PDefault.Text = "원래대로";
            this.PDefault.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 234);
            this.Controls.Add(this.PDefault);
            this.Controls.Add(this.PCancel);
            this.Controls.Add(this.POk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "녹화 설정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PMute;
        private System.Windows.Forms.CheckBox PMousePointer;
        private System.Windows.Forms.ComboBox PSubSound;
        private System.Windows.Forms.CheckBox PCkSubSound;
        private System.Windows.Forms.ComboBox PMainSound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PDir;
        private System.Windows.Forms.TextBox PDirText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button POk;
        private System.Windows.Forms.Button PCancel;
        private System.Windows.Forms.Button PDefault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PFullMode;
        private System.Windows.Forms.RadioButton PWindow;
    }
}