


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
                //loadSaveData.SaveDataToFiles(allSites);  //using to save test data
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

            LoadDateIntoTextBoxes(); //keep it????????????
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

        #endregion

        #region Buttons

        //todo checks so you can't use buttons if there is no data saved

        private void nextScheduleButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.Items.Count == 0) return;
            //add 105 days
            site.NextSchedule();
            LoadDatesIntoSchedule();
        }

        private void previousScheduleButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (staffListView.Items.Count == 0) return;
            //subtract 105 days
            site.PreviousSchedule();
            LoadDatesIntoSchedule();
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
            if (siteComboBox.Text == string.Empty)
            {
                MessageBox.Show("You need a name for this site(s)");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to create a site named: \n\n\t\t" + siteComboBox.Text,
                                    "Create Site???", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (TestForValidDates() == false)
            {
                MessageBox.Show("Your starting dates are not valid.");
                return;
            }

            Sites _site = new Sites();
            _site.SiteName = siteComboBox.Text.Trim();

            //int.Parse should be fine as it will of been tested already
            _site.Day = int.Parse(dayTextBox.Text);
            _site.Month = int.Parse(monthTextBox.Text);
            _site.Year = int.Parse(yearTextBox.Text);

            allSites.Add(_site);

            siteComboBox.Text = "";
            ClearAndResetControls();
            LoadSitesIntoSiteBox();
        }

        private void editSiteButton_Click(object sender, EventArgs e)
        {
            if (selectedSiteIndex == -1) return;
            if (siteComboBox.SelectedIndex == -1 && selectedSiteIndex == -1)
            {
                return;
            }

            string dialogText = "Are you sure you want to edit the site named: \n\n\t" +
                                 allSites[selectedSiteIndex].SiteName + "\n\n\t\tTo\n\n\t" +
                                 siteComboBox.Text + "\n\n\t" +
                                 "Month = " + monthTextBox.Text +
                                 "  Day = " + dayTextBox.Text +
                                 "  Year = " + yearTextBox.Text;

            DialogResult result = MessageBox.Show(dialogText, "Edit Site???", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (TestForValidDates() == false)
            {
                MessageBox.Show("Your starting dates are not valid.");
                return;
            }

            allSites[selectedSiteIndex].SiteName = siteComboBox.Text.Trim();
            allSites[selectedSiteIndex].Month = int.Parse(monthTextBox.Text);
            allSites[selectedSiteIndex].Day = int.Parse(dayTextBox.Text);
            allSites[selectedSiteIndex].Year = int.Parse(yearTextBox.Text);

            ClearAndResetControls();
            LoadSitesIntoSiteBox();
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

            //todo save
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

            //todo save
        }

        #endregion

        private void bottomOfPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedSiteIndex == -1) return;

            if (e.KeyCode == Keys.Enter)
            {
                site.CommentToPrint = bottomOfPageTextBox.Text;
                MessageBox.Show("Changed");

                //Todo: Save to file
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Printer print = new Printer(new DrawPage().CreateOnCallLog(site));
            print.Print();
        }
    }
}
