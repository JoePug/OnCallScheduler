


namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page

        private Sites site = new Sites();

        public MainForm()
        {
            InitializeComponent();
            StartUpStuff();
        }

        private void StartUpStuff()
        {
            //check for first time and ask for data if it is
            // get startup month, day and year and staff that is the first on the page

            site.CurrentSchedule(); //only use these if there is actual data otherwise skip
            LoadDatesIntoSchedule(); //will probably happen last after all other checks and setup stuff
        }

        private void LoadDatesIntoSchedule() //rewrite as it's going to pull from Sites instead and grab what it needs
        {            
            displayListView.Items.Clear();
                        
            for(int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem(site.CurrentPageOfLines[i]);

                lvl.SubItems.Add(site.CurrentPageOfNamesAndNumbers[i]);

                displayListView.Items.Add(lvl);
            }

            yearDisplayLabel.Text = "Year: " + site.GetYear();           
        }

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
      
    }
}
