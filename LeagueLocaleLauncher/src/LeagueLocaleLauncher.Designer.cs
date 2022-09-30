namespace LeagueLocaleLauncher
{
    partial class LeagueLocaleLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeagueLocaleLauncher));
            this.RegionComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FunctionBorderPanel = new System.Windows.Forms.Panel();
            this.FunctionPanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.FunctionBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.RegionComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionComboBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.RegionComboBox.FormattingEnabled = true;
            this.RegionComboBox.Location = new System.Drawing.Point(99, 16);
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(152, 22);
            this.RegionComboBox.TabIndex = 1;
            this.RegionComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.RegionComboBox_DrawItem);
            this.RegionComboBox.SelectedIndexChanged += new System.EventHandler(this.RegionComboBox_SelectedIndexChanged);
            this.RegionComboBox.DropDownClosed += new System.EventHandler(this.RegionComboBox_DropDownClosed);
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.LanguageComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.Font = new System.Drawing.Font("Georgia", 9F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(99, 43);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(152, 22);
            this.LanguageComboBox.TabIndex = 2;
            this.LanguageComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LanguageComboBox_DrawItem);
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            this.LanguageComboBox.DropDownClosed += new System.EventHandler(this.LanguageComboBox_DropDownClosed);
            // 
            // RegionLabel
            // 
            this.RegionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RegionLabel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.RegionLabel.Location = new System.Drawing.Point(3, 18);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegionLabel.Size = new System.Drawing.Size(90, 15);
            this.RegionLabel.TabIndex = 5;
            this.RegionLabel.Text = "REGION";
            this.RegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LanguageLabel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.LanguageLabel.Location = new System.Drawing.Point(6, 45);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(87, 15);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "LANGUAGE";
            this.LanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.FunctionPanel.Controls.Add(this.RegionComboBox);
            this.FunctionPanel.Controls.Add(this.LanguageComboBox);
            this.FunctionPanel.Controls.Add(this.LanguageLabel);
            this.FunctionPanel.Controls.Add(this.LaunchButton);
            this.FunctionPanel.Controls.Add(this.RegionLabel);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionPanel.Location = new System.Drawing.Point(3, 0);
            this.FunctionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(305, 133);
            this.FunctionPanel.TabIndex = 10;
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackgroundImage = global::LeagueLocaleLauncher.Properties.Resources.launch_button;
            this.LaunchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaunchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LaunchButton.Location = new System.Drawing.Point(123, 70);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(65, 51);
            this.LaunchButton.TabIndex = 4;
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            this.LaunchButton.MouseEnter += new System.EventHandler(this.LaunchButton_MouseEnter);
            this.LaunchButton.MouseLeave += new System.EventHandler(this.LaunchButton_MouseLeave);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.Controls.Add(this.LogoPictureBox);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.CloseButton);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(311, 41);
            this.TitleBarPanel.TabIndex = 11;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::LeagueLocaleLauncher.Properties.Resources.logo;
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(41, 41);
            this.LogoPictureBox.TabIndex = 10;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPictureBox_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::LeagueLocaleLauncher.Properties.Resources.minimize_button;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.MinimizeButton.Location = new System.Drawing.Point(229, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 41);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::LeagueLocaleLauncher.Properties.Resources.close_button;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.CloseButton.Location = new System.Drawing.Point(270, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 41);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // FunctionBorderPanel
            // 
            this.FunctionBorderPanel.Controls.Add(this.FunctionPanel);
            this.FunctionBorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionBorderPanel.Location = new System.Drawing.Point(0, 41);
            this.FunctionBorderPanel.Name = "FunctionBorderPanel";
            this.FunctionBorderPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.FunctionBorderPanel.Size = new System.Drawing.Size(311, 136);
            this.FunctionBorderPanel.TabIndex = 12;
            // 
            // LeagueLocaleLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(311, 177);
            this.Controls.Add(this.FunctionBorderPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeagueLocaleLauncher";
            this.Text = "League Locale Launcher";
            this.FunctionPanel.ResumeLayout(false);
            this.TitleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.FunctionBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox RegionComboBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel FunctionBorderPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

