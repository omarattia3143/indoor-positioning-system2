﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mapForm : Form
    {
        public mapForm()
        {
            InitializeComponent();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 54)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logoAnimator.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 54;
                panelAnimator.ShowSync(sideMenu);
            }
        }

        private void search_image_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 54)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
        }

        private void c1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {
            
        }

        private void c1Zoom1_ZoomFactorChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 54)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
        }

        private void customize_view_Click(object sender, EventArgs e)
        {
            adminTools.SendToBack();
            map.BringToFront();
        }

        private void customize_view_Click_1(object sender, EventArgs e)
        {
            
        }

        private void adminTools_Click(object sender, EventArgs e)
        {
            loginForm1.BringToFront();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginForm1_Load(object sender, EventArgs e)
        {

        }
    }
}