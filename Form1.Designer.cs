namespace OnCallScheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            staffListView = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            scheduleLabel = new Label();
            staffLabel = new Label();
            siteLabel = new Label();
            siteComboBox = new ComboBox();
            printButton = new Button();
            exitButton = new Button();
            previousScheduleButton = new Button();
            nextScheduleButton = new Button();
            addStaffButton = new Button();
            editStaffButton = new Button();
            deleteStaffButton = new Button();
            sortLabel = new Label();
            sortUpButton = new Button();
            sortDownButton = new Button();
            deleteSiteButton = new Button();
            editSiteButton = new Button();
            addSiteButton = new Button();
            yearDisplayLabel = new Label();
            monthTextBox = new TextBox();
            dayTextBox = new TextBox();
            yearTextBox = new TextBox();
            yearLabel = new Label();
            dayLabel = new Label();
            monthLabel = new Label();
            resetOrderButton = new Button();
            bottomOfPageTextBox = new TextBox();
            BottomOfPageCommentCheckBox = new CheckBox();
            pressEnterToSaveLabel = new Label();
            SuspendLayout();
            // 
            // displayListView
            // 
            displayListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            displayListView.FullRowSelect = true;
            displayListView.GridLines = true;
            displayListView.Location = new Point(23, 59);
            displayListView.Margin = new Padding(3, 2, 3, 2);
            displayListView.Name = "displayListView";
            displayListView.Scrollable = false;
            displayListView.Size = new Size(355, 320);
            displayListView.TabIndex = 0;
            displayListView.UseCompatibleStateImageBehavior = false;
            displayListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dates";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Staff";
            columnHeader2.Width = 150;
            // 
            // staffListView
            // 
            staffListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            staffListView.FullRowSelect = true;
            staffListView.GridLines = true;
            staffListView.Location = new Point(395, 208);
            staffListView.Margin = new Padding(3, 2, 3, 2);
            staffListView.MultiSelect = false;
            staffListView.Name = "staffListView";
            staffListView.Size = new Size(355, 133);
            staffListView.TabIndex = 1;
            staffListView.UseCompatibleStateImageBehavior = false;
            staffListView.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Staff";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Phone Number";
            columnHeader4.Width = 200;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new Point(161, 27);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(55, 15);
            scheduleLabel.TabIndex = 2;
            scheduleLabel.Text = "Schedule";
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.Location = new Point(553, 184);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(31, 15);
            staffLabel.TabIndex = 3;
            staffLabel.Text = "Staff";
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new Point(583, 27);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new Size(26, 15);
            siteLabel.TabIndex = 4;
            siteLabel.Text = "Site";
            // 
            // siteComboBox
            // 
            siteComboBox.FormattingEnabled = true;
            siteComboBox.Location = new Point(470, 111);
            siteComboBox.Margin = new Padding(3, 2, 3, 2);
            siteComboBox.Name = "siteComboBox";
            siteComboBox.Size = new Size(263, 23);
            siteComboBox.TabIndex = 5;
            siteComboBox.SelectedIndexChanged += siteComboBox_SelectedIndexChanged;
            siteComboBox.TextChanged += siteComboBox_TextChanged;
            // 
            // printButton
            // 
            printButton.Location = new Point(613, 416);
            printButton.Margin = new Padding(3, 2, 3, 2);
            printButton.Name = "printButton";
            printButton.Size = new Size(88, 30);
            printButton.TabIndex = 6;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(719, 416);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(88, 30);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // previousScheduleButton
            // 
            previousScheduleButton.Location = new Point(64, 416);
            previousScheduleButton.Margin = new Padding(3, 2, 3, 2);
            previousScheduleButton.Name = "previousScheduleButton";
            previousScheduleButton.Size = new Size(68, 30);
            previousScheduleButton.TabIndex = 8;
            previousScheduleButton.Text = "Previous";
            previousScheduleButton.UseVisualStyleBackColor = true;
            previousScheduleButton.Click += previousScheduleButton_Click;
            // 
            // nextScheduleButton
            // 
            nextScheduleButton.Location = new Point(195, 416);
            nextScheduleButton.Margin = new Padding(3, 2, 3, 2);
            nextScheduleButton.Name = "nextScheduleButton";
            nextScheduleButton.Size = new Size(68, 30);
            nextScheduleButton.TabIndex = 9;
            nextScheduleButton.Text = "Next";
            nextScheduleButton.UseVisualStyleBackColor = true;
            nextScheduleButton.Click += nextScheduleButton_Click;
            // 
            // addStaffButton
            // 
            addStaffButton.Location = new Point(417, 352);
            addStaffButton.Margin = new Padding(3, 2, 3, 2);
            addStaffButton.Name = "addStaffButton";
            addStaffButton.Size = new Size(88, 30);
            addStaffButton.TabIndex = 10;
            addStaffButton.Text = "Add";
            addStaffButton.UseVisualStyleBackColor = true;
            addStaffButton.Click += addStaffButton_Click;
            // 
            // editStaffButton
            // 
            editStaffButton.Location = new Point(532, 352);
            editStaffButton.Margin = new Padding(3, 2, 3, 2);
            editStaffButton.Name = "editStaffButton";
            editStaffButton.Size = new Size(88, 30);
            editStaffButton.TabIndex = 11;
            editStaffButton.Text = "Edit";
            editStaffButton.UseVisualStyleBackColor = true;
            editStaffButton.Click += editStaffButton_Click;
            // 
            // deleteStaffButton
            // 
            deleteStaffButton.Location = new Point(649, 352);
            deleteStaffButton.Margin = new Padding(3, 2, 3, 2);
            deleteStaffButton.Name = "deleteStaffButton";
            deleteStaffButton.Size = new Size(88, 30);
            deleteStaffButton.TabIndex = 12;
            deleteStaffButton.Text = "Delete";
            deleteStaffButton.UseVisualStyleBackColor = true;
            deleteStaffButton.Click += deleteStaffButton_Click;
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(774, 226);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(28, 15);
            sortLabel.TabIndex = 15;
            sortLabel.Text = "Sort";
            // 
            // sortUpButton
            // 
            sortUpButton.Location = new Point(765, 251);
            sortUpButton.Margin = new Padding(3, 2, 3, 2);
            sortUpButton.Name = "sortUpButton";
            sortUpButton.Size = new Size(53, 30);
            sortUpButton.TabIndex = 16;
            sortUpButton.Text = "Up";
            sortUpButton.UseVisualStyleBackColor = true;
            sortUpButton.Click += sortUpButton_Click;
            // 
            // sortDownButton
            // 
            sortDownButton.Location = new Point(765, 295);
            sortDownButton.Margin = new Padding(3, 2, 3, 2);
            sortDownButton.Name = "sortDownButton";
            sortDownButton.Size = new Size(53, 30);
            sortDownButton.TabIndex = 17;
            sortDownButton.Text = "Down";
            sortDownButton.UseVisualStyleBackColor = true;
            sortDownButton.Click += sortDownButton_Click;
            // 
            // deleteSiteButton
            // 
            deleteSiteButton.Location = new Point(671, 148);
            deleteSiteButton.Margin = new Padding(3, 2, 3, 2);
            deleteSiteButton.Name = "deleteSiteButton";
            deleteSiteButton.Size = new Size(61, 22);
            deleteSiteButton.TabIndex = 20;
            deleteSiteButton.Text = "Delete";
            deleteSiteButton.UseVisualStyleBackColor = true;
            deleteSiteButton.Click += deleteSiteButton_Click;
            // 
            // editSiteButton
            // 
            editSiteButton.Location = new Point(572, 148);
            editSiteButton.Margin = new Padding(3, 2, 3, 2);
            editSiteButton.Name = "editSiteButton";
            editSiteButton.Size = new Size(61, 23);
            editSiteButton.TabIndex = 19;
            editSiteButton.Text = "Edit";
            editSiteButton.UseVisualStyleBackColor = true;
            editSiteButton.Click += editSiteButton_Click;
            // 
            // addSiteButton
            // 
            addSiteButton.Location = new Point(475, 148);
            addSiteButton.Margin = new Padding(3, 2, 3, 2);
            addSiteButton.Name = "addSiteButton";
            addSiteButton.Size = new Size(61, 23);
            addSiteButton.TabIndex = 18;
            addSiteButton.Text = "Add";
            addSiteButton.UseVisualStyleBackColor = true;
            addSiteButton.Click += addSiteButton_Click;
            // 
            // yearDisplayLabel
            // 
            yearDisplayLabel.AutoSize = true;
            yearDisplayLabel.Location = new Point(308, 27);
            yearDisplayLabel.Name = "yearDisplayLabel";
            yearDisplayLabel.Size = new Size(32, 15);
            yearDisplayLabel.TabIndex = 21;
            yearDisplayLabel.Text = "Year:";
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(484, 73);
            monthTextBox.MaxLength = 2;
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(68, 23);
            monthTextBox.TabIndex = 22;
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(565, 73);
            dayTextBox.MaxLength = 2;
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(68, 23);
            dayTextBox.TabIndex = 23;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(649, 73);
            yearTextBox.MaxLength = 4;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(68, 23);
            yearTextBox.TabIndex = 24;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(651, 55);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(64, 15);
            yearLabel.TabIndex = 25;
            yearLabel.Text = "Year (yyyy)";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(584, 55);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(27, 15);
            dayLabel.TabIndex = 26;
            dayLabel.Text = "Day";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(496, 55);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(46, 15);
            monthLabel.TabIndex = 27;
            monthLabel.Text = "Month ";
            // 
            // resetOrderButton
            // 
            resetOrderButton.Location = new Point(325, 410);
            resetOrderButton.Margin = new Padding(3, 2, 3, 2);
            resetOrderButton.Name = "resetOrderButton";
            resetOrderButton.Size = new Size(53, 42);
            resetOrderButton.TabIndex = 28;
            resetOrderButton.Text = "Reset Order";
            resetOrderButton.UseVisualStyleBackColor = true;
            resetOrderButton.Click += resetOrderButton_Click;
            // 
            // bottomOfPageTextBox
            // 
            bottomOfPageTextBox.Location = new Point(264, 476);
            bottomOfPageTextBox.Name = "bottomOfPageTextBox";
            bottomOfPageTextBox.Size = new Size(510, 23);
            bottomOfPageTextBox.TabIndex = 30;
            bottomOfPageTextBox.KeyDown += bottomOfPageTextBox_KeyDown;
            // 
            // BottomOfPageCommentCheckBox
            // 
            BottomOfPageCommentCheckBox.AutoSize = true;
            BottomOfPageCommentCheckBox.Checked = true;
            BottomOfPageCommentCheckBox.CheckState = CheckState.Checked;
            BottomOfPageCommentCheckBox.Location = new Point(57, 480);
            BottomOfPageCommentCheckBox.Name = "BottomOfPageCommentCheckBox";
            BottomOfPageCommentCheckBox.Size = new Size(191, 19);
            BottomOfPageCommentCheckBox.TabIndex = 31;
            BottomOfPageCommentCheckBox.Text = "Add Comment To Printed Page";
            BottomOfPageCommentCheckBox.UseVisualStyleBackColor = true;
            BottomOfPageCommentCheckBox.CheckedChanged += BottomOfPageCommentCheckBox_CheckedChanged;
            // 
            // pressEnterToSaveLabel
            // 
            pressEnterToSaveLabel.AutoSize = true;
            pressEnterToSaveLabel.Location = new Point(417, 511);
            pressEnterToSaveLabel.Name = "pressEnterToSaveLabel";
            pressEnterToSaveLabel.Size = new Size(200, 15);
            pressEnterToSaveLabel.TabIndex = 32;
            pressEnterToSaveLabel.Text = "Press 'ENTER' To UPDATE Comment.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 559);
            Controls.Add(pressEnterToSaveLabel);
            Controls.Add(BottomOfPageCommentCheckBox);
            Controls.Add(bottomOfPageTextBox);
            Controls.Add(resetOrderButton);
            Controls.Add(monthLabel);
            Controls.Add(dayLabel);
            Controls.Add(yearLabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(yearDisplayLabel);
            Controls.Add(deleteSiteButton);
            Controls.Add(editSiteButton);
            Controls.Add(addSiteButton);
            Controls.Add(sortDownButton);
            Controls.Add(sortUpButton);
            Controls.Add(sortLabel);
            Controls.Add(deleteStaffButton);
            Controls.Add(editStaffButton);
            Controls.Add(addStaffButton);
            Controls.Add(nextScheduleButton);
            Controls.Add(previousScheduleButton);
            Controls.Add(exitButton);
            Controls.Add(printButton);
            Controls.Add(siteComboBox);
            Controls.Add(siteLabel);
            Controls.Add(staffLabel);
            Controls.Add(scheduleLabel);
            Controls.Add(staffListView);
            Controls.Add(displayListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "On-Call Scheduler - c 2025 - Joseph A. Pugliese";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView displayListView;
        private ColumnHeader columnHeader1;
        private ListView staffListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label scheduleLabel;
        private Label staffLabel;
        private Label siteLabel;
        private ComboBox siteComboBox;
        private Button printButton;
        private Button exitButton;
        private Button previousScheduleButton;
        private Button nextScheduleButton;
        private Button addStaffButton;
        private Button editStaffButton;
        private Button deleteStaffButton;
        private Label sortLabel;
        private Button sortUpButton;
        private Button sortDownButton;
        private ColumnHeader columnHeader2;
        private Button deleteSiteButton;
        private Button editSiteButton;
        private Button addSiteButton;
        private Label yearDisplayLabel;
        private TextBox monthTextBox;
        private TextBox dayTextBox;
        private TextBox yearTextBox;
        private Label yearLabel;
        private Label dayLabel;
        private Label monthLabel;
        private Button resetOrderButton;
        private Label label1;
        private TextBox bottomOfPageTextBox;
        private CheckBox BottomOfPageCommentCheckBox;
        private Label pressEnterToSaveLabel;
    }
}
