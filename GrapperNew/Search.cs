using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GrapperNew
{
    internal class Search
    {
        private string SearchDirectory;
        private string[] SearchArray;
        private IEnumerable<string> FileNames;
        public Boolean IsMatch;
        public ProgressBar ProgBar;
        public int Matches;
        public BackgroundWorker Bw;
        public Boolean FirstMatch;
       

        public Search(string searchDirectory, string[] searchArray, IEnumerable<string> fileNames, BackgroundWorker bw)
        {

            SearchDirectory = searchDirectory;
            SearchArray = searchArray;
            FileNames = fileNames;
            Bw = bw;
            //FirstMatch = firstMatch;
        }
        
        public DataTable SearchFiles()
        {
            List<string> searchList = SearchArray.Cast<string>().ToList();
            DataTable fileMatchTable = new DataTable();
            int numOfFiles = FileNames.Count();
            fileMatchTable.Columns.Add("A");
            fileMatchTable.Columns.Add("B");

            int n = 0;

            foreach (string file in FileNames)
            {
                for (int i = 0; i < searchList.Count; i++)
                {
                    if (SearchArray[i] != "")
                    {
                        Boolean isMatch = File.ReadAllText(file).ToLower().Contains(searchList[i].ToLower())
                            ? true
                            : false;
                        if (isMatch)
                        {
                            fileMatchTable.Rows.Add(searchList[i],file);
                            Matches = Matches + 1;
                            //first match only
                            if (FirstMatch == true)
                            {
                                searchList.RemoveAt(i);
                            }
                            
                        }
                    }
                }

                //progress bar update
                int percentage = (n + 1) * 100 / numOfFiles;
                n = n + 1;
                Bw.ReportProgress(percentage);
            }

            return fileMatchTable; 
        }
    }
}
