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

        public string SiteName { get; set; } = "Carbondale/Dunmore";
        public int Year { get; set; } = 2025;
        public int Month { get; set; } = 4;
        public int Day { get; set; } = 4;
        public int CurrentStaff { get; set; } = 0;
        public int yearFromDateHandler { get; set; } = 2025; // 2025 for now
        public string[] currentPageOfLines { get; set; } = new string[15];
        public string[] currentPageOfNamesAndNumbers { get; set; } = new string[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates


        private StaffNameAndNumbers staff = new StaffNameAndNumbers();
        /*
        int year = 2025;
        int month = 4;
        int day = 4;
        int currentStaff = 0;
        int yearFromDateHandler = 2025; // 2025 for now
        string[] currentPageOfLines = new string[15];
        string[] currentPageOfNamesAndNumbers = new string[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates

        
        */

        #region Public Methods

        public void NextSchedule()
        {
            //add 105 days
            CalculateNextDate(true, false);
            GetNewPageOfNamesAndNumbers(true);
            //LoadDatesInSchedule();
            //return 
        }

        public void PreviousSchedule()
        {
            //subtract 105 days
            CalculateNextDate(false, true);
            GetNewPageOfNamesAndNumbers(false);
            //LoadDatesInSchedule();
        }

        public string GetYear()
        {
            string s = string.Empty;

            if (yearFromDateHandler > Year)
            {
                s = Year.ToString() + " - " + yearFromDateHandler.ToString();
            }
            else if (yearFromDateHandler < Year)
            {
                s = yearFromDateHandler.ToString() + " - " + Year.ToString();
            }
            else
            {
                s = Year.ToString();
            }

            return s;
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
                staff.IndexOfLastUsed = CurrentStaff;
                currentPageOfNamesAndNumbers = staff.GetNextFifteenNames();
                CurrentStaff = staff.IndexOfLastUsed;
            }
            else
            {
                staff.IndexOfLastUsed = CurrentStaff;
                currentPageOfNamesAndNumbers = staff.GetPreviousFifteenNames();
                CurrentStaff = staff.IndexOfLastUsed;
            }
        }

        private void GetNewPageOfDates()
        {
            DateHandler dh = new DateHandler(Month, Day, Year);

            for (int i = 0; i < 15; i++)
            {
                currentPageOfLines[i] = dh.GetNextLine();
            }

            yearFromDateHandler = dh.GetYear();
        }

        private void CalculateNextDate(bool nextPage, bool previousPage)
        {
            DateTime date = new DateTime(Year, Month, Day);

            if (nextPage)
            {
                date = date.AddDays(daysPerPage);
            }
            else if (previousPage)
            {
                date = date.AddDays(-daysPerPage);
            }

            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }

        #endregion
    }
}
