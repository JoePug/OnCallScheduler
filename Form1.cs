


namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page

        int year = 2025;
        int month = 4;
        int day = 4;
        int currentStaff = 0;

        public MainForm()
        {
            InitializeComponent();
            StartUpStuff();
        }

        private void StartUpStuff()
        {
            //check for first time and ask for data if it is
            // get startup month, day and year and staff that is the first on the page


            LoadDatesInSchedule(); //will probably happen last after all other checks and setup stuff
        }

        private void LoadDatesInSchedule()
        {
            DateHandler dh = new DateHandler(month, day, year);

            displayListView.Items.Clear();

            for (int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem(dh.GetNextLine());

                lvl.SubItems.Add("Joe Pugliese - (908)635-4106");

                displayListView.Items.Add(lvl);
            }
        }

        #region Buttons

        private void nextScheduleButton_Click(object sender, EventArgs e)
        {
            //add 105 days
        }

        private void previousScheduleButton_Click(object sender, EventArgs e)
        {
            //subtract 105 days
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
