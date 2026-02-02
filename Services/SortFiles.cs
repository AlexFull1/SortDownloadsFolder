using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Services
{
    public class SortFiles
    {
        //Function to sort files based on extensions
        public static void Sort(string path, string folderName, string[] extensions)
        {
            // Get directory information
            var fileInfo = new DirectoryInfo(path);
            var pathToFolder = Path.Combine(path, folderName);
            foreach (var extension in extensions)
            {
                // Get files with the current extension 
                var files = fileInfo.GetFiles($"*.{extension}");
                // Create target folder if it doesn't exist
                if (!Directory.Exists(pathToFolder))
                {
                    Directory.CreateDirectory(pathToFolder);
                }
                // Move files to the target folder
                if (files.Length != 0)
                {
                    foreach (var file in files)
                    {
                        //Console.WriteLine(file.Name);
                        file.MoveTo(Path.Combine(pathToFolder, file.Name));
                    }
                }
                else
                {
                    //Console.WriteLine($"No {extension} files found.");
                    continue;
                }
            }
        }
    }
}
