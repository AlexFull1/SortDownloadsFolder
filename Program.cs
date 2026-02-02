using Cleaner.Services;
class Program
{
    static void Main(string[] args)
    {
        // Enable UTF-8 encoding for console output
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Specify the path to the Downloads folder
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        Console.WriteLine($"The specified path is: {path}");
        // Define file extensions for different categories
        string[] imageExtensions = { "jpg", "png", "drawio" };
        string[] documentExtensions = { "pdf", "docx", "xlsx", "doc", "pptx", "txt", "csv" };
        string[] archiveExtensions = { "zip", "rar", "7z", "tar", "gz" };
        string[] audioExtensions = { "mp3", "wav", "flac", "aac", "ogg" };
        string[] videoExtensions = { "mp4", "avi", "mkv", "mov" };
        string[] appExtensions = { "exe", "msi" };
        // Sort files into respective folders based on their extensions
        SortFiles.Sort(path, "Images", imageExtensions);
        SortFiles.Sort(path, "Documents", documentExtensions);
        SortFiles.Sort(path, "Music", audioExtensions);
        SortFiles.Sort(path, "Archives", archiveExtensions);
        SortFiles.Sort(path, "Apps", appExtensions);
        SortFiles.Sort(path, "Videos", videoExtensions);
        Console.WriteLine("File sorting completed.");
        Console.ReadKey();
    }
}