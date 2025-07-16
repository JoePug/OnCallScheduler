using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnCallScheduler
{
    public class FileLoadSave
    {   
        public List<Sites> GetDataFromFiles()
        {
            List<Sites> sites = new List<Sites>();

            List<string> data = LoadTestData();
            int numOfSites = int.Parse(data[0]);

            data.RemoveAt(0);

            for (int i = 0; i < numOfSites; i++)
            {
                Sites _site = new Sites();

                //int.Parse should be fine as it will of been tested already
                _site.Month = int.Parse(data[0]);
                _site.Day = int.Parse(data[1]);
                _site.Year = int.Parse(data[2]);
                _site.SiteName = data[3];
                _site.GetStaffNameAndNumbers().LastSavedTopOfPage = int.Parse(data[4]);

                int numOfStaff = int.Parse(data[5]);

                data.RemoveRange(0, 6);

                if (numOfStaff > 0)
                {
                    for (int j = 0; j < numOfStaff; j++)
                    {
                        _site.GetStaffNameAndNumbers().AddNewNameAndNumber((data[0], data[1]));
                        data.RemoveRange(0, 2);
                    }
                }
                sites.Add(_site);
            }
                return sites;
        }

        private List<string> LoadTestData()
        {
            List<string> data = new List<string>()
            {
                "2",                //Number of sites

                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Carbondale/Dunmore",  //SiteName
                "0",                    //Index of first staff in list
                "4",                   //Number of Staff Names and Numbers
                "Jamie Maher", "(570)280-4194",  //Staff Names and Numbers
                "Sandy O'Connell", "(570)335-4419",
                "Joe Pugliese", "(908)635-4106",
                "4444444444", "(444)444-4444",

                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Test Site",  //SiteName
                "0",                    //Index of first staff in list
                "4",                   //Number of Staff Names and Numbers
                "1111111111", "(111)111-1111",  //Staff Names and Numbers
                "2222222222", "(222)222-2222",
                "3333333333", "(333)333-3333",
                "4444444444", "(444)444-4444"
            };

            return data;
        }
    }
}
