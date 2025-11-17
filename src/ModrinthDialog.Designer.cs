namespace YAMCL
{
    partial class ModrinthDialog
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
            this.roundedCorners = new CuoreUI.Components.cuiFormRounder();
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.modList = new CuoreUI.Controls.cuiListbox();
            this.searchBox = new CuoreUI.Controls.cuiTextBox();
            this.installBtn = new CuoreUI.Controls.cuiButton();
            this.closeBtn = new CuoreUI.Controls.cuiButton();
            this.searchBtn = new CuoreUI.Controls.cuiButton();
            this.progBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
            this.statusLbl = new CuoreUI.Controls.cuiLabel();
            this.SuspendLayout();
            // 
            // roundedCorners
            // 
            this.roundedCorners.OutlineColor = System.Drawing.Color.Black;
            this.roundedCorners.Rounding = 4;
            this.roundedCorners.TargetForm = this;
            // 
            // formDrag
            // 
            this.formDrag.TargetForm = this;
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
            // modList
            // 
            this.modList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.modList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.modList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modList.DisplayMember = "Title";
            this.modList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.modList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.modList.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.modList.FormattingEnabled = true;
            this.modList.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.modList.ItemHeight = 34;
            this.modList.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.modList.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.modList.ItemRounding = 12;
            this.modList.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.modList.Location = new System.Drawing.Point(12, 65);
            this.modList.Name = "modList";
            this.modList.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modList.Rounding = new System.Windows.Forms.Padding(8);
            this.modList.SelectedForegroundColor = System.Drawing.Color.White;
            this.modList.Size = new System.Drawing.Size(704, 442);
            this.modList.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.searchBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.searchBox.Content = "";
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.searchBox.FocusImageTint = System.Drawing.Color.White;
            this.searchBox.FocusOutlineColor = System.Drawing.Color.White;
            this.searchBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.searchBox.Image = null;
            this.searchBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.searchBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchBox.Location = new System.Drawing.Point(13, 13);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.NormalImageTint = System.Drawing.Color.White;
            this.searchBox.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchBox.Padding = new System.Windows.Forms.Padding(17, 14, 17, 0);
            this.searchBox.PasswordChar = false;
            this.searchBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.Rounding = new System.Windows.Forms.Padding(8);
            this.searchBox.Size = new System.Drawing.Size(611, 45);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextOffset = new System.Drawing.Size(0, 0);
            this.searchBox.UnderlinedStyle = true;
            // 
            // installBtn
            // 
            this.installBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.installBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installBtn.CheckButton = false;
            this.installBtn.Checked = false;
            this.installBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.installBtn.CheckedForeColor = System.Drawing.Color.White;
            this.installBtn.CheckedImageTint = System.Drawing.Color.White;
            this.installBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.installBtn.Content = "Install";
            this.installBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.installBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.installBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.installBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.installBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.installBtn.HoverImageTint = System.Drawing.Color.White;
            this.installBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.installBtn.Image = null;
            this.installBtn.ImageAutoCenter = true;
            this.installBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.installBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.installBtn.Location = new System.Drawing.Point(632, 515);
            this.installBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.installBtn.Name = "installBtn";
            this.installBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.installBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.installBtn.NormalImageTint = System.Drawing.Color.White;
            this.installBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.installBtn.OutlineThickness = 1F;
            this.installBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.installBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.installBtn.PressedImageTint = System.Drawing.Color.White;
            this.installBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.installBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.installBtn.Size = new System.Drawing.Size(83, 44);
            this.installBtn.TabIndex = 11;
            this.installBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.installBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.closeBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeBtn.CheckButton = false;
            this.closeBtn.Checked = false;
            this.closeBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.closeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.closeBtn.CheckedImageTint = System.Drawing.Color.White;
            this.closeBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.closeBtn.Content = "Close";
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
            this.closeBtn.Location = new System.Drawing.Point(12, 515);
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
            this.closeBtn.Size = new System.Drawing.Size(83, 44);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.closeBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.searchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBtn.CheckButton = false;
            this.searchBtn.Checked = false;
            this.searchBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.searchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.searchBtn.CheckedImageTint = System.Drawing.Color.White;
            this.searchBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.searchBtn.Content = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.searchBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.searchBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.searchBtn.HoverImageTint = System.Drawing.Color.White;
            this.searchBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchBtn.Image = null;
            this.searchBtn.ImageAutoCenter = true;
            this.searchBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.searchBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchBtn.Location = new System.Drawing.Point(632, 14);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.searchBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.searchBtn.NormalImageTint = System.Drawing.Color.White;
            this.searchBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchBtn.OutlineThickness = 1F;
            this.searchBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.searchBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.searchBtn.PressedImageTint = System.Drawing.Color.White;
            this.searchBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.searchBtn.Size = new System.Drawing.Size(83, 44);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.searchBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.Background = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar.Flipped = false;
            this.progBar.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.progBar.Location = new System.Drawing.Point(13, 567);
            this.progBar.MaxValue = 100;
            this.progBar.Name = "progBar";
            this.progBar.Rounding = 8;
            this.progBar.Size = new System.Drawing.Size(703, 26);
            this.progBar.TabIndex = 16;
            this.progBar.Value = 0;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLbl.Content = "Nothing\\ to\\ do";
            this.statusLbl.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.statusLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.statusLbl.Location = new System.Drawing.Point(102, 513);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(523, 46);
            this.statusLbl.TabIndex = 17;
            this.statusLbl.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ModrinthDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(728, 606);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.modList);
            this.Font = new System.Drawing.Font("Inter", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModrinthDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for mods";
            this.Load += new System.EventHandler(this.ModrinthDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormRounder roundedCorners;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiListbox modList;
        private CuoreUI.Controls.cuiTextBox searchBox;
        private CuoreUI.Controls.cuiButton installBtn;
        private CuoreUI.Controls.cuiButton closeBtn;
        private CuoreUI.Controls.cuiButton searchBtn;
        private CuoreUI.Controls.cuiProgressBarHorizontal progBar;
        private CuoreUI.Controls.cuiLabel statusLbl;
    }
}