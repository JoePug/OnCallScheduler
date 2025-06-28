namespace OnCallScheduler
{
    partial class StaffNameAddEditForm
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
            staffNameLabel = new Label();
            areaCodeLabel = new Label();
            phoneNumberLabel = new Label();
            lineNumberTextBox = new TextBox();
            exchangeTextBox = new TextBox();
            staffNameTextBox = new TextBox();
            acceptButton = new Button();
            areaCodeTextBox = new TextBox();
            lineNumberLabel = new Label();
            exchangeLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // staffNameLabel
            // 
            staffNameLabel.AutoSize = true;
            staffNameLabel.Location = new Point(86, 60);
            staffNameLabel.Name = "staffNameLabel";
            staffNameLabel.Size = new Size(66, 15);
            staffNameLabel.TabIndex = 38;
            staffNameLabel.Text = "Staff Name";
            // 
            // areaCodeLabel
            // 
            areaCodeLabel.AutoSize = true;
            areaCodeLabel.Location = new Point(287, 60);
            areaCodeLabel.Name = "areaCodeLabel";
            areaCodeLabel.Size = new Size(62, 15);
            areaCodeLabel.TabIndex = 37;
            areaCodeLabel.Text = "Area Code";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(361, 29);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(84, 15);
            phoneNumberLabel.TabIndex = 36;
            phoneNumberLabel.Text = "Phone Nunber";
            // 
            // lineNumberTextBox
            // 
            lineNumberTextBox.Location = new Point(462, 78);
            lineNumberTextBox.MaxLength = 4;
            lineNumberTextBox.Name = "lineNumberTextBox";
            lineNumberTextBox.Size = new Size(72, 23);
            lineNumberTextBox.TabIndex = 4;
            // 
            // exchangeTextBox
            // 
            exchangeTextBox.Location = new Point(376, 78);
            exchangeTextBox.MaxLength = 3;
            exchangeTextBox.Name = "exchangeTextBox";
            exchangeTextBox.Size = new Size(68, 23);
            exchangeTextBox.TabIndex = 3;
            // 
            // staffNameTextBox
            // 
            staffNameTextBox.Location = new Point(26, 79);
            staffNameTextBox.MaxLength = 2;
            staffNameTextBox.Name = "staffNameTextBox";
            staffNameTextBox.Size = new Size(197, 23);
            staffNameTextBox.TabIndex = 1;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(477, 136);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(61, 23);
            acceptButton.TabIndex = 5;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // areaCodeTextBox
            // 
            areaCodeTextBox.Location = new Point(287, 78);
            areaCodeTextBox.MaxLength = 3;
            areaCodeTextBox.Name = "areaCodeTextBox";
            areaCodeTextBox.Size = new Size(68, 23);
            areaCodeTextBox.TabIndex = 2;
            // 
            // lineNumberLabel
            // 
            lineNumberLabel.AutoSize = true;
            lineNumberLabel.Location = new Point(462, 60);
            lineNumberLabel.Name = "lineNumberLabel";
            lineNumberLabel.Size = new Size(76, 15);
            lineNumberLabel.TabIndex = 40;
            lineNumberLabel.Text = "Line Number";
            // 
            // exchangeLabel
            // 
            exchangeLabel.AutoSize = true;
            exchangeLabel.Location = new Point(382, 60);
            exchangeLabel.Name = "exchangeLabel";
            exchangeLabel.Size = new Size(57, 15);
            exchangeLabel.TabIndex = 41;
            exchangeLabel.Text = "Exchange";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 81);
            label2.Name = "label2";
            label2.Size = new Size(11, 15);
            label2.TabIndex = 43;
            label2.Text = "(";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 82);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 44;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 82);
            label4.Name = "label4";
            label4.Size = new Size(11, 15);
            label4.TabIndex = 45;
            label4.Text = ")";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(384, 136);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(61, 23);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // StaffNameAddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 182);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exchangeLabel);
            Controls.Add(lineNumberLabel);
            Controls.Add(areaCodeTextBox);
            Controls.Add(staffNameLabel);
            Controls.Add(areaCodeLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lineNumberTextBox);
            Controls.Add(exchangeTextBox);
            Controls.Add(staffNameTextBox);
            Controls.Add(acceptButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "StaffNameAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add /  Edit Staff Names and Numbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staffNameLabel;
        private Label areaCodeLabel;
        private Label phoneNumberLabel;
        private TextBox lineNumberTextBox;
        private TextBox exchangeTextBox;
        private TextBox staffNameTextBox;
        private Button acceptButton;
        private TextBox areaCodeTextBox;
        private Label lineNumberLabel;
        private Label exchangeLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cancelButton;
    }
}