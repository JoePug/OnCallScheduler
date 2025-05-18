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
            addSiteButton = new Button();
            editSiteButton = new Button();
            deleteSiteButton = new Button();
            yearTextBox = new TextBox();
            yearLabel = new Label();
            sortLabel = new Label();
            sortUpButton = new Button();
            sortDownButton = new Button();
            SuspendLayout();
            // 
            // displayListView
            // 
            displayListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            displayListView.GridLines = true;
            displayListView.Location = new Point(26, 79);
            displayListView.Name = "displayListView";
            displayListView.Size = new Size(405, 419);
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
            columnHeader2.Width = 200;
            // 
            // staffListView
            // 
            staffListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            staffListView.GridLines = true;
            staffListView.Location = new Point(451, 182);
            staffListView.Name = "staffListView";
            staffListView.Size = new Size(405, 176);
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
            scheduleLabel.Location = new Point(184, 36);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(69, 20);
            scheduleLabel.TabIndex = 2;
            scheduleLabel.Text = "Schedule";
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.Location = new Point(618, 150);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(40, 20);
            staffLabel.TabIndex = 3;
            staffLabel.Text = "Staff";
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new Point(618, 36);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new Size(34, 20);
            siteLabel.TabIndex = 4;
            siteLabel.Text = "Site";
            // 
            // siteComboBox
            // 
            siteComboBox.FormattingEnabled = true;
            siteComboBox.Location = new Point(502, 79);
            siteComboBox.Name = "siteComboBox";
            siteComboBox.Size = new Size(300, 28);
            siteComboBox.TabIndex = 5;
            // 
            // printButton
            // 
            printButton.Location = new Point(700, 518);
            printButton.Name = "printButton";
            printButton.Size = new Size(100, 40);
            printButton.TabIndex = 6;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(821, 518);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 40);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // previousScheduleButton
            // 
            previousScheduleButton.Location = new Point(133, 518);
            previousScheduleButton.Name = "previousScheduleButton";
            previousScheduleButton.Size = new Size(78, 40);
            previousScheduleButton.TabIndex = 8;
            previousScheduleButton.Text = "Previous";
            previousScheduleButton.UseVisualStyleBackColor = true;
            // 
            // nextScheduleButton
            // 
            nextScheduleButton.Location = new Point(232, 518);
            nextScheduleButton.Name = "nextScheduleButton";
            nextScheduleButton.Size = new Size(78, 40);
            nextScheduleButton.TabIndex = 9;
            nextScheduleButton.Text = "Next";
            nextScheduleButton.UseVisualStyleBackColor = true;
            // 
            // addSiteButton
            // 
            addSiteButton.Location = new Point(477, 373);
            addSiteButton.Name = "addSiteButton";
            addSiteButton.Size = new Size(100, 40);
            addSiteButton.TabIndex = 10;
            addSiteButton.Text = "Add";
            addSiteButton.UseVisualStyleBackColor = true;
            // 
            // editSiteButton
            // 
            editSiteButton.Location = new Point(608, 373);
            editSiteButton.Name = "editSiteButton";
            editSiteButton.Size = new Size(100, 40);
            editSiteButton.TabIndex = 11;
            editSiteButton.Text = "Edit";
            editSiteButton.UseVisualStyleBackColor = true;
            // 
            // deleteSiteButton
            // 
            deleteSiteButton.Location = new Point(742, 373);
            deleteSiteButton.Name = "deleteSiteButton";
            deleteSiteButton.Size = new Size(100, 40);
            deleteSiteButton.TabIndex = 12;
            deleteSiteButton.Text = "Delete";
            deleteSiteButton.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(856, 79);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(79, 27);
            yearTextBox.TabIndex = 13;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(874, 36);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(37, 20);
            yearLabel.TabIndex = 14;
            yearLabel.Text = "Year";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(885, 191);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(36, 20);
            sortLabel.TabIndex = 15;
            sortLabel.Text = "Sort";
            // 
            // sortUpButton
            // 
            sortUpButton.Location = new Point(874, 224);
            sortUpButton.Name = "sortUpButton";
            sortUpButton.Size = new Size(61, 40);
            sortUpButton.TabIndex = 16;
            sortUpButton.Text = "Up";
            sortUpButton.UseVisualStyleBackColor = true;
            // 
            // sortDownButton
            // 
            sortDownButton.Location = new Point(874, 282);
            sortDownButton.Name = "sortDownButton";
            sortDownButton.Size = new Size(61, 40);
            sortDownButton.TabIndex = 17;
            sortDownButton.Text = "Down";
            sortDownButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 575);
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
        private ColumnHeader columnHeader2;
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
    }
}
