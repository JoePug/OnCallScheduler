using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCallScheduler
{ 
    class StaffNameAndNumbers
    {
        List <string> names = new List<string>();

        public int IndexOfLastUsed { get; set; } = 0;

        public void AddNewNameAndNumber(string name)
        {
            names.Add(name);    
        }

        public void GetNextFifteenNames()
        {
            //returns array of string
        }

        public void GetPreviousFifteenNames()
        {
            //returns array of strings
            //start at the end and work your way up?
        }

        public int GetLenghtOfLongestLine()
        {

            return 0; //placeholder
        }
    }
}
