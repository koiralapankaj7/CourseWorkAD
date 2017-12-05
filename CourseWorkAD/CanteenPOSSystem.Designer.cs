﻿namespace CourseWorkAD
{
    partial class CanteenPOSSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanteenPOSSystem));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.BunifuElipseMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnHamburger = new Bunifu.Framework.UI.BunifuImageButton();
            this.PbOrgLogoLarge = new System.Windows.Forms.PictureBox();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnSystemClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PbOrgIcon = new System.Windows.Forms.PictureBox();
            this.LblOrgName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuItem1 = new CourseWorkAD.MenuItem();
            this.billGenerator1 = new CourseWorkAD.BillGenerator();
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgLogoLarge)).BeginInit();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSystemClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BunifuElipseMain
            // 
            this.BunifuElipseMain.ElipseRadius = 5;
            this.BunifuElipseMain.TargetControl = this;
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlSideBar.Controls.Add(this.bunifuFlatButton4);
            this.PnlSideBar.Controls.Add(this.bunifuFlatButton3);
            this.PnlSideBar.Controls.Add(this.bunifuFlatButton2);
            this.PnlSideBar.Controls.Add(this.bunifuFlatButton1);
            this.PnlSideBar.Controls.Add(this.BtnHamburger);
            this.PnlSideBar.Controls.Add(this.PbOrgLogoLarge);
            this.PanelAnimator.SetDecoration(this.PnlSideBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PnlSideBar, BunifuAnimatorNS.DecorationType.None);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 49);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(380, 1053);
            this.PnlSideBar.TabIndex = 0;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Generate Bill";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 15;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 280);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(380, 55);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Generate Bill";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Chart";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 15;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 45D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 225);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(380, 55);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Chart";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Menu";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 15;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 45D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 170);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(380, 55);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "Menu";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 15;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 115);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(380, 55);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Home";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnHamburger
            // 
            this.BtnHamburger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnHamburger, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnHamburger, BunifuAnimatorNS.DecorationType.None);
            this.BtnHamburger.Image = ((System.Drawing.Image)(resources.GetObject("BtnHamburger.Image")));
            this.BtnHamburger.ImageActive = null;
            this.BtnHamburger.Location = new System.Drawing.Point(319, 26);
            this.BtnHamburger.Margin = new System.Windows.Forms.Padding(5);
            this.BtnHamburger.Name = "BtnHamburger";
            this.BtnHamburger.Size = new System.Drawing.Size(50, 46);
            this.BtnHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHamburger.TabIndex = 1;
            this.BtnHamburger.TabStop = false;
            this.BtnHamburger.Zoom = 10;
            this.BtnHamburger.Click += new System.EventHandler(this.BtnHamburger_Click);
            // 
            // PbOrgLogoLarge
            // 
            this.PbOrgLogoLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LogoAnimator.SetDecoration(this.PbOrgLogoLarge, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PbOrgLogoLarge, BunifuAnimatorNS.DecorationType.None);
            this.PbOrgLogoLarge.Image = ((System.Drawing.Image)(resources.GetObject("PbOrgLogoLarge.Image")));
            this.PbOrgLogoLarge.Location = new System.Drawing.Point(47, 23);
            this.PbOrgLogoLarge.Name = "PbOrgLogoLarge";
            this.PbOrgLogoLarge.Size = new System.Drawing.Size(156, 49);
            this.PbOrgLogoLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOrgLogoLarge.TabIndex = 0;
            this.PbOrgLogoLarge.TabStop = false;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlHeader.Controls.Add(this.BtnSystemClose);
            this.PnlHeader.Controls.Add(this.PbOrgIcon);
            this.PnlHeader.Controls.Add(this.LblOrgName);
            this.PnlHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.PnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1800, 49);
            this.PnlHeader.TabIndex = 1;
            // 
            // BtnSystemClose
            // 
            this.BtnSystemClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSystemClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnSystemClose, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnSystemClose, BunifuAnimatorNS.DecorationType.None);
            this.BtnSystemClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnSystemClose.Image")));
            this.BtnSystemClose.ImageActive = null;
            this.BtnSystemClose.Location = new System.Drawing.Point(1759, 14);
            this.BtnSystemClose.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSystemClose.Name = "BtnSystemClose";
            this.BtnSystemClose.Size = new System.Drawing.Size(20, 20);
            this.BtnSystemClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSystemClose.TabIndex = 3;
            this.BtnSystemClose.TabStop = false;
            this.BtnSystemClose.Zoom = 10;
            this.BtnSystemClose.Click += new System.EventHandler(this.BtnSystemClose_Click);
            // 
            // PbOrgIcon
            // 
            this.LogoAnimator.SetDecoration(this.PbOrgIcon, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PbOrgIcon, BunifuAnimatorNS.DecorationType.None);
            this.PbOrgIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbOrgIcon.Image")));
            this.PbOrgIcon.Location = new System.Drawing.Point(33, 3);
            this.PbOrgIcon.Name = "PbOrgIcon";
            this.PbOrgIcon.Size = new System.Drawing.Size(33, 37);
            this.PbOrgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOrgIcon.TabIndex = 1;
            this.PbOrgIcon.TabStop = false;
            // 
            // LblOrgName
            // 
            this.LblOrgName.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.LblOrgName, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LblOrgName, BunifuAnimatorNS.DecorationType.None);
            this.LblOrgName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrgName.ForeColor = System.Drawing.Color.Silver;
            this.LblOrgName.Location = new System.Drawing.Point(75, 12);
            this.LblOrgName.Name = "LblOrgName";
            this.LblOrgName.Size = new System.Drawing.Size(206, 23);
            this.LblOrgName.TabIndex = 0;
            this.LblOrgName.Text = "Canteen of Islington";
            // 
            // BunifuDragControl
            // 
            this.BunifuDragControl.Fixed = true;
            this.BunifuDragControl.Horizontal = true;
            this.BunifuDragControl.TargetControl = this.PnlHeader;
            this.BunifuDragControl.Vertical = true;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
            this.LogoAnimator.Interval = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.billGenerator1);
            this.panel1.Controls.Add(this.menuItem1);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(380, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 1053);
            this.panel1.TabIndex = 2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation4;
            this.PanelAnimator.MaxAnimationTime = 1000;
            // 
            // menuItem1
            // 
            this.LogoAnimator.SetDecoration(this.menuItem1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.menuItem1, BunifuAnimatorNS.DecorationType.None);
            this.menuItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuItem1.Location = new System.Drawing.Point(0, 0);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(1420, 1053);
            this.menuItem1.TabIndex = 0;
            // 
            // billGenerator1
            // 
            this.LogoAnimator.SetDecoration(this.billGenerator1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.billGenerator1, BunifuAnimatorNS.DecorationType.None);
            this.billGenerator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billGenerator1.Location = new System.Drawing.Point(0, 0);
            this.billGenerator1.Name = "billGenerator1";
            this.billGenerator1.Size = new System.Drawing.Size(1420, 1053);
            this.billGenerator1.TabIndex = 1;
            // 
            // CanteenPOSSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1800, 1102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.PnlHeader);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanteenPOSSystem";
            this.Text = "Menu Generator";
            this.PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgLogoLarge)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSystemClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BunifuElipseMain;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Panel PnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnHamburger;
        private System.Windows.Forms.PictureBox PbOrgLogoLarge;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel LblOrgName;
        private System.Windows.Forms.PictureBox PbOrgIcon;
        private Bunifu.Framework.UI.BunifuImageButton BtnSystemClose;
        private Bunifu.Framework.UI.BunifuDragControl BunifuDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private System.Windows.Forms.Panel panel1;
        private MenuItem menuItem1;
        private BillGenerator billGenerator1;
    }
}
