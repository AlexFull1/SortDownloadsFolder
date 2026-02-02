class Program
{
    static void Main(string[] args)
    {
        // Enable UTF-8 encoding for console output
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Specify the path to the directory to be organized
        string path = @"C:\Users\Aleksandr\Downloads";
        Console.WriteLine($"The specified path is: {path}");
        // Define file extensions for different categories
        string[] imageExtensions = { "jpg", "png", "drawio" };
        string[] documentExtensions = { "pdf", "docx", "xlsx", "doc", "pptx", "txt", "csv" };
        string[] archiveExtensions = { "zip", "rar", "7z", "tar", "gz" };
        string[] audioExtensions = { "mp3", "wav", "flac", "aac", "ogg" };
        string[] videoExtensions = { "mp4", "avi", "mkv", "mov" };
        string[] appExtensions = { "exe", "msi" };
        // Sort files into respective folders based on their extensions
        SortFiles(path, "Images", imageExtensions);
        SortFiles(path, "Documents", documentExtensions);
        SortFiles(path, "Music", audioExtensions);
        SortFiles(path, "Archives", archiveExtensions);
        SortFiles(path, "Apps", appExtensions);
        SortFiles(path, "Videos", videoExtensions);
    }

    //Function to sort files based on extensions
    public static void SortFiles(string path, string folderName, string[] extensions)
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
                    Console.WriteLine(file.Name);
                    file.MoveTo(Path.Combine(pathToFolder, file.Name));
                }
            }
            else
            {
                Console.WriteLine($"No {extension} files found.");
                continue;
            }
        }
    }
}