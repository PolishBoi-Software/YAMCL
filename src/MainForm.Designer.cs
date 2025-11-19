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
            this.cuiResizeGrip1 = new CuoreUI.Controls.cuiResizeGrip();
            this.createInst = new CuoreUI.Controls.cuiButton();
            this.closeBtn = new CuoreUI.Controls.cuiButton();
            this.miniBtn = new CuoreUI.Controls.cuiButton();
            this.maxBtn = new CuoreUI.Controls.cuiButton();
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.closeBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.maxBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.miniBtnTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.rmInstanceBtn = new CuoreUI.Controls.cuiButton();
            this.progBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
            this.taskLbl = new CuoreUI.Controls.cuiLabel();
            this.downloadProgressLbl = new CuoreUI.Controls.cuiLabel();
            this.taskbarState = new CuoreUI.Components.cuiTaskbarStateController(this.components);
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.settingsBtn = new CuoreUI.Controls.cuiButton();
            this.killBtn = new CuoreUI.Controls.cuiButton();
            this.addModBtn = new CuoreUI.Controls.cuiButton();
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
            this.signInBtn.Location = new System.Drawing.Point(965, 53);
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
            this.launchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.launchBtn.Location = new System.Drawing.Point(965, 536);
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
            this.instanceList.Location = new System.Drawing.Point(12, 118);
            this.instanceList.Name = "instanceList";
            this.instanceList.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.instanceList.Rounding = new System.Windows.Forms.Padding(8);
            this.instanceList.SelectedForegroundColor = System.Drawing.Color.White;
            this.instanceList.Size = new System.Drawing.Size(946, 476);
            this.instanceList.TabIndex = 6;
            // 
            // cuiResizeGrip1
            // 
            this.cuiResizeGrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip1.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip1.GripSize = 2;
            this.cuiResizeGrip1.GripTexture = true;
            this.cuiResizeGrip1.Location = new System.Drawing.Point(1140, 601);
            this.cuiResizeGrip1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cuiResizeGrip1.Name = "cuiResizeGrip1";
            this.cuiResizeGrip1.Size = new System.Drawing.Size(16, 14);
            this.cuiResizeGrip1.SkipBottomRightSquare = false;
            this.cuiResizeGrip1.TabIndex = 9;
            this.cuiResizeGrip1.TargetForm = this;
            this.cuiResizeGrip1.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // createInst
            // 
            this.createInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createInst.CheckButton = false;
            this.createInst.Checked = false;
            this.createInst.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.createInst.CheckedForeColor = System.Drawing.Color.White;
            this.createInst.CheckedImageTint = System.Drawing.Color.White;
            this.createInst.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.createInst.Content = "Create instance";
            this.createInst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createInst.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createInst.Font = new System.Drawing.Font("Inter", 12F);
            this.createInst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInst.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.createInst.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInst.HoverImageTint = System.Drawing.Color.White;
            this.createInst.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInst.Image = null;
            this.createInst.ImageAutoCenter = true;
            this.createInst.ImageExpand = new System.Drawing.Point(0, 0);
            this.createInst.ImageOffset = new System.Drawing.Point(0, 0);
            this.createInst.Location = new System.Drawing.Point(965, 122);
            this.createInst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createInst.Name = "createInst";
            this.createInst.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInst.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInst.NormalImageTint = System.Drawing.Color.White;
            this.createInst.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInst.OutlineThickness = 1F;
            this.createInst.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.createInst.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.createInst.PressedImageTint = System.Drawing.Color.White;
            this.createInst.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.createInst.Rounding = new System.Windows.Forms.Padding(8);
            this.createInst.Size = new System.Drawing.Size(178, 59);
            this.createInst.TabIndex = 10;
            this.createInst.TextAlignment = System.Drawing.StringAlignment.Center;
            this.createInst.TextOffset = new System.Drawing.Point(0, 0);
            this.createInst.Click += new System.EventHandler(this.createInst_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(1120, 4);
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
            this.miniBtn.Location = new System.Drawing.Point(1058, 4);
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
            this.maxBtn.Location = new System.Drawing.Point(1089, 4);
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
            // rmInstanceBtn
            // 
            this.rmInstanceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rmInstanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstanceBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rmInstanceBtn.CheckButton = false;
            this.rmInstanceBtn.Checked = false;
            this.rmInstanceBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.rmInstanceBtn.CheckedForeColor = System.Drawing.Color.White;
            this.rmInstanceBtn.CheckedImageTint = System.Drawing.Color.White;
            this.rmInstanceBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.rmInstanceBtn.Content = "Remove instance";
            this.rmInstanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmInstanceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rmInstanceBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.rmInstanceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstanceBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.rmInstanceBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstanceBtn.HoverImageTint = System.Drawing.Color.White;
            this.rmInstanceBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstanceBtn.Image = null;
            this.rmInstanceBtn.ImageAutoCenter = true;
            this.rmInstanceBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.rmInstanceBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.rmInstanceBtn.Location = new System.Drawing.Point(965, 191);
            this.rmInstanceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rmInstanceBtn.Name = "rmInstanceBtn";
            this.rmInstanceBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstanceBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstanceBtn.NormalImageTint = System.Drawing.Color.White;
            this.rmInstanceBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstanceBtn.OutlineThickness = 1F;
            this.rmInstanceBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.rmInstanceBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rmInstanceBtn.PressedImageTint = System.Drawing.Color.White;
            this.rmInstanceBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rmInstanceBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.rmInstanceBtn.Size = new System.Drawing.Size(178, 59);
            this.rmInstanceBtn.TabIndex = 14;
            this.rmInstanceBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.rmInstanceBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.rmInstanceBtn.Click += new System.EventHandler(this.rmInstanceBtn_Click);
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
            this.progBar.Size = new System.Drawing.Size(946, 26);
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
            this.taskLbl.Size = new System.Drawing.Size(511, 20);
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
            this.downloadProgressLbl.Size = new System.Drawing.Size(457, 20);
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
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.settingsBtn.Location = new System.Drawing.Point(965, 398);
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
            this.killBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.killBtn.Location = new System.Drawing.Point(965, 467);
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
            this.addModBtn.Location = new System.Drawing.Point(965, 260);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1156, 615);
            this.Controls.Add(this.addModBtn);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.rmInstanceBtn);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.miniBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.createInst);
            this.Controls.Add(this.cuiResizeGrip1);
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
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip1;
        private CuoreUI.Controls.cuiButton createInst;
        private CuoreUI.Controls.cuiButton maxBtn;
        private CuoreUI.Controls.cuiButton miniBtn;
        private CuoreUI.Controls.cuiButton closeBtn;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiTooltipHover closeBtnTooltip;
        private CuoreUI.Components.cuiTooltipHover maxBtnTooltip;
        private CuoreUI.Components.cuiTooltipHover miniBtnTooltip;
        private CuoreUI.Controls.cuiButton rmInstanceBtn;
        private CuoreUI.Controls.cuiProgressBarHorizontal progBar;
        private CuoreUI.Controls.cuiLabel taskLbl;
        private CuoreUI.Controls.cuiLabel downloadProgressLbl;
        private CuoreUI.Components.cuiTaskbarStateController taskbarState;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiButton settingsBtn;
        private CuoreUI.Controls.cuiButton killBtn;
        private CuoreUI.Controls.cuiButton addModBtn;
    }
}

