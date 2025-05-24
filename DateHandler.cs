using System;


namespace OnCallScheduler
{
    public class DateHandler
    {
        private int year = 2025;
        private int month = 4;
        private int day = 4;

        private DateTime date;

        private string assembledDateLine = string.Empty;

        public string GetNextLine()
        {
            //returns the line to the calling class

            BuildTheLine();

            assembledDateLine = " April 4th - April 10th";

            return assembledDateLine;
        }

        private void BuildTheLine()
        {
            //this will do the work of calling the methods that builds the string and update the date for the next line
            assembledDateLine = string.Empty; //clear the string
            AddToLine(GetMonthName(date.Month)); //send the current month to AddToLine()
            AddToLine(" ");
            AddToLine(date.Day.ToString());
            AddToLine(GetDaySuffix(date.Day)); //todo gonna have to figure out how to make this raised
            AddToLine(" - ");

            //todo - pick up here

            // add 6 days to date to get second date\

        }

        private void AddToLine(string text)
        {
            //use stringbuilder to assemble the line
        }


        private void CalculateNextDate(int year, int month, int day, int numOfDays)
        {
            //should return the 15 start and end dates

            DateTime date = new DateTime(year, month, day); //year, month, day
            date = date.AddDays(numOfDays);

        }

        private string GetMonthName(int _month)
        {
            string name = string.Empty;

            switch (_month)
            {
                case 1:
                    name = "Jan.";
                    break;
                case 2:
                    name = "Feb.";
                    break;
                case 3:
                    name = "March";
                    break;
                case 4:
                    name = "April";
                    break;
                case 5:
                    name = "May";
                    break;
                case 6:
                    name = "June";
                    break;
                case 7:
                    name = "July";
                    break;
                case 8:
                    name = "Aug.";
                    break;
                case 9:
                    name = "Sept.";
                    break;
                case 10:
                    name = "Oct.";
                    break;
                case 11:
                    name = "Nov.";
                    break;
                case 12:
                    name = "Dec.";
                    break;
            }

            return name;
        }

        private string GetDaySuffix(int _day)
        {
            string suffix = string.Empty;

            switch (_day)
            {
                case (1 || 21 || 31)
                    suffix = "st"
                        break;
                case (2 || 22)
                    suffix = "nd"
                    break;
                case (3 || 23)
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
        }
    }
}