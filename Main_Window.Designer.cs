namespace ARC_V4
{
    partial class Main_Window
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
            this.components = new System.ComponentModel.Container();
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs = new AntdUI.Tabs();
            this.tabPage_MoDraw = new AntdUI.TabPage();
            this.tabPage_Settings = new AntdUI.TabPage();
            this.tabPage_About = new AntdUI.TabPage();
            this.timer_Mo = new System.Windows.Forms.Timer(this.components);
            this.labe_MoDisplay = new AntdUI.Label();
            this.tabPage_AutoDraw = new AntdUI.TabPage();
            this.label_AutoDisplay = new AntdUI.Label();
            this.timer_Auto = new System.Windows.Forms.Timer(this.components);
            this.label_Settings_Time = new AntdUI.Label();
            this.inputNumber_Settings_Time = new AntdUI.InputNumber();
            this.inputNumber_Settings_AutoTime = new AntdUI.InputNumber();
            this.label_Settings_AutoTime = new AntdUI.Label();
            this.tooltipComponent = new AntdUI.TooltipComponent();
            this.button_NamelistEditor = new AntdUI.Button();
            this.select_Settings_NamelistsFile = new AntdUI.Select();
            this.button_MoStart = new AntdUI.Button();
            this.button_AutoStart = new AntdUI.Button();
            this.image3D_About = new AntdUI.Image3D();
            this.label_AboutInfo1 = new AntdUI.Label();
            this.label_AboutInfo2 = new AntdUI.Label();
            this.label_AboutInfo4 = new AntdUI.Label();
            this.label_AboutInfo3 = new AntdUI.Label();
            this.tabs.SuspendLayout();
            this.tabPage_MoDraw.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            this.tabPage_AutoDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.ShowIcon = true;
            this.pageHeader.Size = new System.Drawing.Size(550, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "Main_Window";
            // 
            // tabs
            // 
            this.tabs.Centered = true;
            this.tabs.Controls.Add(this.tabPage_MoDraw);
            this.tabs.Controls.Add(this.tabPage_AutoDraw);
            this.tabs.Controls.Add(this.tabPage_Settings);
            this.tabs.Controls.Add(this.tabPage_About);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs.HandCursor = System.Windows.Forms.Cursors.Default;
            this.tabs.Location = new System.Drawing.Point(0, 30);
            this.tabs.Name = "tabs";
            this.tabs.Pages.Add(this.tabPage_MoDraw);
            this.tabs.Pages.Add(this.tabPage_AutoDraw);
            this.tabs.Pages.Add(this.tabPage_Settings);
            this.tabs.Pages.Add(this.tabPage_About);
            this.tabs.SelectedIndex = 3;
            this.tabs.Size = new System.Drawing.Size(550, 270);
            this.tabs.Style = styleLine1;
            this.tabs.TabIndex = 1;
            this.tabs.Text = "tabs";
            // 
            // tabPage_MoDraw
            // 
            this.tabPage_MoDraw.Controls.Add(this.labe_MoDisplay);
            this.tabPage_MoDraw.Controls.Add(this.button_MoStart);
            this.tabPage_MoDraw.Location = new System.Drawing.Point(-544, -234);
            this.tabPage_MoDraw.Name = "tabPage_MoDraw";
            this.tabPage_MoDraw.Size = new System.Drawing.Size(544, 234);
            this.tabPage_MoDraw.TabIndex = 0;
            this.tabPage_MoDraw.Text = "手动抽取";
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.select_Settings_NamelistsFile);
            this.tabPage_Settings.Controls.Add(this.button_NamelistEditor);
            this.tabPage_Settings.Controls.Add(this.inputNumber_Settings_AutoTime);
            this.tabPage_Settings.Controls.Add(this.label_Settings_AutoTime);
            this.tabPage_Settings.Controls.Add(this.inputNumber_Settings_Time);
            this.tabPage_Settings.Controls.Add(this.label_Settings_Time);
            this.tabPage_Settings.Location = new System.Drawing.Point(0, 0);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(0, 0);
            this.tabPage_Settings.TabIndex = 3;
            this.tabPage_Settings.Text = "设置";
            // 
            // tabPage_About
            // 
            this.tabPage_About.Controls.Add(this.label_AboutInfo3);
            this.tabPage_About.Controls.Add(this.label_AboutInfo4);
            this.tabPage_About.Controls.Add(this.label_AboutInfo2);
            this.tabPage_About.Controls.Add(this.label_AboutInfo1);
            this.tabPage_About.Controls.Add(this.image3D_About);
            this.tabPage_About.Location = new System.Drawing.Point(3, 29);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(544, 238);
            this.tabPage_About.TabIndex = 4;
            this.tabPage_About.Text = "关于";
            // 
            // timer_Mo
            // 
            this.timer_Mo.Enabled = true;
            this.timer_Mo.Tick += new System.EventHandler(this.timer_Mo_Tick);
            // 
            // labe_MoDisplay
            // 
            this.labe_MoDisplay.BackColor = System.Drawing.Color.White;
            this.labe_MoDisplay.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.labe_MoDisplay.Location = new System.Drawing.Point(9, 6);
            this.labe_MoDisplay.Name = "labe_MoDisplay";
            this.labe_MoDisplay.Size = new System.Drawing.Size(526, 123);
            this.labe_MoDisplay.TabIndex = 0;
            this.labe_MoDisplay.Text = "UNKNOWN";
            this.labe_MoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_AutoDraw
            // 
            this.tabPage_AutoDraw.Controls.Add(this.label_AutoDisplay);
            this.tabPage_AutoDraw.Controls.Add(this.button_AutoStart);
            this.tabPage_AutoDraw.Location = new System.Drawing.Point(0, 0);
            this.tabPage_AutoDraw.Name = "tabPage_AutoDraw";
            this.tabPage_AutoDraw.Size = new System.Drawing.Size(0, 0);
            this.tabPage_AutoDraw.TabIndex = 5;
            this.tabPage_AutoDraw.Text = "自动抽取";
            // 
            // label_AutoDisplay
            // 
            this.label_AutoDisplay.BackColor = System.Drawing.Color.White;
            this.label_AutoDisplay.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label_AutoDisplay.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_AutoDisplay.Location = new System.Drawing.Point(9, 6);
            this.label_AutoDisplay.Name = "label_AutoDisplay";
            this.label_AutoDisplay.Size = new System.Drawing.Size(526, 123);
            this.label_AutoDisplay.TabIndex = 2;
            this.label_AutoDisplay.Text = "UNKNOWN";
            this.label_AutoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Auto
            // 
            this.timer_Auto.Enabled = true;
            this.timer_Auto.Tick += new System.EventHandler(this.timer_Auto_Tick);
            // 
            // label_Settings_Time
            // 
            this.label_Settings_Time.Location = new System.Drawing.Point(9, 3);
            this.label_Settings_Time.Name = "label_Settings_Time";
            this.label_Settings_Time.Size = new System.Drawing.Size(88, 30);
            this.label_Settings_Time.TabIndex = 0;
            this.label_Settings_Time.Text = "切换间隔(ms):";
            // 
            // inputNumber_Settings_Time
            // 
            this.inputNumber_Settings_Time.HandCursor = System.Windows.Forms.Cursors.Default;
            this.inputNumber_Settings_Time.Location = new System.Drawing.Point(91, 3);
            this.inputNumber_Settings_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber_Settings_Time.Name = "inputNumber_Settings_Time";
            this.inputNumber_Settings_Time.Size = new System.Drawing.Size(127, 30);
            this.inputNumber_Settings_Time.TabIndex = 1;
            this.inputNumber_Settings_Time.Text = "1";
            this.inputNumber_Settings_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber_Settings_Time.ValueChanged += new AntdUI.DecimalEventHandler(this.inputNumber_Settings_Time_ValueChanged);
            // 
            // inputNumber_Settings_AutoTime
            // 
            this.inputNumber_Settings_AutoTime.HandCursor = System.Windows.Forms.Cursors.Default;
            this.inputNumber_Settings_AutoTime.Location = new System.Drawing.Point(91, 39);
            this.inputNumber_Settings_AutoTime.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber_Settings_AutoTime.Name = "inputNumber_Settings_AutoTime";
            this.inputNumber_Settings_AutoTime.Size = new System.Drawing.Size(127, 30);
            this.inputNumber_Settings_AutoTime.TabIndex = 3;
            this.inputNumber_Settings_AutoTime.Text = "1000";
            this.inputNumber_Settings_AutoTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber_Settings_AutoTime.ValueChanged += new AntdUI.DecimalEventHandler(this.inputNumber_Settings_AutoTime_ValueChanged);
            // 
            // label_Settings_AutoTime
            // 
            this.label_Settings_AutoTime.Location = new System.Drawing.Point(9, 39);
            this.label_Settings_AutoTime.Name = "label_Settings_AutoTime";
            this.label_Settings_AutoTime.Size = new System.Drawing.Size(88, 30);
            this.label_Settings_AutoTime.TabIndex = 2;
            this.label_Settings_AutoTime.Text = "自动抽取时间:";
            // 
            // button_NamelistEditor
            // 
            this.button_NamelistEditor.Location = new System.Drawing.Point(9, 75);
            this.button_NamelistEditor.Name = "button_NamelistEditor";
            this.button_NamelistEditor.Size = new System.Drawing.Size(126, 37);
            this.button_NamelistEditor.TabIndex = 4;
            this.button_NamelistEditor.Text = "名单编辑器";
            this.button_NamelistEditor.Click += new System.EventHandler(this.button_NamelistEditor_Click);
            // 
            // select_Settings_NamelistsFile
            // 
            this.select_Settings_NamelistsFile.HandCursor = System.Windows.Forms.Cursors.Default;
            this.select_Settings_NamelistsFile.List = true;
            this.select_Settings_NamelistsFile.ListAutoWidth = true;
            this.select_Settings_NamelistsFile.Location = new System.Drawing.Point(9, 184);
            this.select_Settings_NamelistsFile.MaxCount = 10;
            this.select_Settings_NamelistsFile.Name = "select_Settings_NamelistsFile";
            this.select_Settings_NamelistsFile.Placement = AntdUI.TAlignFrom.Top;
            this.select_Settings_NamelistsFile.Size = new System.Drawing.Size(523, 45);
            this.select_Settings_NamelistsFile.TabIndex = 5;
            this.select_Settings_NamelistsFile.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_Settings_NamelistsFile_SelectedIndexChanged);
            // 
            // button_MoStart
            // 
            this.button_MoStart.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_MoStart.Icon = global::ARC_V4.Properties.Resources.Start;
            this.button_MoStart.IconRatio = 1F;
            this.button_MoStart.Location = new System.Drawing.Point(350, 165);
            this.button_MoStart.Name = "button_MoStart";
            this.button_MoStart.Size = new System.Drawing.Size(185, 70);
            this.button_MoStart.TabIndex = 1;
            this.button_MoStart.Text = "开始抽取";
            this.button_MoStart.Type = AntdUI.TTypeMini.Primary;
            this.button_MoStart.Click += new System.EventHandler(this.button_MoStart_Click);
            // 
            // button_AutoStart
            // 
            this.button_AutoStart.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_AutoStart.Icon = global::ARC_V4.Properties.Resources.Start;
            this.button_AutoStart.IconRatio = 1F;
            this.button_AutoStart.Location = new System.Drawing.Point(350, 165);
            this.button_AutoStart.Name = "button_AutoStart";
            this.button_AutoStart.Size = new System.Drawing.Size(185, 70);
            this.button_AutoStart.TabIndex = 3;
            this.button_AutoStart.Text = "开始抽取";
            this.button_AutoStart.Type = AntdUI.TTypeMini.Primary;
            this.button_AutoStart.Click += new System.EventHandler(this.button_AutoStart_Click);
            // 
            // image3D_About
            // 
            this.image3D_About.Image = global::ARC_V4.Properties.Resources.Icon;
            this.image3D_About.ImageFit = AntdUI.TFit.Fill;
            this.image3D_About.Location = new System.Drawing.Point(9, 10);
            this.image3D_About.Name = "image3D_About";
            this.image3D_About.Size = new System.Drawing.Size(64, 64);
            this.image3D_About.TabIndex = 0;
            // 
            // label_AboutInfo1
            // 
            this.label_AboutInfo1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label_AboutInfo1.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_AboutInfo1.Location = new System.Drawing.Point(100, 10);
            this.label_AboutInfo1.Name = "label_AboutInfo1";
            this.label_AboutInfo1.Size = new System.Drawing.Size(163, 30);
            this.label_AboutInfo1.TabIndex = 1;
            this.label_AboutInfo1.Text = "自动点名器V4";
            // 
            // label_AboutInfo2
            // 
            this.label_AboutInfo2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_AboutInfo2.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_AboutInfo2.Location = new System.Drawing.Point(100, 46);
            this.label_AboutInfo2.Name = "label_AboutInfo2";
            this.label_AboutInfo2.Size = new System.Drawing.Size(265, 21);
            this.label_AboutInfo2.TabIndex = 2;
            this.label_AboutInfo2.Text = "华某人 版权所有 2024~2025 © 盗版必究";
            // 
            // label_AboutInfo4
            // 
            this.label_AboutInfo4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_AboutInfo4.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_AboutInfo4.Location = new System.Drawing.Point(9, 206);
            this.label_AboutInfo4.Name = "label_AboutInfo4";
            this.label_AboutInfo4.Size = new System.Drawing.Size(294, 21);
            this.label_AboutInfo4.TabIndex = 3;
            this.label_AboutInfo4.Text = "此软件使用.NET Framework框架，UI使用AntdUI库";
            // 
            // label_AboutInfo3
            // 
            this.label_AboutInfo3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_AboutInfo3.HandCursor = System.Windows.Forms.Cursors.Default;
            this.label_AboutInfo3.Location = new System.Drawing.Point(9, 179);
            this.label_AboutInfo3.Name = "label_AboutInfo3";
            this.label_AboutInfo3.Size = new System.Drawing.Size(520, 21);
            this.label_AboutInfo3.TabIndex = 4;
            this.label_AboutInfo3.Text = "当前分支: UNKNOWN  当前版本:UNKNOWN";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pageHeader);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Mode = AntdUI.TAMode.Light;
            this.Name = "Main_Window";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.tabs.ResumeLayout(false);
            this.tabPage_MoDraw.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.tabPage_About.ResumeLayout(false);
            this.tabPage_AutoDraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Tabs tabs;
        private AntdUI.TabPage tabPage_MoDraw;
        private AntdUI.TabPage tabPage_Settings;
        private AntdUI.TabPage tabPage_About;
        private System.Windows.Forms.Timer timer_Mo;
        private AntdUI.Label labe_MoDisplay;
        private AntdUI.Button button_MoStart;
        private AntdUI.TabPage tabPage_AutoDraw;
        private AntdUI.Label label_AutoDisplay;
        private AntdUI.Button button_AutoStart;
        private System.Windows.Forms.Timer timer_Auto;
        private AntdUI.InputNumber inputNumber_Settings_Time;
        private AntdUI.Label label_Settings_Time;
        private AntdUI.InputNumber inputNumber_Settings_AutoTime;
        private AntdUI.Label label_Settings_AutoTime;
        private AntdUI.TooltipComponent tooltipComponent;
        private AntdUI.Button button_NamelistEditor;
        private AntdUI.Select select_Settings_NamelistsFile;
        private AntdUI.Image3D image3D_About;
        private AntdUI.Label label_AboutInfo4;
        private AntdUI.Label label_AboutInfo2;
        private AntdUI.Label label_AboutInfo1;
        private AntdUI.Label label_AboutInfo3;
    }
}

