namespace Hafala_Hub
{
    partial class Alert_Display
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditButton1 = new System.Windows.Forms.Button();
            this.ExitButton1 = new System.Windows.Forms.Button();
            this.AlertGroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-1, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(964, 477);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditButton1
            // 
            this.EditButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.EditButton1.FlatAppearance.BorderSize = 0;
            this.EditButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.EditButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.EditButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.EditButton1.Location = new System.Drawing.Point(137, 534);
            this.EditButton1.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton1.Name = "EditButton1";
            this.EditButton1.Size = new System.Drawing.Size(122, 40);
            this.EditButton1.TabIndex = 1;
            this.EditButton1.Text = "עריכה";
            this.EditButton1.UseVisualStyleBackColor = false;
            this.EditButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton1
            // 
            this.ExitButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitButton1.FlatAppearance.BorderSize = 0;
            this.ExitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ExitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ExitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.ExitButton1.Location = new System.Drawing.Point(11, 534);
            this.ExitButton1.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton1.Name = "ExitButton1";
            this.ExitButton1.Size = new System.Drawing.Size(122, 40);
            this.ExitButton1.TabIndex = 2;
            this.ExitButton1.Text = "סגירה";
            this.ExitButton1.UseVisualStyleBackColor = false;
            this.ExitButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlertGroupLabel
            // 
            this.AlertGroupLabel.AutoSize = true;
            this.AlertGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlertGroupLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F);
            this.AlertGroupLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AlertGroupLabel.Location = new System.Drawing.Point(11, 9);
            this.AlertGroupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlertGroupLabel.Name = "AlertGroupLabel";
            this.AlertGroupLabel.Size = new System.Drawing.Size(97, 41);
            this.AlertGroupLabel.TabIndex = 3;
            this.AlertGroupLabel.Text = "label1";
            this.AlertGroupLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Alert_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 585);
            this.Controls.Add(this.AlertGroupLabel);
            this.Controls.Add(this.ExitButton1);
            this.Controls.Add(this.EditButton1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alert_Display";
            this.Text = "Alert_Display";
            this.Load += new System.EventHandler(this.Alert_Display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditButton1;
        private System.Windows.Forms.Button ExitButton1;
        private System.Windows.Forms.Label AlertGroupLabel;
    }
}