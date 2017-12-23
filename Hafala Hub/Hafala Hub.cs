using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class HafalaHub : Form
    {
        // Variables definitions:
        Point lastClick;
        public static string DirectoryPath = @"E:\DB\";

        // Initializing application:
        public HafalaHub()
        {
            InitializeComponent();
        }

        // 2 Functions that enable form movement by mouse interaction.
        private void HafalaHub_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void HafalaHub_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        // 2 Functions that enable form movement by mouse interaction.
        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        // Upper X buttun exit function:
        private void UpperExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 2 Functions that enable form movement by mouse interaction.
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        
        // Menu button tab properties changes.
        private void MenuButton_CheckedChanged(object sender, EventArgs e)
        {
            MenuButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            page_Menu1.BringToFront();
        }

        // Alerts archive button tab properties changes.
        private void AlertsArchiveButton_CheckedChanged(object sender, EventArgs e)
        {
            AlertsArchiveButton.ForeColor = Color.DodgerBlue;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            page_AlertsArchive1.BringToFront();
        }

        // Filesystems automation button tab properties changes.
        private void FSAutoButton_CheckedChanged(object sender, EventArgs e)
        {
            FSAutoButton.ForeColor = Color.DodgerBlue;
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            page_FSAuto1.BringToFront();
        }

        // Contact list button tab properties changes.
        private void ContactListButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DodgerBlue;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            page_Contactlist1.BringToFront();
        }

        // Tools button tab properties changes.
        private void ToolsButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DodgerBlue;
            ExitButton.ForeColor = Color.DimGray;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            page_Tools1.BringToFront();
        }

        // Menu button tab properties changes & exit function.
        private void ExitButton_CheckedChanged(object sender, EventArgs e)
        {
            ContactListButton.ForeColor = Color.DimGray;
            ToolsButton.ForeColor = Color.DimGray;
            ExitButton.ForeColor = Color.DodgerBlue;
            AlertsArchiveButton.ForeColor = Color.DimGray;
            MenuButton.ForeColor = Color.DimGray;
            FSAutoButton.ForeColor = Color.DimGray;
            Application.Exit();
        }

        // Upper _ buttun minimize function:
        private void UpperMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 2 Functions that enable form movement by mouse interaction.
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        // 2 Functions that enable form movement by mouse interaction.
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
    }
}