namespace Hafala_Hub
{
    partial class Page_AlertsArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_AlertsArchive));
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReadEditButton = new System.Windows.Forms.Button();
            this.ReadEditPanel = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlertGroupList = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AlertGroupLabel = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.AddFileImageButton = new System.Windows.Forms.PictureBox();
            this.SearchOrEditImageButton = new System.Windows.Forms.PictureBox();
            this.ReadEditPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFileImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOrEditImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(154, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "ארכיון ההתראות";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddButton.Location = new System.Drawing.Point(62, 124);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(262, 63);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "הוסף התראה חדשה";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseDown);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // ReadEditButton
            // 
            this.ReadEditButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadEditButton.FlatAppearance.BorderSize = 0;
            this.ReadEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReadEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadEditButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadEditButton.ForeColor = System.Drawing.Color.DimGray;
            this.ReadEditButton.Location = new System.Drawing.Point(457, 124);
            this.ReadEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReadEditButton.Name = "ReadEditButton";
            this.ReadEditButton.Size = new System.Drawing.Size(262, 63);
            this.ReadEditButton.TabIndex = 3;
            this.ReadEditButton.Text = "חפש או ערוך התראה קיימת";
            this.ReadEditButton.UseVisualStyleBackColor = false;
            this.ReadEditButton.Click += new System.EventHandler(this.ReadEditButton_Click);
            this.ReadEditButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReadEditButton_MouseDown);
            this.ReadEditButton.MouseLeave += new System.EventHandler(this.ReadEditButton_MouseLeave);
            this.ReadEditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadEditButton_MouseMove);
            // 
            // ReadEditPanel
            // 
            this.ReadEditPanel.Controls.Add(this.OpenFileButton);
            this.ReadEditPanel.Controls.Add(this.BackButton1);
            this.ReadEditPanel.Controls.Add(this.panel2);
            this.ReadEditPanel.Controls.Add(this.SearchButton);
            this.ReadEditPanel.Controls.Add(this.AlertGroupLabel);
            this.ReadEditPanel.Controls.Add(this.SearchTxtBox);
            this.ReadEditPanel.Location = new System.Drawing.Point(0, 0);
            this.ReadEditPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReadEditPanel.Name = "ReadEditPanel";
            this.ReadEditPanel.Size = new System.Drawing.Size(782, 708);
            this.ReadEditPanel.TabIndex = 4;
            this.ReadEditPanel.Visible = false;
            this.ReadEditPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReadEditPanel_MouseDown);
            this.ReadEditPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadEditPanel_MouseMove);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Gainsboro;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.OpenFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.OpenFileButton.Location = new System.Drawing.Point(320, 492);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(108, 46);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "פתח";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // BackButton1
            // 
            this.BackButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.BackButton1.FlatAppearance.BorderSize = 0;
            this.BackButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BackButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BackButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton1.Location = new System.Drawing.Point(666, 20);
            this.BackButton1.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(96, 42);
            this.BackButton1.TabIndex = 3;
            this.BackButton1.Text = "חזרה";
            this.BackButton1.UseVisualStyleBackColor = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AlertGroupList);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(248, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 313);
            this.panel2.TabIndex = 7;
            // 
            // AlertGroupList
            // 
            this.AlertGroupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlertGroupList.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlertGroupList.FormattingEnabled = true;
            this.AlertGroupList.Location = new System.Drawing.Point(0, 0);
            this.AlertGroupList.Margin = new System.Windows.Forms.Padding(2);
            this.AlertGroupList.Name = "AlertGroupList";
            this.AlertGroupList.Size = new System.Drawing.Size(269, 312);
            this.AlertGroupList.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-184, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(658, 398);
            this.textBox2.TabIndex = 0;
            this.textBox2.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.SearchButton.Location = new System.Drawing.Point(169, 78);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(97, 46);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "חפש";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AlertGroupLabel
            // 
            this.AlertGroupLabel.AutoSize = true;
            this.AlertGroupLabel.Font = new System.Drawing.Font("Segoe UI Light", 10.2F);
            this.AlertGroupLabel.Location = new System.Drawing.Point(502, 95);
            this.AlertGroupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlertGroupLabel.Name = "AlertGroupLabel";
            this.AlertGroupLabel.Size = new System.Drawing.Size(102, 19);
            this.AlertGroupLabel.TabIndex = 5;
            this.AlertGroupLabel.Text = ":קבוצת התראות";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(275, 96);
            this.SearchTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(223, 20);
            this.SearchTxtBox.TabIndex = 4;
            // 
            // AddFileImageButton
            // 
            this.AddFileImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileImageButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFileImageButton.Image")));
            this.AddFileImageButton.Location = new System.Drawing.Point(121, 177);
            this.AddFileImageButton.Name = "AddFileImageButton";
            this.AddFileImageButton.Size = new System.Drawing.Size(203, 254);
            this.AddFileImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddFileImageButton.TabIndex = 5;
            this.AddFileImageButton.TabStop = false;
            this.AddFileImageButton.Click += new System.EventHandler(this.AddFileImageButton_Click);
            this.AddFileImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFileImageButton_MouseDown);
            this.AddFileImageButton.MouseLeave += new System.EventHandler(this.AddFileImageButton_MouseLeave);
            this.AddFileImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFileImageButton_MouseMove);
            // 
            // SearchOrEditImageButton
            // 
            this.SearchOrEditImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchOrEditImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchOrEditImageButton.Image")));
            this.SearchOrEditImageButton.Location = new System.Drawing.Point(490, 177);
            this.SearchOrEditImageButton.Name = "SearchOrEditImageButton";
            this.SearchOrEditImageButton.Size = new System.Drawing.Size(203, 254);
            this.SearchOrEditImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchOrEditImageButton.TabIndex = 6;
            this.SearchOrEditImageButton.TabStop = false;
            this.SearchOrEditImageButton.Click += new System.EventHandler(this.SearchOrEditImageButton_Click);
            this.SearchOrEditImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchOrEditImageButton_MouseDown);
            this.SearchOrEditImageButton.MouseLeave += new System.EventHandler(this.SearchOrEditImageButton_MouseLeave);
            this.SearchOrEditImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchOrEditImageButton_MouseMove);
            // 
            // Page_AlertsArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReadEditPanel);
            this.Controls.Add(this.SearchOrEditImageButton);
            this.Controls.Add(this.AddFileImageButton);
            this.Controls.Add(this.ReadEditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "Page_AlertsArchive";
            this.Size = new System.Drawing.Size(782, 708);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Page_AlertsArchive_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Page_AlertsArchive_MouseMove);
            this.ReadEditPanel.ResumeLayout(false);
            this.ReadEditPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFileImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOrEditImageButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReadEditButton;
        private System.Windows.Forms.Panel ReadEditPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label AlertGroupLabel;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.ListBox AlertGroupList;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.PictureBox AddFileImageButton;
        private System.Windows.Forms.PictureBox SearchOrEditImageButton;
    }
}
