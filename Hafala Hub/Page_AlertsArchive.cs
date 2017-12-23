using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hafala_Hub
{
    public partial class Page_AlertsArchive : UserControl
    {
        // Variables definitions:
        public static string passingText;
        public static string passingAlertGroup;
        public static string passingPath;
        private static string[] names = Directory.GetFiles(HafalaHub.DirectoryPath, "*.txt");
        Point lastclick;

        // Initializing Alerts archive page:
        public Page_AlertsArchive()
        {
            InitializeComponent();
        }

        // Shows the "New Alert" form:
        private void AddButton_Click(object sender, EventArgs e)
        {
            New_Alert NewAlert = new New_Alert();
            NewAlert.Show();
        }

        // Shows the "New Alert" form:
        private void AddFileImageButton_Click(object sender, EventArgs e)
        {
            New_Alert NewAlert = new New_Alert();
            NewAlert.Show();
        }

        // Shows the "ReadEditPanel" panel:
        private void ReadEditButton_Click(object sender, EventArgs e)
        {
            foreach (string name in names)
            {
                AlertGroupList.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
            ReadEditPanel.Show();
        }

        // Shows the "ReadEditPanel" panel:
        private void SearchOrEditImageButton_Click(object sender, EventArgs e)
        {
            foreach (string name in names)
            {
                AlertGroupList.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
            ReadEditPanel.Show();
        }

        // Search button clicked events:
        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool flag = File.Exists(HafalaHub.DirectoryPath + SearchTxtBox.Text + ".txt"); // A boolean value that indicates if the desired file exists.

            // If the file exists then it's opening the alert display form and if not it's showing host an error messege:
            if (flag)
            {
                string AlertText = File.ReadAllText(HafalaHub.DirectoryPath + SearchTxtBox.Text + ".txt");
                passingText = AlertText;
                passingAlertGroup = SearchTxtBox.Text;
                passingPath = HafalaHub.DirectoryPath + SearchTxtBox.Text + ".txt";
                Alert_Display alert_Display = new Alert_Display();
                alert_Display.Show();
            }
            else
            {
                if (SearchTxtBox.Text == "")
                {
                    MessageBox.Show("Plese insert an alert group identifier!"
                      , "oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("The alertgroup you have inserted is either wrong or doesn't exist yet in the archive."
                      , "oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            // ----------------------------------------------------------------------------------------------------------
        }

        // Open button clicked events:
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (AlertGroupList.SelectedItem == null)
            {
                return;
            }
            string curAlertGroup = AlertGroupList.SelectedItem.ToString();
            passingText = File.ReadAllText(HafalaHub.DirectoryPath + curAlertGroup + ".txt");
            passingAlertGroup = curAlertGroup;
            passingPath = HafalaHub.DirectoryPath + curAlertGroup + ".txt";
            Alert_Display alert_Display = new Alert_Display();
            alert_Display.Show();

        }

        // Back button clicked events:
        private void BackButton1_Click(object sender, EventArgs e)
        {
            AlertGroupList.Items.Clear();
            ReadEditPanel.Visible = false;
        }

        // ----------------------------------------------------------------------------------------------------------
        // Buttons UI design functions.
        private void ReadEditButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
            SearchOrEditImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void ReadEditButton_MouseDown(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
            SearchOrEditImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
            AddFileImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
            AddFileImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void ReadEditButton_MouseLeave(object sender, EventArgs e)
        {
            ReadEditButton.ForeColor = Color.DimGray;
            SearchOrEditImageButton.Size = new System.Drawing.Size(203, 254);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.DimGray;
            AddFileImageButton.Size = new System.Drawing.Size(203, 254);
        }

        private void SearchOrEditImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
            SearchOrEditImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void SearchOrEditImageButton_MouseLeave(object sender, EventArgs e)
        {
            ReadEditButton.ForeColor = Color.DimGray;
            SearchOrEditImageButton.Size = new System.Drawing.Size(203, 254);
        }

        private void SearchOrEditImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            ReadEditButton.ForeColor = Color.DodgerBlue;
            SearchOrEditImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void AddFileImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
            AddFileImageButton.Size = new System.Drawing.Size(208, 259);
        }

        private void AddFileImageButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.DimGray;
            AddFileImageButton.Size = new System.Drawing.Size(203, 254);
        }

        private void AddFileImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButton.ForeColor = Color.DodgerBlue;
            AddFileImageButton.Size = new System.Drawing.Size(208, 259);


        }
        // ----------------------------------------------------------------------------------------------------------


        // ----------------------------------------------------------------------------------------------------------
        // User control mouse move causes full form movement:
        private void Page_AlertsArchive_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void Page_AlertsArchive_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }

        private void ReadEditPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void ReadEditPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        // ----------------------------------------------------------------------------------------------------------

    }
}
