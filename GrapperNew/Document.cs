using System.IO;

namespace GrapperNew
{
    class Document
    {
        public Document()
        {
            
        }

        public void SaveDocument(string filePath, string savePath)
        {
            File.Copy(filePath,savePath + "\\" + Path.GetFileName(filePath), true);
        }

        public void DeleteDocument(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
        }

        public void WriteLineToFile(string text, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@filename,true))
            {
                sw.WriteLine(text);
            }
        }



    }

}
