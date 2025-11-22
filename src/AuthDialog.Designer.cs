namespace YAMCL
{
    partial class AuthDialog
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
            this.unameBox = new CuoreUI.Controls.cuiTextBox();
            this.unameLbl = new CuoreUI.Controls.cuiLabel();
            this.signInBtn = new CuoreUI.Controls.cuiButton();
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
            // unameBox
            // 
            this.unameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.unameBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.unameBox.Content = "";
            this.unameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameBox.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.unameBox.FocusImageTint = System.Drawing.Color.White;
            this.unameBox.FocusOutlineColor = System.Drawing.Color.White;
            this.unameBox.Font = new System.Drawing.Font("Inter Medium", 10F, System.Drawing.FontStyle.Bold);
            this.unameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.unameBox.Image = null;
            this.unameBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.unameBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.unameBox.Location = new System.Drawing.Point(13, 44);
            this.unameBox.Margin = new System.Windows.Forms.Padding(4);
            this.unameBox.Multiline = false;
            this.unameBox.Name = "unameBox";
            this.unameBox.NormalImageTint = System.Drawing.Color.White;
            this.unameBox.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.unameBox.Padding = new System.Windows.Forms.Padding(17, 14, 17, 0);
            this.unameBox.PasswordChar = false;
            this.unameBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.unameBox.PlaceholderText = "Username";
            this.unameBox.Rounding = new System.Windows.Forms.Padding(8);
            this.unameBox.Size = new System.Drawing.Size(418, 45);
            this.unameBox.TabIndex = 2;
            this.unameBox.TextOffset = new System.Drawing.Size(0, 0);
            this.unameBox.UnderlinedStyle = true;
            // 
            // unameLbl
            // 
            this.unameLbl.Content = "Username:";
            this.unameLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.unameLbl.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.unameLbl.Location = new System.Drawing.Point(13, 12);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(210, 20);
            this.unameLbl.TabIndex = 10;
            this.unameLbl.VerticalAlignment = System.Drawing.StringAlignment.Near;
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
            this.signInBtn.Location = new System.Drawing.Point(313, 98);
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
            this.signInBtn.Size = new System.Drawing.Size(118, 45);
            this.signInBtn.TabIndex = 11;
            this.signInBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.signInBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // AuthDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(444, 157);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.unameLbl);
            this.Controls.Add(this.unameBox);
            this.Font = new System.Drawing.Font("Inter", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authenticate";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormRounder roundedCorners;
        private CuoreUI.Components.cuiFormDrag formDrag;
        private CuoreUI.Controls.cuiTextBox unameBox;
        private CuoreUI.Controls.cuiLabel unameLbl;
        private CuoreUI.Controls.cuiButton signInBtn;
    }
}