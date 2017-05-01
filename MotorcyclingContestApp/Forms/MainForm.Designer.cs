namespace MotorcyclingContestApp.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchContestantsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchByTeamButton = new System.Windows.Forms.Button();
            this.teamNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.contestantsGrid = new System.Windows.Forms.DataGridView();
            this.contestantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestantTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestantEc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.cEngineCapacityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cTeamComboBox = new System.Windows.Forms.ComboBox();
            this.resetContestantButton = new System.Windows.Forms.Button();
            this.registerContestantButton = new System.Windows.Forms.Button();
            this.cRacesListBox = new System.Windows.Forms.CheckedListBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listRacesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.racesGrid = new System.Windows.Forms.DataGridView();
            this.idRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfContestantsRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContestantsGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsGrid)).BeginInit();
            this.registerTabPage.SuspendLayout();
            this.listRacesTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem1.Text = "Session";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "Logout";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchTabPage);
            this.tabControl1.Controls.Add(this.registerTabPage);
            this.tabControl1.Controls.Add(this.listRacesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 642);
            this.tabControl1.TabIndex = 1;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.tableLayoutPanel1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(965, 616);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "Seaarch participants";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 610);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchContestantsGrid);
            this.panel1.Controls.Add(this.searchByTeamButton);
            this.panel1.Controls.Add(this.teamNameSearchTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 604);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search participants by team name";
            // 
            // searchContestantsGrid
            // 
            this.searchContestantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchContestantsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.searchContestantsGrid.Location = new System.Drawing.Point(0, 46);
            this.searchContestantsGrid.Name = "searchContestantsGrid";
            this.searchContestantsGrid.Size = new System.Drawing.Size(462, 460);
            this.searchContestantsGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Contestant Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Engine Capacity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // searchByTeamButton
            // 
            this.searchByTeamButton.Location = new System.Drawing.Point(84, 562);
            this.searchByTeamButton.Name = "searchByTeamButton";
            this.searchByTeamButton.Size = new System.Drawing.Size(75, 23);
            this.searchByTeamButton.TabIndex = 5;
            this.searchByTeamButton.Text = "Search";
            this.searchByTeamButton.UseVisualStyleBackColor = true;
            this.searchByTeamButton.Click += new System.EventHandler(this.searchByTeamButton_Click);
            // 
            // teamNameSearchTextBox
            // 
            this.teamNameSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teamNameSearchTextBox.Location = new System.Drawing.Point(84, 529);
            this.teamNameSearchTextBox.Name = "teamNameSearchTextBox";
            this.teamNameSearchTextBox.Size = new System.Drawing.Size(114, 20);
            this.teamNameSearchTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.contestantsGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(482, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 604);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "All available participants";
            // 
            // contestantsGrid
            // 
            this.contestantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contestantsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contestantId,
            this.contestantName,
            this.contestantTeamName,
            this.contestantEc});
            this.contestantsGrid.Location = new System.Drawing.Point(0, 46);
            this.contestantsGrid.Name = "contestantsGrid";
            this.contestantsGrid.Size = new System.Drawing.Size(460, 562);
            this.contestantsGrid.TabIndex = 0;
            // 
            // contestantId
            // 
            this.contestantId.HeaderText = "#";
            this.contestantId.Name = "contestantId";
            // 
            // contestantName
            // 
            this.contestantName.HeaderText = "Contestant Name";
            this.contestantName.Name = "contestantName";
            this.contestantName.ReadOnly = true;
            // 
            // contestantTeamName
            // 
            this.contestantTeamName.HeaderText = "TeamName";
            this.contestantTeamName.Name = "contestantTeamName";
            this.contestantTeamName.ReadOnly = true;
            // 
            // contestantEc
            // 
            this.contestantEc.HeaderText = "Engine Capacity";
            this.contestantEc.Name = "contestantEc";
            this.contestantEc.ReadOnly = true;
            // 
            // registerTabPage
            // 
            this.registerTabPage.Controls.Add(this.cEngineCapacityComboBox);
            this.registerTabPage.Controls.Add(this.label7);
            this.registerTabPage.Controls.Add(this.cTeamComboBox);
            this.registerTabPage.Controls.Add(this.resetContestantButton);
            this.registerTabPage.Controls.Add(this.registerContestantButton);
            this.registerTabPage.Controls.Add(this.cRacesListBox);
            this.registerTabPage.Controls.Add(this.cNameTextBox);
            this.registerTabPage.Controls.Add(this.label6);
            this.registerTabPage.Controls.Add(this.label5);
            this.registerTabPage.Controls.Add(this.label4);
            this.registerTabPage.Location = new System.Drawing.Point(4, 22);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(965, 616);
            this.registerTabPage.TabIndex = 1;
            this.registerTabPage.Text = "Register partcipants";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // cEngineCapacityComboBox
            // 
            this.cEngineCapacityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cEngineCapacityComboBox.FormattingEnabled = true;
            this.cEngineCapacityComboBox.Location = new System.Drawing.Point(372, 192);
            this.cEngineCapacityComboBox.Name = "cEngineCapacityComboBox";
            this.cEngineCapacityComboBox.Size = new System.Drawing.Size(224, 21);
            this.cEngineCapacityComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Engine capacity:";
            // 
            // cTeamComboBox
            // 
            this.cTeamComboBox.FormattingEnabled = true;
            this.cTeamComboBox.Location = new System.Drawing.Point(372, 152);
            this.cTeamComboBox.Name = "cTeamComboBox";
            this.cTeamComboBox.Size = new System.Drawing.Size(224, 21);
            this.cTeamComboBox.TabIndex = 8;
            // 
            // resetContestantButton
            // 
            this.resetContestantButton.Location = new System.Drawing.Point(521, 480);
            this.resetContestantButton.Name = "resetContestantButton";
            this.resetContestantButton.Size = new System.Drawing.Size(75, 23);
            this.resetContestantButton.TabIndex = 7;
            this.resetContestantButton.Text = "Reset fields";
            this.resetContestantButton.UseVisualStyleBackColor = true;
            this.resetContestantButton.Click += new System.EventHandler(this.resetContestantButton_Click);
            // 
            // registerContestantButton
            // 
            this.registerContestantButton.Location = new System.Drawing.Point(372, 480);
            this.registerContestantButton.Name = "registerContestantButton";
            this.registerContestantButton.Size = new System.Drawing.Size(75, 23);
            this.registerContestantButton.TabIndex = 6;
            this.registerContestantButton.Text = "Register Contestant";
            this.registerContestantButton.UseVisualStyleBackColor = true;
            this.registerContestantButton.Click += new System.EventHandler(this.registerContestantButton_Click);
            // 
            // cRacesListBox
            // 
            this.cRacesListBox.FormattingEnabled = true;
            this.cRacesListBox.Items.AddRange(new object[] {
            "Race 1",
            "Race 2",
            "Race 3"});
            this.cRacesListBox.Location = new System.Drawing.Point(372, 232);
            this.cRacesListBox.Name = "cRacesListBox";
            this.cRacesListBox.Size = new System.Drawing.Size(224, 229);
            this.cRacesListBox.TabIndex = 5;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(372, 113);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.cNameTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Team name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Participates in races:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contestant name:";
            // 
            // listRacesTabPage
            // 
            this.listRacesTabPage.Controls.Add(this.panel5);
            this.listRacesTabPage.Location = new System.Drawing.Point(4, 22);
            this.listRacesTabPage.Name = "listRacesTabPage";
            this.listRacesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.listRacesTabPage.Size = new System.Drawing.Size(965, 616);
            this.listRacesTabPage.TabIndex = 2;
            this.listRacesTabPage.Text = "List races";
            this.listRacesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(957, 608);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 602);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(507, 602);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.racesGrid);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 418);
            this.panel4.TabIndex = 0;
            // 
            // racesGrid
            // 
            this.racesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRaceColumn,
            this.nameRaceColumn,
            this.startTimeRaceColumn,
            this.noOfContestantsRaceColumn});
            this.racesGrid.Location = new System.Drawing.Point(-3, 33);
            this.racesGrid.Name = "racesGrid";
            this.racesGrid.Size = new System.Drawing.Size(612, 385);
            this.racesGrid.TabIndex = 0;
            // 
            // idRaceColumn
            // 
            this.idRaceColumn.HeaderText = "#";
            this.idRaceColumn.Name = "idRaceColumn";
            this.idRaceColumn.ReadOnly = true;
            // 
            // nameRaceColumn
            // 
            this.nameRaceColumn.HeaderText = "Name";
            this.nameRaceColumn.Name = "nameRaceColumn";
            this.nameRaceColumn.ReadOnly = true;
            // 
            // startTimeRaceColumn
            // 
            this.startTimeRaceColumn.HeaderText = "Start time";
            this.startTimeRaceColumn.Name = "startTimeRaceColumn";
            this.startTimeRaceColumn.ReadOnly = true;
            // 
            // noOfContestantsRaceColumn
            // 
            this.noOfContestantsRaceColumn.HeaderText = "Number of Contestants";
            this.noOfContestantsRaceColumn.Name = "noOfContestantsRaceColumn";
            this.noOfContestantsRaceColumn.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Available Races:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(959, 610);
            this.panel5.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(989, 705);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContestantsGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contestantsGrid)).EndInit();
            this.registerTabPage.ResumeLayout(false);
            this.registerTabPage.PerformLayout();
            this.listRacesTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.DataGridView contestantsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestantEc;
        private System.Windows.Forms.Button searchByTeamButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamNameSearchTextBox;
        private System.Windows.Forms.DataGridView searchContestantsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerContestantButton;
        private System.Windows.Forms.CheckedListBox cRacesListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.Button resetContestantButton;
        private System.Windows.Forms.ComboBox cEngineCapacityComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cTeamComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage listRacesTabPage;
        private System.Windows.Forms.DataGridView racesGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeRaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfContestantsRaceColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
    }
}