using System;
using System.Text;


namespace OnCallScheduler
{
    public class DateHandler
    {
        private DateTime date;        

        private string assembledDateLine = string.Empty;
        private StringBuilder sb = new StringBuilder("");

        public DateHandler(int month, int day, int year) 
        { 
            date = new DateTime(year, month, day);
            //date = date.AddDays(-105); test line - delete when bored with it
        }

        public string GetNextLine()
        {
            //returns the line to the calling class

            BuildTheLine();

            //assembledDateLine = " April 4th - April 10th";

            return assembledDateLine;
        }

        public int GetYear()
        {
            return date.Year;   
        }

        private void BuildTheLine()
        {
            //this will do the work of calling the methods that builds the string and update the date for the next line
            assembledDateLine = string.Empty; //clear the string
            AddToLine(GetMonthName(date.Month)); //send the current month to AddToLine()
            AddToLine(" ");
            AddToLine(date.Day.ToString());
            AddToLine(GetDaySuffix(date.Day));
            AddToLine(" - ");
            date = date.AddDays(6);
            AddToLine(GetMonthName(date.Month));
            AddToLine(" ");
            AddToLine(date.Day.ToString());
            AddToLine(GetDaySuffix(date.Day));

            assembledDateLine = sb.ToString();
            sb.Clear();
            date = date.AddDays(1);
        }

        private void AddToLine(string text)
        {
            //use stringbuilder to assemble the line
            sb.Append(text);
        }

        #region Lookup Methods

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
                case 1:
                    suffix = "st";
                        break;
                case 21:
                    suffix = "st";
                        break;
                case 31:
                    suffix = "st";
                        break;
                case 2:
                    suffix = "nd";
                    break;
                case 22:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
                case 23:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }

            return suffix;
        }

        #endregion
    }
}