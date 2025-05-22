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
            addSiteButton = new Button();
            editSiteButton = new Button();
            deleteSiteButton = new Button();
            yearTextBox = new TextBox();
            yearLabel = new Label();
            sortLabel = new Label();
            sortUpButton = new Button();
            sortDownButton = new Button();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // displayListView
            // 
            displayListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
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
            // staffListView
            // 
            staffListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            staffListView.GridLines = true;
            staffListView.Location = new Point(395, 162);
            staffListView.Margin = new Padding(3, 2, 3, 2);
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
            staffLabel.Location = new Point(541, 138);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(31, 15);
            staffLabel.TabIndex = 3;
            staffLabel.Text = "Staff";
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new Point(541, 27);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new Size(26, 15);
            siteLabel.TabIndex = 4;
            siteLabel.Text = "Site";
            // 
            // siteComboBox
            // 
            siteComboBox.FormattingEnabled = true;
            siteComboBox.Location = new Point(439, 59);
            siteComboBox.Margin = new Padding(3, 2, 3, 2);
            siteComboBox.Name = "siteComboBox";
            siteComboBox.Size = new Size(263, 23);
            siteComboBox.TabIndex = 5;
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
            previousScheduleButton.Location = new Point(117, 416);
            previousScheduleButton.Margin = new Padding(3, 2, 3, 2);
            previousScheduleButton.Name = "previousScheduleButton";
            previousScheduleButton.Size = new Size(68, 30);
            previousScheduleButton.TabIndex = 8;
            previousScheduleButton.Text = "Previous";
            previousScheduleButton.UseVisualStyleBackColor = true;
            // 
            // nextScheduleButton
            // 
            nextScheduleButton.Location = new Point(204, 416);
            nextScheduleButton.Margin = new Padding(3, 2, 3, 2);
            nextScheduleButton.Name = "nextScheduleButton";
            nextScheduleButton.Size = new Size(68, 30);
            nextScheduleButton.TabIndex = 9;
            nextScheduleButton.Text = "Next";
            nextScheduleButton.UseVisualStyleBackColor = true;
            // 
            // addSiteButton
            // 
            addSiteButton.Location = new Point(417, 306);
            addSiteButton.Margin = new Padding(3, 2, 3, 2);
            addSiteButton.Name = "addSiteButton";
            addSiteButton.Size = new Size(88, 30);
            addSiteButton.TabIndex = 10;
            addSiteButton.Text = "Add";
            addSiteButton.UseVisualStyleBackColor = true;
            // 
            // editSiteButton
            // 
            editSiteButton.Location = new Point(532, 306);
            editSiteButton.Margin = new Padding(3, 2, 3, 2);
            editSiteButton.Name = "editSiteButton";
            editSiteButton.Size = new Size(88, 30);
            editSiteButton.TabIndex = 11;
            editSiteButton.Text = "Edit";
            editSiteButton.UseVisualStyleBackColor = true;
            // 
            // deleteSiteButton
            // 
            deleteSiteButton.Location = new Point(649, 306);
            deleteSiteButton.Margin = new Padding(3, 2, 3, 2);
            deleteSiteButton.Name = "deleteSiteButton";
            deleteSiteButton.Size = new Size(88, 30);
            deleteSiteButton.TabIndex = 12;
            deleteSiteButton.Text = "Delete";
            deleteSiteButton.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(749, 59);
            yearTextBox.Margin = new Padding(3, 2, 3, 2);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(70, 23);
            yearTextBox.TabIndex = 13;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(765, 27);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(29, 15);
            yearLabel.TabIndex = 14;
            yearLabel.Text = "Year";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(774, 169);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(28, 15);
            sortLabel.TabIndex = 15;
            sortLabel.Text = "Sort";
            // 
            // sortUpButton
            // 
            sortUpButton.Location = new Point(765, 194);
            sortUpButton.Margin = new Padding(3, 2, 3, 2);
            sortUpButton.Name = "sortUpButton";
            sortUpButton.Size = new Size(53, 30);
            sortUpButton.TabIndex = 16;
            sortUpButton.Text = "Up";
            sortUpButton.UseVisualStyleBackColor = true;
            // 
            // sortDownButton
            // 
            sortDownButton.Location = new Point(765, 238);
            sortDownButton.Margin = new Padding(3, 2, 3, 2);
            sortDownButton.Name = "sortDownButton";
            sortDownButton.Size = new Size(53, 30);
            sortDownButton.TabIndex = 17;
            sortDownButton.Text = "Down";
            sortDownButton.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Staff";
            columnHeader2.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 471);
            Controls.Add(sortDownButton);
            Controls.Add(sortUpButton);
            Controls.Add(sortLabel);
            Controls.Add(yearLabel);
            Controls.Add(yearTextBox);
            Controls.Add(deleteSiteButton);
            Controls.Add(editSiteButton);
            Controls.Add(addSiteButton);
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
        private Button addSiteButton;
        private Button editSiteButton;
        private Button deleteSiteButton;
        private TextBox yearTextBox;
        private Label yearLabel;
        private Label sortLabel;
        private Button sortUpButton;
        private Button sortDownButton;
        private ColumnHeader columnHeader2;
    }
}
