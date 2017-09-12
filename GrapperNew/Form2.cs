using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GrapperNew
{

    // +++++++++TODO++++++++++++++++
    // [x] create directory with tracking number or time stamp
    // [x] not finding exact results, first extended test found 5 documents for 3 search terms
    // [x] progress bar not accurat
    // [x] output text to log text box
    //  [-] live update match text box with current match count
    // [ ] try catches to handle errors
    // [x] impliment first match option
    // [x] packing list txt file
    // [x] count number of files in folder
    // [x] name the zip file with timestamp
    // [ ] make progress bar refresh immediately after pressing start search button
    // [ ] add search by date range

    
    public partial class Form2 : Form
    {

        private string _searchPath;
        private string _tempDirPath;
        private string _zipPath;
        private string[] _searchStrings;
        private IEnumerable<string> _searchFiles;
        delegate void SetTextCallback(string text, TextBox textBox, Boolean scroll);
        private string matches;
        private readonly string timestamp = DateTime.Now.ToString("M.dd.yyyy hh-mm-ss");

        public Form2()
        {
            InitializeComponent();
        }

        private void searchDirectoryButton_Click(object sender, EventArgs e)
        {
            if (searchFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                directoryTextBox.Text = searchFolderBrowserDialog.SelectedPath;
                _searchPath = directoryTextBox.Text;
            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Folder folder = new Folder();
            Document document = new Document();
            
            //create temp directory
            _tempDirPath = Path.GetTempPath() + "Grapper" +timestamp;

           //assign zip path
            _zipPath = _tempDirPath + ".zip";

            //clear old temp dir and zip file
            RemoveOldTemp(_zipPath,_tempDirPath);

            folder.CreateFolder(_tempDirPath);

            backgroundWorker.RunWorkerAsync();
            
        }

        //allows writing text to any text box even if it's not on the same thread
        private void SetText(string text, TextBox textBox, Boolean scroll)
        {
            if (textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text,textBox,scroll });
            }
            else
            {
                if (scroll == true)
                {
                    textBox.ScrollToCaret();
                }
                textBox.Text = textBox.Text + text;
            }

        }

        private void backgroundWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            SetText("START: \t\t" + DateTime.Now + Environment.NewLine, logTextBox, true);
            SetText("Scanning: \t "+ _searchPath + Environment.NewLine, logTextBox, true);

            Document document = new Document();
            Folder folder = new Folder();

            //collect data for main search
            _searchStrings = searchListTextBox.Lines;
            _searchFiles = folder.GetFiles(_searchPath,searchDatePicker.Value);
            int numOfFiles = _searchFiles.Count();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            SetText("Searching " + numOfFiles.ToString() + " files." + Environment.NewLine, logTextBox, true);
            SetText("----------------------------------BEGIN------------------------------------------------------ " + Environment.NewLine, logTextBox, true);
            
            Search search = new Search(_searchPath, _searchStrings, _searchFiles, backgroundWorker);
            DataTable searchTable = search.SearchFiles();//runs the main search 

            if (firstMatchCheckBox.Checked)
            {
                search.FirstMatch = true;
            }

            search.ProgBar = progressBar1;//important so progress bar can respond back

            for (int i = 0; i < searchTable.Rows.Count; i++)
            {
                string searchString = searchTable.Rows[i][0].ToString();
                string filePath = searchTable.Rows[i][1].ToString();
                string savePath = _tempDirPath + "\\" + searchString;
                
                folder.CreateFolder(savePath);
                document.SaveDocument(filePath, savePath);
                document.WriteLineToFile(searchString , _tempDirPath + "\\contents.txt");

                SetText("Found:\t\t " + searchString + "\t" +filePath + Environment.NewLine, logTextBox, true);
                
            }

            matches = search.Matches.ToString();
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            string elapsedtime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            SetText("----------------------------------FINISHED----------------------------------------------------" + Environment.NewLine, logTextBox, true);
            SetText("END TIME:\t " + DateTime.Now + Environment.NewLine, logTextBox, true);
            SetText("TOTAL TIME:   \t  " + elapsedtime + " minutes" + Environment.NewLine, logTextBox, true);
            SetText("MATCHES: \t " + matches + Environment.NewLine, logTextBox, true);

        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Folder folder = new Folder();
            Document document = new Document();

            folder.ZipDirectory(_tempDirPath);
            

            //create and send email
            string address = emailComboBox.Text;
            string body = emailBodyRichTextBox.Text;
            if (address != "")
            {
                Mail mail = new Mail(address, "Grapper Search Results - "+timestamp, body, _zipPath);
                mail.Send();

                //might not need these because of RemoveOldTemp()
                document.DeleteDocument(_zipPath);
                folder.DeleteFolder(_tempDirPath);
            }

            MessageBox.Show("finished \n" + matches + " found");
        }

        private void aboutGrapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grapper v1.0");
        }

        private void RemoveOldTemp(string zipPath, string tempDirPath)
        {
            Document document = new Document();
            Folder folder = new Folder();
            
            if (File.Exists(zipPath))
            {
                document.DeleteDocument(zipPath);
            }

            if (Directory.Exists(tempDirPath))
            {
                folder.DeleteFolder(tempDirPath);
            }
        }

        

       

    }
   
}


