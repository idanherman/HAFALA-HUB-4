namespace Hafala_Hub
{
    partial class Page_Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.ActivitiesLabel = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.clmActivityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.Activity1AddImageButton = new System.Windows.Forms.PictureBox();
            this.Activity2AddImageButton = new System.Windows.Forms.PictureBox();
            this.ID1TextBox = new System.Windows.Forms.TextBox();
            this.Activity1EndDateTime = new System.Windows.Forms.Label();
            this.Activity1StartDateTime = new System.Windows.Forms.Label();
            this.Activity1Inserter = new System.Windows.Forms.Label();
            this.Activity1ID = new System.Windows.Forms.Label();
            this.Activity1Leaders = new System.Windows.Forms.Label();
            this.Activity1Severity = new System.Windows.Forms.Label();
            this.Activity1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Activity1Summary = new System.Windows.Forms.TextBox();
            this.Activity1Header = new System.Windows.Forms.Label();
            this.Activity1Panel = new System.Windows.Forms.Panel();
            this.Activity2Panel = new System.Windows.Forms.Panel();
            this.Activity2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Activity2EndDateTime = new System.Windows.Forms.Label();
            this.Activity2StartDateTime = new System.Windows.Forms.Label();
            this.Activity2Inserter = new System.Windows.Forms.Label();
            this.Activity2ID = new System.Windows.Forms.Label();
            this.Activity2Leaders = new System.Windows.Forms.Label();
            this.Activity2Severity = new System.Windows.Forms.Label();
            this.Activity2Summary = new System.Windows.Forms.TextBox();
            this.Activity2Header = new System.Windows.Forms.Label();
            this.Leaders1TextBox = new System.Windows.Forms.TextBox();
            this.Inserter1TextBox = new System.Windows.Forms.TextBox();
            this.Severity1TextBox = new System.Windows.Forms.TextBox();
            this.StartDateTime1TextBox = new System.Windows.Forms.TextBox();
            this.EndDateTime1TextBox = new System.Windows.Forms.TextBox();
            this.EndDateTime2TextBox = new System.Windows.Forms.TextBox();
            this.StartDateTime2TextBox = new System.Windows.Forms.TextBox();
            this.Severity2TextBox = new System.Windows.Forms.TextBox();
            this.Inserter2TextBox = new System.Windows.Forms.TextBox();
            this.Leaders2TextBox = new System.Windows.Forms.TextBox();
            this.ID2TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Activity1AddImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity2AddImageButton)).BeginInit();
            this.Activity1Panel.SuspendLayout();
            this.Activity2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(331, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "בית";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // ActivitiesLabel
            // 
            this.ActivitiesLabel.AutoSize = true;
            this.ActivitiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivitiesLabel.Location = new System.Drawing.Point(697, 60);
            this.ActivitiesLabel.Name = "ActivitiesLabel";
            this.ActivitiesLabel.Size = new System.Drawing.Size(76, 21);
            this.ActivitiesLabel.TabIndex = 1;
            this.ActivitiesLabel.Text = ":פעילויות";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmActivityID});
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.Location = new System.Drawing.Point(27, 60);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(160, 437);
            this.lvUsers.TabIndex = 2;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // clmActivityID
            // 
            this.clmActivityID.Text = "Activity ID";
            this.clmActivityID.Width = 143;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(66, 503);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAll.TabIndex = 5;
            this.btnLoadAll.Text = "Load all";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // Activity1AddImageButton
            // 
            this.Activity1AddImageButton.BackColor = System.Drawing.Color.Transparent;
            this.Activity1AddImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activity1AddImageButton.Image = ((System.Drawing.Image)(resources.GetObject("Activity1AddImageButton.Image")));
            this.Activity1AddImageButton.Location = new System.Drawing.Point(618, 93);
            this.Activity1AddImageButton.Name = "Activity1AddImageButton";
            this.Activity1AddImageButton.Size = new System.Drawing.Size(135, 137);
            this.Activity1AddImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Activity1AddImageButton.TabIndex = 8;
            this.Activity1AddImageButton.TabStop = false;
            this.Activity1AddImageButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Activity2AddImageButton
            // 
            this.Activity2AddImageButton.BackColor = System.Drawing.Color.Transparent;
            this.Activity2AddImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activity2AddImageButton.Image = ((System.Drawing.Image)(resources.GetObject("Activity2AddImageButton.Image")));
            this.Activity2AddImageButton.Location = new System.Drawing.Point(400, 106);
            this.Activity2AddImageButton.Name = "Activity2AddImageButton";
            this.Activity2AddImageButton.Size = new System.Drawing.Size(135, 137);
            this.Activity2AddImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Activity2AddImageButton.TabIndex = 9;
            this.Activity2AddImageButton.TabStop = false;
            this.Activity2AddImageButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ID1TextBox
            // 
            this.ID1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.ID1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.ID1TextBox.Location = new System.Drawing.Point(6, 104);
            this.ID1TextBox.Name = "ID1TextBox";
            this.ID1TextBox.Size = new System.Drawing.Size(100, 15);
            this.ID1TextBox.TabIndex = 19;
            this.ID1TextBox.Text = "ID";
            // 
            // Activity1EndDateTime
            // 
            this.Activity1EndDateTime.AutoSize = true;
            this.Activity1EndDateTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1EndDateTime.ForeColor = System.Drawing.Color.White;
            this.Activity1EndDateTime.Location = new System.Drawing.Point(124, 143);
            this.Activity1EndDateTime.Name = "Activity1EndDateTime";
            this.Activity1EndDateTime.Size = new System.Drawing.Size(66, 13);
            this.Activity1EndDateTime.TabIndex = 18;
            this.Activity1EndDateTime.Text = ":מסתיימת ב";
            // 
            // Activity1StartDateTime
            // 
            this.Activity1StartDateTime.AutoSize = true;
            this.Activity1StartDateTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1StartDateTime.ForeColor = System.Drawing.Color.White;
            this.Activity1StartDateTime.Location = new System.Drawing.Point(129, 130);
            this.Activity1StartDateTime.Name = "Activity1StartDateTime";
            this.Activity1StartDateTime.Size = new System.Drawing.Size(61, 13);
            this.Activity1StartDateTime.TabIndex = 17;
            this.Activity1StartDateTime.Text = ":התחילה ב";
            // 
            // Activity1Inserter
            // 
            this.Activity1Inserter.AutoSize = true;
            this.Activity1Inserter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1Inserter.ForeColor = System.Drawing.Color.White;
            this.Activity1Inserter.Location = new System.Drawing.Point(141, 117);
            this.Activity1Inserter.Name = "Activity1Inserter";
            this.Activity1Inserter.Size = new System.Drawing.Size(49, 13);
            this.Activity1Inserter.TabIndex = 16;
            this.Activity1Inserter.Text = ":נוצר ע\"י";
            // 
            // Activity1ID
            // 
            this.Activity1ID.AutoSize = true;
            this.Activity1ID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1ID.ForeColor = System.Drawing.Color.White;
            this.Activity1ID.Location = new System.Drawing.Point(115, 104);
            this.Activity1ID.Name = "Activity1ID";
            this.Activity1ID.Size = new System.Drawing.Size(75, 13);
            this.Activity1ID.TabIndex = 15;
            this.Activity1ID.Text = ":מזהה פעילות";
            // 
            // Activity1Leaders
            // 
            this.Activity1Leaders.AutoSize = true;
            this.Activity1Leaders.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1Leaders.ForeColor = System.Drawing.Color.White;
            this.Activity1Leaders.Location = new System.Drawing.Point(142, 91);
            this.Activity1Leaders.Name = "Activity1Leaders";
            this.Activity1Leaders.Size = new System.Drawing.Size(48, 13);
            this.Activity1Leaders.TabIndex = 14;
            this.Activity1Leaders.Text = ":מובילים";
            // 
            // Activity1Severity
            // 
            this.Activity1Severity.AutoSize = true;
            this.Activity1Severity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1Severity.ForeColor = System.Drawing.Color.White;
            this.Activity1Severity.Location = new System.Drawing.Point(147, 78);
            this.Activity1Severity.Name = "Activity1Severity";
            this.Activity1Severity.Size = new System.Drawing.Size(43, 13);
            this.Activity1Severity.TabIndex = 13;
            this.Activity1Severity.Text = ":חומרה";
            // 
            // Activity1ProgressBar
            // 
            this.Activity1ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Activity1ProgressBar.Location = new System.Drawing.Point(0, 171);
            this.Activity1ProgressBar.Name = "Activity1ProgressBar";
            this.Activity1ProgressBar.Size = new System.Drawing.Size(196, 13);
            this.Activity1ProgressBar.TabIndex = 12;
            // 
            // Activity1Summary
            // 
            this.Activity1Summary.BackColor = System.Drawing.Color.DodgerBlue;
            this.Activity1Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Activity1Summary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1Summary.ForeColor = System.Drawing.Color.White;
            this.Activity1Summary.Location = new System.Drawing.Point(6, 22);
            this.Activity1Summary.Multiline = true;
            this.Activity1Summary.Name = "Activity1Summary";
            this.Activity1Summary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Activity1Summary.Size = new System.Drawing.Size(184, 60);
            this.Activity1Summary.TabIndex = 11;
            this.Activity1Summary.Text = resources.GetString("Activity1Summary.Text");
            // 
            // Activity1Header
            // 
            this.Activity1Header.AutoSize = true;
            this.Activity1Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity1Header.ForeColor = System.Drawing.Color.White;
            this.Activity1Header.Location = new System.Drawing.Point(6, 0);
            this.Activity1Header.Name = "Activity1Header";
            this.Activity1Header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Activity1Header.Size = new System.Drawing.Size(89, 19);
            this.Activity1Header.TabIndex = 10;
            this.Activity1Header.Text = "דוגמא דוגמא";
            this.Activity1Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Activity1Panel
            // 
            this.Activity1Panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Activity1Panel.Controls.Add(this.EndDateTime1TextBox);
            this.Activity1Panel.Controls.Add(this.StartDateTime1TextBox);
            this.Activity1Panel.Controls.Add(this.Severity1TextBox);
            this.Activity1Panel.Controls.Add(this.Inserter1TextBox);
            this.Activity1Panel.Controls.Add(this.Leaders1TextBox);
            this.Activity1Panel.Controls.Add(this.ID1TextBox);
            this.Activity1Panel.Controls.Add(this.Activity1ProgressBar);
            this.Activity1Panel.Controls.Add(this.Activity1EndDateTime);
            this.Activity1Panel.Controls.Add(this.Activity1StartDateTime);
            this.Activity1Panel.Controls.Add(this.Activity1Inserter);
            this.Activity1Panel.Controls.Add(this.Activity1ID);
            this.Activity1Panel.Controls.Add(this.Activity1Leaders);
            this.Activity1Panel.Controls.Add(this.Activity1Severity);
            this.Activity1Panel.Controls.Add(this.Activity1Summary);
            this.Activity1Panel.Controls.Add(this.Activity1Header);
            this.Activity1Panel.Location = new System.Drawing.Point(577, 84);
            this.Activity1Panel.Name = "Activity1Panel";
            this.Activity1Panel.Size = new System.Drawing.Size(196, 184);
            this.Activity1Panel.TabIndex = 20;
            this.Activity1Panel.Visible = false;
            // 
            // Activity2Panel
            // 
            this.Activity2Panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Activity2Panel.Controls.Add(this.EndDateTime2TextBox);
            this.Activity2Panel.Controls.Add(this.StartDateTime2TextBox);
            this.Activity2Panel.Controls.Add(this.Severity2TextBox);
            this.Activity2Panel.Controls.Add(this.Inserter2TextBox);
            this.Activity2Panel.Controls.Add(this.Leaders2TextBox);
            this.Activity2Panel.Controls.Add(this.ID2TextBox);
            this.Activity2Panel.Controls.Add(this.Activity2ProgressBar);
            this.Activity2Panel.Controls.Add(this.Activity2EndDateTime);
            this.Activity2Panel.Controls.Add(this.Activity2StartDateTime);
            this.Activity2Panel.Controls.Add(this.Activity2Inserter);
            this.Activity2Panel.Controls.Add(this.Activity2ID);
            this.Activity2Panel.Controls.Add(this.Activity2Leaders);
            this.Activity2Panel.Controls.Add(this.Activity2Severity);
            this.Activity2Panel.Controls.Add(this.Activity2Summary);
            this.Activity2Panel.Controls.Add(this.Activity2Header);
            this.Activity2Panel.Location = new System.Drawing.Point(375, 84);
            this.Activity2Panel.Name = "Activity2Panel";
            this.Activity2Panel.Size = new System.Drawing.Size(196, 184);
            this.Activity2Panel.TabIndex = 21;
            this.Activity2Panel.Visible = false;
            // 
            // Activity2ProgressBar
            // 
            this.Activity2ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Activity2ProgressBar.Location = new System.Drawing.Point(0, 171);
            this.Activity2ProgressBar.Name = "Activity2ProgressBar";
            this.Activity2ProgressBar.Size = new System.Drawing.Size(196, 13);
            this.Activity2ProgressBar.TabIndex = 12;
            // 
            // Activity2EndDateTime
            // 
            this.Activity2EndDateTime.AutoSize = true;
            this.Activity2EndDateTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2EndDateTime.ForeColor = System.Drawing.Color.White;
            this.Activity2EndDateTime.Location = new System.Drawing.Point(124, 143);
            this.Activity2EndDateTime.Name = "Activity2EndDateTime";
            this.Activity2EndDateTime.Size = new System.Drawing.Size(66, 13);
            this.Activity2EndDateTime.TabIndex = 18;
            this.Activity2EndDateTime.Text = ":מסתיימת ב";
            // 
            // Activity2StartDateTime
            // 
            this.Activity2StartDateTime.AutoSize = true;
            this.Activity2StartDateTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2StartDateTime.ForeColor = System.Drawing.Color.White;
            this.Activity2StartDateTime.Location = new System.Drawing.Point(129, 130);
            this.Activity2StartDateTime.Name = "Activity2StartDateTime";
            this.Activity2StartDateTime.Size = new System.Drawing.Size(61, 13);
            this.Activity2StartDateTime.TabIndex = 17;
            this.Activity2StartDateTime.Text = ":התחילה ב";
            // 
            // Activity2Inserter
            // 
            this.Activity2Inserter.AutoSize = true;
            this.Activity2Inserter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2Inserter.ForeColor = System.Drawing.Color.White;
            this.Activity2Inserter.Location = new System.Drawing.Point(141, 117);
            this.Activity2Inserter.Name = "Activity2Inserter";
            this.Activity2Inserter.Size = new System.Drawing.Size(49, 13);
            this.Activity2Inserter.TabIndex = 16;
            this.Activity2Inserter.Text = ":נוצר ע\"י";
            // 
            // Activity2ID
            // 
            this.Activity2ID.AutoSize = true;
            this.Activity2ID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2ID.ForeColor = System.Drawing.Color.White;
            this.Activity2ID.Location = new System.Drawing.Point(115, 104);
            this.Activity2ID.Name = "Activity2ID";
            this.Activity2ID.Size = new System.Drawing.Size(75, 13);
            this.Activity2ID.TabIndex = 15;
            this.Activity2ID.Text = ":מזהה פעילות";
            // 
            // Activity2Leaders
            // 
            this.Activity2Leaders.AutoSize = true;
            this.Activity2Leaders.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2Leaders.ForeColor = System.Drawing.Color.White;
            this.Activity2Leaders.Location = new System.Drawing.Point(142, 91);
            this.Activity2Leaders.Name = "Activity2Leaders";
            this.Activity2Leaders.Size = new System.Drawing.Size(48, 13);
            this.Activity2Leaders.TabIndex = 14;
            this.Activity2Leaders.Text = ":מובילים";
            // 
            // Activity2Severity
            // 
            this.Activity2Severity.AutoSize = true;
            this.Activity2Severity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2Severity.ForeColor = System.Drawing.Color.White;
            this.Activity2Severity.Location = new System.Drawing.Point(147, 78);
            this.Activity2Severity.Name = "Activity2Severity";
            this.Activity2Severity.Size = new System.Drawing.Size(43, 13);
            this.Activity2Severity.TabIndex = 13;
            this.Activity2Severity.Text = ":חומרה";
            // 
            // Activity2Summary
            // 
            this.Activity2Summary.BackColor = System.Drawing.Color.DodgerBlue;
            this.Activity2Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Activity2Summary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2Summary.ForeColor = System.Drawing.Color.White;
            this.Activity2Summary.Location = new System.Drawing.Point(6, 22);
            this.Activity2Summary.Multiline = true;
            this.Activity2Summary.Name = "Activity2Summary";
            this.Activity2Summary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Activity2Summary.Size = new System.Drawing.Size(184, 60);
            this.Activity2Summary.TabIndex = 11;
            this.Activity2Summary.Text = resources.GetString("Activity2Summary.Text");
            // 
            // Activity2Header
            // 
            this.Activity2Header.AutoSize = true;
            this.Activity2Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity2Header.ForeColor = System.Drawing.Color.White;
            this.Activity2Header.Location = new System.Drawing.Point(6, 0);
            this.Activity2Header.Name = "Activity2Header";
            this.Activity2Header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Activity2Header.Size = new System.Drawing.Size(89, 19);
            this.Activity2Header.TabIndex = 10;
            this.Activity2Header.Text = "דוגמא דוגמא";
            // 
            // Leaders1TextBox
            // 
            this.Leaders1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Leaders1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leaders1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leaders1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Leaders1TextBox.Location = new System.Drawing.Point(6, 91);
            this.Leaders1TextBox.Name = "Leaders1TextBox";
            this.Leaders1TextBox.Size = new System.Drawing.Size(100, 15);
            this.Leaders1TextBox.TabIndex = 20;
            this.Leaders1TextBox.Text = "Leaders";
            // 
            // Inserter1TextBox
            // 
            this.Inserter1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Inserter1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Inserter1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserter1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Inserter1TextBox.Location = new System.Drawing.Point(6, 117);
            this.Inserter1TextBox.Name = "Inserter1TextBox";
            this.Inserter1TextBox.Size = new System.Drawing.Size(100, 15);
            this.Inserter1TextBox.TabIndex = 21;
            this.Inserter1TextBox.Text = "Inserter";
            // 
            // Severity1TextBox
            // 
            this.Severity1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Severity1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Severity1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Severity1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Severity1TextBox.Location = new System.Drawing.Point(6, 78);
            this.Severity1TextBox.Name = "Severity1TextBox";
            this.Severity1TextBox.Size = new System.Drawing.Size(100, 15);
            this.Severity1TextBox.TabIndex = 22;
            this.Severity1TextBox.Text = "Severity";
            // 
            // StartDateTime1TextBox
            // 
            this.StartDateTime1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartDateTime1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartDateTime1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTime1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.StartDateTime1TextBox.Location = new System.Drawing.Point(6, 130);
            this.StartDateTime1TextBox.Name = "StartDateTime1TextBox";
            this.StartDateTime1TextBox.Size = new System.Drawing.Size(100, 15);
            this.StartDateTime1TextBox.TabIndex = 23;
            this.StartDateTime1TextBox.Text = "00.00.0000-00:00";
            // 
            // EndDateTime1TextBox
            // 
            this.EndDateTime1TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.EndDateTime1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndDateTime1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTime1TextBox.ForeColor = System.Drawing.Color.Gold;
            this.EndDateTime1TextBox.Location = new System.Drawing.Point(6, 143);
            this.EndDateTime1TextBox.Name = "EndDateTime1TextBox";
            this.EndDateTime1TextBox.Size = new System.Drawing.Size(100, 15);
            this.EndDateTime1TextBox.TabIndex = 24;
            this.EndDateTime1TextBox.Text = "00.00.0000-00:00";
            // 
            // EndDateTime2TextBox
            // 
            this.EndDateTime2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.EndDateTime2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndDateTime2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTime2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.EndDateTime2TextBox.Location = new System.Drawing.Point(6, 143);
            this.EndDateTime2TextBox.Name = "EndDateTime2TextBox";
            this.EndDateTime2TextBox.Size = new System.Drawing.Size(100, 15);
            this.EndDateTime2TextBox.TabIndex = 30;
            this.EndDateTime2TextBox.Text = "00.00.0000-00:00";
            // 
            // StartDateTime2TextBox
            // 
            this.StartDateTime2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartDateTime2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartDateTime2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTime2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.StartDateTime2TextBox.Location = new System.Drawing.Point(6, 130);
            this.StartDateTime2TextBox.Name = "StartDateTime2TextBox";
            this.StartDateTime2TextBox.Size = new System.Drawing.Size(100, 15);
            this.StartDateTime2TextBox.TabIndex = 29;
            this.StartDateTime2TextBox.Text = "00.00.0000-00:00";
            // 
            // Severity2TextBox
            // 
            this.Severity2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Severity2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Severity2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Severity2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Severity2TextBox.Location = new System.Drawing.Point(6, 78);
            this.Severity2TextBox.Name = "Severity2TextBox";
            this.Severity2TextBox.Size = new System.Drawing.Size(100, 15);
            this.Severity2TextBox.TabIndex = 28;
            this.Severity2TextBox.Text = "Severity";
            // 
            // Inserter2TextBox
            // 
            this.Inserter2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Inserter2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Inserter2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserter2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Inserter2TextBox.Location = new System.Drawing.Point(6, 117);
            this.Inserter2TextBox.Name = "Inserter2TextBox";
            this.Inserter2TextBox.Size = new System.Drawing.Size(100, 15);
            this.Inserter2TextBox.TabIndex = 27;
            this.Inserter2TextBox.Text = "Inserter";
            // 
            // Leaders2TextBox
            // 
            this.Leaders2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.Leaders2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leaders2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leaders2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.Leaders2TextBox.Location = new System.Drawing.Point(6, 91);
            this.Leaders2TextBox.Name = "Leaders2TextBox";
            this.Leaders2TextBox.Size = new System.Drawing.Size(100, 15);
            this.Leaders2TextBox.TabIndex = 26;
            this.Leaders2TextBox.Text = "Leaders";
            // 
            // ID2TextBox
            // 
            this.ID2TextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.ID2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID2TextBox.ForeColor = System.Drawing.Color.Gold;
            this.ID2TextBox.Location = new System.Drawing.Point(6, 104);
            this.ID2TextBox.Name = "ID2TextBox";
            this.ID2TextBox.Size = new System.Drawing.Size(100, 15);
            this.ID2TextBox.TabIndex = 25;
            this.ID2TextBox.Text = "ID";
            // 
            // Page_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Activity2Panel);
            this.Controls.Add(this.Activity1Panel);
            this.Controls.Add(this.Activity2AddImageButton);
            this.Controls.Add(this.Activity1AddImageButton);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.ActivitiesLabel);
            this.Controls.Add(this.label1);
            this.Name = "Page_Menu";
            this.Size = new System.Drawing.Size(782, 583);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Page_Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Page_Menu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Activity1AddImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity2AddImageButton)).EndInit();
            this.Activity1Panel.ResumeLayout(false);
            this.Activity1Panel.PerformLayout();
            this.Activity2Panel.ResumeLayout(false);
            this.Activity2Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActivitiesLabel;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader clmActivityID;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.PictureBox Activity1AddImageButton;
        private System.Windows.Forms.PictureBox Activity2AddImageButton;
        private System.Windows.Forms.TextBox ID1TextBox;
        private System.Windows.Forms.Label Activity1EndDateTime;
        private System.Windows.Forms.Label Activity1StartDateTime;
        private System.Windows.Forms.Label Activity1Inserter;
        private System.Windows.Forms.Label Activity1ID;
        private System.Windows.Forms.Label Activity1Leaders;
        private System.Windows.Forms.Label Activity1Severity;
        private System.Windows.Forms.ProgressBar Activity1ProgressBar;
        private System.Windows.Forms.TextBox Activity1Summary;
        private System.Windows.Forms.Label Activity1Header;
        private System.Windows.Forms.Panel Activity1Panel;
        private System.Windows.Forms.Panel Activity2Panel;
        private System.Windows.Forms.ProgressBar Activity2ProgressBar;
        private System.Windows.Forms.Label Activity2EndDateTime;
        private System.Windows.Forms.Label Activity2StartDateTime;
        private System.Windows.Forms.Label Activity2Inserter;
        private System.Windows.Forms.Label Activity2ID;
        private System.Windows.Forms.Label Activity2Leaders;
        private System.Windows.Forms.Label Activity2Severity;
        private System.Windows.Forms.TextBox Activity2Summary;
        private System.Windows.Forms.Label Activity2Header;
        private System.Windows.Forms.TextBox EndDateTime1TextBox;
        private System.Windows.Forms.TextBox StartDateTime1TextBox;
        private System.Windows.Forms.TextBox Severity1TextBox;
        private System.Windows.Forms.TextBox Inserter1TextBox;
        private System.Windows.Forms.TextBox Leaders1TextBox;
        private System.Windows.Forms.TextBox EndDateTime2TextBox;
        private System.Windows.Forms.TextBox StartDateTime2TextBox;
        private System.Windows.Forms.TextBox Severity2TextBox;
        private System.Windows.Forms.TextBox Inserter2TextBox;
        private System.Windows.Forms.TextBox Leaders2TextBox;
        private System.Windows.Forms.TextBox ID2TextBox;
    }
}
