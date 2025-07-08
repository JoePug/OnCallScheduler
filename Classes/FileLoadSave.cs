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
                "1", "3",   // 1 site, 3 names and numbers
                "4", "4", "2026", //Start date MM-DD-YYYY
                "Carbondale/Dunmore",  //SiteName
                "Jamie Maher", "(570)280-4194",  //Staff Names and Numbers
                "Sandy O'Connell", "(570)335-4419",
                "Joe Pugliese", "(908)635-4106",
                "4444444444", "(444)444-4444"
            };

            return data;
        }
    }
}
