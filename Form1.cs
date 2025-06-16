


namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page

        private Sites site = new Sites();
        private List<Sites> allSites = new List<Sites>();

        #region Startup Methods

        public MainForm()
        {
            InitializeComponent();
            StartUpStuff();
        }

        private void StartUpStuff()
        {
            //check for first time and ask for data if it is
            // get startup month, day and year and staff that is the first on the page
            allSites.Add(site);// just to have something there for now. Fix later when you move test data to it's own class.
            LoadSitesIntoSiteBox();
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
        }

        private void LoadInfoIntoStaff()
        {
            staffListView.Items.Clear();

            foreach((string, string) text in site.GetNamesAndNumbers())
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
            foreach(Sites _site in allSites)
            {
                siteComboBox.Items.Add(_site.SiteName);
            }
        }

        #endregion

        #region Buttons

        //todo checks so you can't use buttons if there is no data saved

        private void nextScheduleButton_Click(object sender, EventArgs e)
        {
            //add 105 days
            site.NextSchedule();
            LoadDatesIntoSchedule();
        }

        private void previousScheduleButton_Click(object sender, EventArgs e)
        {
            //subtract 105 days
            site.PreviousSchedule();
            LoadDatesIntoSchedule();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            QuitApplication();
        }

        #endregion

        #region Other Methods

        private void QuitApplication()
        {
            Application.Exit();
        }

        #endregion

        private void siteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siteComboBox.SelectedIndex == -1)
            {
                displayListView.Items.Clear(); //see how this works out
                staffListView.Items.Clear();
                return;
            }
            site = allSites[siteComboBox.SelectedIndex]; // Untested

            site.CurrentSchedule(); //only use these if there is actual data otherwise skip
            LoadDatesIntoSchedule(); //will probably happen last after all other checks and setup stuff
            LoadInfoIntoStaff();    //will have to seperate data
            LoadDatesIntoSchedule();
        }
    }
}
