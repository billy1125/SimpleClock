namespace SimpleClock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.cmbCountHour = new System.Windows.Forms.ComboBox();
            this.cmbCountMin = new System.Windows.Forms.ComboBox();
            this.cmbCountSecond = new System.Windows.Forms.ComboBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStop = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelAlert);
            this.tabPage1.Controls.Add(this.btnSetAlert);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbMin);
            this.tabPage1.Controls.Add(this.cmbHour);
            this.tabPage1.Controls.Add(this.txtWeekDay);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Location = new System.Drawing.Point(584, 323);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(162, 53);
            this.btnCancelAlert.TabIndex = 7;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(404, 323);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(162, 53);
            this.btnSetAlert.TabIndex = 6;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(188, 305);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(153, 33);
            this.cmbMin.TabIndex = 4;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(6, 305);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(153, 33);
            this.cmbHour.TabIndex = 3;
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Enabled = false;
            this.txtWeekDay.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeekDay.Location = new System.Drawing.Point(584, 184);
            this.txtWeekDay.Multiline = true;
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(389, 116);
            this.txtWeekDay.TabIndex = 2;
            this.txtWeekDay.Text = "test";
            this.txtWeekDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(6, 183);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(572, 116);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "test";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("微軟正黑體", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(6, 6);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(967, 172);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "test";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnLog);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.listStopWatchLog);
            this.tabPage2.Controls.Add(this.txtStopWatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStop.Location = new System.Drawing.Point(347, 317);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(460, 60);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止並歸零";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLog.Location = new System.Drawing.Point(579, 251);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(227, 60);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(346, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(227, 60);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.Location = new System.Drawing.Point(580, 185);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(227, 60);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(347, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(227, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 25;
            this.listStopWatchLog.Location = new System.Drawing.Point(6, 184);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(335, 329);
            this.listStopWatchLog.TabIndex = 2;
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Enabled = false;
            this.txtStopWatch.Font = new System.Drawing.Font("微軟正黑體", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.Location = new System.Drawing.Point(6, 6);
            this.txtStopWatch.Multiline = true;
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(967, 172);
            this.txtStopWatch.TabIndex = 1;
            this.txtStopWatch.Text = "00:00:00:000";
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCountStop);
            this.tabPage3.Controls.Add(this.btnCountPause);
            this.tabPage3.Controls.Add(this.btnCountStart);
            this.tabPage3.Controls.Add(this.cmbCountSecond);
            this.tabPage3.Controls.Add(this.cmbCountMin);
            this.tabPage3.Controls.Add(this.cmbCountHour);
            this.tabPage3.Controls.Add(this.txtCountDown);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(979, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Interval = 1000;
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // txtCountDown
            // 
            this.txtCountDown.Enabled = false;
            this.txtCountDown.Font = new System.Drawing.Font("微軟正黑體", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCountDown.Location = new System.Drawing.Point(3, 3);
            this.txtCountDown.Multiline = true;
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(967, 172);
            this.txtCountDown.TabIndex = 2;
            this.txtCountDown.Text = "00:00:00";
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCountHour
            // 
            this.cmbCountHour.FormattingEnabled = true;
            this.cmbCountHour.Location = new System.Drawing.Point(3, 181);
            this.cmbCountHour.Name = "cmbCountHour";
            this.cmbCountHour.Size = new System.Drawing.Size(153, 33);
            this.cmbCountHour.TabIndex = 4;
            // 
            // cmbCountMin
            // 
            this.cmbCountMin.FormattingEnabled = true;
            this.cmbCountMin.Location = new System.Drawing.Point(162, 181);
            this.cmbCountMin.Name = "cmbCountMin";
            this.cmbCountMin.Size = new System.Drawing.Size(153, 33);
            this.cmbCountMin.TabIndex = 5;
            // 
            // cmbCountSecond
            // 
            this.cmbCountSecond.FormattingEnabled = true;
            this.cmbCountSecond.Location = new System.Drawing.Point(321, 181);
            this.cmbCountSecond.Name = "cmbCountSecond";
            this.cmbCountSecond.Size = new System.Drawing.Size(153, 33);
            this.cmbCountSecond.TabIndex = 6;
            // 
            // btnCountStart
            // 
            this.btnCountStart.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountStart.Location = new System.Drawing.Point(3, 220);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(471, 60);
            this.btnCountStart.TabIndex = 7;
            this.btnCountStart.Text = "開始";
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // btnCountPause
            // 
            this.btnCountPause.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountPause.Location = new System.Drawing.Point(3, 286);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(471, 60);
            this.btnCountPause.TabIndex = 8;
            this.btnCountPause.Text = "暫停";
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStop
            // 
            this.btnCountStop.BackColor = System.Drawing.Color.Red;
            this.btnCountStop.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCountStop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCountStop.Location = new System.Drawing.Point(3, 352);
            this.btnCountStop.Name = "btnCountStop";
            this.btnCountStop.Size = new System.Drawing.Size(471, 60);
            this.btnCountStop.TabIndex = 9;
            this.btnCountStop.Text = "停止";
            this.btnCountStop.UseVisualStyleBackColor = false;
            this.btnCountStop.Click += new System.EventHandler(this.btnCountStop_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 600);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button btnCountStop;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.ComboBox cmbCountSecond;
        private System.Windows.Forms.ComboBox cmbCountMin;
        private System.Windows.Forms.ComboBox cmbCountHour;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

