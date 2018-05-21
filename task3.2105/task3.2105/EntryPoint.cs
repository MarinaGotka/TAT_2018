using System;

namespace task3._2105
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                FilesSearcher filesSearcher = new FilesSearcher(args[0],"*" + args[1]);
                string[] files = filesSearcher.GetFilesWithExtension();

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!", ex.Message);
            }
        }
    }
}
