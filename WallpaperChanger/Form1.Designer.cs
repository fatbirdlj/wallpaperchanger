namespace WallpaperChanger
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
            this.btnScan = new System.Windows.Forms.Button();
            this.pbShowSmallpic = new System.Windows.Forms.PictureBox();
            this.btnSetasWallpaper = new System.Windows.Forms.Button();
            this.lvWallPapers = new System.Windows.Forms.ListView();
            this.imglWallPapers = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.rbtnTiled = new System.Windows.Forms.RadioButton();
            this.rbtnCentered = new System.Windows.Forms.RadioButton();
            this.rbtnStretched = new System.Windows.Forms.RadioButton();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.rbtnTowM = new System.Windows.Forms.RadioButton();
            this.rbtnOneM = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.nfiShow = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnabled = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowSmallpic)).BeginInit();
            this.gbStyle.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Blue;
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(924, 34);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(142, 46);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "浏览";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pbShowSmallpic
            // 
            this.pbShowSmallpic.Location = new System.Drawing.Point(924, 160);
            this.pbShowSmallpic.Name = "pbShowSmallpic";
            this.pbShowSmallpic.Size = new System.Drawing.Size(142, 100);
            this.pbShowSmallpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowSmallpic.TabIndex = 1;
            this.pbShowSmallpic.TabStop = false;
            // 
            // btnSetasWallpaper
            // 
            this.btnSetasWallpaper.BackColor = System.Drawing.Color.Blue;
            this.btnSetasWallpaper.ForeColor = System.Drawing.Color.White;
            this.btnSetasWallpaper.Location = new System.Drawing.Point(924, 86);
            this.btnSetasWallpaper.Name = "btnSetasWallpaper";
            this.btnSetasWallpaper.Size = new System.Drawing.Size(142, 46);
            this.btnSetasWallpaper.TabIndex = 2;
            this.btnSetasWallpaper.Text = "设为桌面";
            this.btnSetasWallpaper.UseVisualStyleBackColor = false;
            this.btnSetasWallpaper.Click += new System.EventHandler(this.btnSetasWallpaper_Click);
            // 
            // lvWallPapers
            // 
            this.lvWallPapers.AllowDrop = true;
            this.lvWallPapers.Location = new System.Drawing.Point(62, 34);
            this.lvWallPapers.Name = "lvWallPapers";
            this.lvWallPapers.Size = new System.Drawing.Size(613, 501);
            this.lvWallPapers.TabIndex = 3;
            this.lvWallPapers.UseCompatibleStateImageBehavior = false;
            this.lvWallPapers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvWallPapers_ItemDrag);
            this.lvWallPapers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvWallPapers_DragDrop);
            this.lvWallPapers.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvWallPapers_DragEnter);
            this.lvWallPapers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvWallPapers_MouseMove);
            this.lvWallPapers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvWallPapers_MouseUp);
            // 
            // imglWallPapers
            // 
            this.imglWallPapers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglWallPapers.ImageSize = new System.Drawing.Size(32, 32);
            this.imglWallPapers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(720, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(720, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbStyle
            // 
            this.gbStyle.Controls.Add(this.rbtnTiled);
            this.gbStyle.Controls.Add(this.rbtnCentered);
            this.gbStyle.Controls.Add(this.rbtnStretched);
            this.gbStyle.Location = new System.Drawing.Point(703, 404);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(191, 131);
            this.gbStyle.TabIndex = 6;
            this.gbStyle.TabStop = false;
            this.gbStyle.Text = "Style";
            // 
            // rbtnTiled
            // 
            this.rbtnTiled.AutoSize = true;
            this.rbtnTiled.Location = new System.Drawing.Point(57, 84);
            this.rbtnTiled.Name = "rbtnTiled";
            this.rbtnTiled.Size = new System.Drawing.Size(60, 21);
            this.rbtnTiled.TabIndex = 2;
            this.rbtnTiled.Text = "Tiled";
            this.rbtnTiled.UseVisualStyleBackColor = true;
            // 
            // rbtnCentered
            // 
            this.rbtnCentered.AutoSize = true;
            this.rbtnCentered.Location = new System.Drawing.Point(57, 57);
            this.rbtnCentered.Name = "rbtnCentered";
            this.rbtnCentered.Size = new System.Drawing.Size(87, 21);
            this.rbtnCentered.TabIndex = 1;
            this.rbtnCentered.Text = "Centered";
            this.rbtnCentered.UseVisualStyleBackColor = true;
            // 
            // rbtnStretched
            // 
            this.rbtnStretched.AutoSize = true;
            this.rbtnStretched.Checked = true;
            this.rbtnStretched.Location = new System.Drawing.Point(57, 30);
            this.rbtnStretched.Name = "rbtnStretched";
            this.rbtnStretched.Size = new System.Drawing.Size(90, 21);
            this.rbtnStretched.TabIndex = 0;
            this.rbtnStretched.TabStop = true;
            this.rbtnStretched.Text = "Stretched";
            this.rbtnStretched.UseVisualStyleBackColor = true;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Controls.Add(this.btnCustom);
            this.gbTime.Controls.Add(this.rbtnTowM);
            this.gbTime.Controls.Add(this.rbtnOneM);
            this.gbTime.Location = new System.Drawing.Point(703, 248);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(191, 150);
            this.gbTime.TabIndex = 7;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom:";
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(96, 94);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(69, 23);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // rbtnTowM
            // 
            this.rbtnTowM.AutoSize = true;
            this.rbtnTowM.Location = new System.Drawing.Point(34, 65);
            this.rbtnTowM.Name = "rbtnTowM";
            this.rbtnTowM.Size = new System.Drawing.Size(84, 21);
            this.rbtnTowM.TabIndex = 1;
            this.rbtnTowM.Tag = "2";
            this.rbtnTowM.Text = "TwoMinit";
            this.rbtnTowM.UseVisualStyleBackColor = true;
            // 
            // rbtnOneM
            // 
            this.rbtnOneM.AutoSize = true;
            this.rbtnOneM.Checked = true;
            this.rbtnOneM.Location = new System.Drawing.Point(33, 38);
            this.rbtnOneM.Name = "rbtnOneM";
            this.rbtnOneM.Size = new System.Drawing.Size(85, 21);
            this.rbtnOneM.TabIndex = 0;
            this.rbtnOneM.TabStop = true;
            this.rbtnOneM.Tag = "1";
            this.rbtnOneM.Text = "OneMinit";
            this.rbtnOneM.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Blue;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(924, 464);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(124, 46);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.Blue;
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(720, 64);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(124, 46);
            this.btnAddGroup.TabIndex = 9;
            this.btnAddGroup.Text = "添加组";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.ItemHeight = 16;
            this.cmbGroup.Location = new System.Drawing.Point(720, 34);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 24);
            this.cmbGroup.TabIndex = 10;
            // 
            // nfiShow
            // 
            this.nfiShow.ContextMenuStrip = this.cmsNotify;
            this.nfiShow.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiShow.Icon")));
            this.nfiShow.Text = "胖鸟景焕";
            this.nfiShow.Visible = true;
            this.nfiShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nfiShow_MouseClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiStop,
            this.tsmiExit});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.Size = new System.Drawing.Size(115, 76);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(114, 24);
            this.tsmiShow.Text = "Show";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(114, 24);
            this.tsmiStop.Text = "Stop";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(114, 24);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // btnEnabled
            // 
            this.btnEnabled.BackColor = System.Drawing.Color.Blue;
            this.btnEnabled.ForeColor = System.Drawing.Color.White;
            this.btnEnabled.Location = new System.Drawing.Point(924, 405);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(124, 46);
            this.btnEnabled.TabIndex = 11;
            this.btnEnabled.Text = "设置";
            this.btnEnabled.UseVisualStyleBackColor = false;
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.Blue;
            this.btnDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGroup.Location = new System.Drawing.Point(720, 202);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(124, 46);
            this.btnDeleteGroup.TabIndex = 12;
            this.btnDeleteGroup.Text = "删除组";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(107, 557);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(46, 17);
            this.labelX.TabIndex = 13;
            this.labelX.Text = "label2";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(180, 557);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(46, 17);
            this.labelY.TabIndex = 14;
            this.labelY.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 609);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnEnabled);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbStyle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvWallPapers);
            this.Controls.Add(this.btnSetasWallpaper);
            this.Controls.Add(this.pbShowSmallpic);
            this.Controls.Add(this.btnScan);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "胖鸟景焕";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowSmallpic)).EndInit();
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pbShowSmallpic;
        private System.Windows.Forms.Button btnSetasWallpaper;
        private System.Windows.Forms.ListView lvWallPapers;
        private System.Windows.Forms.ImageList imglWallPapers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.RadioButton rbtnTiled;
        private System.Windows.Forms.RadioButton rbtnCentered;
        private System.Windows.Forms.RadioButton rbtnStretched;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTowM;
        private System.Windows.Forms.RadioButton rbtnOneM;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.NotifyIcon nfiShow;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button btnEnabled;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
    }
}

