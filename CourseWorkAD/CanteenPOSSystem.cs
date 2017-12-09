﻿using System;
using System.Windows.Forms;

namespace CourseWorkAD {
    public partial class CanteenPOSSystem : Form {

        public CanteenPOSSystem() {
            InitializeComponent();
            homePage.BringToFront();
        }

        private void BtnSystemClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnHamburger_Click(object sender, EventArgs e) {

            if(PnlSideBar.Width == 55) {
                //Expand
                PnlSideBar.Visible = false;
                PnlSideBar.Width = 285;
                PanelAnimator.ShowSync(PnlSideBar);
                LogoAnimator.ShowSync(PbOrgLogoLarge);
            } else {
                //Minimize
                LogoAnimator.Hide(PbOrgLogoLarge);
                PnlSideBar.Visible = false;
                PnlSideBar.Width = 55;
                PanelAnimator.ShowSync(PnlSideBar);
            }
        }

        private void BtnHomeSideBar_Click(object sender, EventArgs e) {
            homePage.BringToFront();
        }

        private void BtnMenuSideBar_Click(object sender, EventArgs e) {
            menuItem.BringToFront();
        }

        private void BtnChartSideBar_Click(object sender, EventArgs e) {
            chartGenerator.BringToFront();
        }

        private void BtnGenerateBillSideBar_Click(object sender, EventArgs e) {
            billGenerator.BringToFront();
        }

    }
}
