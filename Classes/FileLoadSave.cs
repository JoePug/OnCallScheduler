using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace OnCallScheduler
{
    public class FileLoadSave
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory;
        //private string testPath = @"D:\Junk1\";                   //Desktop
        //private string testPath = @"C:\Users\Joe\Documents\Junk1\";  //laptop
        private string fileName = @"OnCallScheduler";
        private string ext = @".dat";
        private string backupExt = @".bak";
        private string saveFolder = @"Data\";
        private string workPath = string.Empty;
        private bool backupFileExists = false;

        public FileLoadSave()
        {
            workPath = path + saveFolder;  //uncomment for production
            //workPath = testPath + saveFolder;   //uncomment for testing
        }

        public List<Sites> LoadDataFromFiles()
        {
            string[] lines = [];
            bool works = false;

            while (!works)
            { 
                try
                {
                    lines = File.ReadAllLines(workPath + fileName + ext);            //works               
                    works = true;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    ManageBackup(false);
                    try
                    {
                        lines = File.ReadAllLines(workPath + fileName + ext);            //works               
                        works = true;
                    }
                    catch
                    {
                        MessageBox.Show("Loading Data Failed!");
                        return new List<Sites>();
                    }
                    return new List<Sites>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                    ManageBackup(false);
                    try
                    {
                        lines = File.ReadAllLines(workPath + fileName + ext);            //works               
                        works = true;
                    }
                    catch
                    {
                        MessageBox.Show("Loading Data Failed!");
                        return new List<Sites>();
                    }
                }
            }
            //return GetDataFromList(LoadTestData());  //returning test data for now
            return GetDataFromList(new List<string>(lines));
        }

        public void SaveDataToFiles(List<Sites> _sites)
        {
            if (_sites.Count == 0)
            {
                DeleteSaveFile();
                return;
            }

            List<string> data = new List<string>();
            data = CreateDataList(_sites);
            
            IEnumerable<string> lines = data;

            ManageBackup(true);
            bool works = false;

            while (!works)
            {
                try
                {
                    File.WriteAllLines(workPath + fileName + ext, lines);
                    works = true; //works
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    try
                    {
                        File.WriteAllLines(workPath + fileName + ext, lines);
                        works = true; //works
                    }
                    catch
                    {
                        MessageBox.Show("Saving Data Failed!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    try
                    {
                        File.WriteAllLines(workPath + fileName + ext, lines);
                        works = true; //works
                    }
                    catch
                    {
                        MessageBox.Show("Saving Data Failed!");
                        return;
                    }
                }
            }
        }

        public bool DirAndFileExists()
        {
            bool _file = false;

            if(!Directory.Exists(workPath))
            {
                Directory.CreateDirectory(workPath); //should probably try-catch this also                
            }

            if(File.Exists(workPath + fileName + ext))
            {
                _file = true;
            }

            if (File.Exists(workPath + fileName + backupExt))
            {
                backupFileExists = true;
            }

            return _file;    
        }

        private void DeleteSaveFile()
        {
            if (File.Exists(workPath + fileName + ext))
            {
                File.Delete(workPath + fileName + ext);
            }
        }

        private void ManageBackup(bool createBackup)
        {
            //use this to create backups of the previous saved files
            //also to revert to a backup if regular file fails to load
            if (!File.Exists(workPath + fileName + ext)) return; //file can be deleted if all sites are deleted.

            if (createBackup) //called before saving file
            {
                if(backupFileExists) //if true assume regular files exists too
                {
                    File.Move(workPath + fileName + ext, workPath + fileName + backupExt, overwrite: true);   //remane current file to backup file
                }
                else //if no backup, need to check for regular file existing also
                {
                    if (File.Exists(workPath + fileName + ext))
                        File.Move(workPath + fileName + ext, workPath + fileName + backupExt);  //rename current file to backup file
                }
            }
            else   //something went wrong and you need to revert to the backup file
            {                
                if (File.Exists(workPath + fileName + ext) && File.Exists(workPath + fileName + backupExt))
                {
                    File.Move(workPath + fileName + ext, workPath + fileName + @".bad", overwrite: true);
                    File.Copy(workPath + fileName + backupExt, workPath + fileName + ext, overwrite: true);
                }
                else
                {
                    if (File.Exists(workPath + fileName + ext))
                        File.Move(workPath + fileName + ext, workPath + fileName + @".bad", overwrite: true);

                    if (File.Exists(workPath + fileName + backupExt))
                        File.Copy(workPath + fileName + backupExt, workPath + fileName + ext, overwrite: true);
                }
            }    
        }

        private List<string> LoadTestData()
        {
            List<string> data = new List<string>()
            {
                "2",                //Number of sites

                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Carbondale/Dunmore",  //SiteName
                "The New Shift Begins at 8 AM on Fridays, if you want.", //Comment to print at the bottom of the page.
                "0",                    //Index of first staff in list
                "4",                   //Number of Staff Names and Numbers
                "Jamie Maher", "(570)280-4194",  //Staff Names and Numbers
                "Sandy O'Connell", "(570)335-4419",
                "Joe Pugliese", "(908)635-4106",
                "4444444444", "(444)444-4444",

                "7", "18", "2025",   //Start date MM-DD-YYYY
                "Test Site",  //SiteName
                "The New Shift Begins at 8 AM on Fridays, or never.", //Comment to print at the bottom of the page.
                "0",                    //Index of first staff in list
                "4",                   //Number of Staff Names and Numbers
                "1111111111", "(111)111-1111",  //Staff Names and Numbers
                "2222222222", "(222)222-2222",
                "3333333333", "(333)333-3333",
                "4444444444", "(444)444-4444"
            };

            return data;
        }

        private List<Sites> GetDataFromList(List<string> data)
        {
            List<Sites> sites = new List<Sites>();

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
                _site.CommentToPrint = data[4];
                _site.GetStaffNameAndNumbers().LastSavedTopOfPage = int.Parse(data[5]);

                int numOfStaff = int.Parse(data[6]);

                data.RemoveRange(0, 7);

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

        private List<string> CreateDataList(List<Sites> _sites)
        {
            List<String> data = new List<String>();

            if(_sites.Count == 0) return data;

            int numOfSites = _sites.Count;

            data.Add(numOfSites.ToString());

            foreach (Sites _site in _sites)
            {
                data.Add(_site.Month.ToString());
                data.Add(_site.Day.ToString());
                data.Add(_site.Year.ToString());
                data.Add(_site.SiteName);
                data.Add(_site.CommentToPrint);
                data.Add(_site.GetStaffNameAndNumbers().LastSavedTopOfPage.ToString());

                int numOfStaff = _site.GetStaffNameAndNumbers().GetStaffNamesCount();
                data.Add(numOfStaff.ToString());
                
                if (numOfStaff > 0)
                {
                    for (int j = 0; j < numOfStaff; j++)
                    {
                        data.Add(_site.GetStaffNameAndNumbers().GetOneName(j).Item1);
                        data.Add(_site.GetStaffNameAndNumbers().GetOneName(j).Item2);
                    }
                }
            }

            return data;
        }
    }
}
