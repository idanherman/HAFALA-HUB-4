﻿using System;
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
    public partial class Alert_Display : Form
    {
        public string alerttext;
        public Alert_Display()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private int clickCounter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clickCounter++;
            textBox1.ReadOnly = false;
            EditButton1.Text = "Save";
            DialogResult result;
            if (clickCounter > 1)
            {
                result = MessageBox.Show("Are you sure you want to save your changes?", "Save alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                File.WriteAllText(Page_AlertsArchive.passingPath, textBox1.Text);
                this.Close();
            }
            else
            {
                return;
            }
            }

        }
        
        private void Alert_Display_Load(object sender, EventArgs e)
        {
            textBox1.Text = Page_AlertsArchive.passingText;
            AlertGroupLabel.Text = Page_AlertsArchive.passingAlertGroup; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
