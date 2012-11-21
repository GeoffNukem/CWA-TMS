namespace CWATMS
{
    partial class FormMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLesson = new System.Windows.Forms.TabPage();
            this.tabLecturer = new System.Windows.Forms.TabPage();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.tabClass = new System.Windows.Forms.TabPage();
            this.pnlLessons = new System.Windows.Forms.Panel();
            this.menuMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pnlLessons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.AllowMerge = false;
            this.menuMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1039, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byLecturerToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.classToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // byLecturerToolStripMenuItem
            // 
            this.byLecturerToolStripMenuItem.Name = "byLecturerToolStripMenuItem";
            this.byLecturerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.byLecturerToolStripMenuItem.Text = "Lecturer";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.moduleToolStripMenuItem.Text = "Subject";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.classToolStripMenuItem.Text = "Class";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabLecturer);
            this.tabControl.Controls.Add(this.tabSubject);
            this.tabControl.Controls.Add(this.tabRoom);
            this.tabControl.Controls.Add(this.tabClass);
            this.tabControl.Controls.Add(this.tabLesson);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(64, 32);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1039, 104);
            this.tabControl.TabIndex = 6;
            this.tabControl.TabStop = false;
            // 
            // tabLesson
            // 
            this.tabLesson.BackColor = System.Drawing.SystemColors.Control;
            this.tabLesson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabLesson.Location = new System.Drawing.Point(4, 36);
            this.tabLesson.Margin = new System.Windows.Forms.Padding(2);
            this.tabLesson.Name = "tabLesson";
            this.tabLesson.Size = new System.Drawing.Size(1031, 64);
            this.tabLesson.TabIndex = 4;
            this.tabLesson.Text = "Lesson";
            // 
            // tabLecturer
            // 
            this.tabLecturer.BackColor = System.Drawing.SystemColors.Control;
            this.tabLecturer.Location = new System.Drawing.Point(4, 36);
            this.tabLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.tabLecturer.Name = "tabLecturer";
            this.tabLecturer.Padding = new System.Windows.Forms.Padding(2);
            this.tabLecturer.Size = new System.Drawing.Size(1031, 64);
            this.tabLecturer.TabIndex = 0;
            this.tabLecturer.Text = "Lecturer";
            // 
            // tabSubject
            // 
            this.tabSubject.Location = new System.Drawing.Point(4, 36);
            this.tabSubject.Margin = new System.Windows.Forms.Padding(2);
            this.tabSubject.Name = "tabSubject";
            this.tabSubject.Padding = new System.Windows.Forms.Padding(2);
            this.tabSubject.Size = new System.Drawing.Size(1031, 64);
            this.tabSubject.TabIndex = 1;
            this.tabSubject.Text = "Subject";
            this.tabSubject.UseVisualStyleBackColor = true;
            // 
            // tabRoom
            // 
            this.tabRoom.Location = new System.Drawing.Point(4, 36);
            this.tabRoom.Margin = new System.Windows.Forms.Padding(2);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Size = new System.Drawing.Size(1031, 64);
            this.tabRoom.TabIndex = 2;
            this.tabRoom.Text = "Room";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // tabClass
            // 
            this.tabClass.Location = new System.Drawing.Point(4, 36);
            this.tabClass.Margin = new System.Windows.Forms.Padding(2);
            this.tabClass.Name = "tabClass";
            this.tabClass.Size = new System.Drawing.Size(1031, 64);
            this.tabClass.TabIndex = 3;
            this.tabClass.Text = "Class";
            this.tabClass.UseVisualStyleBackColor = true;
            // 
            // pnlLessons
            // 
            this.pnlLessons.Controls.Add(this.tabControl);
            this.pnlLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLessons.Location = new System.Drawing.Point(0, 24);
            this.pnlLessons.Name = "pnlLessons";
            this.pnlLessons.Size = new System.Drawing.Size(1039, 104);
            this.pnlLessons.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 547);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLessons);
            this.Controls.Add(this.menuMain);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "CWA Timetable Management System - Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pnlLessons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLesson;
        private System.Windows.Forms.TabPage tabLecturer;
        private System.Windows.Forms.TabPage tabSubject;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabClass;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLessons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem byLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        
    }
}

