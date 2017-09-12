using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace GrapperNew
{
    internal class Folder
    {
        
        
        public Folder()
        {
            
        }

        public void ZipDirectory(string filePath)
        {
            string zipPath = filePath + ".zip";
            try
            {
                
                ZipFile.CreateFromDirectory(@filePath, @zipPath); //requires try-catch
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public IEnumerable<string> GetFiles(string folderPath, DateTime dt)
        {

            var filelist = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Where(x => new FileInfo(x).LastWriteTime.Date >= dt);
            return filelist;
        }

        public void CreateFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public void DeleteFolder(string folderPath)
        {
            //delete temp directory and zip file
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
                  
            }

        }

        
    }

}
        
    
