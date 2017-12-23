using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hafala_Hub
{
    public partial class Page_Menu : UserControl
    {
        int Count;

        public Page_Menu()
        {
            InitializeComponent();
            Activity.InitializeDB();
            LoadAll();
            if (Count > 0)
            {
                Activity1Panel.Visible = true;
                Activity1AddImageButton.Visible = false;
                Activity2Panel.Visible = true;
                Activity2AddImageButton.Visible = false;
            }
            else
            {
                return;
            }

        }

        Point lastClick;

        private void Page_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Page_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastClick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastClick.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastClick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastClick.Y;
            }
        }

        private void LoadAll()
        {
            List<string> activitiesID = Activity.GetActivitiesID();
            ID1TextBox.Text = activitiesID[0];
            ID2TextBox.Text = activitiesID[1];
            Count = activitiesID.Count;
            List<string> activitiesHeader = Activity.GetActivitiesHeader();
            Activity1Header.Text = activitiesHeader[0];
            Activity2Header.Text = activitiesHeader[1];
            List<string> activitiesSummary = Activity.GetActivitiesSummary();
            Activity1Summary.Text = activitiesSummary[0];
            Activity2Summary.Text = activitiesSummary[1];
            List<string> activitiesLeaders = Activity.GetActivitiesLeaders();
            Leaders1TextBox.Text = activitiesLeaders[0];
            Leaders2TextBox.Text = activitiesLeaders[1];
            List<string> activitiesSeverity = Activity.GetActivitiesSeverity();
            Severity1TextBox.Text = activitiesSeverity[0];
            Severity2TextBox.Text = activitiesSeverity[1];
            List<string> activitiesStartDateTime = Activity.GetActivitiesStartDateTime();
            StartDateTime1TextBox.Text = activitiesStartDateTime[0];
            StartDateTime2TextBox.Text = activitiesStartDateTime[1];
            List<string> activitiesEndDateTime = Activity.GetActivitiesEndDateTime();
            EndDateTime1TextBox.Text = activitiesEndDateTime[0];
            EndDateTime2TextBox.Text = activitiesEndDateTime[1];
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Activity1Panel.Visible = true;
            Activity1AddImageButton.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Activity2Panel.Visible = true;
            Activity2AddImageButton.Visible = false;
        }
    }
}
