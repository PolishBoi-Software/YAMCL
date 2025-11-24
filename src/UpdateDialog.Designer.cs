namespace YAMCL
{
    partial class UpdateDialog
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
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.formRounder = new CuoreUI.Components.cuiFormRounder();
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.newUpdateLbl = new CuoreUI.Controls.cuiLabel();
            this.installedVersion = new CuoreUI.Controls.cuiLabel();
            this.latestLbl = new CuoreUI.Controls.cuiLabel();
            this.questionLbl = new CuoreUI.Controls.cuiLabel();
            this.yesBtn = new CuoreUI.Controls.cuiButton();
            this.noBtn = new CuoreUI.Controls.cuiButton();
            this.changeLogBtn = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
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
            // newUpdateLbl
            // 
            this.newUpdateLbl.Content = LanguageManager.GetTranslation("dialog.update.newupdate");
            this.newUpdateLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newUpdateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.newUpdateLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.newUpdateLbl.Location = new System.Drawing.Point(12, 12);
            this.newUpdateLbl.Name = "newUpdateLbl";
            this.newUpdateLbl.Size = new System.Drawing.Size(493, 20);
            this.newUpdateLbl.TabIndex = 10;
            this.newUpdateLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // installedVersion
            // 
            this.installedVersion.Content = "Current\\ version:\\ INSTALLED";
            this.installedVersion.Font = new System.Drawing.Font("Inter Medium", 12F);
            this.installedVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.installedVersion.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.installedVersion.Location = new System.Drawing.Point(12, 38);
            this.installedVersion.Name = "installedVersion";
            this.installedVersion.Size = new System.Drawing.Size(493, 20);
            this.installedVersion.TabIndex = 11;
            this.installedVersion.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // latestLbl
            // 
            this.latestLbl.Content = "Latest\\ version:\\ LATEST";
            this.latestLbl.Font = new System.Drawing.Font("Inter Medium", 12F);
            this.latestLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.latestLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.latestLbl.Location = new System.Drawing.Point(12, 64);
            this.latestLbl.Name = "latestLbl";
            this.latestLbl.Size = new System.Drawing.Size(493, 20);
            this.latestLbl.TabIndex = 12;
            this.latestLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // questionLbl
            // 
            this.questionLbl.Content = LanguageManager.GetTranslation("dialog.update.question");
            this.questionLbl.Font = new System.Drawing.Font("Inter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.questionLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.questionLbl.Location = new System.Drawing.Point(12, 133);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(526, 30);
            this.questionLbl.TabIndex = 13;
            this.questionLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // yesBtn
            // 
            this.yesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.yesBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yesBtn.CheckButton = false;
            this.yesBtn.Checked = false;
            this.yesBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.yesBtn.CheckedForeColor = System.Drawing.Color.White;
            this.yesBtn.CheckedImageTint = System.Drawing.Color.White;
            this.yesBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.yesBtn.Content = LanguageManager.GetTranslation("btn.yes.text");
            this.yesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.yesBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.yesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.yesBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.yesBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.yesBtn.HoverImageTint = System.Drawing.Color.White;
            this.yesBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yesBtn.Image = null;
            this.yesBtn.ImageAutoCenter = true;
            this.yesBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.yesBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.yesBtn.Location = new System.Drawing.Point(364, 204);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.yesBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.yesBtn.NormalImageTint = System.Drawing.Color.White;
            this.yesBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yesBtn.OutlineThickness = 1F;
            this.yesBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.yesBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.yesBtn.PressedImageTint = System.Drawing.Color.White;
            this.yesBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yesBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.yesBtn.Size = new System.Drawing.Size(83, 44);
            this.yesBtn.TabIndex = 14;
            this.yesBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.yesBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.noBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noBtn.CheckButton = false;
            this.noBtn.Checked = false;
            this.noBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.noBtn.CheckedForeColor = System.Drawing.Color.White;
            this.noBtn.CheckedImageTint = System.Drawing.Color.White;
            this.noBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.noBtn.Content = LanguageManager.GetTranslation("btn.no.text");
            this.noBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.noBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.noBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.noBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.noBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.noBtn.HoverImageTint = System.Drawing.Color.White;
            this.noBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.noBtn.Image = null;
            this.noBtn.ImageAutoCenter = true;
            this.noBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.noBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.noBtn.Location = new System.Drawing.Point(455, 204);
            this.noBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noBtn.Name = "noBtn";
            this.noBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.noBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.noBtn.NormalImageTint = System.Drawing.Color.White;
            this.noBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.noBtn.OutlineThickness = 1F;
            this.noBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.noBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.noBtn.PressedImageTint = System.Drawing.Color.White;
            this.noBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.noBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.noBtn.Size = new System.Drawing.Size(83, 44);
            this.noBtn.TabIndex = 15;
            this.noBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.noBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // changeLogBtn
            // 
            this.changeLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.changeLogBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeLogBtn.CheckButton = false;
            this.changeLogBtn.Checked = false;
            this.changeLogBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.changeLogBtn.CheckedForeColor = System.Drawing.Color.White;
            this.changeLogBtn.CheckedImageTint = System.Drawing.Color.White;
            this.changeLogBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.changeLogBtn.Content = "View changelog";
            this.changeLogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeLogBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.changeLogBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.changeLogBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.changeLogBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.changeLogBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.changeLogBtn.HoverImageTint = System.Drawing.Color.White;
            this.changeLogBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeLogBtn.Image = null;
            this.changeLogBtn.ImageAutoCenter = true;
            this.changeLogBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.changeLogBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.changeLogBtn.Location = new System.Drawing.Point(13, 204);
            this.changeLogBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeLogBtn.Name = "changeLogBtn";
            this.changeLogBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.changeLogBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.changeLogBtn.NormalImageTint = System.Drawing.Color.White;
            this.changeLogBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeLogBtn.OutlineThickness = 1F;
            this.changeLogBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.changeLogBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.changeLogBtn.PressedImageTint = System.Drawing.Color.White;
            this.changeLogBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeLogBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.changeLogBtn.Size = new System.Drawing.Size(167, 44);
            this.changeLogBtn.TabIndex = 16;
            this.changeLogBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.changeLogBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.changeLogBtn.Click += new System.EventHandler(this.changeLogBtn_Click);
            // 
            // UpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.changeLogBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.latestLbl);
            this.Controls.Add(this.installedVersion);
            this.Controls.Add(this.newUpdateLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = LanguageManager.GetTranslation("dialog.update.newupdate");
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiFormRounder formRounder;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiLabel newUpdateLbl;
        private CuoreUI.Controls.cuiLabel installedVersion;
        private CuoreUI.Controls.cuiLabel latestLbl;
        private CuoreUI.Controls.cuiLabel questionLbl;
        private CuoreUI.Controls.cuiButton noBtn;
        private CuoreUI.Controls.cuiButton yesBtn;
        private CuoreUI.Controls.cuiButton changeLogBtn;
    }
}