using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnCallScheduler
{ 
    public class StaffNameAndNumbers
    {
        List<(string, string)> names = new List<(string, string)>();

        public int IndexOfLastUsed { get; set; } = -1;
        bool pagedForward = true;

        public void AddNewNameAndNumber((string, string) name)
        {
            //when you add a new name, redo the index of last used to point to the first one of the displaListView

            names.Add(name);    
        }

        public (string, string) GetOneName(int index)
        {
            return names[index];
        }

        public void EditOneName((string, string) oneName, int index)
        {
            names[index] = oneName;
        }

        public void DeleteOneName(int index)
        {
            names.RemoveAt(index);
        }

        public (string, string)[] GetNextFifteenNames()
        {
            (string, string)[] fifteenNames = new (string, string)[15];

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
                CircularArrayTraversal(1);
            }
            //returns array of string
            return fifteenNames;
        }

        public (string, string)[] GetPreviousFifteenNames()
        {
            //returns array of strings
            //start at the end and work your way up?
            (string, string)[] fifteenNames = new (string, string)[15];
            if (pagedForward)
            {
                pagedForward = false;
                //get new index - jump back 16
                //IndexOfLastUsed = ((IndexOfLastUsed + -16) % names.Count + names.Count) % names.Count;
                CircularArrayTraversal(-16);
            }

            for (int i = 15; i > 0; i--)
            {
                fifteenNames[i - 1] = names[IndexOfLastUsed];
                CircularArrayTraversal(-1);
            }
            return fifteenNames;    
        }

        public (string, string)[] GetCurrnetNamesAgain(int lastSavedTopOfPage = 0)
        {
            (string, string)[] fifteenNames = new (string, string)[15];
            
            IndexOfLastUsed = lastSavedTopOfPage;

            for (int i = 0; i < 15; i++)
            {
                fifteenNames[i] = names[IndexOfLastUsed];
                CircularArrayTraversal(1);
            }

            pagedForward = true;

            return fifteenNames;
        }

        public void SwapNames(int index1, int index2)
        {
            (string, string) temp = names[index1];
            names[index1] = names[index2];  
            names[index2] = temp;
        }

        public int GetStaffNamesCount()
        {
            return names.Count;
        }

        public StaffNameAndNumbers GetStaffNameAndNumbers()
        {
            return this;
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

        public List<(string, string)> GetNameAndNumbersList()
        {
            return names;
        }

        public int GetLenghtOfLongestLine()
        {

            return 0; //placeholder
        }
    }
}
