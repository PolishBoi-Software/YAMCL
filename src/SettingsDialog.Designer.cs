namespace YAMCL
{
    partial class SettingsDialog
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
            this.okBtn = new CuoreUI.Controls.cuiButton();
            this.autoSignInCheck = new CuoreUI.Controls.cuiSwitch();
            this.autoSignInLbl = new CuoreUI.Controls.cuiLabel();
            this.autoSignInLblTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.formDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.formRounder = new CuoreUI.Components.cuiFormRounder();
            this.cancelBtn = new CuoreUI.Controls.cuiButton();
            this.formAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.autoUpdateLbl = new CuoreUI.Controls.cuiLabel();
            this.autoUpdateCheck = new CuoreUI.Controls.cuiSwitch();
            this.autoUpdateLblTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.discordRpcLbl = new CuoreUI.Controls.cuiLabel();
            this.discordRpcCheck = new CuoreUI.Controls.cuiSwitch();
            this.discordRpcLblTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.checkUpdateBtn = new CuoreUI.Controls.cuiButton();
            this.displayLogsLblTooltip = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.SuspendLayout();
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
            this.okBtn.Location = new System.Drawing.Point(641, 340);
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
            this.okBtn.TabIndex = 11;
            this.okBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.okBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // autoSignInCheck
            // 
            this.autoSignInCheck.Checked = false;
            this.autoSignInCheck.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.autoSignInCheck.CheckedForeground = System.Drawing.Color.White;
            this.autoSignInCheck.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.autoSignInCheck.CheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.autoSignInCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoSignInCheck.Location = new System.Drawing.Point(12, 12);
            this.autoSignInCheck.MinimumSize = new System.Drawing.Size(12, 8);
            this.autoSignInCheck.Name = "autoSignInCheck";
            this.autoSignInCheck.OutlineThickness = 1F;
            this.autoSignInCheck.ShowSymbols = false;
            this.autoSignInCheck.Size = new System.Drawing.Size(48, 26);
            this.autoSignInCheck.TabIndex = 12;
            this.autoSignInCheck.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.autoSignInCheck.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.autoSignInCheck.UncheckedForeground = System.Drawing.Color.White;
            this.autoSignInCheck.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.autoSignInCheck.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // autoSignInLbl
            // 
            this.autoSignInLbl.Content = "Auto\\ Sign\\ In";
            this.autoSignInLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.autoSignInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.autoSignInLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.autoSignInLbl.Location = new System.Drawing.Point(66, 15);
            this.autoSignInLbl.Name = "autoSignInLbl";
            this.autoSignInLbl.Size = new System.Drawing.Size(210, 20);
            this.autoSignInLbl.TabIndex = 13;
            this.autoSignInLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // autoSignInLblTooltip
            // 
            this.autoSignInLblTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.autoSignInLblTooltip.Content = "Asks you if you want to sign in with a Microsoft account (or an offline one) on s" +
    "tartup.";
            this.autoSignInLblTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.autoSignInLblTooltip.TargetControl = this.autoSignInLbl;
            this.autoSignInLblTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.autoSignInLblTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
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
            this.cancelBtn.Location = new System.Drawing.Point(13, 340);
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
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            // autoUpdateLbl
            // 
            this.autoUpdateLbl.Content = "Auto\\ Update";
            this.autoUpdateLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.autoUpdateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.autoUpdateLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.autoUpdateLbl.Location = new System.Drawing.Point(66, 54);
            this.autoUpdateLbl.Name = "autoUpdateLbl";
            this.autoUpdateLbl.Size = new System.Drawing.Size(210, 20);
            this.autoUpdateLbl.TabIndex = 16;
            this.autoUpdateLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // autoUpdateCheck
            // 
            this.autoUpdateCheck.Checked = false;
            this.autoUpdateCheck.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.autoUpdateCheck.CheckedForeground = System.Drawing.Color.White;
            this.autoUpdateCheck.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.autoUpdateCheck.CheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.autoUpdateCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoUpdateCheck.Location = new System.Drawing.Point(12, 51);
            this.autoUpdateCheck.MinimumSize = new System.Drawing.Size(12, 8);
            this.autoUpdateCheck.Name = "autoUpdateCheck";
            this.autoUpdateCheck.OutlineThickness = 1F;
            this.autoUpdateCheck.ShowSymbols = false;
            this.autoUpdateCheck.Size = new System.Drawing.Size(48, 26);
            this.autoUpdateCheck.TabIndex = 15;
            this.autoUpdateCheck.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.autoUpdateCheck.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.autoUpdateCheck.UncheckedForeground = System.Drawing.Color.White;
            this.autoUpdateCheck.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.autoUpdateCheck.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // autoUpdateLblTooltip
            // 
            this.autoUpdateLblTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.autoUpdateLblTooltip.Content = "Automatically checks for updates on startup.";
            this.autoUpdateLblTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.autoUpdateLblTooltip.TargetControl = this.autoUpdateLbl;
            this.autoUpdateLblTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.autoUpdateLblTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // discordRpcLbl
            // 
            this.discordRpcLbl.Content = "Discord\\ RPC";
            this.discordRpcLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.discordRpcLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.discordRpcLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.discordRpcLbl.Location = new System.Drawing.Point(66, 95);
            this.discordRpcLbl.Name = "discordRpcLbl";
            this.discordRpcLbl.Size = new System.Drawing.Size(210, 20);
            this.discordRpcLbl.TabIndex = 18;
            this.discordRpcLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // discordRpcCheck
            // 
            this.discordRpcCheck.Checked = false;
            this.discordRpcCheck.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.discordRpcCheck.CheckedForeground = System.Drawing.Color.White;
            this.discordRpcCheck.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.discordRpcCheck.CheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.discordRpcCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordRpcCheck.Location = new System.Drawing.Point(12, 92);
            this.discordRpcCheck.MinimumSize = new System.Drawing.Size(12, 8);
            this.discordRpcCheck.Name = "discordRpcCheck";
            this.discordRpcCheck.OutlineThickness = 1F;
            this.discordRpcCheck.ShowSymbols = false;
            this.discordRpcCheck.Size = new System.Drawing.Size(48, 26);
            this.discordRpcCheck.TabIndex = 17;
            this.discordRpcCheck.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.discordRpcCheck.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.discordRpcCheck.UncheckedForeground = System.Drawing.Color.White;
            this.discordRpcCheck.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.discordRpcCheck.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // discordRpcLblTooltip
            // 
            this.discordRpcLblTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.discordRpcLblTooltip.Content = "Displays YAMCL in your Discord rich presence.";
            this.discordRpcLblTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.discordRpcLblTooltip.TargetControl = this.discordRpcLbl;
            this.discordRpcLblTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.discordRpcLblTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // checkUpdateBtn
            // 
            this.checkUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkUpdateBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkUpdateBtn.CheckButton = false;
            this.checkUpdateBtn.Checked = false;
            this.checkUpdateBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkUpdateBtn.CheckedForeColor = System.Drawing.Color.White;
            this.checkUpdateBtn.CheckedImageTint = System.Drawing.Color.White;
            this.checkUpdateBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkUpdateBtn.Content = "Check for updates";
            this.checkUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkUpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkUpdateBtn.Font = new System.Drawing.Font("Inter", 12F);
            this.checkUpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.checkUpdateBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.checkUpdateBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.checkUpdateBtn.HoverImageTint = System.Drawing.Color.White;
            this.checkUpdateBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkUpdateBtn.Image = null;
            this.checkUpdateBtn.ImageAutoCenter = true;
            this.checkUpdateBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.checkUpdateBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.checkUpdateBtn.Location = new System.Drawing.Point(544, 15);
            this.checkUpdateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkUpdateBtn.Name = "checkUpdateBtn";
            this.checkUpdateBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkUpdateBtn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.checkUpdateBtn.NormalImageTint = System.Drawing.Color.White;
            this.checkUpdateBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkUpdateBtn.OutlineThickness = 1F;
            this.checkUpdateBtn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkUpdateBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.checkUpdateBtn.PressedImageTint = System.Drawing.Color.White;
            this.checkUpdateBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkUpdateBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.checkUpdateBtn.Size = new System.Drawing.Size(180, 44);
            this.checkUpdateBtn.TabIndex = 19;
            this.checkUpdateBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.checkUpdateBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.checkUpdateBtn.Click += new System.EventHandler(this.checkUpdateBtn_Click);
            // 
            // displayLogsLblTooltip
            // 
            this.displayLogsLblTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.displayLogsLblTooltip.Content = "Logs what Minecraft is doing.";
            this.displayLogsLblTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.displayLogsLblTooltip.TargetControl = null;
            this.displayLogsLblTooltip.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.displayLogsLblTooltip.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(737, 398);
            this.Controls.Add(this.checkUpdateBtn);
            this.Controls.Add(this.discordRpcLbl);
            this.Controls.Add(this.discordRpcCheck);
            this.Controls.Add(this.autoUpdateLbl);
            this.Controls.Add(this.autoUpdateCheck);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.autoSignInLbl);
            this.Controls.Add(this.autoSignInCheck);
            this.Controls.Add(this.okBtn);
            this.Font = new System.Drawing.Font("Inter", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton okBtn;
        private CuoreUI.Controls.cuiSwitch autoSignInCheck;
        private CuoreUI.Controls.cuiLabel autoSignInLbl;
        private CuoreUI.Components.cuiTooltipHover autoSignInLblTooltip;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Components.cuiFormRounder formRounder;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Components.cuiFormAnimator formAnimator;
        private CuoreUI.Controls.cuiLabel autoUpdateLbl;
        private CuoreUI.Controls.cuiSwitch autoUpdateCheck;
        private CuoreUI.Components.cuiTooltipHover autoUpdateLblTooltip;
        private CuoreUI.Controls.cuiLabel discordRpcLbl;
        private CuoreUI.Controls.cuiSwitch discordRpcCheck;
        private CuoreUI.Components.cuiTooltipHover discordRpcLblTooltip;
        private CuoreUI.Controls.cuiButton checkUpdateBtn;
        private CuoreUI.Components.cuiTooltipHover displayLogsLblTooltip;
    }
}