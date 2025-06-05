using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnCallScheduler
{
    class Sites
    {
        //this class will interact with the Main form
        //responsible for managing the current site and all it's data and feeds it to the main form
        //main form should only get it's data in the form it needs it to be

        public string SiteName { get; set; } = string.Empty;
        public int Year { get; set; } = 2025;
        public int Month { get; set; } = 4;
        public int Day { get; set; } = 4;
        public int CurrentStaff { get; set; } = 0;
        public int yearFromDateHandler { get; set; } = 2025; // 2025 for now
        public string[] currentPageOfLines { get; set; } = new string[15];
        public string[] currentPageOfNamesAndNumbers { get; set; } = new string[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates

        /*
        int year = 2025;
        int month = 4;
        int day = 4;
        int currentStaff = 0;
        int yearFromDateHandler = 2025; // 2025 for now
        string[] currentPageOfLines = new string[15];
        string[] currentPageOfNamesAndNumbers = new string[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates

        private StaffNameAndNumbers staff = new StaffNameAndNumbers();
        */

        #region Public Methods

        public void NextSchedule()
        {
            //add 105 days
            CalculateNextDate(true, false);
            GetNewPageOfNamesAndNumbers(true);
            LoadDatesInSchedule();
        }

        public void PreviousSchedule()
        {
            //subtract 105 days
            CalculateNextDate(false, true);
            GetNewPageOfNamesAndNumbers(false);
            LoadDatesInSchedule();
        }

        public string GetYear()
        {
            if (yearFromDateHandler > year)
            {
                yearDisplayLabel.Text = "Year: " + year.ToString() + " - " + yearFromDateHandler.ToString();
            }
            else if (yearFromDateHandler < year)
            {
                yearDisplayLabel.Text = "Year: " + yearFromDateHandler.ToString() + " - " + year.ToString();
            }
            else
            {
                yearDisplayLabel.Text = "Year: " + year.ToString();
            }
        }

        public void LoadData()
        {
            // will pull data from files and load them in
        }

        public void SaveData()
        {
            // will save data to files
        }

        public bool FirstTimeCheck()
        {
            //will check for data files and return false if it finds them

            return true;    
        }

        #endregion

        #region Private Methods

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

        #endregion
    }
}
