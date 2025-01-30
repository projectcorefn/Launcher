namespace Core_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormDrag1 = new CuoreUI.cuiFormDrag(this.components);
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.SuspendLayout();
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.EnhanceCorners = false;
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder1.Rounding = 8;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox1.BackgroundImage")));
            this.cuiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cuiPictureBox1.Content = null;
            this.cuiPictureBox1.CornerRadius = 8;
            this.cuiPictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(4, 5);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Size = new System.Drawing.Size(29, 29);
            this.cuiPictureBox1.TabIndex = 1;
            this.cuiPictureBox1.Load += new System.EventHandler(this.cuiPictureBox1_Load);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Core\\ Launcher";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Quicksand Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel1.Location = new System.Drawing.Point(41, 9);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(134, 22);
            this.cuiLabel1.TabIndex = 2;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "0\\.5\\.3\\ TESTING";
            this.cuiLabel2.Enabled = false;
            this.cuiLabel2.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.Purple;
            this.cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel2.Location = new System.Drawing.Point(174, 9);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(122, 22);
            this.cuiLabel2.TabIndex = 3;
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton2.Content = "X";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Quicksand Book", 12F, System.Drawing.FontStyle.Bold);
            this.cuiButton2.ForeColor = System.Drawing.Color.Fuchsia;
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.Location = new System.Drawing.Point(1223, 2);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton2.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton2.OutlineThickness = 1.6F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cuiButton2.PressedForeColor = System.Drawing.Color.Gainsboro;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(7);
            this.cuiButton2.Size = new System.Drawing.Size(37, 37);
            this.cuiButton2.TabIndex = 5;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, -1);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MainPanel.Location = new System.Drawing.Point(12, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1240, 615);
            this.MainPanel.TabIndex = 6;
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton1.Content = "";
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Enabled = false;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(0, 41);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton1.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton1.OutlineThickness = 1.6F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton1.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(10);
            this.cuiButton1.Size = new System.Drawing.Size(1264, 813);
            this.cuiButton1.TabIndex = 8;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton3.Content = "i";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Quicksand Book", 15F, System.Drawing.FontStyle.Bold);
            this.cuiButton3.ForeColor = System.Drawing.Color.Fuchsia;
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageTint = System.Drawing.Color.White;
            this.cuiButton3.Location = new System.Drawing.Point(1180, 2);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cuiButton3.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton3.OutlineThickness = 1.6F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cuiButton3.PressedForeColor = System.Drawing.Color.Gainsboro;
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(7);
            this.cuiButton3.Size = new System.Drawing.Size(37, 37);
            this.cuiButton3.TabIndex = 9;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, -1);
            this.cuiButton3.Click += new System.EventHandler(this.cuiButton3_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cuiButton3);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Core Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.cuiFormDrag cuiFormDrag1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.Panel MainPanel;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
    }
}

