namespace MovieBonanza_OnlineStream
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryTextBox5 = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox4 = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDChargeLabel = new System.Windows.Forms.Label();
            this.DVDChargeTextBox10 = new System.Windows.Forms.TextBox();
            this.DividerLabel = new System.Windows.Forms.Label();
            this.OptionalDVDCheckBox = new System.Windows.Forms.CheckBox();
            this.GrantTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox9 = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox8 = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox7 = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.CostTextBox6 = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.YourOrderGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MovieSelectedGroupBox.Controls.Add(this.MoviePictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox5);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox4);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(297, 437);
            this.MovieSelectedGroupBox.TabIndex = 0;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            this.MovieSelectedGroupBox.Enter += new System.EventHandler(this.MovieSelectedGroupBox_Enter);
            // 
            // CategoryTextBox5
            // 
            this.CategoryTextBox5.Location = new System.Drawing.Point(7, 81);
            this.CategoryTextBox5.Name = "CategoryTextBox5";
            this.CategoryTextBox5.ReadOnly = true;
            this.CategoryTextBox5.Size = new System.Drawing.Size(284, 20);
            this.CategoryTextBox5.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(7, 64);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox4
            // 
            this.TitleTextBox4.Location = new System.Drawing.Point(7, 37);
            this.TitleTextBox4.Name = "TitleTextBox4";
            this.TitleTextBox4.ReadOnly = true;
            this.TitleTextBox4.Size = new System.Drawing.Size(284, 20);
            this.TitleTextBox4.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(7, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.YourOrderGroupBox.Controls.Add(this.DVDChargeLabel);
            this.YourOrderGroupBox.Controls.Add(this.DVDChargeTextBox10);
            this.YourOrderGroupBox.Controls.Add(this.DividerLabel);
            this.YourOrderGroupBox.Controls.Add(this.OptionalDVDCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.GrantTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox9);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox8);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalTextBox7);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox6);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(315, 27);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(309, 300);
            this.YourOrderGroupBox.TabIndex = 1;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // DVDChargeLabel
            // 
            this.DVDChargeLabel.AutoSize = true;
            this.DVDChargeLabel.Location = new System.Drawing.Point(59, 93);
            this.DVDChargeLabel.Name = "DVDChargeLabel";
            this.DVDChargeLabel.Size = new System.Drawing.Size(67, 13);
            this.DVDChargeLabel.TabIndex = 11;
            this.DVDChargeLabel.Text = "DVD Charge";
            this.DVDChargeLabel.Visible = false;
            // 
            // DVDChargeTextBox10
            // 
            this.DVDChargeTextBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DVDChargeTextBox10.Location = new System.Drawing.Point(142, 93);
            this.DVDChargeTextBox10.Name = "DVDChargeTextBox10";
            this.DVDChargeTextBox10.ReadOnly = true;
            this.DVDChargeTextBox10.Size = new System.Drawing.Size(87, 20);
            this.DVDChargeTextBox10.TabIndex = 10;
            this.DVDChargeTextBox10.Visible = false;
            // 
            // DividerLabel
            // 
            this.DividerLabel.AutoSize = true;
            this.DividerLabel.Location = new System.Drawing.Point(120, 142);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(97, 13);
            this.DividerLabel.TabIndex = 9;
            this.DividerLabel.Text = "_______________";
            // 
            // OptionalDVDCheckBox
            // 
            this.OptionalDVDCheckBox.AutoSize = true;
            this.OptionalDVDCheckBox.Location = new System.Drawing.Point(30, 256);
            this.OptionalDVDCheckBox.Name = "OptionalDVDCheckBox";
            this.OptionalDVDCheckBox.Size = new System.Drawing.Size(226, 17);
            this.OptionalDVDCheckBox.TabIndex = 8;
            this.OptionalDVDCheckBox.Text = "Order the DVD (adds $10.00 to your order)";
            this.OptionalDVDCheckBox.UseVisualStyleBackColor = true;
            this.OptionalDVDCheckBox.CheckedChanged += new System.EventHandler(this.OptionalDVDCheckBox_CheckedChanged);
            // 
            // GrantTotalLabel
            // 
            this.GrantTotalLabel.AutoSize = true;
            this.GrantTotalLabel.Location = new System.Drawing.Point(63, 200);
            this.GrantTotalLabel.Name = "GrantTotalLabel";
            this.GrantTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.GrantTotalLabel.TabIndex = 7;
            this.GrantTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(43, 164);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.SalesTaxLabel.TabIndex = 6;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // GrandTotalTextBox9
            // 
            this.GrandTotalTextBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrandTotalTextBox9.Location = new System.Drawing.Point(142, 193);
            this.GrandTotalTextBox9.Name = "GrandTotalTextBox9";
            this.GrandTotalTextBox9.ReadOnly = true;
            this.GrandTotalTextBox9.Size = new System.Drawing.Size(87, 20);
            this.GrandTotalTextBox9.TabIndex = 5;
            // 
            // SalesTaxTextBox8
            // 
            this.SalesTaxTextBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesTaxTextBox8.Location = new System.Drawing.Point(142, 164);
            this.SalesTaxTextBox8.Name = "SalesTaxTextBox8";
            this.SalesTaxTextBox8.ReadOnly = true;
            this.SalesTaxTextBox8.Size = new System.Drawing.Size(87, 20);
            this.SalesTaxTextBox8.TabIndex = 4;
            // 
            // SubTotalTextBox7
            // 
            this.SubTotalTextBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalTextBox7.Location = new System.Drawing.Point(142, 122);
            this.SubTotalTextBox7.Name = "SubTotalTextBox7";
            this.SubTotalTextBox7.ReadOnly = true;
            this.SubTotalTextBox7.Size = new System.Drawing.Size(87, 20);
            this.SubTotalTextBox7.TabIndex = 3;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(76, 125);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(50, 13);
            this.SubTotalLabel.TabIndex = 2;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // CostTextBox6
            // 
            this.CostTextBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CostTextBox6.Location = new System.Drawing.Point(142, 61);
            this.CostTextBox6.Name = "CostTextBox6";
            this.CostTextBox6.ReadOnly = true;
            this.CostTextBox6.Size = new System.Drawing.Size(87, 20);
            this.CostTextBox6.TabIndex = 1;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(98, 64);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.backToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Strea&m";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "&Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(315, 441);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(538, 441);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "&Stream";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.streamToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(457, 441);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoviePictureBox.Location = new System.Drawing.Point(10, 122);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(272, 300);
            this.MoviePictureBox.TabIndex = 4;
            this.MoviePictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(617, 472);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Your Order";
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.TextBox CategoryTextBox5;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox4;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox OptionalDVDCheckBox;
        private System.Windows.Forms.Label GrantTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox GrandTotalTextBox9;
        private System.Windows.Forms.TextBox SalesTaxTextBox8;
        private System.Windows.Forms.TextBox SubTotalTextBox7;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox CostTextBox6;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label DividerLabel;
        private System.Windows.Forms.Label DVDChargeLabel;
        private System.Windows.Forms.TextBox DVDChargeTextBox10;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}