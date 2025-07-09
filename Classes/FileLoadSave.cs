using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCallScheduler
{
    public class FileLoadSave
    {
        public List<string> LoadTestData()
        {
            List<string> data = new List<string>()
            {
                "2",                //Number of sites

                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Carbondale/Dunmore",  //SiteName
                 "4",                   //Number of Staff Names and Numbers
                "Jamie Maher", "(570)280-4194",  //Staff Names and Numbers
                "Sandy O'Connell", "(570)335-4419",
                "Joe Pugliese", "(908)635-4106",
                "4444444444", "(444)444-4444",
                
                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Test Site",  //SiteName
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
