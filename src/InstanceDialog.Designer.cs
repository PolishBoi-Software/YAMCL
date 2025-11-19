namespace YAMCL
{
    partial class InstanceDialog
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
            this.nameBox = new CuoreUI.Controls.cuiTextBox();
            this.versionList = new CuoreUI.Controls.cuiListbox();
            this.nameLbl = new CuoreUI.Controls.cuiLabel();
            this.okBtn = new CuoreUI.Controls.cuiButton();
            this.cancelBtn = new CuoreUI.Controls.cuiButton();
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.formRounder = new CuoreUI.Components.cuiFormRounder();
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.versionLbl = new CuoreUI.Controls.cuiLabel();
            this.modLoaderLbl = new CuoreUI.Controls.cuiLabel();
            this.modLoaderList = new CuoreUI.Controls.cuiListbox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.nameBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.nameBox.Content = "";
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.nameBox.FocusImageTint = System.Drawing.Color.White;
            this.nameBox.FocusOutlineColor = System.Drawing.Color.White;
            this.nameBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold);
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.nameBox.Image = null;
            this.nameBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.nameBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.nameBox.Location = new System.Drawing.Point(12, 32);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.NormalImageTint = System.Drawing.Color.White;
            this.nameBox.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nameBox.Padding = new System.Windows.Forms.Padding(17, 14, 17, 0);
            this.nameBox.PasswordChar = false;
            this.nameBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.nameBox.PlaceholderText = "Name";
            this.nameBox.Rounding = new System.Windows.Forms.Padding(8);
            this.nameBox.Size = new System.Drawing.Size(509, 45);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextOffset = new System.Drawing.Size(0, 0);
            this.nameBox.UnderlinedStyle = true;
            // 
            // versionList
            // 
            this.versionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.versionList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.versionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionList.DisplayMember = "Name";
            this.versionList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.versionList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.versionList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.versionList.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.versionList.FormattingEnabled = true;
            this.versionList.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.versionList.ItemHeight = 34;
            this.versionList.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.versionList.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.versionList.ItemRounding = 8;
            this.versionList.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.versionList.Location = new System.Drawing.Point(12, 123);
            this.versionList.Name = "versionList";
            this.versionList.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.versionList.Rounding = new System.Windows.Forms.Padding(8);
            this.versionList.SelectedForegroundColor = System.Drawing.Color.White;
            this.versionList.Size = new System.Drawing.Size(509, 374);
            this.versionList.TabIndex = 7;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLbl.Content = "Instance\\ name:";
            this.nameLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.nameLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.nameLbl.Location = new System.Drawing.Point(159, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(210, 20);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.okBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.okBtn.CheckButton = false;
            this.okBtn.Checked = false;
            this.okBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.okBtn.CheckedForeColor = System.Drawing.Color.White;
            this.okBtn.CheckedImageTint = System.Drawing.Color.White;
            this.okBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.okBtn.Content = "OK";
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.okBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.okBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.okBtn.HoverImageTint = System.Drawing.Color.White;
            this.okBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.okBtn.Image = null;
            this.okBtn.ImageAutoCenter = true;
            this.okBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.okBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.okBtn.Location = new System.Drawing.Point(438, 746);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okBtn.Name = "okBtn";
            this.okBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.okBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.okBtn.NormalImageTint = System.Drawing.Color.White;
            this.okBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.okBtn.OutlineThickness = 1F;
            this.okBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.okBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.okBtn.PressedImageTint = System.Drawing.Color.White;
            this.okBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.okBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.okBtn.Size = new System.Drawing.Size(83, 44);
            this.okBtn.TabIndex = 10;
            this.okBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.okBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cancelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cancelBtn.CheckButton = false;
            this.cancelBtn.Checked = false;
            this.cancelBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cancelBtn.CheckedForeColor = System.Drawing.Color.White;
            this.cancelBtn.CheckedImageTint = System.Drawing.Color.White;
            this.cancelBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cancelBtn.Content = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.cancelBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.cancelBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.cancelBtn.HoverImageTint = System.Drawing.Color.White;
            this.cancelBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageAutoCenter = true;
            this.cancelBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cancelBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cancelBtn.Location = new System.Drawing.Point(12, 746);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cancelBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.cancelBtn.NormalImageTint = System.Drawing.Color.White;
            this.cancelBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.OutlineThickness = 1F;
            this.cancelBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cancelBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.cancelBtn.PressedImageTint = System.Drawing.Color.White;
            this.cancelBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.cancelBtn.Size = new System.Drawing.Size(83, 44);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // formDrag
            // 
            this.formDrag.TargetForm = this;
            // 
            // formRounder
            // 
            this.formRounder.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.formRounder.Rounding = 4;
            this.formRounder.TargetForm = this;
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
            // versionLbl
            // 
            this.versionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLbl.Content = "Instance\\ version:";
            this.versionLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.versionLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.versionLbl.Location = new System.Drawing.Point(159, 91);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(210, 20);
            this.versionLbl.TabIndex = 12;
            this.versionLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // modLoaderLbl
            // 
            this.modLoaderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modLoaderLbl.Content = "Mod\\ loader:";
            this.modLoaderLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modLoaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.modLoaderLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.modLoaderLbl.Location = new System.Drawing.Point(159, 503);
            this.modLoaderLbl.Name = "modLoaderLbl";
            this.modLoaderLbl.Size = new System.Drawing.Size(210, 20);
            this.modLoaderLbl.TabIndex = 13;
            this.modLoaderLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // modLoaderList
            // 
            this.modLoaderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modLoaderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.modLoaderList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.modLoaderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modLoaderList.DisplayMember = "Name";
            this.modLoaderList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modLoaderList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.modLoaderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.modLoaderList.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.modLoaderList.FormattingEnabled = true;
            this.modLoaderList.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.modLoaderList.ItemHeight = 34;
            this.modLoaderList.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.modLoaderList.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.modLoaderList.ItemRounding = 8;
            this.modLoaderList.Items.AddRange(new object[] {
            "Fabric",
            "Forge",
            "NeoForge",
            "Quilt",
            "LiteLoader",
            "None"});
            this.modLoaderList.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.modLoaderList.Location = new System.Drawing.Point(12, 529);
            this.modLoaderList.Name = "modLoaderList";
            this.modLoaderList.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modLoaderList.Rounding = new System.Windows.Forms.Padding(8);
            this.modLoaderList.SelectedForegroundColor = System.Drawing.Color.White;
            this.modLoaderList.Size = new System.Drawing.Size(509, 204);
            this.modLoaderList.TabIndex = 14;
            // 
            // InstanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(534, 804);
            this.Controls.Add(this.modLoaderList);
            this.Controls.Add(this.modLoaderLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.versionList);
            this.Controls.Add(this.nameBox);
            this.Font = new System.Drawing.Font("Inter", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstanceDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new instance";
            this.Load += new System.EventHandler(this.InstanceDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiTextBox nameBox;
        private CuoreUI.Controls.cuiListbox versionList;
        private CuoreUI.Controls.cuiLabel nameLbl;
        private CuoreUI.Controls.cuiButton okBtn;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiFormRounder formRounder;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiListbox modLoaderList;
        private CuoreUI.Controls.cuiLabel modLoaderLbl;
        private CuoreUI.Controls.cuiLabel versionLbl;
    }
}