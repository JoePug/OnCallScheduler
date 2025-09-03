


namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page

        private Sites site = new Sites();
        private List<Sites> allSites = new List<Sites>();
        private int selectedSiteIndex = -1;
        private FileLoadSave loadSaveData = new FileLoadSave();
        bool needToSave = false;

        #region Startup Methods

        public MainForm()
        {
            InitializeComponent();
            StartUpStuff();
        }

        private void StartUpStuff()
        {
            if (loadSaveData.DirAndFileExists())
            {
                LoadDataFromFile(); 
                if (allSites.Count > 0) siteComboBox.SelectedIndex = 0;
            }
        }

        #endregion

        #region Main Methods

        private void LoadDatesIntoSchedule()
        {
            displayListView.Items.Clear();

            for (int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem(site.CurrentPageOfLines[i]);

                lvl.SubItems.Add(site.CurrentPageOfNamesAndNumbers[i].Item1);

                displayListView.Items.Add(lvl);
            }

            yearDisplayLabel.Text = "Year: " + site.GetYear();

            LoadDateIntoTextBoxes(); //keep it???????????? Seems to be ok to leave it in.
        }

        private void LoadInfoIntoStaff()
        {
            staffListView.Items.Clear();

            foreach ((string, string) text in site.GetStaffNameAndNumbers().GetNameAndNumbersList())
            {
                ListViewItem lvl = new ListViewItem(text.Item1); //split the data
                lvl.SubItems.Add(text.Item2); //split the data
                staffListView.Items.Add(lvl);
            }
        }

        private void LoadSitesIntoSiteBox()
        {
            siteComboBox.Items.Clear();
            siteComboBox.SelectedIndex = -1;
            foreach (Sites _site in allSites)
            {
                siteComboBox.Items.Add(_site.SiteName);
            }
        }

        private void LoadDateIntoTextBoxes()
        {
            monthTextBox.Text = site.Month.ToString();
            dayTextBox.Text = site.Day.ToString();
            yearTextBox.Text = site.Year.ToString();
        }

        private void siteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siteComboBox.Text == string.Empty) siteComboBox.SelectedIndex = -1;
            if (siteComboBox.SelectedIndex == -1)
            {
                ClearAndResetControls();
                return;
            }

            selectedSiteIndex = siteComboBox.SelectedIndex;
            site = allSites[selectedSiteIndex];

            bottomOfPageTextBox.Text = site.CommentToPrint;
            BottomOfPageCommentCheckBox.Checked = site.CommentActive;


            LoadDateIntoTextBoxes();
            if (site.GetStaffNameAndNumbers().GetStaffNamesCount() > 0)
            {
                site.CurrentSchedule(true); //only use these if there is actual data otherwise skip            
                LoadInfoIntoStaff();    //will have to seperate data
                LoadDatesIntoSchedule();
            }
        }

        private void siteComboBox_TextChanged(object sender, EventArgs e)
        {
            if (siteComboBox.Text == string.Empty)
            {
                siteComboBox.SelectedIndex = -1;
                ClearAndResetControls();
            }
        }

        private void LoadDataFromFile()
        {
            allSites = loadSaveData.LoadDataFromFiles();

            foreach (var _site in allSites)
            {
                siteComboBox.Items.Add(_site.SiteName);
            }
        }

        private void SaveAllData()
        {
            if (needToSave)
            {
                loadSaveData.SaveDataToFiles(allSites);
                needToSave = false;
            }
        }

        #endregion

        #region Buttons
        
        private void nextScheduleButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.Items.Count == 0) return;
            //add 105 days
            site.NextSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        private void previousScheduleButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.Items.Count == 0) return;
            //subtract 105 days
            site.PreviousSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            QuitApplication();
        }

        private void resetOrderButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (site.GetStaffNameAndNumbers().GetStaffNamesCount() < 2) return;

            site.CurrentSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        #endregion

        #region Other Methods

        private void ClearAndResetControls()
        {
            displayListView.Items.Clear(); //see how this works out
            staffListView.Items.Clear();
            monthTextBox.Text = "";
            dayTextBox.Text = "";
            yearTextBox.Text = "";
            siteComboBox.SelectedIndex = -1;
            siteComboBox.Text = "";
            selectedSiteIndex = -1;
            bottomOfPageTextBox.Text = string.Empty;
        }

        private bool TestForValidDates()
        {
            bool validDates = false;

            try
            {
                int a = int.Parse(monthTextBox.Text);
                a = int.Parse(dayTextBox.Text);
                a = int.Parse(yearTextBox.Text);
            }
            catch (FormatException)
            {
                validDates = false;
                return validDates;
            }

            string input = yearTextBox.Text + "-" + monthTextBox.Text + "-" + dayTextBox.Text;
            DateTime result; //throw away

            validDates = DateTime.TryParse(input, out result);

            if (int.Parse(yearTextBox.Text) < 2020) validDates = false;

            return validDates;
        }

        private void QuitApplication()
        {
            Application.Exit();
        }

        #endregion

        #region Site Buttons

        private void addSiteButton_Click(object sender, EventArgs e)
        {
            if (allSites.Count > 0)
            {
                needToSave = true;
                SaveAllData();
            }

            ClearAndResetControls();

            AddNewSiteAndDate addSite = new AddNewSiteAndDate();

            addSite.ShowDialog();

            if(addSite.Cancelled) return;

            Sites _site = addSite.NewSite;

            allSites.Add(_site);
            needToSave = true;
            SaveAllData();
            LoadSitesIntoSiteBox();            
        }

        private void editSiteButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (siteComboBox.SelectedIndex == -1 && selectedSiteIndex == -1)
            {
                return;
            }

            AddNewSiteAndDate addSite = new AddNewSiteAndDate(allSites[selectedSiteIndex]);

            addSite.ShowDialog();

            if (addSite.Cancelled) return;

            ClearAndResetControls();
            LoadSitesIntoSiteBox();
            needToSave = true;
            SaveAllData();
        }

        private void deleteSiteButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (siteComboBox.SelectedIndex == -1)
            {
                return;
            }
            int i = siteComboBox.SelectedIndex;
            DialogResult result = MessageBox.Show("Are you sure you want to delete the site named: \n\n\t\t" + allSites[i].SiteName,
                                    "Delete Site???", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            allSites.RemoveAt(i);
            ClearAndResetControls();
            LoadSitesIntoSiteBox();
            needToSave = true;
        }

        #endregion

        #region Staff Names and Numbers Buttons

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            //test for site loaded
            if (siteComboBox.SelectedIndex == -1) return;

            StaffNameAddEditForm staffForm = new StaffNameAddEditForm(site.GetStaffNameAndNumbers(), true, -1);
            staffForm.Text = "Add New Staff Name and Phone Number";
            staffForm.ShowDialog();

            LoadInfoIntoStaff();
            staffListView.SelectedIndices.Clear();

            site.CurrentSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        private void editStaffButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            //test for site loaded
            if (siteComboBox.SelectedIndex == -1) return;
            if (staffListView.SelectedIndices.Count == 0) return;

            StaffNameAddEditForm staffForm = new StaffNameAddEditForm(site.GetStaffNameAndNumbers(), false, staffListView.SelectedIndices[0]);
            staffForm.Text = "Edit Staff Name and Phone Number";
            staffForm.ShowDialog();
            LoadInfoIntoStaff();
            staffListView.SelectedIndices.Clear();
            site.CurrentSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            //test for site loaded
            if (siteComboBox.SelectedIndex == -1) return;
            if (staffListView.SelectedIndices.Count == 0) return;

            site.GetStaffNameAndNumbers().DeleteOneName(staffListView.SelectedIndices[0]);
            LoadInfoIntoStaff();
            staffListView.SelectedIndices.Clear();

            if (site.GetStaffNameAndNumbers().GetStaffNamesCount() == 0)
            {
                displayListView.Items.Clear();
                return;
            }

            site.CurrentSchedule();
            LoadDatesIntoSchedule();
            needToSave = true;
        }

        private void sortUpButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.SelectedIndices.Count == 0) return;

            staffListView.Focus();
            if (staffListView.Items.Count < 2) return;
            if (staffListView.SelectedIndices[0] < 1) return;

            int index = staffListView.SelectedIndices[0];

            //swap index with index - 1
            site.GetStaffNameAndNumbers().SwapNames(index, index - 1);
            LoadInfoIntoStaff(); //refresh list
            staffListView.Items[index - 1].Selected = true;
            staffListView.Items[index - 1].Focused = true;
            staffListView.Focus();
            staffListView.EnsureVisible(index - 1);

            site.CurrentSchedule();
            LoadDatesIntoSchedule();

            needToSave = true;
        }

        private void sortDownButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.SelectedIndices.Count == 0) return;

            staffListView.Focus();
            if (staffListView.Items.Count < 2) return;
            if (staffListView.SelectedIndices[0] == staffListView.Items.Count - 1) return;

            int index = staffListView.SelectedIndices[0];

            site.GetStaffNameAndNumbers().SwapNames(index, index + 1);
            LoadInfoIntoStaff();
            staffListView.Items[index + 1].Selected = true;
            staffListView.Items[index + 1].Focused = true;
            staffListView.Focus();
            staffListView.EnsureVisible(index + 1);

            site.CurrentSchedule();
            LoadDatesIntoSchedule();

            needToSave = true;
        }

        #endregion

        private void bottomOfPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedSiteIndex == -1) return;

            if (e.KeyCode == Keys.Enter)
            {
                site.CommentToPrint = bottomOfPageTextBox.Text;
                MessageBox.Show("Changed");
                needToSave = true;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;

            if (site.GetStaffNameAndNumbers().GetStaffNamesCount() == 0)
            {
                MessageBox.Show("You Need At Least 1 Staff To Print!");
                return;
            }

            Printer print = new Printer(new DrawPage().CreateOnCallLog(site));
            print.Print();

            SaveAllData();
        }

        private void BottomOfPageCommentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;

            site.CommentActive = BottomOfPageCommentCheckBox.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllData();
        }
    }
}
