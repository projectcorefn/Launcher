namespace Core_Launcher.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiTextBox1 = new cuiTextBox();
            this.cuiTextBox2 = new cuiTextBox();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag1 = new CuoreUI.cuiFormDrag(this.components);
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.SuspendLayout();
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.EnhanceCorners = false;
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder1.Rounding = 8;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Login\\ To";
            this.cuiLabel2.Enabled = false;
            this.cuiLabel2.Font = new System.Drawing.Font("Caviar Dreams", 50F, System.Drawing.FontStyle.Bold);
            this.cuiLabel2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(198, 38);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(308, 81);
            this.cuiLabel2.TabIndex = 11;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Core";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Caviar Dreams", 50F, System.Drawing.FontStyle.Bold);
            this.cuiLabel1.ForeColor = System.Drawing.Color.Magenta;
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(497, 38);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(192, 81);
            this.cuiLabel1.TabIndex = 10;
            // 
            // cuiTextBox1
            // 
            this.cuiTextBox1.Background = System.Drawing.Color.Black;
            this.cuiTextBox1.Border = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiTextBox1.BorderRadius = new System.Windows.Forms.Padding(16, 16, 8, 8);
            this.cuiTextBox1.BorderSize = 2F;
            this.cuiTextBox1.Content = "";
            this.cuiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox1.DesignStyle = cuiTextBox.Styles.Full;
            this.cuiTextBox1.FocusedBackground = System.Drawing.Color.Black;
            this.cuiTextBox1.FocusedBorder = System.Drawing.Color.Magenta;
            this.cuiTextBox1.Font = new System.Drawing.Font("Caviar Dreams", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cuiTextBox1.ForeColor = System.Drawing.Color.Magenta;
            this.cuiTextBox1.Location = new System.Drawing.Point(75, 162);
            this.cuiTextBox1.Name = "cuiTextBox1";
            this.cuiTextBox1.PartialThickness = 2F;
            this.cuiTextBox1.Placeholder = "Email";
            this.cuiTextBox1.PlaceholderColor = System.Drawing.Color.Purple;
            this.cuiTextBox1.Size = new System.Drawing.Size(748, 58);
            this.cuiTextBox1.TabIndex = 13;
            this.cuiTextBox1.UsePasswordChar = false;
            // 
            // cuiTextBox2
            // 
            this.cuiTextBox2.Background = System.Drawing.Color.Black;
            this.cuiTextBox2.Border = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiTextBox2.BorderRadius = new System.Windows.Forms.Padding(8, 8, 16, 16);
            this.cuiTextBox2.BorderSize = 2F;
            this.cuiTextBox2.Content = "";
            this.cuiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTextBox2.DesignStyle = cuiTextBox.Styles.Full;
            this.cuiTextBox2.FocusedBackground = System.Drawing.Color.Black;
            this.cuiTextBox2.FocusedBorder = System.Drawing.Color.Magenta;
            this.cuiTextBox2.Font = new System.Drawing.Font("Caviar Dreams", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cuiTextBox2.ForeColor = System.Drawing.Color.Magenta;
            this.cuiTextBox2.Location = new System.Drawing.Point(75, 226);
            this.cuiTextBox2.Name = "cuiTextBox2";
            this.cuiTextBox2.PartialThickness = 2F;
            this.cuiTextBox2.Placeholder = "Password";
            this.cuiTextBox2.PlaceholderColor = System.Drawing.Color.Purple;
            this.cuiTextBox2.Size = new System.Drawing.Size(748, 58);
            this.cuiTextBox2.TabIndex = 14;
            this.cuiTextBox2.UsePasswordChar = true;
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Login to Core";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Caviar Dreams", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cuiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(130, 328);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Black;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton1.OutlineThickness = 2F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Purple;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8, 16, 16, 8);
            this.cuiButton1.Size = new System.Drawing.Size(310, 54);
            this.cuiButton1.TabIndex = 15;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click_1);
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "Create an account";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Caviar Dreams", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cuiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.Location = new System.Drawing.Point(446, 328);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Black;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton2.OutlineThickness = 2F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Purple;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(16, 8, 8, 16);
            this.cuiButton2.Size = new System.Drawing.Size(310, 54);
            this.cuiButton2.TabIndex = 16;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // cuiFormAnimator1
            // 
            this.cuiFormAnimator1.AnimateOnStart = true;
            this.cuiFormAnimator1.Duration = 400;
            this.cuiFormAnimator1.EasingType = CuoreUI.Drawing.EasingTypes.QuadOut;
            this.cuiFormAnimator1.StartOpacity = 0D;
            this.cuiFormAnimator1.TargetForm = this;
            this.cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Use\\ Saved\\ Login";
            this.cuiLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiLabel3.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold);
            this.cuiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(3, 422);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(150, 24);
            this.cuiLabel3.TabIndex = 19;
            this.cuiLabel3.Click += new System.EventHandler(this.cuiLabel4_Click);
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Delete\\ Saved\\ Login";
            this.cuiLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiLabel4.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold);
            this.cuiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(737, 422);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(167, 24);
            this.cuiLabel4.TabIndex = 20;
            this.cuiLabel4.Click += new System.EventHandler(this.cuiLabel3_Load);
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.Content = "";
            this.cuiLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiLabel5.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold);
            this.cuiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(177, 422);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(554, 24);
            this.cuiLabel5.TabIndex = 21;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.cuiLabel5);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.cuiLabel3);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.cuiTextBox2);
            this.Controls.Add(this.cuiTextBox1);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private cuiTextBox cuiTextBox2;
        private cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
        private CuoreUI.cuiFormDrag cuiFormDrag1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
    }
}