﻿namespace Hafala_Hub
{
    partial class New_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Alert));
            this.AlertGroupTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.AlertGroupLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SolutionLable = new System.Windows.Forms.Label();
            this.SolutionsTextbox = new System.Windows.Forms.TextBox();
            this.SaveFile_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlertGroupTextbox
            // 
            this.AlertGroupTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlertGroupTextbox.Font = new System.Drawing.Font("Guttman Hatzvi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AlertGroupTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.AlertGroupTextbox.Location = new System.Drawing.Point(11, 33);
            this.AlertGroupTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.AlertGroupTextbox.Multiline = true;
            this.AlertGroupTextbox.Name = "AlertGroupTextbox";
            this.AlertGroupTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AlertGroupTextbox.Size = new System.Drawing.Size(766, 23);
            this.AlertGroupTextbox.TabIndex = 0;
            this.AlertGroupTextbox.Text = "הדבק כאן את הערך \'Alert Group\' מהפנורמה.";
            this.AlertGroupTextbox.Enter += new System.EventHandler(this.AlertGroupTextbox_Enter);
            this.AlertGroupTextbox.Leave += new System.EventHandler(this.AlertGroupTextbox_Leave);
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextbox.Font = new System.Drawing.Font("Guttman Hatzvi", 8.25F);
            this.DescriptionTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.DescriptionTextbox.Location = new System.Drawing.Point(11, 85);
            this.DescriptionTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextbox.Size = new System.Drawing.Size(770, 159);
            this.DescriptionTextbox.TabIndex = 1;
            this.DescriptionTextbox.Text = "פרט על ההתראה כך שמפעילים אחרים ידעו מה משמעותה...";
            this.DescriptionTextbox.Enter += new System.EventHandler(this.DescriptionTextbox_Enter);
            this.DescriptionTextbox.Leave += new System.EventHandler(this.DescriptionTextbox_Leave);
            // 
            // AlertGroupLabel
            // 
            this.AlertGroupLabel.AutoSize = true;
            this.AlertGroupLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertGroupLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AlertGroupLabel.Location = new System.Drawing.Point(798, 19);
            this.AlertGroupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlertGroupLabel.Name = "AlertGroupLabel";
            this.AlertGroupLabel.Size = new System.Drawing.Size(200, 37);
            this.AlertGroupLabel.TabIndex = 2;
            this.AlertGroupLabel.Text = ":קבוצת התראות";
            this.AlertGroupLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlertGroupLabel_MouseDown);
            this.AlertGroupLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlertGroupLabel_MouseMove);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.DescriptionLabel.Location = new System.Drawing.Point(808, 74);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(190, 37);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = ":פרט על הבעיה";
            this.DescriptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DescriptionLabel_MouseDown);
            this.DescriptionLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DescriptionLabel_MouseMove);
            // 
            // SolutionLable
            // 
            this.SolutionLable.AutoSize = true;
            this.SolutionLable.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.SolutionLable.Location = new System.Drawing.Point(806, 269);
            this.SolutionLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SolutionLable.Name = "SolutionLable";
            this.SolutionLable.Size = new System.Drawing.Size(192, 37);
            this.SolutionLable.TabIndex = 4;
            this.SolutionLable.Text = ":פתרונות ידועים";
            this.SolutionLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SolutionLable_MouseDown);
            this.SolutionLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SolutionLable_MouseMove);
            // 
            // SolutionsTextbox
            // 
            this.SolutionsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SolutionsTextbox.Font = new System.Drawing.Font("Guttman Hatzvi", 8.25F);
            this.SolutionsTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.SolutionsTextbox.Location = new System.Drawing.Point(11, 278);
            this.SolutionsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SolutionsTextbox.Multiline = true;
            this.SolutionsTextbox.Name = "SolutionsTextbox";
            this.SolutionsTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SolutionsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SolutionsTextbox.Size = new System.Drawing.Size(770, 159);
            this.SolutionsTextbox.TabIndex = 5;
            this.SolutionsTextbox.Text = "ספק פתרון אחד לפחות שיעלים את התקלה.";
            this.SolutionsTextbox.Enter += new System.EventHandler(this.SolutionsTextbox_Enter);
            this.SolutionsTextbox.Leave += new System.EventHandler(this.SolutionsTextbox_Leave);
            // 
            // SaveFile_Button
            // 
            this.SaveFile_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.SaveFile_Button.FlatAppearance.BorderSize = 0;
            this.SaveFile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveFile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.SaveFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile_Button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.SaveFile_Button.Location = new System.Drawing.Point(113, 450);
            this.SaveFile_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SaveFile_Button.Name = "SaveFile_Button";
            this.SaveFile_Button.Size = new System.Drawing.Size(89, 39);
            this.SaveFile_Button.TabIndex = 6;
            this.SaveFile_Button.Text = "שמירה";
            this.SaveFile_Button.UseVisualStyleBackColor = false;
            this.SaveFile_Button.Click += new System.EventHandler(this.SaveFile_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.Exit_Button.Location = new System.Drawing.Point(11, 450);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(89, 39);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "סגירה";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // New_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 498);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.SaveFile_Button);
            this.Controls.Add(this.SolutionsTextbox);
            this.Controls.Add(this.SolutionLable);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AlertGroupLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.AlertGroupTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "New_Alert";
            this.Text = "New_Alert";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.New_Alert_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.New_Alert_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AlertGroupTextbox;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.Label AlertGroupLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label SolutionLable;
        private System.Windows.Forms.TextBox SolutionsTextbox;
        private System.Windows.Forms.Button SaveFile_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}