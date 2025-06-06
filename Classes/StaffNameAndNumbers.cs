﻿using System;
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
        bool pagedForward = true;

        public StaffNameAndNumbers()
        {
            //temp data
            names.Add("1 Jamie Maher - (570)280-4194");
            names.Add("2 Sandy O'Connell - (570)335-4419");
            names.Add("3 Joe Pugliese - (908)635-4106");
            //names.Add("4 test name");
            //names.Add("5 Other Name");
        }

        public void AddNewNameAndNumber(string name)
        {
            names.Add(name);    
        }

        public string[] GetNextFifteenNames()
        {
            string[] fifteenNames = new string[15];

            if (pagedForward == false)
            {
                pagedForward = true;
                //get new index - jump 16
                //IndexOfLastUsed = (IndexOfLastUsed + 16) % names.Count;
                CircularArrayTraversal(16);
            }
            
            for (int i = 0; i < 15; i++)
            {                
                fifteenNames[i] = names[IndexOfLastUsed];
                //NextNameIndex();
                CircularArrayTraversal(1);
            }
            //returns array of string
            return fifteenNames;
        }

        public string[] GetPreviousFifteenNames()
        {
            //returns array of strings
            //start at the end and work your way up?
            string[] fifteenNames = new string[15];
            if(pagedForward)
            {
                pagedForward = false;
                //get new index - jump back 16
                //IndexOfLastUsed = ((IndexOfLastUsed + -16) % names.Count + names.Count) % names.Count;
                CircularArrayTraversal(-16);
            }

            for (int i = 15; i > 0; i--)
            {                
                fifteenNames[i - 1] = names[IndexOfLastUsed];
                //PreviousNameIndex();
                CircularArrayTraversal(-1);
            }
            return fifteenNames;    
        }

        private void CircularArrayTraversal(int jump)
        {
            if (jump < 0)
            {
                //traverse backwards
                IndexOfLastUsed = ((IndexOfLastUsed + jump) % names.Count + names.Count) % names.Count;
            }
            else
            {
                //traverse forward
                IndexOfLastUsed = (IndexOfLastUsed + jump) % names.Count;
            }
        }

        private void NextNameIndex()
        {
            IndexOfLastUsed++;
            if(IndexOfLastUsed ==  names.Count) 
                IndexOfLastUsed = 0;
        }

        private void PreviousNameIndex()
        {
            IndexOfLastUsed--;
            if (IndexOfLastUsed < 0)
                IndexOfLastUsed = names.Count - 1;
        }

        public List<string> GetNameAndNumbersList()
        {
            return names;
        }

        public int GetLenghtOfLongestLine()
        {

            return 0; //placeholder
        }
    }
}
