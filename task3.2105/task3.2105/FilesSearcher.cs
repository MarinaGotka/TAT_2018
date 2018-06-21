using System;
using System.IO;

namespace task3._2105
{
    public class FilesSearcher
    {
        string Path { get; set; }
        string Extension { get; set; }

        public FilesSearcher(string path, string extension)
        {
            Path = path;
            Extension = extension;
        }

        public string[] GetFilesWithExtension()
        {
            string[] dirs;
            if (!Directory.Exists(Path))
            {
                throw new ArgumentException("Error! Path is not found.");
            }
            if (Path == null)
            {
                throw new Exception("Error! Path is null.");
            }
            if (Extension == null)
            {
                dirs = Directory.GetFiles(Path);
            }
            dirs = Directory.GetFiles(Path, "*" + Extension);
            return dirs;
        }
    }
}
