using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafala_Hub
{
    public partial class Page_Contactlist : UserControl
    {

        Point lastclick;

        public Page_Contactlist()
        {
            InitializeComponent();
        }



        // ------------------------------------------------------------------------------------------------------------------------------
        //
        private void Page_Contactlist_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void Page_Contactlist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void ContactListLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void ContactListLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        // ------------------------------------------------------------------------------------------------------------------------------


        // Contact list user control UI features:
        // ******************************************************************
        // IAF:
        private void IAFImageButton_MouseEnter(object sender, EventArgs e)
        {
            IAFImageButton.Size = new System.Drawing.Size(190, 190);
            IAFButton.ForeColor = Color.DodgerBlue;
            IAFImageButton.Location = new Point(IAFImageButton.Location.X - 5, IAFImageButton.Location.Y - 5);
        }
        private void IAFImageButton_MouseLeave(object sender, EventArgs e)
        {
            IAFImageButton.Size = new System.Drawing.Size(180, 180);
            IAFButton.ForeColor = Color.FromArgb(41, 47, 109);
            IAFImageButton.Location = new Point(IAFImageButton.Location.X + 5, IAFImageButton.Location.Y + 5);
        }
        private void IAFButton_MouseEnter(object sender, EventArgs e)
        {
            IAFImageButton.Size = new System.Drawing.Size(190, 190);
            IAFButton.ForeColor = Color.DodgerBlue;
            IAFImageButton.Location = new Point(IAFImageButton.Location.X - 5, IAFImageButton.Location.Y - 5);
        }
        private void IAFButton_MouseLeave(object sender, EventArgs e)
        {
            IAFImageButton.Size = new System.Drawing.Size(180, 180);
            IAFButton.ForeColor = Color.FromArgb(41, 47, 109);
            IAFImageButton.Location = new Point(IAFImageButton.Location.X + 5, IAFImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Tikshuv:
        private void TikshuvImageButton_MouseEnter(object sender, EventArgs e)
        {
            TikshuvImageButton.Size = new System.Drawing.Size(190, 190);
            TikshuvButton.ForeColor = Color.Red;
            TikshuvImageButton.Location = new Point(TikshuvImageButton.Location.X - 5, TikshuvImageButton.Location.Y - 5);
        }
        private void TikshuvImageButton_MouseLeave(object sender, EventArgs e)
        {
            TikshuvImageButton.Size = new System.Drawing.Size(180, 180);
            TikshuvButton.ForeColor = Color.FromArgb(64, 64, 64);
            TikshuvImageButton.Location = new Point(TikshuvImageButton.Location.X + 5, TikshuvImageButton.Location.Y + 5);
        }
        private void TikshuvButton_MouseEnter(object sender, EventArgs e)
        {
            TikshuvImageButton.Size = new System.Drawing.Size(190, 190);
            TikshuvButton.ForeColor = Color.Red;
            TikshuvImageButton.Location = new Point(TikshuvImageButton.Location.X - 5, TikshuvImageButton.Location.Y - 5);
        }
        private void TikshuvButton_MouseLeave(object sender, EventArgs e)
        {
            TikshuvImageButton.Size = new System.Drawing.Size(180, 180);
            TikshuvButton.ForeColor = Color.FromArgb(64, 64, 64);
            TikshuvImageButton.Location = new Point(TikshuvImageButton.Location.X + 5, TikshuvImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Navy:
        private void NavyImageButton_MouseEnter(object sender, EventArgs e)
        {
            NavyImageButton.Size = new System.Drawing.Size(190, 190);
            NavyButton.ForeColor = Color.DarkGoldenrod;
            NavyImageButton.Location = new Point(NavyImageButton.Location.X - 5, NavyImageButton.Location.Y - 5);
        }
        private void NavyImageButton_MouseLeave(object sender, EventArgs e)
        {
            NavyImageButton.Size = new System.Drawing.Size(180, 180);
            NavyButton.ForeColor = Color.FromArgb(50, 34, 51);
            NavyImageButton.Location = new Point(NavyImageButton.Location.X + 5, NavyImageButton.Location.Y + 5);
        }
        private void NavyButton_MouseEnter(object sender, EventArgs e)
        {
            NavyImageButton.Size = new System.Drawing.Size(190, 190);
            NavyButton.ForeColor = Color.DarkGoldenrod;
            NavyImageButton.Location = new Point(NavyImageButton.Location.X - 5, NavyImageButton.Location.Y - 5);
        }
        private void NavyButton_MouseLeave(object sender, EventArgs e)
        {
            NavyImageButton.Size = new System.Drawing.Size(180, 180);
            NavyButton.ForeColor = Color.FromArgb(50, 34, 51);
            NavyImageButton.Location = new Point(NavyImageButton.Location.X + 5, NavyImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Aman:
        private void AmanImageButton_MouseEnter(object sender, EventArgs e)
        {
            AmanImageButton.Size = new System.Drawing.Size(190, 190);
            AmanButton.ForeColor = Color.ForestGreen;
            AmanImageButton.Location = new Point(AmanImageButton.Location.X - 5, AmanImageButton.Location.Y - 5);
        }
        private void AmanImageButton_MouseLeave(object sender, EventArgs e)
        {
            AmanImageButton.Size = new System.Drawing.Size(180, 180);
            AmanButton.ForeColor = Color.FromArgb(64, 64, 64);
            AmanImageButton.Location = new Point(AmanImageButton.Location.X + 5, AmanImageButton.Location.Y + 5);
        }
        private void AmanButton_MouseEnter(object sender, EventArgs e)
        {
            AmanImageButton.Size = new System.Drawing.Size(190, 190);
            AmanButton.ForeColor = Color.ForestGreen;
            AmanImageButton.Location = new Point(AmanImageButton.Location.X - 5, AmanImageButton.Location.Y - 5);

        }
        private void AmanButton_MouseLeave(object sender, EventArgs e)
        {
            AmanImageButton.Size = new System.Drawing.Size(180, 180);
            AmanButton.ForeColor = Color.FromArgb(64, 64, 64);
            AmanImageButton.Location = new Point(AmanImageButton.Location.X + 5, AmanImageButton.Location.Y + 5);
        }
        // ******************************************************************
        // ------------------------------------------------------------------------------------------------------------------------------




        // ------------------------------------------------------------------------------------------------------------------------------
        // IAF Panel
        // Buttons clicked functions:
        // ******************************************************************
        private void IAFImageButton_Click(object sender, EventArgs e)
        {
            IAFPanel.Visible = true;
            IAFPanel.BringToFront();
        }
        private void IAFButton_Click(object sender, EventArgs e)
        {
            IAFPanel.Visible = true;
            IAFPanel.BringToFront();
        }
        private void IAFBackToFrstButton_Click(object sender, EventArgs e)
        {
            IAFPanel.Visible = false;
        }
        // ******************************************************************

        // Form movement feature enabled by mouse interactions:
        // ******************************************************************
        private void IAFImage_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void IAFImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void IAFLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void IAFLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void IAFPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void IAFPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void IAFKumtaColor_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void IAFKumtaColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        // ******************************************************************

        // UI mouse hover features
        // ******************************************************************
        // Latzad:
        private void LatzadButton_MouseEnter(object sender, EventArgs e)
        {
            LatzadImageButton.Size = new System.Drawing.Size(160, 160);
            LatzadButton.ForeColor = Color.DodgerBlue;
            LatzadImageButton.Location = new Point(LatzadImageButton.Location.X - 5, LatzadImageButton.Location.Y - 5);
        }
        private void LatzadButton_MouseLeave(object sender, EventArgs e)
        {
            LatzadImageButton.Size = new System.Drawing.Size(150, 150);
            LatzadButton.ForeColor = Color.FromArgb(64, 64, 64);
            LatzadImageButton.Location = new Point(LatzadImageButton.Location.X + 5, LatzadImageButton.Location.Y + 5);
        }
        private void LatzadImageButton_MouseEnter(object sender, EventArgs e)
        {
            LatzadImageButton.Size = new System.Drawing.Size(160, 160);
            LatzadButton.ForeColor = Color.DodgerBlue;
            LatzadImageButton.Location = new Point(LatzadImageButton.Location.X - 5, LatzadImageButton.Location.Y - 5);
        }
        private void LatzadImageButton_MouseLeave(object sender, EventArgs e)
        {
            LatzadImageButton.Size = new System.Drawing.Size(150, 150);
            LatzadButton.ForeColor = Color.FromArgb(64, 64, 64);
            LatzadImageButton.Location = new Point(LatzadImageButton.Location.X + 5, LatzadImageButton.Location.Y + 5);
        }
        // ******************************************************************\

        // ******************************************************************
        // Lma:
        private void LmaImageButton_MouseEnter(object sender, EventArgs e)
        {
            LmaImageButton.Size = new System.Drawing.Size(160, 160);
            LmaButton.ForeColor = Color.DodgerBlue;
            LmaImageButton.Location = new Point(LmaImageButton.Location.X - 5, LmaImageButton.Location.Y - 5);
        }
        private void LmaImageButton_MouseLeave(object sender, EventArgs e)
        {
            LmaImageButton.Size = new System.Drawing.Size(150, 150);
            LmaButton.ForeColor = Color.FromArgb(64, 64, 64);
            LmaImageButton.Location = new Point(LmaImageButton.Location.X + 5, LmaImageButton.Location.Y + 5);
        }
        private void LmaButton_MouseEnter(object sender, EventArgs e)
        {
            LmaImageButton.Size = new System.Drawing.Size(160, 160);
            LmaButton.ForeColor = Color.DodgerBlue;
            LmaImageButton.Location = new Point(LmaImageButton.Location.X - 5, LmaImageButton.Location.Y - 5);
        }
        private void LmaButton_MouseLeave(object sender, EventArgs e)
        {
            LmaImageButton.Size = new System.Drawing.Size(150, 150);
            LmaButton.ForeColor = Color.FromArgb(64, 64, 64);
            LmaImageButton.Location = new Point(LmaImageButton.Location.X + 5, LmaImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Lamdan:
        private void LamdanImageButton_MouseEnter(object sender, EventArgs e)
        {
            LamdanImageButton.Size = new System.Drawing.Size(160, 160);
            LamdanButton.ForeColor = Color.DodgerBlue;
            LamdanImageButton.Location = new Point(LamdanImageButton.Location.X - 5, LamdanImageButton.Location.Y - 5);
        }
        private void LamdanImageButton_MouseLeave(object sender, EventArgs e)
        {
            LamdanImageButton.Size = new System.Drawing.Size(150, 150);
            LamdanButton.ForeColor = Color.FromArgb(64,64, 64);
            LamdanImageButton.Location = new Point(LamdanImageButton.Location.X + 5, LamdanImageButton.Location.Y + 5);
        }
        private void LamdanButton_MouseEnter(object sender, EventArgs e)
        {
            LamdanImageButton.Size = new System.Drawing.Size(160, 160);
            LamdanButton.ForeColor = Color.DodgerBlue;
            LamdanImageButton.Location = new Point(LamdanImageButton.Location.X - 5, LamdanImageButton.Location.Y - 5);
        }
        private void LamdanButton_MouseLeave(object sender, EventArgs e)
        {
            LamdanImageButton.Size = new System.Drawing.Size(150, 150);
            LamdanButton.ForeColor = Color.FromArgb(64, 64, 64);
            LamdanImageButton.Location = new Point(LamdanImageButton.Location.X + 5, LamdanImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Bases:
        private void BasesButton_MouseEnter(object sender, EventArgs e)
        {
            BasesImageButton.Size = new System.Drawing.Size(160, 160);
            BasesButton.ForeColor = Color.DodgerBlue;
            BasesImageButton.Location = new Point(BasesImageButton.Location.X - 5, BasesImageButton.Location.Y - 5);
        }
        private void BasesButton_MouseLeave(object sender, EventArgs e)
        {
            BasesImageButton.Size = new System.Drawing.Size(150, 150);
            BasesButton.ForeColor = Color.FromArgb(64, 64, 64);
            BasesImageButton.Location = new Point(BasesImageButton.Location.X + 5, BasesImageButton.Location.Y + 5);
        }
        private void BasesImageButton_MouseEnter(object sender, EventArgs e)
        {
            BasesImageButton.Size = new System.Drawing.Size(160, 160);
            BasesButton.ForeColor = Color.DodgerBlue;
            BasesImageButton.Location = new Point(BasesImageButton.Location.X - 5, BasesImageButton.Location.Y - 5);
        }
        private void BasesImageButton_MouseLeave(object sender, EventArgs e)
        {
            BasesImageButton.Size = new System.Drawing.Size(150, 150);
            BasesButton.ForeColor = Color.FromArgb(64, 64, 64);
            BasesImageButton.Location = new Point(BasesImageButton.Location.X + 5, BasesImageButton.Location.Y + 5);
        }
        // ******************************************************************
        // ------------------------------------------------------------------------------------------------------------------------------


        // ------------------------------------------------------------------------------------------------------------------------------
        // Latzad Panel
        // Buttons clicked functions:
        // ******************************************************************
        private void LatzadButton_Click(object sender, EventArgs e)
        {
            LatzadPanel.Visible = true;
            IAFPanel.Visible = false;
            TikshuvPanel.Visible = false;
            LatzadPanel.BringToFront();
        }
        private void LatzadImageButton_Click(object sender, EventArgs e)
        {
            LatzadPanel.Visible = true;
            IAFPanel.Visible = false;
            TikshuvPanel.Visible = false;
            LatzadPanel.BringToFront();
        }
        private void LatzadBackButton_Click(object sender, EventArgs e)
        {
            LatzadPanel.Visible = false;
            IAFPanel.Visible = true;
            IAFPanel.BringToFront();
        }
        private void LatzadBackToFsrtButton_Click(object sender, EventArgs e)
        {
            TikshuvPanel.Visible = false;
            IAFPanel.Visible = false;
            LatzadPanel.Visible = false;
        }
        // ******************************************************************

        // Form movement feature enabled by mouse interactions:
        // ******************************************************************
        private void LatzadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void LatzadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void LatzadImage_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void LatzadImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void LatzadLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void LatzadLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        // ******************************************************************

        // ******************************************************************
        // Ofek:
        private void OfekButton_MouseEnter(object sender, EventArgs e)
        {
            OfekImageButton.Size = new System.Drawing.Size(160, 160);
            OfekButton.ForeColor = Color.DodgerBlue;
            OfekImageButton.Location = new Point(OfekImageButton.Location.X - 5, OfekImageButton.Location.Y - 5);
        }
        private void OfekButton_MouseLeave(object sender, EventArgs e)
        {
            OfekImageButton.Size = new System.Drawing.Size(150, 150);
            OfekButton.ForeColor = Color.FromArgb(64, 64, 64);
            OfekImageButton.Location = new Point(OfekImageButton.Location.X + 5, OfekImageButton.Location.Y + 5);
        }
        private void OfekImageButton_MouseEnter(object sender, EventArgs e)
        {
            OfekImageButton.Size = new System.Drawing.Size(160, 160);
            OfekButton.ForeColor = Color.DodgerBlue;
            OfekImageButton.Location = new Point(OfekImageButton.Location.X - 5, OfekImageButton.Location.Y - 5);
        }
        private void OfekImageButton_MouseLeave(object sender, EventArgs e)
        {
            OfekImageButton.Size = new System.Drawing.Size(150, 150);
            OfekButton.ForeColor = Color.FromArgb(64, 64, 64);
            OfekImageButton.Location = new Point(OfekImageButton.Location.X + 5, OfekImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Lahav:
        private void LahavButton_MouseEnter(object sender, EventArgs e)
        {
            LahavImageButton.Size = new System.Drawing.Size(160, 160);
            LahavButton.ForeColor = Color.DodgerBlue;
            LahavImageButton.Location = new Point(LahavImageButton.Location.X - 5, LahavImageButton.Location.Y - 5);
        }
        private void LahavButton_MouseLeave(object sender, EventArgs e)
        {
            LahavImageButton.Size = new System.Drawing.Size(150, 150);
            LahavButton.ForeColor = Color.FromArgb(64, 64, 64);
            LahavImageButton.Location = new Point(LahavImageButton.Location.X + 5, LahavImageButton.Location.Y + 5);
        }
        private void LahavImageButton_MouseEnter(object sender, EventArgs e)
        {
            LahavImageButton.Size = new System.Drawing.Size(160, 160);
            LahavButton.ForeColor = Color.DodgerBlue;
            LahavImageButton.Location = new Point(LahavImageButton.Location.X - 5, LahavImageButton.Location.Y - 5);
        }
        private void LahavImageButton_MouseLeave(object sender, EventArgs e)
        {
            LahavImageButton.Size = new System.Drawing.Size(150, 150);
            LahavButton.ForeColor = Color.FromArgb(64, 64, 64);
            LahavImageButton.Location = new Point(LahavImageButton.Location.X + 5, LahavImageButton.Location.Y + 5);
        }
        // ******************************************************************


        // ******************************************************************
        // Bamtza:
        private void BamtzaButton_MouseEnter(object sender, EventArgs e)
        {
            Bamza108ImageButton.Size = new System.Drawing.Size(160, 160);
            BamtzaButton.ForeColor = Color.DodgerBlue;
            Bamza108ImageButton.Location = new Point(Bamza108ImageButton.Location.X - 5, Bamza108ImageButton.Location.Y - 5);

        }
        private void BamtzaButton_MouseLeave(object sender, EventArgs e)
        {
            Bamza108ImageButton.Size = new System.Drawing.Size(150, 150);
            BamtzaButton.ForeColor = Color.FromArgb(64, 64, 64);
            Bamza108ImageButton.Location = new Point(Bamza108ImageButton.Location.X + 5, Bamza108ImageButton.Location.Y + 5);

        }
        private void Bamza108ImageButton_MouseEnter(object sender, EventArgs e)
        {
            Bamza108ImageButton.Size = new System.Drawing.Size(160, 160);
            BamtzaButton.ForeColor = Color.DodgerBlue;
            Bamza108ImageButton.Location = new Point(Bamza108ImageButton.Location.X - 5, Bamza108ImageButton.Location.Y - 5);
        }
        private void Bamza108ImageButton_MouseLeave(object sender, EventArgs e)
        {
            Bamza108ImageButton.Size = new System.Drawing.Size(150, 150);
            BamtzaButton.ForeColor = Color.FromArgb(64, 64, 64);
            Bamza108ImageButton.Location = new Point(Bamza108ImageButton.Location.X + 5, Bamza108ImageButton.Location.Y + 5);
        }
        // ******************************************************************


        // ******************************************************************
        // Handasa:
        private void HandasaButton_MouseEnter(object sender, EventArgs e)
        {
            HandasaImageButton.Size = new System.Drawing.Size(160, 160);
            HandasaButton.ForeColor = Color.DodgerBlue;
            HandasaImageButton.Location = new Point(HandasaImageButton.Location.X - 5, HandasaImageButton.Location.Y - 5);
        }
        private void HandasaButton_MouseLeave(object sender, EventArgs e)
        {
            HandasaImageButton.Size = new System.Drawing.Size(150, 150);
            HandasaButton.ForeColor = Color.FromArgb(64, 64, 64);
            HandasaImageButton.Location = new Point(HandasaImageButton.Location.X + 5, HandasaImageButton.Location.Y + 5);
        }
        private void HandasaImageButton_MouseEnter(object sender, EventArgs e)
        {
            HandasaImageButton.Size = new System.Drawing.Size(160, 160);
            HandasaButton.ForeColor = Color.DodgerBlue;
            HandasaImageButton.Location = new Point(HandasaImageButton.Location.X - 5, HandasaImageButton.Location.Y - 5);
        }
        private void HandasaImageButton_MouseLeave(object sender, EventArgs e)
        {
            HandasaImageButton.Size = new System.Drawing.Size(150, 150);
            HandasaButton.ForeColor = Color.FromArgb(64, 64, 64);
            HandasaImageButton.Location = new Point(HandasaImageButton.Location.X + 5, HandasaImageButton.Location.Y + 5);
        }
        // ******************************************************************
        // ------------------------------------------------------------------------------------------------------------------------------



        // ------------------------------------------------------------------------------------------------------------------------------
        // Tikshuv Panel
        // Buttons clicked functions:
        // ******************************************************************
        private void TikshuvImageButton_Click(object sender, EventArgs e)
        {
            TikshuvPanel.Visible = true;
            TikshuvPanel.BringToFront();
        }
        private void TikshuvButton_Click(object sender, EventArgs e)
        {
            TikshuvPanel.Visible = true;
            TikshuvPanel.BringToFront();
        }
        private void TikshuvBackToFrstButton_Click(object sender, EventArgs e)
        {
            TikshuvPanel.Visible = false;
        }
        // ******************************************************************

        // Form movement feature enabled by mouse interactions:
        // ******************************************************************
        private void TikshuvPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void TikshuvPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void TikshuvImage_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void TikshuvImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void TikshuvKumtaColor_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void TikshuvKumtaColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        private void TikshuvLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }
        private void TikshuvLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HafalaHub.ActiveForm.Left += e.X - lastclick.X;
                HafalaHub.ActiveForm.Top += e.Y - lastclick.Y;
            }
        }
        // ******************************************************************

        // UI mouse hover features
        // ******************************************************************
        // Mamram:
        private void MamramImageButton_MouseEnter(object sender, EventArgs e)
        {
            MamramImageButton.Size = new System.Drawing.Size(190, 190);
            MamramButton.ForeColor = Color.Red;
            MamramImageButton.Location = new Point(MamramImageButton.Location.X - 5, MamramImageButton.Location.Y - 5);
        }
        private void MamramImageButton_MouseLeave(object sender, EventArgs e)
        {
            MamramImageButton.Size = new System.Drawing.Size(180, 180);
            MamramButton.ForeColor = Color.Black;
            MamramImageButton.Location = new Point(MamramImageButton.Location.X + 5, MamramImageButton.Location.Y + 5);
        }
        private void MamramButton_MouseEnter(object sender, EventArgs e)
        {
            MamramImageButton.Size = new System.Drawing.Size(190, 190);
            MamramButton.ForeColor = Color.Red;
            MamramImageButton.Location = new Point(MamramImageButton.Location.X - 5, MamramImageButton.Location.Y - 5);
        }
        private void MamramButton_MouseLeave(object sender, EventArgs e)
        {
            MamramImageButton.Size = new System.Drawing.Size(180, 180);
            MamramButton.ForeColor = Color.Black;
            MamramImageButton.Location = new Point(MamramImageButton.Location.X + 5, MamramImageButton.Location.Y + 5);

        }
        // ******************************************************************

        // ******************************************************************
        // Mazpen:
        private void MazpenImageButton_MouseEnter(object sender, EventArgs e)
        {
            MazpenImageButton.Size = new System.Drawing.Size(190, 190);
            MazpenButton.ForeColor = Color.Red;
            MazpenImageButton.Location = new Point(MazpenImageButton.Location.X - 5, MazpenImageButton.Location.Y - 5);
        }
        private void MazpenImageButton_MouseLeave(object sender, EventArgs e)
        {
            MazpenImageButton.Size = new System.Drawing.Size(180, 180);
            MazpenButton.ForeColor = Color.Black;
            MazpenImageButton.Location = new Point(MazpenImageButton.Location.X + 5, MazpenImageButton.Location.Y + 5);
        }
        private void MazpenButton_MouseEnter(object sender, EventArgs e)
        {
            MazpenImageButton.Size = new System.Drawing.Size(190, 190);
            MazpenButton.ForeColor = Color.Red;
            MazpenImageButton.Location = new Point(MazpenImageButton.Location.X - 5, MazpenImageButton.Location.Y - 5);
        }
        private void MazpenButton_MouseLeave(object sender, EventArgs e)
        {
            MazpenImageButton.Size = new System.Drawing.Size(180, 180);
            MazpenButton.ForeColor = Color.Black;
            MazpenImageButton.Location = new Point(MazpenImageButton.Location.X + 5, MazpenImageButton.Location.Y + 5);
        }
        // ******************************************************************

        // ******************************************************************
        // Mazov:
        private void MazovImageButton_MouseEnter(object sender, EventArgs e)
        {
            MazovImageButton.Size = new System.Drawing.Size(190, 190);
            MazovButton.ForeColor = Color.Red;
            MazovImageButton.Location = new Point(MazovImageButton.Location.X - 5, MazovImageButton.Location.Y - 5);
        }
        private void MazovImageButton_MouseLeave(object sender, EventArgs e)
        {
            MazovImageButton.Size = new System.Drawing.Size(180, 180);
            MazovButton.ForeColor = Color.Black;
            MazovImageButton.Location = new Point(MazovImageButton.Location.X + 5, MazovImageButton.Location.Y + 5);

        }
        private void MazovButton_MouseEnter(object sender, EventArgs e)
        {
            MazovImageButton.Size = new System.Drawing.Size(190, 190);
            MazovButton.ForeColor = Color.Red;
            MazovImageButton.Location = new Point(MazovImageButton.Location.X - 5, MazovImageButton.Location.Y - 5);
        }
        private void MazovButton_MouseLeave(object sender, EventArgs e)
        {
            MazovImageButton.Size = new System.Drawing.Size(180, 180);
            MazovButton.ForeColor = Color.Black;
            MazovImageButton.Location = new Point(MazovImageButton.Location.X + 5, MazovImageButton.Location.Y + 5);
        }
        // ******************************************************************
        // ------------------------------------------------------------------------------------------------------------------------------























    }
}
