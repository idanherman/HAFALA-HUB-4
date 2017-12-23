using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hafala_Hub
{
    public partial class New_Alert : Form
    {
        Point lastClick;
        public New_Alert()
        {
            InitializeComponent();
        }


        private string AGTEXT = "הדבק כאן את הערך 'Alert Group' מהפנורמה.";
        private string DESCTEXT = "פרט על ההתראה כך שמפעילים אחרים ידעו מה משמעותה...";
        private string SLNTEXT = "ספק פתרון אחד לפחות שיעלים את התקלה.";
        
        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            if (AlertGroupTextbox.Text == AGTEXT || DescriptionTextbox.Text == DESCTEXT || SolutionsTextbox.Text == SLNTEXT)
            {
                return;
            }
            DialogResult result;
            if (AlertGroupTextbox.Text == "")
                return;
            if (DescriptionTextbox.Text == "")
            {

                result = MessageBox.Show("You have to write a description and add solutions.", "Saving Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                    return;
            }
            if (DescriptionTextbox.Text != "")
            {
                result = MessageBox.Show("Have you finished writing everything?" + "\r\n" + "Also, make sure your info is correct and valid.", "Confirm Saving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                String AlertGroup = AlertGroupTextbox.Text;
                String DirectoryPath = @"E:\DB";
                String Path = DirectoryPath + @"\" + AlertGroup + ".txt";
                String text = "Alert Description:" + "\r\n" + DescriptionTextbox.Text + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Suggested Solution: " + "\r\n" + SolutionsTextbox.Text;

                File.WriteAllText(Path, text);
                MessageBox.Show("Your alert has been added", "New Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AlertGroupTextbox.Clear();
                DescriptionTextbox.Clear();
                SolutionsTextbox.Clear();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void New_Alert_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        // ----------------------------------------------------------------------------------------------------------
        // Form movement functions:
        private void New_Alert_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        private void AlertGroupLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
        private void AlertGroupLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        private void DescriptionLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void DescriptionLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        private void SolutionLable_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void SolutionLable_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        // ----------------------------------------------------------------------------------------------------------


        // ----------------------------------------------------------------------------------------------------------
        // Focus features on alert group textbox:
        private void AlertGroupTextbox_Enter(object sender, EventArgs e)
        {
            if (AlertGroupTextbox.Text == AGTEXT)
            {
                AlertGroupTextbox.Text = "";
                AlertGroupTextbox.ForeColor = Color.Black;
            }
        }

        private void AlertGroupTextbox_Leave(object sender, EventArgs e)
        {
            if (AlertGroupTextbox.Text == "")
            {
                AlertGroupTextbox.Text = AGTEXT;
                AlertGroupTextbox.ForeColor = Color.DimGray;
            }
        }
        // ----------------------------------------------------------------------------------------------------------

        // ----------------------------------------------------------------------------------------------------------
        // Focus features on description textbox:
        private void DescriptionTextbox_Enter(object sender, EventArgs e)
        {
            if (DescriptionTextbox.Text == DESCTEXT)
            {
                DescriptionTextbox.Text = "";
                DescriptionTextbox.ForeColor = Color.Black;
            }
        }

        private void DescriptionTextbox_Leave(object sender, EventArgs e)
        {
            if (DescriptionTextbox.Text == "")
            {
                DescriptionTextbox.Text = DESCTEXT;
                DescriptionTextbox.ForeColor = Color.DimGray;
            }
        }
        // ----------------------------------------------------------------------------------------------------------

        // ----------------------------------------------------------------------------------------------------------
        // Focus features on solutions textbox:
        private void SolutionsTextbox_Enter(object sender, EventArgs e)
        {
            if (SolutionsTextbox.Text == SLNTEXT)
            {
                SolutionsTextbox.Text = "";
                SolutionsTextbox.ForeColor = Color.Black;
            }
        }

        private void SolutionsTextbox_Leave(object sender, EventArgs e)
        {
            if (SolutionsTextbox.Text == "")
            {
                SolutionsTextbox.Text = SLNTEXT;
                SolutionsTextbox.ForeColor = Color.DimGray;
            }
        }
        // ----------------------------------------------------------------------------------------------------------
    }
}
