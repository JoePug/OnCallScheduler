namespace OnCallScheduler
{
    partial class AddNewSiteAndDate
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
            siteNameLabel = new Label();
            addButton = new Button();
            siteNameTextBox = new TextBox();
            cancelButton = new Button();
            monthLabel = new Label();
            dayLabel = new Label();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            dayTextBox = new TextBox();
            monthTextBox = new TextBox();
            SuspendLayout();
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Location = new Point(112, 28);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new Size(61, 15);
            siteNameLabel.TabIndex = 0;
            siteNameLabel.Text = "Site Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(293, 116);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // siteNameTextBox
            // 
            siteNameTextBox.Location = new Point(32, 46);
            siteNameTextBox.Name = "siteNameTextBox";
            siteNameTextBox.Size = new Size(245, 23);
            siteNameTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(163, 116);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(84, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(312, 28);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(46, 15);
            monthLabel.TabIndex = 33;
            monthLabel.Text = "Month ";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(400, 28);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(27, 15);
            dayLabel.TabIndex = 32;
            dayLabel.Text = "Day";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(467, 28);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(64, 15);
            yearLabel.TabIndex = 31;
            yearLabel.Text = "Year (yyyy)";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(465, 46);
            yearTextBox.MaxLength = 4;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(77, 23);
            yearTextBox.TabIndex = 30;
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(381, 46);
            dayTextBox.MaxLength = 2;
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(77, 23);
            dayTextBox.TabIndex = 29;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(300, 46);
            monthTextBox.MaxLength = 2;
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(77, 23);
            monthTextBox.TabIndex = 28;
            // 
            // AddNewSiteAndDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 175);
            ControlBox = false;
            Controls.Add(monthLabel);
            Controls.Add(dayLabel);
            Controls.Add(yearLabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(cancelButton);
            Controls.Add(siteNameTextBox);
            Controls.Add(addButton);
            Controls.Add(siteNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddNewSiteAndDate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddNewSiteAndDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label siteNameLabel;
        private Button addButton;
        private TextBox siteNameTextBox;
        private Button cancelButton;
        private Label monthLabel;
        private Label dayLabel;
        private Label yearLabel;
        private TextBox yearTextBox;
        private TextBox dayTextBox;
        private TextBox monthTextBox;
    }
}