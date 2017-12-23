using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hafala_Hub.Properties;

namespace Hafala_Hub
{
    public partial class Page_Tools : UserControl
    {
        public static string PathPutty;
        public static string PathVC;
        public static string PathEB;
        public static string PathShifts;

        public Page_Tools()
        {
            InitializeComponent();
            PathPutty = Settings.Default["PuttyPath"].ToString();
            PathVC = Settings.Default["VCPath"].ToString();
            PathEB = Settings.Default["EBPath"].ToString();
            PathShifts = Settings.Default["ShiftsPath"].ToString();
        }

        private void DNSIPTextBox_Enter(object sender, EventArgs e)
        {
            if (DNSIPTextBox.Text == "DNS או כתובת IP")
            {
                DNSIPTextBox.Text = "";
                DNSIPTextBox.ForeColor = Color.Black;
            }
        }

        private void MstscButton_MouseEnter(object sender, EventArgs e)
        {
            MstscImageButton.Size = new System.Drawing.Size(110, 110);
            MstscButton.ForeColor = Color.DodgerBlue;
            MstscImageButton.Location = new Point(MstscImageButton.Location.X - 2, MstscImageButton.Location.Y - 2);
        }

        private void MstscButton_MouseLeave(object sender, EventArgs e)
        {
            MstscImageButton.Size = new System.Drawing.Size(105, 105);
            MstscButton.ForeColor = Color.Black;
            MstscImageButton.Location = new Point(MstscImageButton.Location.X + 2, MstscImageButton.Location.Y + 2);
        }

        private void MstscImageButton_MouseEnter(object sender, EventArgs e)
        {
            MstscImageButton.Size = new System.Drawing.Size(110, 110);
            MstscButton.ForeColor = Color.DodgerBlue;
            MstscImageButton.Location = new Point(MstscImageButton.Location.X - 2, MstscImageButton.Location.Y - 2);
        }

        private void MstscImageButton_MouseLeave(object sender, EventArgs e)
        {
            MstscImageButton.Size = new System.Drawing.Size(105, 105);
            MstscButton.ForeColor = Color.Black;
            MstscImageButton.Location = new Point(MstscImageButton.Location.X + 2, MstscImageButton.Location.Y + 2);
        }

        private void MstscImageButton_Click(object sender, EventArgs e)
        {
            if (DNSIPTextBox.Text.Equals("") || DNSIPTextBox.Text.Equals("DNS או כתובת IP"))
            {
                System.Diagnostics.Process.Start("mstsc.exe");
            }
            else
            {
                System.Diagnostics.Process.Start("mstsc.exe", "/v:" + DNSIPTextBox.Text);
            }
        }
        private void MstscButton_Click(object sender, EventArgs e)
        {
            {
                if (DNSIPTextBox.Text.Equals("") || DNSIPTextBox.Text.Equals("DNS או כתובת IP"))
                {
                    System.Diagnostics.Process.Start("mstsc.exe");
                }
                else
                {
                    System.Diagnostics.Process.Start("mstsc.exe", "/v:" + DNSIPTextBox.Text);
                }
            }
        }

        private void PuttyButton_MouseEnter(object sender, EventArgs e)
        {
            PuttyImageButton.Size = new System.Drawing.Size(110, 110);
            PuttyButton.ForeColor = Color.DodgerBlue;
            PuttyImageButton.Location = new Point(PuttyImageButton.Location.X - 2, PuttyImageButton.Location.Y - 2);
        }

        private void PuttyButton_MouseLeave(object sender, EventArgs e)
        {
            PuttyImageButton.Size = new System.Drawing.Size(105, 105);
            PuttyButton.ForeColor = Color.Black;
            PuttyImageButton.Location = new Point(PuttyImageButton.Location.X + 2, PuttyImageButton.Location.Y + 2);
        }

        private void PuttyImageButton_MouseEnter(object sender, EventArgs e)
        {
            PuttyImageButton.Size = new System.Drawing.Size(110, 110);
            PuttyButton.ForeColor = Color.DodgerBlue;
            PuttyImageButton.Location = new Point(PuttyImageButton.Location.X - 2, PuttyImageButton.Location.Y - 2);
        }

        private void PuttyImageButton_MouseLeave(object sender, EventArgs e)
        {
            PuttyImageButton.Size = new System.Drawing.Size(105, 105);
            PuttyButton.ForeColor = Color.Black;
            PuttyImageButton.Location = new Point(PuttyImageButton.Location.X + 2, PuttyImageButton.Location.Y + 2);
        }

        private void PuttyButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process putty = new System.Diagnostics.Process();

            {
                if (DNSIPTextBox.Text.Equals("") || DNSIPTextBox.Text.Equals("DNS או כתובת IP"))
                {
                    System.Diagnostics.Process.Start(@PathPutty);
                }
                else
                {
                    putty.StartInfo.FileName = @PathPutty;
                    putty.StartInfo.Arguments = string.Format("{0}@{1}", "root", DNSIPTextBox.Text);
                    putty.Start();
                }
            }
        }

        private void PuttyImageButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process putty = new System.Diagnostics.Process();

            {
                if (DNSIPTextBox.Text.Equals("") || DNSIPTextBox.Text.Equals("DNS או כתובת IP"))
                {
                    System.Diagnostics.Process.Start(@PathPutty);
                }
                else
                {
                    putty.StartInfo.FileName = @PathPutty;
                    putty.StartInfo.Arguments = string.Format("{0}@{1}", "root", DNSIPTextBox.Text);
                    putty.Start();
                }
            }
        }

        private void vSphereButton_MouseEnter(object sender, EventArgs e)
        {
            vSphereImageButton.Size = new System.Drawing.Size(135, 135);
            vSphereButton.ForeColor = Color.DodgerBlue;
            vSphereImageButton.Location = new Point(vSphereImageButton.Location.X - 2, vSphereImageButton.Location.Y - 2);
        }

        private void vSphereButton_MouseLeave(object sender, EventArgs e)
        {
            vSphereImageButton.Size = new System.Drawing.Size(130, 130);
            vSphereButton.ForeColor = Color.Black;
            vSphereImageButton.Location = new Point(vSphereImageButton.Location.X + 2, vSphereImageButton.Location.Y + 2);
        }

        private void vSphereImageButton_MouseEnter(object sender, EventArgs e)
        {
            vSphereImageButton.Size = new System.Drawing.Size(135, 135);
            vSphereButton.ForeColor = Color.DodgerBlue;
            vSphereImageButton.Location = new Point(vSphereImageButton.Location.X - 2, vSphereImageButton.Location.Y - 2);
        }

        private void vSphereImageButton_MouseLeave(object sender, EventArgs e)
        {
            vSphereImageButton.Size = new System.Drawing.Size(130, 130);
            vSphereButton.ForeColor = Color.Black;
            vSphereImageButton.Location = new Point(vSphereImageButton.Location.X + 2, vSphereImageButton.Location.Y + 2);
        }

        private void vSphereButton_Click(object sender, EventArgs e)
        {

        }

        private void vSphereImageButton_Click(object sender, EventArgs e)
        {

        }

        private void PanoramaButton_MouseEnter(object sender, EventArgs e)
        {
            PanoramaImageButton.Size = new System.Drawing.Size(105, 105);
            PanoramaButton.ForeColor = Color.DodgerBlue;
            PanoramaImageButton.Location = new Point(PanoramaImageButton.Location.X - 2, PanoramaImageButton.Location.Y - 2);
        }

        private void PanoramaButton_MouseLeave(object sender, EventArgs e)
        {
            PanoramaImageButton.Size = new System.Drawing.Size(100, 100);
            PanoramaButton.ForeColor = Color.Black;
            PanoramaImageButton.Location = new Point(PanoramaImageButton.Location.X + 2, PanoramaImageButton.Location.Y + 2);
        }

        private void PanoramaImageButton_MouseEnter(object sender, EventArgs e)
        {
            PanoramaImageButton.Size = new System.Drawing.Size(105, 105);
            PanoramaButton.ForeColor = Color.DodgerBlue;
            PanoramaImageButton.Location = new Point(PanoramaImageButton.Location.X - 2, PanoramaImageButton.Location.Y - 2);
        }

        private void PanoramaImageButton_MouseLeave(object sender, EventArgs e)
        {
            PanoramaImageButton.Size = new System.Drawing.Size(100, 100);
            PanoramaButton.ForeColor = Color.Black;
            PanoramaImageButton.Location = new Point(PanoramaImageButton.Location.X + 2, PanoramaImageButton.Location.Y + 2);
        }

        private void ConfluenceButton_MouseEnter(object sender, EventArgs e)
        {
            ConfluenceImageButton.Size = new System.Drawing.Size(105, 105);
            ConfluenceButton.ForeColor = Color.DodgerBlue;
            ConfluenceImageButton.Location = new Point(ConfluenceImageButton.Location.X - 2, ConfluenceImageButton.Location.Y - 2);
        }

        private void ConfluenceButton_MouseLeave(object sender, EventArgs e)
        {
            ConfluenceImageButton.Size = new System.Drawing.Size(100, 100);
            ConfluenceButton.ForeColor = Color.Black;
            ConfluenceImageButton.Location = new Point(ConfluenceImageButton.Location.X + 2, ConfluenceImageButton.Location.Y + 2);
        }
        private void ConfluenceImageButton_MouseEnter(object sender, EventArgs e)
        {
            ConfluenceImageButton.Size = new System.Drawing.Size(105, 105);
            ConfluenceButton.ForeColor = Color.DodgerBlue;
            ConfluenceImageButton.Location = new Point(ConfluenceImageButton.Location.X - 2, ConfluenceImageButton.Location.Y - 2);
        }

        private void ConfluenceImageButton_MouseLeave(object sender, EventArgs e)
        {
            ConfluenceImageButton.Size = new System.Drawing.Size(100, 100);
            ConfluenceButton.ForeColor = Color.Black;
            ConfluenceImageButton.Location = new Point(ConfluenceImageButton.Location.X + 2, ConfluenceImageButton.Location.Y + 2);
        }

        private void KonanimButton_MouseEnter(object sender, EventArgs e)
        {
            KonanimImageButton.Size = new System.Drawing.Size(105, 105);
            KonanimButton.ForeColor = Color.DodgerBlue;
            KonanimImageButton.Location = new Point(KonanimImageButton.Location.X - 2, KonanimImageButton.Location.Y - 2);
        }

        private void KonanimButton_MouseLeave(object sender, EventArgs e)
        {
            KonanimImageButton.Size = new System.Drawing.Size(100, 100);
            KonanimButton.ForeColor = Color.Black;
            KonanimImageButton.Location = new Point(KonanimImageButton.Location.X + 2, KonanimImageButton.Location.Y + 2);
        }
        private void KonanimImageButton_MouseEnter(object sender, EventArgs e)
        {
            KonanimImageButton.Size = new System.Drawing.Size(105, 105);
            KonanimButton.ForeColor = Color.DodgerBlue;
            KonanimImageButton.Location = new Point(KonanimImageButton.Location.X - 2, KonanimImageButton.Location.Y - 2);
        }

        private void KonanimImageButton_MouseLeave(object sender, EventArgs e)
        {
            KonanimImageButton.Size = new System.Drawing.Size(100, 100);
            KonanimButton.ForeColor = Color.Black;
            KonanimImageButton.Location = new Point(KonanimImageButton.Location.X + 2, KonanimImageButton.Location.Y + 2);
        }

        private void MalaButton_MouseEnter(object sender, EventArgs e)
        {
            MalaImageButton.Size = new System.Drawing.Size(105, 105);
            MalaButton.ForeColor = Color.DodgerBlue;
            MalaImageButton.Location = new Point(MalaImageButton.Location.X - 2, MalaImageButton.Location.Y - 2);
        }

        private void MalaButton_MouseLeave(object sender, EventArgs e)
        {
            MalaImageButton.Size = new System.Drawing.Size(100, 100);
            MalaButton.ForeColor = Color.Black;
            MalaImageButton.Location = new Point(MalaImageButton.Location.X + 2, MalaImageButton.Location.Y + 2);
        }

        private void MalaImageButton_MouseEnter(object sender, EventArgs e)
        {
            MalaImageButton.Size = new System.Drawing.Size(105, 105);
            MalaButton.ForeColor = Color.DodgerBlue;
            MalaImageButton.Location = new Point(MalaImageButton.Location.X - 2, MalaImageButton.Location.Y - 2);
        }

        private void MalaImageButton_MouseLeave(object sender, EventArgs e)
        {
            MalaImageButton.Size = new System.Drawing.Size(100, 100);
            MalaButton.ForeColor = Color.Black;
            MalaImageButton.Location = new Point(MalaImageButton.Location.X + 2, MalaImageButton.Location.Y + 2);
        }

        private void WhiteNightButton_MouseEnter(object sender, EventArgs e)
        {
            WhiteNightImageButton.Size = new System.Drawing.Size(105, 105);
            WhiteNightButton.ForeColor = Color.DodgerBlue;
            WhiteNightImageButton.Location = new Point(WhiteNightImageButton.Location.X - 2, WhiteNightImageButton.Location.Y - 2);
        }

        private void WhiteNightButton_MouseLeave(object sender, EventArgs e)
        {
            WhiteNightImageButton.Size = new System.Drawing.Size(100, 100);
            WhiteNightButton.ForeColor = Color.Black;
            WhiteNightImageButton.Location = new Point(WhiteNightImageButton.Location.X + 2, WhiteNightImageButton.Location.Y + 2);
        }

        private void WhiteNightImageButton_MouseEnter(object sender, EventArgs e)
        {
            WhiteNightImageButton.Size = new System.Drawing.Size(105, 105);
            WhiteNightButton.ForeColor = Color.DodgerBlue;
            WhiteNightImageButton.Location = new Point(WhiteNightImageButton.Location.X - 2, WhiteNightImageButton.Location.Y - 2);
        }

        private void WhiteNightImageButton_MouseLeave(object sender, EventArgs e)
        {
            WhiteNightImageButton.Size = new System.Drawing.Size(100, 100);
            WhiteNightButton.ForeColor = Color.Black;
            WhiteNightImageButton.Location = new Point(WhiteNightImageButton.Location.X + 2, WhiteNightImageButton.Location.Y + 2);
        }

        private void ShiftsButton_MouseEnter(object sender, EventArgs e)
        {
            ShiftsImageButton.Size = new System.Drawing.Size(135, 135);
            ShiftsButton.ForeColor = Color.DodgerBlue;
            ShiftsImageButton.Location = new Point(ShiftsImageButton.Location.X - 2, ShiftsImageButton.Location.Y - 2);
        }

        private void ShiftsButton_MouseLeave(object sender, EventArgs e)
        {
            ShiftsImageButton.Size = new System.Drawing.Size(130, 130);
            ShiftsButton.ForeColor = Color.Black;
            ShiftsImageButton.Location = new Point(ShiftsImageButton.Location.X + 2, ShiftsImageButton.Location.Y + 2);
        }

        private void ShiftsImageButton_MouseEnter(object sender, EventArgs e)
        {
            ShiftsImageButton.Size = new System.Drawing.Size(135, 135);
            ShiftsButton.ForeColor = Color.DodgerBlue;
            ShiftsImageButton.Location = new Point(ShiftsImageButton.Location.X - 2, ShiftsImageButton.Location.Y - 2);
        }

        private void ShiftsImageButton_MouseLeave(object sender, EventArgs e)
        {
            ShiftsImageButton.Size = new System.Drawing.Size(130, 130);
            ShiftsButton.ForeColor = Color.Black;
            ShiftsImageButton.Location = new Point(ShiftsImageButton.Location.X + 2, ShiftsImageButton.Location.Y + 2);
        }

        private void EBButton_MouseEnter(object sender, EventArgs e)
        {
            EBImageButton.Size = new System.Drawing.Size(135, 135);
            EBButton.ForeColor = Color.DodgerBlue;
            EBImageButton.Location = new Point(EBImageButton.Location.X - 2, EBImageButton.Location.Y - 2);
        }

        private void EBButton_MouseLeave(object sender, EventArgs e)
        {
            EBImageButton.Size = new System.Drawing.Size(130, 130);
            EBButton.ForeColor = Color.Black;
            EBImageButton.Location = new Point(EBImageButton.Location.X + 2, EBImageButton.Location.Y + 2);
        }

        private void EBImageButton_MouseEnter(object sender, EventArgs e)
        {
            EBImageButton.Size = new System.Drawing.Size(135, 135);
            EBButton.ForeColor = Color.DodgerBlue;
            EBImageButton.Location = new Point(EBImageButton.Location.X - 2, EBImageButton.Location.Y - 2);
        }

        private void EBImageButton_MouseLeave(object sender, EventArgs e)
        {
            EBImageButton.Size = new System.Drawing.Size(130, 130);
            EBButton.ForeColor = Color.Black;
            EBImageButton.Location = new Point(EBImageButton.Location.X + 2, EBImageButton.Location.Y + 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToolsSettings toolsSettings = new ToolsSettings();
            toolsSettings.Show();
        }
    }
}
