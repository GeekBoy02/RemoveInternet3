namespace RemoveInternet2
{
    partial class RemoveInternet2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveInternet2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listAllProcesses_btn = new System.Windows.Forms.Button();
            this.ProcessNameValue_lbl = new System.Windows.Forms.Label();
            this.PorcessIDvalue_lbl = new System.Windows.Forms.Label();
            this.ProcessNameLabel_lbl = new System.Windows.Forms.Label();
            this.ProcessIDLabel_lbl = new System.Windows.Forms.Label();
            this.Block_btn = new System.Windows.Forms.Button();
            this.Unblock_btn = new System.Windows.Forms.Button();
            this.listOpenWindow_btn = new System.Windows.Forms.Button();
            this.unBlockAllApps_btn = new System.Windows.Forms.Button();
            this.blockedApps_listbox = new System.Windows.Forms.ListBox();
            this.ProcessesListbox_lbl = new System.Windows.Forms.Label();
            this.blockedAppsListBox_lbl = new System.Windows.Forms.Label();
            this.Unblock2_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thereIsNoHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProcessLocationLabel_lbl = new System.Windows.Forms.Label();
            this.ProcessLocationValue_lbl = new System.Windows.Forms.Label();
            this.SelectedItem_lbl = new System.Windows.Forms.Label();
            this.blockApp_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActiveProcess_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unblockApp_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listAlProcesess_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOpenWindows_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockedList_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unBlockAllApps_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unblockApp_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPath_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ActiveProcess_contextMenu.SuspendLayout();
            this.BlockedList_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 394);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            // 
            // listAllProcesses_btn
            // 
            this.listAllProcesses_btn.Location = new System.Drawing.Point(369, 315);
            this.listAllProcesses_btn.Name = "listAllProcesses_btn";
            this.listAllProcesses_btn.Size = new System.Drawing.Size(108, 23);
            this.listAllProcesses_btn.TabIndex = 2;
            this.listAllProcesses_btn.Text = "List all Processes";
            this.listAllProcesses_btn.UseVisualStyleBackColor = true;
            this.listAllProcesses_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // ProcessNameValue_lbl
            // 
            this.ProcessNameValue_lbl.Location = new System.Drawing.Point(470, 59);
            this.ProcessNameValue_lbl.Name = "ProcessNameValue_lbl";
            this.ProcessNameValue_lbl.Size = new System.Drawing.Size(131, 29);
            this.ProcessNameValue_lbl.TabIndex = 4;
            // 
            // PorcessIDvalue_lbl
            // 
            this.PorcessIDvalue_lbl.Location = new System.Drawing.Point(470, 88);
            this.PorcessIDvalue_lbl.Name = "PorcessIDvalue_lbl";
            this.PorcessIDvalue_lbl.Size = new System.Drawing.Size(131, 29);
            this.PorcessIDvalue_lbl.TabIndex = 5;
            // 
            // ProcessNameLabel_lbl
            // 
            this.ProcessNameLabel_lbl.AutoSize = true;
            this.ProcessNameLabel_lbl.Location = new System.Drawing.Point(369, 60);
            this.ProcessNameLabel_lbl.Name = "ProcessNameLabel_lbl";
            this.ProcessNameLabel_lbl.Size = new System.Drawing.Size(79, 13);
            this.ProcessNameLabel_lbl.TabIndex = 6;
            this.ProcessNameLabel_lbl.Text = "Process Name:";
            // 
            // ProcessIDLabel_lbl
            // 
            this.ProcessIDLabel_lbl.AutoSize = true;
            this.ProcessIDLabel_lbl.Location = new System.Drawing.Point(369, 88);
            this.ProcessIDLabel_lbl.Name = "ProcessIDLabel_lbl";
            this.ProcessIDLabel_lbl.Size = new System.Drawing.Size(62, 13);
            this.ProcessIDLabel_lbl.TabIndex = 7;
            this.ProcessIDLabel_lbl.Text = "Process ID:";
            // 
            // Block_btn
            // 
            this.Block_btn.Location = new System.Drawing.Point(369, 402);
            this.Block_btn.Name = "Block_btn";
            this.Block_btn.Size = new System.Drawing.Size(108, 23);
            this.Block_btn.TabIndex = 8;
            this.Block_btn.Text = "Block App.";
            this.Block_btn.UseVisualStyleBackColor = true;
            this.Block_btn.Click += new System.EventHandler(this.Block_btn_Click);
            // 
            // Unblock_btn
            // 
            this.Unblock_btn.Location = new System.Drawing.Point(369, 431);
            this.Unblock_btn.Name = "Unblock_btn";
            this.Unblock_btn.Size = new System.Drawing.Size(108, 23);
            this.Unblock_btn.TabIndex = 9;
            this.Unblock_btn.Text = "Unblock App.";
            this.Unblock_btn.UseVisualStyleBackColor = true;
            this.Unblock_btn.Click += new System.EventHandler(this.Unblock_btn_Click);
            // 
            // listOpenWindow_btn
            // 
            this.listOpenWindow_btn.Location = new System.Drawing.Point(369, 344);
            this.listOpenWindow_btn.Name = "listOpenWindow_btn";
            this.listOpenWindow_btn.Size = new System.Drawing.Size(108, 23);
            this.listOpenWindow_btn.TabIndex = 10;
            this.listOpenWindow_btn.Text = "List open Windows";
            this.listOpenWindow_btn.UseVisualStyleBackColor = true;
            this.listOpenWindow_btn.Click += new System.EventHandler(this.ListRunningPs_btn_Click);
            // 
            // unBlockAllApps_btn
            // 
            this.unBlockAllApps_btn.Location = new System.Drawing.Point(493, 402);
            this.unBlockAllApps_btn.Name = "unBlockAllApps_btn";
            this.unBlockAllApps_btn.Size = new System.Drawing.Size(108, 23);
            this.unBlockAllApps_btn.TabIndex = 11;
            this.unBlockAllApps_btn.Text = "Unblock all Apps";
            this.unBlockAllApps_btn.UseVisualStyleBackColor = true;
            this.unBlockAllApps_btn.Click += new System.EventHandler(this.UnBlockAllApps_btn_Click);
            // 
            // blockedApps_listbox
            // 
            this.blockedApps_listbox.FormattingEnabled = true;
            this.blockedApps_listbox.Location = new System.Drawing.Point(607, 60);
            this.blockedApps_listbox.Name = "blockedApps_listbox";
            this.blockedApps_listbox.Size = new System.Drawing.Size(351, 394);
            this.blockedApps_listbox.TabIndex = 12;
            this.blockedApps_listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            this.blockedApps_listbox.DoubleClick += new System.EventHandler(this.blockedApps_listbox_DoubleClick);
            this.blockedApps_listbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockedApps_listbox_MouseDown);
            // 
            // ProcessesListbox_lbl
            // 
            this.ProcessesListbox_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessesListbox_lbl.AutoSize = true;
            this.ProcessesListbox_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessesListbox_lbl.Location = new System.Drawing.Point(12, 37);
            this.ProcessesListbox_lbl.Name = "ProcessesListbox_lbl";
            this.ProcessesListbox_lbl.Size = new System.Drawing.Size(130, 20);
            this.ProcessesListbox_lbl.TabIndex = 13;
            this.ProcessesListbox_lbl.Text = "Active Processes";
            // 
            // blockedAppsListBox_lbl
            // 
            this.blockedAppsListBox_lbl.AutoSize = true;
            this.blockedAppsListBox_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedAppsListBox_lbl.Location = new System.Drawing.Point(796, 37);
            this.blockedAppsListBox_lbl.Name = "blockedAppsListBox_lbl";
            this.blockedAppsListBox_lbl.Size = new System.Drawing.Size(162, 20);
            this.blockedAppsListBox_lbl.TabIndex = 14;
            this.blockedAppsListBox_lbl.Text = "Firewall blocked Apps";
            // 
            // Unblock2_btn
            // 
            this.Unblock2_btn.Location = new System.Drawing.Point(493, 431);
            this.Unblock2_btn.Name = "Unblock2_btn";
            this.Unblock2_btn.Size = new System.Drawing.Size(108, 23);
            this.Unblock2_btn.TabIndex = 15;
            this.Unblock2_btn.Text = "Unblock App.";
            this.Unblock2_btn.UseVisualStyleBackColor = true;
            this.Unblock2_btn.Click += new System.EventHandler(this.Unblock2_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToBlockToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fIleToolStripMenuItem.Text = "Menu";
            // 
            // selectFileToBlockToolStripMenuItem
            // 
            this.selectFileToBlockToolStripMenuItem.Name = "selectFileToBlockToolStripMenuItem";
            this.selectFileToBlockToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.selectFileToBlockToolStripMenuItem.Text = "Select File and block it";
            this.selectFileToBlockToolStripMenuItem.Click += new System.EventHandler(this.selectFileToBlockToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thereIsNoHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // thereIsNoHelpToolStripMenuItem
            // 
            this.thereIsNoHelpToolStripMenuItem.Name = "thereIsNoHelpToolStripMenuItem";
            this.thereIsNoHelpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.thereIsNoHelpToolStripMenuItem.Text = "There is no help";
            this.thereIsNoHelpToolStripMenuItem.Click += new System.EventHandler(this.thereIsNoHelpToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ProcessLocationLabel_lbl
            // 
            this.ProcessLocationLabel_lbl.AutoSize = true;
            this.ProcessLocationLabel_lbl.Location = new System.Drawing.Point(369, 117);
            this.ProcessLocationLabel_lbl.Name = "ProcessLocationLabel_lbl";
            this.ProcessLocationLabel_lbl.Size = new System.Drawing.Size(92, 13);
            this.ProcessLocationLabel_lbl.TabIndex = 17;
            this.ProcessLocationLabel_lbl.Text = "Process Location:";
            // 
            // ProcessLocationValue_lbl
            // 
            this.ProcessLocationValue_lbl.Location = new System.Drawing.Point(470, 117);
            this.ProcessLocationValue_lbl.Name = "ProcessLocationValue_lbl";
            this.ProcessLocationValue_lbl.Size = new System.Drawing.Size(131, 73);
            this.ProcessLocationValue_lbl.TabIndex = 18;
            // 
            // SelectedItem_lbl
            // 
            this.SelectedItem_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedItem_lbl.AutoSize = true;
            this.SelectedItem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItem_lbl.Location = new System.Drawing.Point(369, 37);
            this.SelectedItem_lbl.Name = "SelectedItem_lbl";
            this.SelectedItem_lbl.Size = new System.Drawing.Size(108, 20);
            this.SelectedItem_lbl.TabIndex = 19;
            this.SelectedItem_lbl.Text = "Selected Item";
            // 
            // blockApp_ToolStripMenuItem
            // 
            this.blockApp_ToolStripMenuItem.Name = "blockApp_ToolStripMenuItem";
            this.blockApp_ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.blockApp_ToolStripMenuItem.Text = "Block App.";
            this.blockApp_ToolStripMenuItem.Click += new System.EventHandler(this.blockItemToolStripMenuItem_Click);
            // 
            // ActiveProcess_contextMenu
            // 
            this.ActiveProcess_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockApp_ToolStripMenuItem,
            this.unblockApp_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.listAlProcesess_ToolStripMenuItem,
            this.listOpenWindows_ToolStripMenuItem});
            this.ActiveProcess_contextMenu.Name = "ActiveProcess_contexMenu";
            this.ActiveProcess_contextMenu.Size = new System.Drawing.Size(175, 98);
            // 
            // unblockApp_ToolStripMenuItem
            // 
            this.unblockApp_ToolStripMenuItem.Name = "unblockApp_ToolStripMenuItem";
            this.unblockApp_ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.unblockApp_ToolStripMenuItem.Text = "Unblock App.";
            this.unblockApp_ToolStripMenuItem.Click += new System.EventHandler(this.unblockApp_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // listAlProcesess_ToolStripMenuItem
            // 
            this.listAlProcesess_ToolStripMenuItem.Name = "listAlProcesess_ToolStripMenuItem";
            this.listAlProcesess_ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.listAlProcesess_ToolStripMenuItem.Text = "List al Procesess";
            this.listAlProcesess_ToolStripMenuItem.Click += new System.EventHandler(this.listAlProcesess_ToolStripMenuItem_Click);
            // 
            // listOpenWindows_ToolStripMenuItem
            // 
            this.listOpenWindows_ToolStripMenuItem.Name = "listOpenWindows_ToolStripMenuItem";
            this.listOpenWindows_ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.listOpenWindows_ToolStripMenuItem.Text = "List open Windows";
            this.listOpenWindows_ToolStripMenuItem.Click += new System.EventHandler(this.listOpenWindows_ToolStripMenuItem_Click);
            // 
            // BlockedList_contextMenu
            // 
            this.BlockedList_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unBlockAllApps_toolStripMenuItem1,
            this.unblockApp_toolStripMenuItem2,
            this.toolStripSeparator2,
            this.showPathToolStripMenuItem});
            this.BlockedList_contextMenu.Name = "ActiveProcess_contexMenu";
            this.BlockedList_contextMenu.Size = new System.Drawing.Size(164, 76);
            // 
            // unBlockAllApps_toolStripMenuItem1
            // 
            this.unBlockAllApps_toolStripMenuItem1.Name = "unBlockAllApps_toolStripMenuItem1";
            this.unBlockAllApps_toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.unBlockAllApps_toolStripMenuItem1.Text = "Unblock all Apps";
            this.unBlockAllApps_toolStripMenuItem1.Click += new System.EventHandler(this.unBlockAllApps_toolStripMenuItem1_Click);
            // 
            // unblockApp_toolStripMenuItem2
            // 
            this.unblockApp_toolStripMenuItem2.Name = "unblockApp_toolStripMenuItem2";
            this.unblockApp_toolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.unblockApp_toolStripMenuItem2.Text = "Unblock App.";
            this.unblockApp_toolStripMenuItem2.Click += new System.EventHandler(this.unblockApp_toolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // showPathToolStripMenuItem
            // 
            this.showPathToolStripMenuItem.Name = "showPathToolStripMenuItem";
            this.showPathToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showPathToolStripMenuItem.Text = "Show Path";
            this.showPathToolStripMenuItem.Click += new System.EventHandler(this.showPathToolStripMenuItem_Click);
            // 
            // showPath_btn
            // 
            this.showPath_btn.Location = new System.Drawing.Point(493, 344);
            this.showPath_btn.Name = "showPath_btn";
            this.showPath_btn.Size = new System.Drawing.Size(108, 23);
            this.showPath_btn.TabIndex = 20;
            this.showPath_btn.Text = "Show Path";
            this.showPath_btn.UseVisualStyleBackColor = true;
            this.showPath_btn.Click += new System.EventHandler(this.showPath_btn_Click);
            // 
            // RemoveInternet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(972, 465);
            this.Controls.Add(this.showPath_btn);
            this.Controls.Add(this.SelectedItem_lbl);
            this.Controls.Add(this.ProcessLocationValue_lbl);
            this.Controls.Add(this.ProcessLocationLabel_lbl);
            this.Controls.Add(this.Unblock2_btn);
            this.Controls.Add(this.blockedAppsListBox_lbl);
            this.Controls.Add(this.ProcessesListbox_lbl);
            this.Controls.Add(this.blockedApps_listbox);
            this.Controls.Add(this.unBlockAllApps_btn);
            this.Controls.Add(this.listOpenWindow_btn);
            this.Controls.Add(this.Unblock_btn);
            this.Controls.Add(this.Block_btn);
            this.Controls.Add(this.ProcessIDLabel_lbl);
            this.Controls.Add(this.ProcessNameLabel_lbl);
            this.Controls.Add(this.PorcessIDvalue_lbl);
            this.Controls.Add(this.ProcessNameValue_lbl);
            this.Controls.Add(this.listAllProcesses_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveInternet2";
            this.Text = "Remove Internet 3";
            this.Load += new System.EventHandler(this.RemoveInternet2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ActiveProcess_contextMenu.ResumeLayout(false);
            this.BlockedList_contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button listAllProcesses_btn;
        private System.Windows.Forms.Label ProcessNameValue_lbl;
        private System.Windows.Forms.Label PorcessIDvalue_lbl;
        private System.Windows.Forms.Label ProcessNameLabel_lbl;
        private System.Windows.Forms.Label ProcessIDLabel_lbl;
        private System.Windows.Forms.Button Block_btn;
        private System.Windows.Forms.Button Unblock_btn;
        private System.Windows.Forms.Button listOpenWindow_btn;
        private System.Windows.Forms.Button unBlockAllApps_btn;
        private System.Windows.Forms.ListBox blockedApps_listbox;
        private System.Windows.Forms.Label ProcessesListbox_lbl;
        private System.Windows.Forms.Label blockedAppsListBox_lbl;
        private System.Windows.Forms.Button Unblock2_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileToBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thereIsNoHelpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ProcessLocationLabel_lbl;
        private System.Windows.Forms.Label ProcessLocationValue_lbl;
        private System.Windows.Forms.Label SelectedItem_lbl;
        private System.Windows.Forms.ToolStripMenuItem blockApp_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ActiveProcess_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem unblockApp_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip BlockedList_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem unBlockAllApps_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unblockApp_toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listAlProcesess_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOpenWindows_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showPathToolStripMenuItem;
        private System.Windows.Forms.Button showPath_btn;
    }
}
