


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
        int yearFromDateHandler = 2025; // 2025 for now
        string[] currentPageOfLines = new string[15];
        string[] currentPageOfNamesAndNumbers = new string[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates

        private StaffNameAndNumbers staff = new StaffNameAndNumbers();

        public MainForm()
        {
            InitializeComponent();
            StartUpStuff();
        }

        private void StartUpStuff()
        {
            //check for first time and ask for data if it is
            // get startup month, day and year and staff that is the first on the page

            staff.IndexOfLastUsed = currentStaff;
            GetNewPageOfNamesAndNumbers(true);
            LoadDatesIntoSchedule(); //will probably happen last after all other checks and setup stuff
        }

        private void LoadDatesIntoSchedule() //rewrite as it's going to pull from Sites instead and grab what it needs
        {            
            GetNewPageOfDates();
            displayListView.Items.Clear();
                        
            //foreach(string line in currentPageOfLines)
            for(int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem(currentPageOfLines[i]);

                lvl.SubItems.Add(currentPageOfNamesAndNumbers[i]);

                displayListView.Items.Add(lvl);
            }

            //moved to Sites - call with GetYear - Returns a string
            if(yearFromDateHandler > year)
            {
                yearDisplayLabel.Text = "Year: " + year.ToString() + " - " + yearFromDateHandler.ToString();
            }
            else if(yearFromDateHandler < year)
            {
                yearDisplayLabel.Text = "Year: " + yearFromDateHandler.ToString() + " - " + year.ToString();
            }
            else
            {
                yearDisplayLabel.Text = "Year: " + year.ToString();
            }
           
        }        

        private void GetNewPageOfNamesAndNumbers(bool forward)
        {
            if (forward)
            {
                staff.IndexOfLastUsed = currentStaff;
                currentPageOfNamesAndNumbers = staff.GetNextFifteenNames();
                currentStaff = staff.IndexOfLastUsed;
            }
            else
            {
                staff.IndexOfLastUsed = currentStaff;
                currentPageOfNamesAndNumbers = staff.GetPreviousFifteenNames();
                currentStaff = staff.IndexOfLastUsed;
            }
        }

        #region Buttons

        private void nextScheduleButton_Click(object sender, EventArgs e)
        {
            //add 105 days
            CalculateNextDate(true, false);
            GetNewPageOfNamesAndNumbers(true);
            LoadDatesInSchedule();
        }

        private void previousScheduleButton_Click(object sender, EventArgs e)
        {
            //subtract 105 days
            CalculateNextDate(false, true);
            GetNewPageOfNamesAndNumbers(false);
            LoadDatesInSchedule();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            QuitApplication();
        }

        #endregion

        #region Other Methods

        private void GetNewPageOfDates()
        {
            DateHandler dh = new DateHandler(month, day, year);

            for (int i = 0; i < 15; i++)
            {
                currentPageOfLines[i] = dh.GetNextLine();
            }

            yearFromDateHandler = dh.GetYear();
        }

        private void CalculateNextDate(bool nextPage, bool previousPage)
        {
            DateTime date = new DateTime(year, month, day);

            if (nextPage)
            {
                date = date.AddDays(daysPerPage);
            }
            else if (previousPage)
            {
                date = date.AddDays(-daysPerPage);
            }

            year = date.Year;
            month = date.Month;
            day = date.Day;
        }

        private void QuitApplication()
        {
            Application.Exit();
        }

        #endregion
      
    }
}
