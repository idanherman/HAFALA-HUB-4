using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class New_Activity : Form
    {
        public New_Activity()
        {
            InitializeComponent();
            DataBaseQueries.InitializeDB();
            Console.WriteLine(StartDatePicker.Value.ToString("yyyy-MM-dd"));
            Console.WriteLine(StartDatePicker.Value.ToString("HH:mm:ss"));
            Console.WriteLine(StartDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        
        private string HEADERTEXT = "הכנס שם פעילות. (לא יעלה על 50 תווים)";
        private string SUMMARYTEXT = "הכנס תיאור קצר שיסביר את הפעילות והשלכותיה.";
        private string LEADERTEXT = ".הכנס את שם הגוף או האדם שמוביל/ים את הפעילות";
        private string INSERTERTEXT = "הכנס את השם המלא שלך כדי שנוכל לדעת מי יצר את מעקב הפעילות הזה.";
        private int SEVERITYLEVEL;
        private char STARTED;
        private char PAUSED;
        private char STOPPED;
        string StartDateTime;
        string EndDateTime;
        Page_Menu Menu = new Page_Menu();
        Activity newactivity;



        private void NewActivityHeaderTextBox_Enter(object sender, EventArgs e)
        {
            if (NewActivityHeaderTextBox.Text == HEADERTEXT)
            {
                NewActivityHeaderTextBox.Text = "";
                NewActivityHeaderTextBox.ForeColor = Color.Black;
            }
        }

        private void NewActivityHeaderTextBox_Leave(object sender, EventArgs e)
        {
            if (NewActivityHeaderTextBox.Text == "")
            {
                NewActivityHeaderTextBox.Text = HEADERTEXT;
                NewActivityHeaderTextBox.ForeColor = Color.DimGray;
            }

        }

        private void NewActivitySummaryTextBox_Enter(object sender, EventArgs e)
        {
            if (NewActivitySummaryTextBox.Text == SUMMARYTEXT)
            {
                NewActivitySummaryTextBox.Text = "";
                NewActivitySummaryTextBox.ForeColor = Color.Black;
            }
        }
        private void NewActivitySummaryTextBox_Leave(object sender, EventArgs e)
        {
            if (NewActivitySummaryTextBox.Text == "")
            {
                NewActivitySummaryTextBox.Text = SUMMARYTEXT;
                NewActivitySummaryTextBox.ForeColor = Color.DimGray;
            }

        }
        private void NewActivityLeadersTextBox_Enter(object sender, EventArgs e)
        {
            if (NewActivityLeadersTextBox.Text == LEADERTEXT)
            {
                NewActivityLeadersTextBox.Text = "";
                NewActivityLeadersTextBox.ForeColor = Color.Black;
            }
        }

        private void NewActivityLeadersTextBox_Leave(object sender, EventArgs e)
        {
            if (NewActivityLeadersTextBox.Text == "")
            {
                NewActivityLeadersTextBox.Text = LEADERTEXT;
                NewActivityLeadersTextBox.ForeColor = Color.DimGray;
            }
        }

        private void NewActivityInserterTextBox_Enter(object sender, EventArgs e)
        {
            if (NewActivityInserterTextBox.Text == INSERTERTEXT)
            {
                NewActivityInserterTextBox.Text = "";
                NewActivityInserterTextBox.ForeColor = Color.Black;
            }
        }

        private void NewActivityInserterTextBox_Leave(object sender, EventArgs e)
        {
            if (NewActivityInserterTextBox.Text == "")
            {
                NewActivityInserterTextBox.Text = INSERTERTEXT;
                NewActivityInserterTextBox.ForeColor = Color.DimGray;
            }
        }

        private void NowDateTimeButton_Click(object sender, EventArgs e)
        {
            StartDatePicker.Value = DateTime.Now;
            StartTimePicker.Value = DateTime.Now;
            //StartDateTime = StartDatePicker.Value.Date + StartTimePicker.Value.TimeOfDay;
        }

        private void SaveActivity_Button_Click(object sender, EventArgs e)
        {
            HEADERTEXT = NewActivityHeaderTextBox.Text;
            SUMMARYTEXT = NewActivitySummaryTextBox.Text;
            LEADERTEXT = NewActivityLeadersTextBox.Text;
            INSERTERTEXT = NewActivityInserterTextBox.Text;
            //StartDateTime = StartDatePicker.Value.Date + StartTimePicker.Value.TimeOfDay;
            StartDateTime = StartDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //EndDateTime = EndDatePicker.Value.Date + EndTimePicker.Value.TimeOfDay;
            EndDateTime = StartDatePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            STARTED = 'Y';
            PAUSED = 'N';
            STOPPED = 'N';
            Console.WriteLine(StartDatePicker.Value.ToString("yyyy - MM - dd"));
            DialogResult result;
            result = MessageBox.Show("וודא שפרטי הפעילות נכונים, אם אכן כך, בחר ב'OK'", "וודא אמיתות הפרטים", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                newactivity = DataBaseQueries.Insert(HEADERTEXT, SUMMARYTEXT, SEVERITYLEVEL, INSERTERTEXT, LEADERTEXT, StartDateTime, EndDateTime, STARTED, PAUSED, STOPPED);
                this.Close();
            }

        }
        
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShutDownRadioButton_Click(object sender, EventArgs e)
        {
            SEVERITYLEVEL = 1;
        }

        private void DisturbingRadioButton_Click(object sender, EventArgs e)
        {
            SEVERITYLEVEL = 2;
        }

        private void SurvivabiltyRadioButton_Click(object sender, EventArgs e)
        {
            SEVERITYLEVEL = 3;
        }

        private void NoEffectRadioButton_Click(object sender, EventArgs e)
        {
            SEVERITYLEVEL = 4;
        }
    }
}
