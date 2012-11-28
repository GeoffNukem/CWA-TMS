namespace CWATMS
{
    partial class Export
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
            this.Export_Tab_List = new System.Windows.Forms.TabControl();
            this.Export_List_Home = new System.Windows.Forms.TabPage();
            this.Open_All_List_PDF = new System.Windows.Forms.Button();
            this.Export_All_To_PDF = new System.Windows.Forms.Button();
            this.Export_List_Lecturers = new System.Windows.Forms.TabPage();
            this.dataLecTable = new System.Windows.Forms.DataGridView();
            this.LecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursPerModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print_PDF_Dialog_List_Lec = new System.Windows.Forms.Button();
            this.Print_PDF_Lst_Lecturers = new System.Windows.Forms.Button();
            this.Open_PDF_List_Lecturers = new System.Windows.Forms.Button();
            this.Lecturers_Export = new System.Windows.Forms.Button();
            this.Export_List_Modules = new System.Windows.Forms.TabPage();
            this.dataSubTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Mod_Print_Dia = new System.Windows.Forms.Button();
            this.List_Mod_Print_Pre = new System.Windows.Forms.Button();
            this.List_Mod_Open = new System.Windows.Forms.Button();
            this.List_Modules_Export = new System.Windows.Forms.Button();
            this.Export_List_Rooms = new System.Windows.Forms.TabPage();
            this.List_Rooms_Print_Dia = new System.Windows.Forms.Button();
            this.List_Rooms_Print_pre = new System.Windows.Forms.Button();
            this.List_Rooms_Open = new System.Windows.Forms.Button();
            this.List_Room_Export = new System.Windows.Forms.Button();
            this.Export_List_Groups = new System.Windows.Forms.TabPage();
            this.List_Groups_Print_Dia = new System.Windows.Forms.Button();
            this.List_Groups_Print_Pre = new System.Windows.Forms.Button();
            this.List_Groups_Open = new System.Windows.Forms.Button();
            this.List_Groups_Export = new System.Windows.Forms.Button();
            this.Export_Tab = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Export_Tab_Timetable = new System.Windows.Forms.TabControl();
            this.Export_Timetable_Home = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Export_Timetable_Lecturers = new System.Windows.Forms.TabPage();
            this.Timetable_Lecturers_Export = new System.Windows.Forms.Button();
            this.Export_Timetable_Rooms = new System.Windows.Forms.TabPage();
            this.Exprt_Timetable_Groups = new System.Windows.Forms.TabPage();
            this.Export_Settings = new System.Windows.Forms.TabPage();
            this.Export_Tab_Settings = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.Export_Settings_Advanced = new System.Windows.Forms.TabPage();
            this.dataRoomTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataClassTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Export_Tab_List.SuspendLayout();
            this.Export_List_Home.SuspendLayout();
            this.Export_List_Lecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLecTable)).BeginInit();
            this.Export_List_Modules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubTable)).BeginInit();
            this.Export_List_Rooms.SuspendLayout();
            this.Export_List_Groups.SuspendLayout();
            this.Export_Tab.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.Export_Tab_Timetable.SuspendLayout();
            this.Export_Timetable_Home.SuspendLayout();
            this.Export_Timetable_Lecturers.SuspendLayout();
            this.Export_Settings.SuspendLayout();
            this.Export_Tab_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Export_Tab_List
            // 
            this.Export_Tab_List.Controls.Add(this.Export_List_Home);
            this.Export_Tab_List.Controls.Add(this.Export_List_Lecturers);
            this.Export_Tab_List.Controls.Add(this.Export_List_Modules);
            this.Export_Tab_List.Controls.Add(this.Export_List_Rooms);
            this.Export_Tab_List.Controls.Add(this.Export_List_Groups);
            this.Export_Tab_List.Location = new System.Drawing.Point(6, 6);
            this.Export_Tab_List.Name = "Export_Tab_List";
            this.Export_Tab_List.SelectedIndex = 0;
            this.Export_Tab_List.Size = new System.Drawing.Size(674, 365);
            this.Export_Tab_List.TabIndex = 0;
            this.Export_Tab_List.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Export_List_Home
            // 
            this.Export_List_Home.Controls.Add(this.Open_All_List_PDF);
            this.Export_List_Home.Controls.Add(this.Export_All_To_PDF);
            this.Export_List_Home.Location = new System.Drawing.Point(4, 22);
            this.Export_List_Home.Name = "Export_List_Home";
            this.Export_List_Home.Padding = new System.Windows.Forms.Padding(3);
            this.Export_List_Home.Size = new System.Drawing.Size(666, 339);
            this.Export_List_Home.TabIndex = 0;
            this.Export_List_Home.Text = "Home";
            this.Export_List_Home.UseVisualStyleBackColor = true;
            // 
            // Open_All_List_PDF
            // 
            this.Open_All_List_PDF.Location = new System.Drawing.Point(98, 81);
            this.Open_All_List_PDF.Name = "Open_All_List_PDF";
            this.Open_All_List_PDF.Size = new System.Drawing.Size(157, 77);
            this.Open_All_List_PDF.TabIndex = 1;
            this.Open_All_List_PDF.Text = "Open all PDF in seperate window";
            this.Open_All_List_PDF.UseVisualStyleBackColor = true;
            this.Open_All_List_PDF.Click += new System.EventHandler(this.Open_All_List_PDF_Click);
            // 
            // Export_All_To_PDF
            // 
            this.Export_All_To_PDF.Location = new System.Drawing.Point(98, 181);
            this.Export_All_To_PDF.Name = "Export_All_To_PDF";
            this.Export_All_To_PDF.Size = new System.Drawing.Size(157, 77);
            this.Export_All_To_PDF.TabIndex = 0;
            this.Export_All_To_PDF.Text = "Export All List To PDF";
            this.Export_All_To_PDF.UseVisualStyleBackColor = true;
            this.Export_All_To_PDF.Click += new System.EventHandler(this.Export_All_To_PDF_Click);
            // 
            // Export_List_Lecturers
            // 
            this.Export_List_Lecturers.Controls.Add(this.dataLecTable);
            this.Export_List_Lecturers.Controls.Add(this.Print_PDF_Dialog_List_Lec);
            this.Export_List_Lecturers.Controls.Add(this.Print_PDF_Lst_Lecturers);
            this.Export_List_Lecturers.Controls.Add(this.Open_PDF_List_Lecturers);
            this.Export_List_Lecturers.Controls.Add(this.Lecturers_Export);
            this.Export_List_Lecturers.Location = new System.Drawing.Point(4, 22);
            this.Export_List_Lecturers.Name = "Export_List_Lecturers";
            this.Export_List_Lecturers.Padding = new System.Windows.Forms.Padding(3);
            this.Export_List_Lecturers.Size = new System.Drawing.Size(666, 339);
            this.Export_List_Lecturers.TabIndex = 1;
            this.Export_List_Lecturers.Text = "Lecturers";
            this.Export_List_Lecturers.UseVisualStyleBackColor = true;
            // 
            // dataLecTable
            // 
            this.dataLecTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLecTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLecTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LecturerName,
            this.Label,
            this.HoursPerModule,
            this.Colour});
            this.dataLecTable.Location = new System.Drawing.Point(7, 44);
            this.dataLecTable.MultiSelect = false;
            this.dataLecTable.Name = "dataLecTable";
            this.dataLecTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataLecTable.Size = new System.Drawing.Size(444, 260);
            this.dataLecTable.TabIndex = 8;
            // 
            // LecturerName
            // 
            this.LecturerName.HeaderText = "Lecturer Name";
            this.LecturerName.Name = "LecturerName";
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.Name = "Label";
            // 
            // HoursPerModule
            // 
            this.HoursPerModule.HeaderText = "Hours Per Module";
            this.HoursPerModule.Name = "HoursPerModule";
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            this.Colour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Print_PDF_Dialog_List_Lec
            // 
            this.Print_PDF_Dialog_List_Lec.Location = new System.Drawing.Point(457, 193);
            this.Print_PDF_Dialog_List_Lec.Name = "Print_PDF_Dialog_List_Lec";
            this.Print_PDF_Dialog_List_Lec.Size = new System.Drawing.Size(108, 23);
            this.Print_PDF_Dialog_List_Lec.TabIndex = 7;
            this.Print_PDF_Dialog_List_Lec.Text = "Print Dialog";
            this.Print_PDF_Dialog_List_Lec.UseVisualStyleBackColor = true;
            this.Print_PDF_Dialog_List_Lec.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Print_PDF_Lst_Lecturers
            // 
            this.Print_PDF_Lst_Lecturers.Location = new System.Drawing.Point(457, 222);
            this.Print_PDF_Lst_Lecturers.Name = "Print_PDF_Lst_Lecturers";
            this.Print_PDF_Lst_Lecturers.Size = new System.Drawing.Size(108, 23);
            this.Print_PDF_Lst_Lecturers.TabIndex = 6;
            this.Print_PDF_Lst_Lecturers.Text = "Print Preview";
            this.Print_PDF_Lst_Lecturers.UseVisualStyleBackColor = true;
            this.Print_PDF_Lst_Lecturers.Click += new System.EventHandler(this.Print_PDF_Lst_Lecturers_Click);
            // 
            // Open_PDF_List_Lecturers
            // 
            this.Open_PDF_List_Lecturers.Location = new System.Drawing.Point(457, 164);
            this.Open_PDF_List_Lecturers.Name = "Open_PDF_List_Lecturers";
            this.Open_PDF_List_Lecturers.Size = new System.Drawing.Size(108, 23);
            this.Open_PDF_List_Lecturers.TabIndex = 5;
            this.Open_PDF_List_Lecturers.Text = "Open PDF";
            this.Open_PDF_List_Lecturers.UseVisualStyleBackColor = true;
            this.Open_PDF_List_Lecturers.Click += new System.EventHandler(this.Open_PDF_List_Lecturers_Click);
            // 
            // Lecturers_Export
            // 
            this.Lecturers_Export.Location = new System.Drawing.Point(457, 135);
            this.Lecturers_Export.Name = "Lecturers_Export";
            this.Lecturers_Export.Size = new System.Drawing.Size(105, 23);
            this.Lecturers_Export.TabIndex = 1;
            this.Lecturers_Export.Text = "Export as PDF";
            this.Lecturers_Export.UseVisualStyleBackColor = true;
            this.Lecturers_Export.Click += new System.EventHandler(this.button1_Click);
            // 
            // Export_List_Modules
            // 
            this.Export_List_Modules.Controls.Add(this.dataSubTable);
            this.Export_List_Modules.Controls.Add(this.List_Mod_Print_Dia);
            this.Export_List_Modules.Controls.Add(this.List_Mod_Print_Pre);
            this.Export_List_Modules.Controls.Add(this.List_Mod_Open);
            this.Export_List_Modules.Controls.Add(this.List_Modules_Export);
            this.Export_List_Modules.Location = new System.Drawing.Point(4, 22);
            this.Export_List_Modules.Name = "Export_List_Modules";
            this.Export_List_Modules.Padding = new System.Windows.Forms.Padding(3);
            this.Export_List_Modules.Size = new System.Drawing.Size(666, 339);
            this.Export_List_Modules.TabIndex = 2;
            this.Export_List_Modules.Text = "Modules";
            this.Export_List_Modules.UseVisualStyleBackColor = true;
            // 
            // dataSubTable
            // 
            this.dataSubTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSubTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataSubTable.Location = new System.Drawing.Point(6, 13);
            this.dataSubTable.Name = "dataSubTable";
            this.dataSubTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataSubTable.Size = new System.Drawing.Size(433, 288);
            this.dataSubTable.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Label";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // List_Mod_Print_Dia
            // 
            this.List_Mod_Print_Dia.Location = new System.Drawing.Point(445, 249);
            this.List_Mod_Print_Dia.Name = "List_Mod_Print_Dia";
            this.List_Mod_Print_Dia.Size = new System.Drawing.Size(108, 23);
            this.List_Mod_Print_Dia.TabIndex = 10;
            this.List_Mod_Print_Dia.Text = "Print Dialog";
            this.List_Mod_Print_Dia.UseVisualStyleBackColor = true;
            this.List_Mod_Print_Dia.Click += new System.EventHandler(this.List_Mod_Print_Dia_Click);
            // 
            // List_Mod_Print_Pre
            // 
            this.List_Mod_Print_Pre.Location = new System.Drawing.Point(445, 278);
            this.List_Mod_Print_Pre.Name = "List_Mod_Print_Pre";
            this.List_Mod_Print_Pre.Size = new System.Drawing.Size(108, 23);
            this.List_Mod_Print_Pre.TabIndex = 9;
            this.List_Mod_Print_Pre.Text = "Print Preview";
            this.List_Mod_Print_Pre.UseVisualStyleBackColor = true;
            this.List_Mod_Print_Pre.Click += new System.EventHandler(this.List_Mod_Print_Pre_Click);
            // 
            // List_Mod_Open
            // 
            this.List_Mod_Open.Location = new System.Drawing.Point(445, 220);
            this.List_Mod_Open.Name = "List_Mod_Open";
            this.List_Mod_Open.Size = new System.Drawing.Size(108, 23);
            this.List_Mod_Open.TabIndex = 8;
            this.List_Mod_Open.Text = "Open PDF";
            this.List_Mod_Open.UseVisualStyleBackColor = true;
            this.List_Mod_Open.Click += new System.EventHandler(this.List_Mod_Open_Click);
            // 
            // List_Modules_Export
            // 
            this.List_Modules_Export.Location = new System.Drawing.Point(445, 191);
            this.List_Modules_Export.Name = "List_Modules_Export";
            this.List_Modules_Export.Size = new System.Drawing.Size(105, 23);
            this.List_Modules_Export.TabIndex = 3;
            this.List_Modules_Export.Text = "Export as PDF";
            this.List_Modules_Export.UseVisualStyleBackColor = true;
            this.List_Modules_Export.Click += new System.EventHandler(this.button2_Click);
            // 
            // Export_List_Rooms
            // 
            this.Export_List_Rooms.Controls.Add(this.dataRoomTable);
            this.Export_List_Rooms.Controls.Add(this.List_Rooms_Print_Dia);
            this.Export_List_Rooms.Controls.Add(this.List_Rooms_Print_pre);
            this.Export_List_Rooms.Controls.Add(this.List_Rooms_Open);
            this.Export_List_Rooms.Controls.Add(this.List_Room_Export);
            this.Export_List_Rooms.Location = new System.Drawing.Point(4, 22);
            this.Export_List_Rooms.Name = "Export_List_Rooms";
            this.Export_List_Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Export_List_Rooms.Size = new System.Drawing.Size(666, 339);
            this.Export_List_Rooms.TabIndex = 3;
            this.Export_List_Rooms.Text = "Rooms";
            this.Export_List_Rooms.UseVisualStyleBackColor = true;
            // 
            // List_Rooms_Print_Dia
            // 
            this.List_Rooms_Print_Dia.Location = new System.Drawing.Point(348, 295);
            this.List_Rooms_Print_Dia.Name = "List_Rooms_Print_Dia";
            this.List_Rooms_Print_Dia.Size = new System.Drawing.Size(108, 23);
            this.List_Rooms_Print_Dia.TabIndex = 10;
            this.List_Rooms_Print_Dia.Text = "Print Dialog";
            this.List_Rooms_Print_Dia.UseVisualStyleBackColor = true;
            this.List_Rooms_Print_Dia.Click += new System.EventHandler(this.List_Rooms_Print_Dia_Click);
            // 
            // List_Rooms_Print_pre
            // 
            this.List_Rooms_Print_pre.Location = new System.Drawing.Point(471, 295);
            this.List_Rooms_Print_pre.Name = "List_Rooms_Print_pre";
            this.List_Rooms_Print_pre.Size = new System.Drawing.Size(108, 23);
            this.List_Rooms_Print_pre.TabIndex = 9;
            this.List_Rooms_Print_pre.Text = "Print Preview";
            this.List_Rooms_Print_pre.UseVisualStyleBackColor = true;
            this.List_Rooms_Print_pre.Click += new System.EventHandler(this.List_Rooms_Print_pre_Click);
            // 
            // List_Rooms_Open
            // 
            this.List_Rooms_Open.Location = new System.Drawing.Point(205, 295);
            this.List_Rooms_Open.Name = "List_Rooms_Open";
            this.List_Rooms_Open.Size = new System.Drawing.Size(108, 23);
            this.List_Rooms_Open.TabIndex = 8;
            this.List_Rooms_Open.Text = "Open PDF";
            this.List_Rooms_Open.UseVisualStyleBackColor = true;
            this.List_Rooms_Open.Click += new System.EventHandler(this.List_Rooms_Open_Click);
            // 
            // List_Room_Export
            // 
            this.List_Room_Export.Location = new System.Drawing.Point(43, 295);
            this.List_Room_Export.Name = "List_Room_Export";
            this.List_Room_Export.Size = new System.Drawing.Size(105, 23);
            this.List_Room_Export.TabIndex = 3;
            this.List_Room_Export.Text = "Export as PDF";
            this.List_Room_Export.UseVisualStyleBackColor = true;
            this.List_Room_Export.Click += new System.EventHandler(this.List_Room_Export_Click);
            // 
            // Export_List_Groups
            // 
            this.Export_List_Groups.Controls.Add(this.dataClassTable);
            this.Export_List_Groups.Controls.Add(this.List_Groups_Print_Dia);
            this.Export_List_Groups.Controls.Add(this.List_Groups_Print_Pre);
            this.Export_List_Groups.Controls.Add(this.List_Groups_Open);
            this.Export_List_Groups.Controls.Add(this.List_Groups_Export);
            this.Export_List_Groups.Location = new System.Drawing.Point(4, 22);
            this.Export_List_Groups.Name = "Export_List_Groups";
            this.Export_List_Groups.Size = new System.Drawing.Size(666, 339);
            this.Export_List_Groups.TabIndex = 4;
            this.Export_List_Groups.Text = "Groups";
            this.Export_List_Groups.UseVisualStyleBackColor = true;
            // 
            // List_Groups_Print_Dia
            // 
            this.List_Groups_Print_Dia.Location = new System.Drawing.Point(361, 289);
            this.List_Groups_Print_Dia.Name = "List_Groups_Print_Dia";
            this.List_Groups_Print_Dia.Size = new System.Drawing.Size(108, 23);
            this.List_Groups_Print_Dia.TabIndex = 10;
            this.List_Groups_Print_Dia.Text = "Print Dialog";
            this.List_Groups_Print_Dia.UseVisualStyleBackColor = true;
            this.List_Groups_Print_Dia.Click += new System.EventHandler(this.List_Groups_Print_Dia_Click);
            // 
            // List_Groups_Print_Pre
            // 
            this.List_Groups_Print_Pre.Location = new System.Drawing.Point(505, 289);
            this.List_Groups_Print_Pre.Name = "List_Groups_Print_Pre";
            this.List_Groups_Print_Pre.Size = new System.Drawing.Size(108, 23);
            this.List_Groups_Print_Pre.TabIndex = 9;
            this.List_Groups_Print_Pre.Text = "Print Preview";
            this.List_Groups_Print_Pre.UseVisualStyleBackColor = true;
            this.List_Groups_Print_Pre.Click += new System.EventHandler(this.List_Groups_Print_Pre_Click);
            // 
            // List_Groups_Open
            // 
            this.List_Groups_Open.Location = new System.Drawing.Point(207, 289);
            this.List_Groups_Open.Name = "List_Groups_Open";
            this.List_Groups_Open.Size = new System.Drawing.Size(108, 23);
            this.List_Groups_Open.TabIndex = 8;
            this.List_Groups_Open.Text = "Open PDF";
            this.List_Groups_Open.UseVisualStyleBackColor = true;
            this.List_Groups_Open.Click += new System.EventHandler(this.List_Groups_Open_Click);
            // 
            // List_Groups_Export
            // 
            this.List_Groups_Export.Location = new System.Drawing.Point(54, 289);
            this.List_Groups_Export.Name = "List_Groups_Export";
            this.List_Groups_Export.Size = new System.Drawing.Size(105, 23);
            this.List_Groups_Export.TabIndex = 5;
            this.List_Groups_Export.Text = "Export as PDF";
            this.List_Groups_Export.UseVisualStyleBackColor = true;
            this.List_Groups_Export.Click += new System.EventHandler(this.List_Groups_Export_Click);
            // 
            // Export_Tab
            // 
            this.Export_Tab.Controls.Add(this.tabPage6);
            this.Export_Tab.Controls.Add(this.tabPage7);
            this.Export_Tab.Controls.Add(this.Export_Settings);
            this.Export_Tab.Location = new System.Drawing.Point(29, 13);
            this.Export_Tab.Name = "Export_Tab";
            this.Export_Tab.SelectedIndex = 0;
            this.Export_Tab.Size = new System.Drawing.Size(694, 403);
            this.Export_Tab.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Export_Tab_List);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(686, 377);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "List";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Export_Tab_Timetable);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(686, 377);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Timetables";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Export_Tab_Timetable
            // 
            this.Export_Tab_Timetable.Controls.Add(this.Export_Timetable_Home);
            this.Export_Tab_Timetable.Controls.Add(this.Export_Timetable_Lecturers);
            this.Export_Tab_Timetable.Controls.Add(this.Export_Timetable_Rooms);
            this.Export_Tab_Timetable.Controls.Add(this.Exprt_Timetable_Groups);
            this.Export_Tab_Timetable.Location = new System.Drawing.Point(6, 6);
            this.Export_Tab_Timetable.Name = "Export_Tab_Timetable";
            this.Export_Tab_Timetable.SelectedIndex = 0;
            this.Export_Tab_Timetable.Size = new System.Drawing.Size(674, 365);
            this.Export_Tab_Timetable.TabIndex = 1;
            // 
            // Export_Timetable_Home
            // 
            this.Export_Timetable_Home.Controls.Add(this.button1);
            this.Export_Timetable_Home.Location = new System.Drawing.Point(4, 22);
            this.Export_Timetable_Home.Name = "Export_Timetable_Home";
            this.Export_Timetable_Home.Padding = new System.Windows.Forms.Padding(3);
            this.Export_Timetable_Home.Size = new System.Drawing.Size(666, 339);
            this.Export_Timetable_Home.TabIndex = 0;
            this.Export_Timetable_Home.Text = "Home";
            this.Export_Timetable_Home.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export all timetable to PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Export_Timetable_Lecturers
            // 
            this.Export_Timetable_Lecturers.Controls.Add(this.Timetable_Lecturers_Export);
            this.Export_Timetable_Lecturers.Location = new System.Drawing.Point(4, 22);
            this.Export_Timetable_Lecturers.Name = "Export_Timetable_Lecturers";
            this.Export_Timetable_Lecturers.Padding = new System.Windows.Forms.Padding(3);
            this.Export_Timetable_Lecturers.Size = new System.Drawing.Size(666, 339);
            this.Export_Timetable_Lecturers.TabIndex = 1;
            this.Export_Timetable_Lecturers.Text = "Lecturers";
            this.Export_Timetable_Lecturers.UseVisualStyleBackColor = true;
            // 
            // Timetable_Lecturers_Export
            // 
            this.Timetable_Lecturers_Export.Location = new System.Drawing.Point(400, 290);
            this.Timetable_Lecturers_Export.Name = "Timetable_Lecturers_Export";
            this.Timetable_Lecturers_Export.Size = new System.Drawing.Size(194, 23);
            this.Timetable_Lecturers_Export.TabIndex = 1;
            this.Timetable_Lecturers_Export.Text = "Export All as PDF";
            this.Timetable_Lecturers_Export.UseVisualStyleBackColor = true;
            this.Timetable_Lecturers_Export.Click += new System.EventHandler(this.Timetable_Lecturers_Export_Click);
            // 
            // Export_Timetable_Rooms
            // 
            this.Export_Timetable_Rooms.Location = new System.Drawing.Point(4, 22);
            this.Export_Timetable_Rooms.Name = "Export_Timetable_Rooms";
            this.Export_Timetable_Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Export_Timetable_Rooms.Size = new System.Drawing.Size(666, 339);
            this.Export_Timetable_Rooms.TabIndex = 3;
            this.Export_Timetable_Rooms.Text = "Rooms";
            this.Export_Timetable_Rooms.UseVisualStyleBackColor = true;
            // 
            // Exprt_Timetable_Groups
            // 
            this.Exprt_Timetable_Groups.Location = new System.Drawing.Point(4, 22);
            this.Exprt_Timetable_Groups.Name = "Exprt_Timetable_Groups";
            this.Exprt_Timetable_Groups.Size = new System.Drawing.Size(666, 339);
            this.Exprt_Timetable_Groups.TabIndex = 4;
            this.Exprt_Timetable_Groups.Text = "Groups";
            this.Exprt_Timetable_Groups.UseVisualStyleBackColor = true;
            // 
            // Export_Settings
            // 
            this.Export_Settings.Controls.Add(this.Export_Tab_Settings);
            this.Export_Settings.Location = new System.Drawing.Point(4, 22);
            this.Export_Settings.Name = "Export_Settings";
            this.Export_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Export_Settings.Size = new System.Drawing.Size(686, 377);
            this.Export_Settings.TabIndex = 2;
            this.Export_Settings.Text = "Export Settings";
            this.Export_Settings.UseVisualStyleBackColor = true;
            // 
            // Export_Tab_Settings
            // 
            this.Export_Tab_Settings.Controls.Add(this.tabPage10);
            this.Export_Tab_Settings.Controls.Add(this.Export_Settings_Advanced);
            this.Export_Tab_Settings.Location = new System.Drawing.Point(6, 6);
            this.Export_Tab_Settings.Name = "Export_Tab_Settings";
            this.Export_Tab_Settings.SelectedIndex = 0;
            this.Export_Tab_Settings.Size = new System.Drawing.Size(674, 365);
            this.Export_Tab_Settings.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(666, 339);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Basic";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // Export_Settings_Advanced
            // 
            this.Export_Settings_Advanced.Location = new System.Drawing.Point(4, 22);
            this.Export_Settings_Advanced.Name = "Export_Settings_Advanced";
            this.Export_Settings_Advanced.Padding = new System.Windows.Forms.Padding(3);
            this.Export_Settings_Advanced.Size = new System.Drawing.Size(666, 339);
            this.Export_Settings_Advanced.TabIndex = 1;
            this.Export_Settings_Advanced.Text = "Advanced";
            this.Export_Settings_Advanced.UseVisualStyleBackColor = true;
            // 
            // dataRoomTable
            // 
            this.dataRoomTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRoomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRoomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.dataGridViewTextBoxColumn8});
            this.dataRoomTable.Location = new System.Drawing.Point(6, 6);
            this.dataRoomTable.Name = "dataRoomTable";
            this.dataRoomTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataRoomTable.Size = new System.Drawing.Size(654, 152);
            this.dataRoomTable.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Room No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Smart Board";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TV";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Projector";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Network Lab";
            this.Column7.Name = "Column7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataClassTable
            // 
            this.dataClassTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClassTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClassTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataClassTable.Location = new System.Drawing.Point(19, 8);
            this.dataClassTable.Name = "dataClassTable";
            this.dataClassTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataClassTable.Size = new System.Drawing.Size(619, 260);
            this.dataClassTable.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Class";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Hours Per Module";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 428);
            this.Controls.Add(this.Export_Tab);
            this.Name = "Export";
            this.Text = "Export";
            this.Export_Tab_List.ResumeLayout(false);
            this.Export_List_Home.ResumeLayout(false);
            this.Export_List_Lecturers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLecTable)).EndInit();
            this.Export_List_Modules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSubTable)).EndInit();
            this.Export_List_Rooms.ResumeLayout(false);
            this.Export_List_Groups.ResumeLayout(false);
            this.Export_Tab.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.Export_Tab_Timetable.ResumeLayout(false);
            this.Export_Timetable_Home.ResumeLayout(false);
            this.Export_Timetable_Lecturers.ResumeLayout(false);
            this.Export_Settings.ResumeLayout(false);
            this.Export_Tab_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Export_Tab_List;
        private System.Windows.Forms.TabPage Export_List_Home;
        private System.Windows.Forms.TabPage Export_List_Lecturers;
        private System.Windows.Forms.Button Lecturers_Export;
        private System.Windows.Forms.TabPage Export_List_Modules;
        private System.Windows.Forms.Button List_Modules_Export;
        private System.Windows.Forms.TabPage Export_List_Rooms;
        private System.Windows.Forms.Button List_Room_Export;
        private System.Windows.Forms.TabPage Export_List_Groups;
        private System.Windows.Forms.Button List_Groups_Export;
        private System.Windows.Forms.TabControl Export_Tab;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl Export_Tab_Timetable;
        private System.Windows.Forms.TabPage Export_Timetable_Home;
        private System.Windows.Forms.TabPage Export_Timetable_Lecturers;
        private System.Windows.Forms.Button Timetable_Lecturers_Export;
        private System.Windows.Forms.TabPage Export_Timetable_Rooms;
        private System.Windows.Forms.TabPage Exprt_Timetable_Groups;
        private System.Windows.Forms.Button Open_PDF_List_Lecturers;
        private System.Windows.Forms.Button Print_PDF_Lst_Lecturers;
        private System.Windows.Forms.Button Print_PDF_Dialog_List_Lec;
        private System.Windows.Forms.TabPage Export_Settings;
        private System.Windows.Forms.Button List_Mod_Print_Dia;
        private System.Windows.Forms.Button List_Mod_Print_Pre;
        private System.Windows.Forms.Button List_Mod_Open;
        private System.Windows.Forms.Button List_Rooms_Print_Dia;
        private System.Windows.Forms.Button List_Rooms_Print_pre;
        private System.Windows.Forms.Button List_Rooms_Open;
        private System.Windows.Forms.Button List_Groups_Print_Dia;
        private System.Windows.Forms.Button List_Groups_Print_Pre;
        private System.Windows.Forms.Button List_Groups_Open;
        private System.Windows.Forms.Button Open_All_List_PDF;
        private System.Windows.Forms.Button Export_All_To_PDF;
        private System.Windows.Forms.TabControl Export_Tab_Settings;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage Export_Settings_Advanced;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataLecTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursPerModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridView dataSubTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataRoomTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dataClassTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}