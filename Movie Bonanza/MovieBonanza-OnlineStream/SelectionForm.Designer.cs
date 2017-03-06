namespace MovieBonanza_OnlineStream
{
    partial class SelectionForm
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
            this.CurrentMoviesListBox = new System.Windows.Forms.ListBox();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox3 = new System.Windows.Forms.TextBox();
            this.CategoryTextBox2 = new System.Windows.Forms.TextBox();
            this.TitleTextBox1 = new System.Windows.Forms.TextBox();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMoviesListBox
            // 
            this.CurrentMoviesListBox.FormattingEnabled = true;
            this.CurrentMoviesListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.CurrentMoviesListBox.Location = new System.Drawing.Point(13, 52);
            this.CurrentMoviesListBox.Name = "CurrentMoviesListBox";
            this.CurrentMoviesListBox.Size = new System.Drawing.Size(120, 199);
            this.CurrentMoviesListBox.Sorted = true;
            this.CurrentMoviesListBox.TabIndex = 0;
            this.CurrentMoviesListBox.SelectedIndexChanged += new System.EventHandler(this.CurrentMoviesListBox_SelectedIndexChanged);
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.PictureBox);
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.CostTextBox3);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox2);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox1);
            this.SelectionGroupBox.Location = new System.Drawing.Point(139, 52);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(347, 147);
            this.SelectionGroupBox.TabIndex = 1;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox.Image = global::MovieBonanza_OnlineStream.Properties.Resources.thriller;
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(7, 20);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(90, 120);
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(269, 71);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(118, 71);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(118, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox3
            // 
            this.CostTextBox3.Location = new System.Drawing.Point(241, 87);
            this.CostTextBox3.Name = "CostTextBox3";
            this.CostTextBox3.ReadOnly = true;
            this.CostTextBox3.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox3.TabIndex = 2;
            // 
            // CategoryTextBox2
            // 
            this.CategoryTextBox2.Location = new System.Drawing.Point(103, 87);
            this.CategoryTextBox2.Name = "CategoryTextBox2";
            this.CategoryTextBox2.ReadOnly = true;
            this.CategoryTextBox2.Size = new System.Drawing.Size(132, 20);
            this.CategoryTextBox2.TabIndex = 1;
            // 
            // TitleTextBox1
            // 
            this.TitleTextBox1.Location = new System.Drawing.Point(103, 36);
            this.TitleTextBox1.Name = "TitleTextBox1";
            this.TitleTextBox1.ReadOnly = true;
            this.TitleTextBox1.Size = new System.Drawing.Size(238, 20);
            this.TitleTextBox1.TabIndex = 0;
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(32, 36);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(78, 13);
            this.CurrentMoviesLabel.TabIndex = 2;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 13);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(283, 13);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(411, 228);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentMoviesListBox;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox CostTextBox3;
        private System.Windows.Forms.TextBox CategoryTextBox2;
        private System.Windows.Forms.TextBox TitleTextBox1;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button NextButton;
    }
}

