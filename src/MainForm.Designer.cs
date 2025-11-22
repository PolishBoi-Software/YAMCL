namespace YAMCL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.roundedCorners = new CuoreUI.Components.cuiFormRounder();
            this.signInBtn = new CuoreUI.Controls.cuiButton();
            this.playerHead = new System.Windows.Forms.PictureBox();
            this.unameLbl = new CuoreUI.Controls.cuiLabel();
            this.uuidLbl = new CuoreUI.Controls.cuiLabel();
            this.launchBtn = new CuoreUI.Controls.cuiButton();
            this.instanceList = new CuoreUI.Controls.cuiListbox();
            this.resizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.createInstBtn = new CuoreUI.Controls.cuiButton();
            this.closeBtn = new CuoreUI.Controls.cuiButton();
            this.miniBtn = new CuoreUI.Controls.cuiButton();
            this.maxBtn = new CuoreUI.Controls.cuiButton();
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.closeBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.maxBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.miniBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.rmInstBtn = new CuoreUI.Controls.cuiButton();
            this.progBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
            this.taskLbl = new CuoreUI.Controls.cuiLabel();
            this.downloadProgressLbl = new CuoreUI.Controls.cuiLabel();
            this.taskbarState = new CuoreUI.Components.cuiTaskbarStateController(this.components);
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.settingsBtn = new CuoreUI.Controls.cuiButton();
            this.killBtn = new CuoreUI.Controls.cuiButton();
            this.addModBtn = new CuoreUI.Controls.cuiButton();
            this.openInstDirBtn = new CuoreUI.Controls.cuiButton();
            this.editInstBtn = new CuoreUI.Controls.cuiButton();
            this.launchOptsBtn = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.playerHead)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedCorners
            // 
            this.roundedCorners.OutlineColor = System.Drawing.Color.Black;
            this.roundedCorners.Rounding = 4;
            this.roundedCorners.TargetForm = this;
            // 
            // signInBtn
            // 
            this.signInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.signInBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signInBtn.CheckButton = false;
            this.signInBtn.Checked = false;
            this.signInBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.signInBtn.CheckedForeColor = System.Drawing.Color.White;
            this.signInBtn.CheckedImageTint = System.Drawing.Color.White;
            this.signInBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.signInBtn.Content = "Sign in";
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signInBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.signInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.signInBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.signInBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.signInBtn.HoverImageTint = System.Drawing.Color.White;
            this.signInBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signInBtn.Image = null;
            this.signInBtn.ImageAutoCenter = true;
            this.signInBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.signInBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.signInBtn.Location = new System.Drawing.Point(1011, 53);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.signInBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.signInBtn.NormalImageTint = System.Drawing.Color.White;
            this.signInBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signInBtn.OutlineThickness = 1F;
            this.signInBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.signInBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.signInBtn.PressedImageTint = System.Drawing.Color.White;
            this.signInBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signInBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.signInBtn.Size = new System.Drawing.Size(178, 59);
            this.signInBtn.TabIndex = 1;
            this.signInBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.signInBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // playerHead
            // 
            this.playerHead.Location = new System.Drawing.Point(12, 16);
            this.playerHead.Name = "playerHead";
            this.playerHead.Size = new System.Drawing.Size(64, 64);
            this.playerHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHead.TabIndex = 2;
            this.playerHead.TabStop = false;
            // 
            // unameLbl
            // 
            this.unameLbl.Content = "USERNAME";
            this.unameLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.unameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.unameLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.unameLbl.Location = new System.Drawing.Point(82, 16);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(304, 20);
            this.unameLbl.TabIndex = 3;
            this.unameLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // uuidLbl
            // 
            this.uuidLbl.Content = "UUID";
            this.uuidLbl.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uuidLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.uuidLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.uuidLbl.Location = new System.Drawing.Point(82, 42);
            this.uuidLbl.Name = "uuidLbl";
            this.uuidLbl.Size = new System.Drawing.Size(490, 19);
            this.uuidLbl.TabIndex = 4;
            this.uuidLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // launchBtn
            // 
            this.launchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchBtn.CheckButton = false;
            this.launchBtn.Checked = false;
            this.launchBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.launchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.launchBtn.CheckedImageTint = System.Drawing.Color.White;
            this.launchBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.launchBtn.Content = "Launch";
            this.launchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.launchBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.launchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.launchBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchBtn.HoverImageTint = System.Drawing.Color.White;
            this.launchBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchBtn.Image = null;
            this.launchBtn.ImageAutoCenter = true;
            this.launchBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.launchBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.launchBtn.Location = new System.Drawing.Point(13, 118);
            this.launchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchBtn.NormalImageTint = System.Drawing.Color.White;
            this.launchBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchBtn.OutlineThickness = 1F;
            this.launchBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchBtn.PressedImageTint = System.Drawing.Color.White;
            this.launchBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.launchBtn.Size = new System.Drawing.Size(178, 59);
            this.launchBtn.TabIndex = 5;
            this.launchBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.launchBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // instanceList
            // 
            this.instanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.instanceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.instanceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instanceList.DisplayMember = "Name";
            this.instanceList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.instanceList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.instanceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.instanceList.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.instanceList.FormattingEnabled = true;
            this.instanceList.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.instanceList.ItemHeight = 34;
            this.instanceList.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.instanceList.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.instanceList.ItemRounding = 12;
            this.instanceList.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.instanceList.Location = new System.Drawing.Point(12, 185);
            this.instanceList.Name = "instanceList";
            this.instanceList.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.instanceList.Rounding = new System.Windows.Forms.Padding(8);
            this.instanceList.SelectedForegroundColor = System.Drawing.Color.White;
            this.instanceList.Size = new System.Drawing.Size(992, 510);
            this.instanceList.TabIndex = 6;
            // 
            // resizeGrip
            // 
            this.resizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeGrip.GripColor = System.Drawing.Color.Gray;
            this.resizeGrip.GripSize = 2;
            this.resizeGrip.GripTexture = true;
            this.resizeGrip.Location = new System.Drawing.Point(1184, 694);
            this.resizeGrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resizeGrip.Name = "resizeGrip";
            this.resizeGrip.Size = new System.Drawing.Size(18, 18);
            this.resizeGrip.SkipBottomRightSquare = false;
            this.resizeGrip.TabIndex = 9;
            this.resizeGrip.TargetForm = this;
            this.resizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // createInstBtn
            // 
            this.createInstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createInstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInstBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createInstBtn.CheckButton = false;
            this.createInstBtn.Checked = false;
            this.createInstBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.createInstBtn.CheckedForeColor = System.Drawing.Color.White;
            this.createInstBtn.CheckedImageTint = System.Drawing.Color.White;
            this.createInstBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.createInstBtn.Content = "Create instance";
            this.createInstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createInstBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createInstBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.createInstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInstBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.createInstBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInstBtn.HoverImageTint = System.Drawing.Color.White;
            this.createInstBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInstBtn.Image = null;
            this.createInstBtn.ImageAutoCenter = true;
            this.createInstBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.createInstBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.createInstBtn.Location = new System.Drawing.Point(1011, 636);
            this.createInstBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createInstBtn.Name = "createInstBtn";
            this.createInstBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInstBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInstBtn.NormalImageTint = System.Drawing.Color.White;
            this.createInstBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInstBtn.OutlineThickness = 1F;
            this.createInstBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInstBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInstBtn.PressedImageTint = System.Drawing.Color.White;
            this.createInstBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInstBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.createInstBtn.Size = new System.Drawing.Size(178, 59);
            this.createInstBtn.TabIndex = 10;
            this.createInstBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.createInstBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.createInstBtn.Click += new System.EventHandler(this.createInstBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.closeBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeBtn.CheckButton = false;
            this.closeBtn.Checked = false;
            this.closeBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.closeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.closeBtn.CheckedImageTint = System.Drawing.Color.White;
            this.closeBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.closeBtn.Content = "X";
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.closeBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.closeBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.closeBtn.HoverImageTint = System.Drawing.Color.White;
            this.closeBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Image = null;
            this.closeBtn.ImageAutoCenter = true;
            this.closeBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.closeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.Location = new System.Drawing.Point(1166, 4);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.closeBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.closeBtn.NormalImageTint = System.Drawing.Color.White;
            this.closeBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.OutlineThickness = 1F;
            this.closeBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.closeBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.closeBtn.PressedImageTint = System.Drawing.Color.White;
            this.closeBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.closeBtn.Size = new System.Drawing.Size(23, 32);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.closeBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.miniBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miniBtn.CheckButton = false;
            this.miniBtn.Checked = false;
            this.miniBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.miniBtn.CheckedForeColor = System.Drawing.Color.White;
            this.miniBtn.CheckedImageTint = System.Drawing.Color.White;
            this.miniBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.miniBtn.Content = "_";
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.miniBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.miniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.miniBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.miniBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.miniBtn.HoverImageTint = System.Drawing.Color.White;
            this.miniBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.miniBtn.Image = null;
            this.miniBtn.ImageAutoCenter = true;
            this.miniBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.miniBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.miniBtn.Location = new System.Drawing.Point(1104, 4);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.miniBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.miniBtn.NormalImageTint = System.Drawing.Color.White;
            this.miniBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.miniBtn.OutlineThickness = 1F;
            this.miniBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.miniBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.miniBtn.PressedImageTint = System.Drawing.Color.White;
            this.miniBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.miniBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.miniBtn.Size = new System.Drawing.Size(23, 32);
            this.miniBtn.TabIndex = 12;
            this.miniBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.miniBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.maxBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxBtn.CheckButton = false;
            this.maxBtn.Checked = false;
            this.maxBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.maxBtn.CheckedForeColor = System.Drawing.Color.White;
            this.maxBtn.CheckedImageTint = System.Drawing.Color.White;
            this.maxBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.maxBtn.Content = "⛶";
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.maxBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.maxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.maxBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.maxBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.maxBtn.HoverImageTint = System.Drawing.Color.White;
            this.maxBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maxBtn.Image = null;
            this.maxBtn.ImageAutoCenter = true;
            this.maxBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.maxBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.maxBtn.Location = new System.Drawing.Point(1135, 4);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.maxBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.maxBtn.NormalImageTint = System.Drawing.Color.White;
            this.maxBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maxBtn.OutlineThickness = 1F;
            this.maxBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.maxBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.maxBtn.PressedImageTint = System.Drawing.Color.White;
            this.maxBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maxBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.maxBtn.Size = new System.Drawing.Size(23, 32);
            this.maxBtn.TabIndex = 13;
            this.maxBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.maxBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // formDrag
            // 
            this.formDrag.TargetForm = this;
            // 
            // closeBtnTooltip
            // 
            this.closeBtnTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.closeBtnTooltip.Content = "Closes the application.";
            this.closeBtnTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.closeBtnTooltip.TargetControl = this.closeBtn;
            this.closeBtnTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.closeBtnTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // maxBtnTooltip
            // 
            this.maxBtnTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.maxBtnTooltip.Content = "Maximizes/restores the window.";
            this.maxBtnTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.maxBtnTooltip.TargetControl = this.maxBtn;
            this.maxBtnTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.maxBtnTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // miniBtnTooltip
            // 
            this.miniBtnTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.miniBtnTooltip.Content = "Minimizes the window.";
            this.miniBtnTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.miniBtnTooltip.TargetControl = this.miniBtn;
            this.miniBtnTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.miniBtnTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // rmInstBtn
            // 
            this.rmInstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rmInstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rmInstBtn.CheckButton = false;
            this.rmInstBtn.Checked = false;
            this.rmInstBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.rmInstBtn.CheckedForeColor = System.Drawing.Color.White;
            this.rmInstBtn.CheckedImageTint = System.Drawing.Color.White;
            this.rmInstBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.rmInstBtn.Content = "Remove instance";
            this.rmInstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmInstBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rmInstBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.rmInstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.rmInstBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstBtn.HoverImageTint = System.Drawing.Color.White;
            this.rmInstBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstBtn.Image = null;
            this.rmInstBtn.ImageAutoCenter = true;
            this.rmInstBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.rmInstBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.rmInstBtn.Location = new System.Drawing.Point(1011, 568);
            this.rmInstBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rmInstBtn.Name = "rmInstBtn";
            this.rmInstBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstBtn.NormalImageTint = System.Drawing.Color.White;
            this.rmInstBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstBtn.OutlineThickness = 1F;
            this.rmInstBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstBtn.PressedImageTint = System.Drawing.Color.White;
            this.rmInstBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.rmInstBtn.Size = new System.Drawing.Size(178, 59);
            this.rmInstBtn.TabIndex = 14;
            this.rmInstBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.rmInstBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.rmInstBtn.Click += new System.EventHandler(this.rmInstBtn_Click);
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.Background = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar.Flipped = false;
            this.progBar.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.progBar.Location = new System.Drawing.Point(12, 86);
            this.progBar.MaxValue = 100;
            this.progBar.Name = "progBar";
            this.progBar.Rounding = 8;
            this.progBar.Size = new System.Drawing.Size(992, 26);
            this.progBar.TabIndex = 15;
            this.progBar.Value = 0;
            // 
            // taskLbl
            // 
            this.taskLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskLbl.Content = "Nothing\\ to\\ do";
            this.taskLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.taskLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.taskLbl.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.taskLbl.Location = new System.Drawing.Point(447, 60);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(557, 20);
            this.taskLbl.TabIndex = 16;
            this.taskLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // downloadProgressLbl
            // 
            this.downloadProgressLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgressLbl.Content = "0\\ bytes\\ /\\ 0\\ bytes";
            this.downloadProgressLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.downloadProgressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.downloadProgressLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.downloadProgressLbl.Location = new System.Drawing.Point(82, 60);
            this.downloadProgressLbl.Name = "downloadProgressLbl";
            this.downloadProgressLbl.Size = new System.Drawing.Size(503, 20);
            this.downloadProgressLbl.TabIndex = 17;
            this.downloadProgressLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // taskbarState
            // 
            this.taskbarState.MaxValue = 100;
            this.taskbarState.ProgressValue = 50;
            this.taskbarState.State = CuoreUI.Components.cuiTaskbarStateController.TaskbarStates.Default;
            this.taskbarState.TargetForm = this;
            // 
            // formAnimator
            // 
            this.formAnimator.AnimateOnStart = true;
            this.formAnimator.Duration = 750;
            this.formAnimator.EasingType = CuoreUI.Helpers.DrawingHelper.EasingTypes.ExpoOut;
            this.formAnimator.StartOpacity = 0D;
            this.formAnimator.TargetForm = this;
            this.formAnimator.TargetOpacity = 1D;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.settingsBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsBtn.CheckButton = false;
            this.settingsBtn.Checked = false;
            this.settingsBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.settingsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedImageTint = System.Drawing.Color.White;
            this.settingsBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.settingsBtn.Content = "Settings";
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingsBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.settingsBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.settingsBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.settingsBtn.HoverImageTint = System.Drawing.Color.White;
            this.settingsBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.settingsBtn.Image = null;
            this.settingsBtn.ImageAutoCenter = true;
            this.settingsBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.settingsBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.settingsBtn.Location = new System.Drawing.Point(1011, 120);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.settingsBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.settingsBtn.NormalImageTint = System.Drawing.Color.White;
            this.settingsBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.settingsBtn.OutlineThickness = 1F;
            this.settingsBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.settingsBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.settingsBtn.PressedImageTint = System.Drawing.Color.White;
            this.settingsBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.settingsBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.settingsBtn.Size = new System.Drawing.Size(178, 59);
            this.settingsBtn.TabIndex = 18;
            this.settingsBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.settingsBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // killBtn
            // 
            this.killBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.killBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.killBtn.CheckButton = false;
            this.killBtn.Checked = false;
            this.killBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.killBtn.CheckedForeColor = System.Drawing.Color.White;
            this.killBtn.CheckedImageTint = System.Drawing.Color.White;
            this.killBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.killBtn.Content = "Kill";
            this.killBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.killBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.killBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.killBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.killBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.killBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.killBtn.HoverImageTint = System.Drawing.Color.White;
            this.killBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.killBtn.Image = null;
            this.killBtn.ImageAutoCenter = true;
            this.killBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.killBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.killBtn.Location = new System.Drawing.Point(199, 118);
            this.killBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killBtn.Name = "killBtn";
            this.killBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.killBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.killBtn.NormalImageTint = System.Drawing.Color.White;
            this.killBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.killBtn.OutlineThickness = 1F;
            this.killBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.killBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.killBtn.PressedImageTint = System.Drawing.Color.White;
            this.killBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.killBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.killBtn.Size = new System.Drawing.Size(178, 59);
            this.killBtn.TabIndex = 19;
            this.killBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.killBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.killBtn.Click += new System.EventHandler(this.killBtn_Click);
            // 
            // addModBtn
            // 
            this.addModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addModBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addModBtn.CheckButton = false;
            this.addModBtn.Checked = false;
            this.addModBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addModBtn.CheckedForeColor = System.Drawing.Color.White;
            this.addModBtn.CheckedImageTint = System.Drawing.Color.White;
            this.addModBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.addModBtn.Content = "Add a mod";
            this.addModBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addModBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addModBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.addModBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.addModBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.addModBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.addModBtn.HoverImageTint = System.Drawing.Color.White;
            this.addModBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addModBtn.Image = null;
            this.addModBtn.ImageAutoCenter = true;
            this.addModBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.addModBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.addModBtn.Location = new System.Drawing.Point(825, 120);
            this.addModBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addModBtn.Name = "addModBtn";
            this.addModBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addModBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.addModBtn.NormalImageTint = System.Drawing.Color.White;
            this.addModBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addModBtn.OutlineThickness = 1F;
            this.addModBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addModBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.addModBtn.PressedImageTint = System.Drawing.Color.White;
            this.addModBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addModBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.addModBtn.Size = new System.Drawing.Size(178, 59);
            this.addModBtn.TabIndex = 20;
            this.addModBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.addModBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.addModBtn.Click += new System.EventHandler(this.addModBtn_Click);
            // 
            // openInstDirBtn
            // 
            this.openInstDirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.openInstDirBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openInstDirBtn.CheckButton = false;
            this.openInstDirBtn.Checked = false;
            this.openInstDirBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.openInstDirBtn.CheckedForeColor = System.Drawing.Color.White;
            this.openInstDirBtn.CheckedImageTint = System.Drawing.Color.White;
            this.openInstDirBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.openInstDirBtn.Content = "Open folder";
            this.openInstDirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openInstDirBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openInstDirBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.openInstDirBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.openInstDirBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.openInstDirBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.openInstDirBtn.HoverImageTint = System.Drawing.Color.White;
            this.openInstDirBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.openInstDirBtn.Image = null;
            this.openInstDirBtn.ImageAutoCenter = true;
            this.openInstDirBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.openInstDirBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.openInstDirBtn.Location = new System.Drawing.Point(639, 120);
            this.openInstDirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openInstDirBtn.Name = "openInstDirBtn";
            this.openInstDirBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.openInstDirBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.openInstDirBtn.NormalImageTint = System.Drawing.Color.White;
            this.openInstDirBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.openInstDirBtn.OutlineThickness = 1F;
            this.openInstDirBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.openInstDirBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.openInstDirBtn.PressedImageTint = System.Drawing.Color.White;
            this.openInstDirBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.openInstDirBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.openInstDirBtn.Size = new System.Drawing.Size(178, 59);
            this.openInstDirBtn.TabIndex = 21;
            this.openInstDirBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.openInstDirBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.openInstDirBtn.Click += new System.EventHandler(this.openInstDirBtn_Click);
            // 
            // editInstBtn
            // 
            this.editInstBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editInstBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.editInstBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editInstBtn.CheckButton = false;
            this.editInstBtn.Checked = false;
            this.editInstBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.editInstBtn.CheckedForeColor = System.Drawing.Color.White;
            this.editInstBtn.CheckedImageTint = System.Drawing.Color.White;
            this.editInstBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.editInstBtn.Content = "Edit instance";
            this.editInstBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editInstBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editInstBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.editInstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.editInstBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.editInstBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.editInstBtn.HoverImageTint = System.Drawing.Color.White;
            this.editInstBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editInstBtn.Image = null;
            this.editInstBtn.ImageAutoCenter = true;
            this.editInstBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.editInstBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.editInstBtn.Location = new System.Drawing.Point(1011, 499);
            this.editInstBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editInstBtn.Name = "editInstBtn";
            this.editInstBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.editInstBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.editInstBtn.NormalImageTint = System.Drawing.Color.White;
            this.editInstBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editInstBtn.OutlineThickness = 1F;
            this.editInstBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.editInstBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.editInstBtn.PressedImageTint = System.Drawing.Color.White;
            this.editInstBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.editInstBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.editInstBtn.Size = new System.Drawing.Size(178, 59);
            this.editInstBtn.TabIndex = 22;
            this.editInstBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.editInstBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.editInstBtn.Click += new System.EventHandler(this.editInstBtn_Click);
            // 
            // launchOptsBtn
            // 
            this.launchOptsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchOptsBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchOptsBtn.CheckButton = false;
            this.launchOptsBtn.Checked = false;
            this.launchOptsBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.launchOptsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.launchOptsBtn.CheckedImageTint = System.Drawing.Color.White;
            this.launchOptsBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.launchOptsBtn.Content = "Launch options";
            this.launchOptsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchOptsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.launchOptsBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.launchOptsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchOptsBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.launchOptsBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchOptsBtn.HoverImageTint = System.Drawing.Color.White;
            this.launchOptsBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchOptsBtn.Image = null;
            this.launchOptsBtn.ImageAutoCenter = true;
            this.launchOptsBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.launchOptsBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.launchOptsBtn.Location = new System.Drawing.Point(1011, 189);
            this.launchOptsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.launchOptsBtn.Name = "launchOptsBtn";
            this.launchOptsBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchOptsBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchOptsBtn.NormalImageTint = System.Drawing.Color.White;
            this.launchOptsBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchOptsBtn.OutlineThickness = 1F;
            this.launchOptsBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.launchOptsBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.launchOptsBtn.PressedImageTint = System.Drawing.Color.White;
            this.launchOptsBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.launchOptsBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.launchOptsBtn.Size = new System.Drawing.Size(178, 59);
            this.launchOptsBtn.TabIndex = 23;
            this.launchOptsBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.launchOptsBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.launchOptsBtn.Click += new System.EventHandler(this.launchOptsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1202, 712);
            this.Controls.Add(this.launchOptsBtn);
            this.Controls.Add(this.editInstBtn);
            this.Controls.Add(this.openInstDirBtn);
            this.Controls.Add(this.addModBtn);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.rmInstBtn);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.miniBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.createInstBtn);
            this.Controls.Add(this.resizeGrip);
            this.Controls.Add(this.instanceList);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.uuidLbl);
            this.Controls.Add(this.unameLbl);
            this.Controls.Add(this.playerHead);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.downloadProgressLbl);
            this.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAMCL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Components.cuiFormRounder roundedCorners;
        private CuoreUI.Controls.cuiButton signInBtn;
        private System.Windows.Forms.PictureBox playerHead;
        private CuoreUI.Controls.cuiLabel unameLbl;
        private CuoreUI.Controls.cuiLabel uuidLbl;
        private CuoreUI.Controls.cuiButton launchBtn;
        private CuoreUI.Controls.cuiListbox instanceList;
        private CuoreUI.Controls.cuiResizeGrip resizeGrip;
        private CuoreUI.Controls.cuiButton createInstBtn;
        private CuoreUI.Controls.cuiButton maxBtn;
        private CuoreUI.Controls.cuiButton miniBtn;
        private CuoreUI.Controls.cuiButton closeBtn;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiTooltipHover closeBtnTooltip;
        private CuoreUI.Components.cuiTooltipHover maxBtnTooltip;
        private CuoreUI.Components.cuiTooltipHover miniBtnTooltip;
        private CuoreUI.Controls.cuiButton rmInstBtn;
        private CuoreUI.Controls.cuiProgressBarHorizontal progBar;
        private CuoreUI.Controls.cuiLabel taskLbl;
        private CuoreUI.Controls.cuiLabel downloadProgressLbl;
        private CuoreUI.Components.cuiTaskbarStateController taskbarState;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiButton settingsBtn;
        private CuoreUI.Controls.cuiButton killBtn;
        private CuoreUI.Controls.cuiButton addModBtn;
        private CuoreUI.Controls.cuiButton openInstDirBtn;
        private CuoreUI.Controls.cuiButton editInstBtn;
        private CuoreUI.Controls.cuiButton launchOptsBtn;
    }
}

