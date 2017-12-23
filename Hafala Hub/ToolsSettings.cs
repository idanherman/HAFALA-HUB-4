using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Hafala_Hub.Properties;

namespace Hafala_Hub
{
    public partial class ToolsSettings : Form
    {

        public ToolsSettings()
        {
                InitializeComponent();
                PuttyPath.Text = Settings.Default["PuttyPath"].ToString();
                VCPath.Text = Settings.Default["VCPath"].ToString();
                EBPath.Text = Settings.Default["EBPath"].ToString();
                ShiftsPath.Text = Settings.Default["ShiftsPath"].ToString();
        }

        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            Settings.Default["PuttyPath"] = PuttyPath.Text;
            Settings.Default["VCPath"] = VCPath.Text;
            Settings.Default["EBPath"] = EBPath.Text;
            Settings.Default["ShiftsPath"] = ShiftsPath.Text;
            Settings.Default.Save();
            Page_Tools.PathPutty = Settings.Default["PuttyPath"].ToString();
            Page_Tools.PathVC = Settings.Default["VCPath"].ToString();
            Page_Tools.PathEB = Settings.Default["EBPath"].ToString();
            Page_Tools.PathShifts = Settings.Default["ShiftsPath"].ToString();
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}