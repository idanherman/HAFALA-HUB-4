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
        int startedActivitiesCount;

        List<Activity> activities = new List<Activity>();

        public Page_Menu()
        {
            InitializeComponent();
            DataBaseQueries.InitializeDB();
            updateActivities();
        }


        Point lastClick;
        public void updateActivities()
        {
            List<string> activitiesID = DataBaseQueries.GetActivitiesID();
            startedActivitiesCount = activitiesID.Count;

            switch (this.startedActivitiesCount)
            {
                case 0:
                    Activity1Panel.Visible = false;
                    Activity1AddImageButton.Visible = true;
                    Activity2Panel.Visible = false;
                    Activity2AddImageButton.Visible = true;
                    Activity3Panel.Visible = false;
                    Activity3AddImageButton.Visible = true;
                    Activity4Panel.Visible = false;
                    Activity4AddImageButton.Visible = true;
                    break;
                case 1:
                    Activity1Panel.Visible = true;
                    Activity1AddImageButton.Visible = false;
                    Activity2Panel.Visible = false;
                    Activity2AddImageButton.Visible = true;
                    Activity3Panel.Visible = false;
                    Activity3AddImageButton.Visible = true;
                    Activity4Panel.Visible = false;
                    Activity4AddImageButton.Visible = true;
                    activities = DataBaseQueries.getActivities();
                    Activity1Header.Text = activities[0].header;
                    Activity1Summary.Text = activities[0].summary;
                    Leaders1TextBox.Text = activities[0].leaders;
                    Inserter1TextBox.Text = activities[0].inserter;
                    Severity1TextBox.Text = activities[0].severity.ToString();
                    ID1TextBox.Text = activities[0].ID.ToString();
                    StartDateTime1TextBox.Text = activities[0].StartDateTime.ToString();
                    EndDateTime1TextBox.Text = activities[0].EndDateTime.ToString();
                    break;
                case 2:
                    Activity1Panel.Visible = true;
                    Activity1AddImageButton.Visible = false;
                    Activity2Panel.Visible = true;
                    Activity2AddImageButton.Visible = false;
                    Activity3Panel.Visible = false;
                    Activity3AddImageButton.Visible = true;
                    Activity4Panel.Visible = false;
                    Activity4AddImageButton.Visible = true;
                    activities = DataBaseQueries.getActivities();

                    Activity1Header.Text = activities[0].header;
                    Activity1Summary.Text = activities[0].summary;
                    Leaders1TextBox.Text = activities[0].leaders;
                    Severity1TextBox.Text = activities[0].severity.ToString();
                    Inserter1TextBox.Text = activities[0].inserter;
                    ID1TextBox.Text = activities[0].ID.ToString();
                    StartDateTime1TextBox.Text = activities[0].StartDateTime.ToString();
                    EndDateTime1TextBox.Text = activities[0].EndDateTime.ToString();

                    Activity2Header.Text = activities[1].header;
                    Activity2Summary.Text = activities[1].summary;
                    Leaders2TextBox.Text = activities[1].leaders;
                    Severity2TextBox.Text = activities[1].severity.ToString();
                    Inserter2TextBox.Text = activities[1].inserter;
                    ID2TextBox.Text = activities[1].ID.ToString();
                    StartDateTime2TextBox.Text = activities[1].StartDateTime.ToString();
                    EndDateTime2TextBox.Text = activities[1].EndDateTime.ToString();
                    break;
                case 3:
                    Activity1Panel.Visible = true;
                    Activity1AddImageButton.Visible = false;
                    Activity2Panel.Visible = true;
                    Activity2AddImageButton.Visible = false;
                    Activity3Panel.Visible = true;
                    Activity3AddImageButton.Visible = false;
                    Activity4Panel.Visible = false;
                    Activity4AddImageButton.Visible = true;
                    activities = DataBaseQueries.getActivities();
                    Activity1Header.Text = activities[0].header;
                    Activity1Summary.Text = activities[0].summary;
                    Leaders1TextBox.Text = activities[0].leaders;
                    Severity1TextBox.Text = activities[0].severity.ToString();
                    Inserter1TextBox.Text = activities[0].inserter;
                    ID1TextBox.Text = activities[0].ID.ToString();
                    StartDateTime1TextBox.Text = activities[0].StartDateTime.ToString();
                    EndDateTime1TextBox.Text = activities[0].EndDateTime.ToString();

                    Activity2Header.Text = activities[1].header;
                    Activity2Summary.Text = activities[1].summary;
                    Leaders2TextBox.Text = activities[1].leaders;
                    Severity2TextBox.Text = activities[1].severity.ToString();
                    Inserter2TextBox.Text = activities[1].inserter;
                    ID2TextBox.Text = activities[1].ID.ToString();
                    StartDateTime2TextBox.Text = activities[1].StartDateTime.ToString();
                    EndDateTime2TextBox.Text = activities[1].EndDateTime.ToString();

                    Activity3Header.Text = activities[2].header;
                    Activity3Summary.Text = activities[2].summary;
                    Leaders3TextBox.Text = activities[2].leaders;
                    Severity3TextBox.Text = activities[2].severity.ToString();
                    Inserter3TextBox.Text = activities[2].inserter;
                    ID3TextBox.Text = activities[2].ID.ToString();
                    StartDateTime3TextBox.Text = activities[2].StartDateTime.ToString();
                    EndDateTime3TextBox.Text = activities[2].EndDateTime.ToString();
                    break;
                case 4:
                    Activity1Panel.Visible = true;
                    Activity1AddImageButton.Visible = false;
                    Activity2Panel.Visible = true;
                    Activity2AddImageButton.Visible = false;
                    Activity3Panel.Visible = true;
                    Activity3AddImageButton.Visible = false;
                    Activity4Panel.Visible = true;
                    Activity4AddImageButton.Visible = false;
                    activities = DataBaseQueries.getActivities();
                    Activity1Header.Text = activities[0].header;
                    Activity1Summary.Text = activities[0].summary;
                    Leaders1TextBox.Text = activities[0].leaders;
                    Severity1TextBox.Text = activities[0].severity.ToString();
                    Inserter1TextBox.Text = activities[0].inserter;
                    ID1TextBox.Text = activities[0].ID.ToString();
                    StartDateTime1TextBox.Text = activities[0].StartDateTime.ToString();
                    EndDateTime1TextBox.Text = activities[0].EndDateTime.ToString();

                    Activity2Header.Text = activities[1].header;
                    Activity2Summary.Text = activities[1].summary;
                    Leaders2TextBox.Text = activities[1].leaders;
                    Severity2TextBox.Text = activities[1].severity.ToString();
                    Inserter2TextBox.Text = activities[1].inserter;
                    ID2TextBox.Text = activities[1].ID.ToString();
                    StartDateTime2TextBox.Text = activities[1].StartDateTime.ToString();
                    EndDateTime2TextBox.Text = activities[1].EndDateTime.ToString();

                    Activity3Header.Text = activities[2].header;
                    Activity3Summary.Text = activities[2].summary;
                    Leaders3TextBox.Text = activities[2].leaders;
                    Severity3TextBox.Text = activities[2].severity.ToString();
                    Inserter3TextBox.Text = activities[2].inserter;
                    ID3TextBox.Text = activities[2].ID.ToString();
                    StartDateTime3TextBox.Text = activities[2].StartDateTime.ToString();
                    EndDateTime3TextBox.Text = activities[2].EndDateTime.ToString();

                    Activity4Header.Text = activities[3].header;
                    Activity4Summary.Text = activities[3].summary;
                    Leaders4TextBox.Text = activities[3].leaders;
                    Severity4TextBox.Text = activities[3].severity.ToString();
                    Inserter4TextBox.Text = activities[3].inserter;
                    ID4TextBox.Text = activities[3].ID.ToString();
                    StartDateTime4TextBox.Text = activities[3].StartDateTime.ToString();
                    EndDateTime4TextBox.Text = activities[3].EndDateTime.ToString();
                    break;
                default:
                    Activity1Panel.Visible = false;
                    Activity1AddImageButton.Visible = true;
                    Activity2Panel.Visible = false;
                    Activity2AddImageButton.Visible = true;
                    Activity3Panel.Visible = false;
                    Activity3AddImageButton.Visible = true;
                    Activity4Panel.Visible = false;
                    Activity4AddImageButton.Visible = true;
                    activities = DataBaseQueries.getActivities();
                    break;
            }
        }

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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            updateActivities();
        }

        private void Activity1AddImageButton_Click(object sender, EventArgs e)
        {
            Activity1Panel.Visible = true;
            Activity1AddImageButton.Visible = false;
            New_Activity NewActivity = new New_Activity();
            NewActivity.Show();
        }

        private void Activity2AddImageButton_Click(object sender, EventArgs e)
        {
            Activity2Panel.Visible = true;
            Activity2AddImageButton.Visible = false;
            New_Activity NewActivity = new New_Activity();
            NewActivity.Show();
        }

        private void Activity3AddImageButton_Click(object sender, EventArgs e)
        {
            Activity3Panel.Visible = true;
            Activity3AddImageButton.Visible = false;
            New_Activity NewActivity = new New_Activity();
            NewActivity.Show();
        }

        private void Activity4AddImageButton_Click(object sender, EventArgs e)
        {
            Activity4Panel.Visible = true;
            Activity4AddImageButton.Visible = false;
            New_Activity NewActivity = new New_Activity();
            NewActivity.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            updateActivities();
        }
    }
}
