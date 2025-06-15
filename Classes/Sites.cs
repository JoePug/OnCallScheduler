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
        public int YearFromDateHandler { get; set; } = 2025; // 2025 for now
        public string[] CurrentPageOfLines { get; set; } = new string[15];
        public (string, string)[] CurrentPageOfNamesAndNumbers { get; set; } = new (string, string)[15];
        private const int daysPerPage = 105; //add or subtract 105 days to go forward or back 15 dates

        private StaffNameAndNumbers staff = new StaffNameAndNumbers();

        #region Public Methods

        public void CurrentSchedule()
        {
            GetNewPageOfDates();
            GetNewPageOfNamesAndNumbers(true);
        }

        public void NextSchedule()
        {
            //add 105 days
            CalculateNextDate(true, false);
            GetNewPageOfNamesAndNumbers(true);
            GetNewPageOfDates(); 
        }

        public void PreviousSchedule()
        {
            //subtract 105 days
            CalculateNextDate(false, true);
            GetNewPageOfNamesAndNumbers(false);
            GetNewPageOfDates();
        }

        public string GetYear()
        {
            string s = string.Empty;

            if (YearFromDateHandler > Year)
            {
                s = Year.ToString() + " - " + YearFromDateHandler.ToString();
            }
            else if (YearFromDateHandler < Year)
            {
                s = YearFromDateHandler.ToString() + " - " + Year.ToString();
            }
            else
            {
                s = Year.ToString();
            }

            return s;
        }

        public List<(string, string)> GetNamesAndNumbers()
        {
            return staff.GetNameAndNumbersList();
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

            //Not sure I'm keeping this here. Usually just check for a file

            return true;    
        }

        #endregion

        #region Private Methods

        private void GetNewPageOfNamesAndNumbers(bool forward)
        {
            if (forward)
            {
                staff.IndexOfLastUsed = CurrentStaff;
                CurrentPageOfNamesAndNumbers = staff.GetNextFifteenNames();
                CurrentStaff = staff.IndexOfLastUsed;
            }
            else
            {
                staff.IndexOfLastUsed = CurrentStaff;
                CurrentPageOfNamesAndNumbers = staff.GetPreviousFifteenNames();
                CurrentStaff = staff.IndexOfLastUsed;
            }
        }

        private void GetNewPageOfDates()
        {
            DateHandler dh = new DateHandler(Month, Day, Year);

            for (int i = 0; i < 15; i++)
            {
                CurrentPageOfLines[i] = dh.GetNextLine();
            }

            YearFromDateHandler = dh.GetYear();
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
