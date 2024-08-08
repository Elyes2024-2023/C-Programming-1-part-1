using _2._1_DirectoryOperationApp;

class Program
{
    static void Main(string[] args)
    {
        string basePathSource = @"C:\Users\Bhavik PC\Desktop\FolderOperations\";
        string sourceFolder = "Copy";
        string basePathDestination = @"C:\Users\Bhavik PC\Desktop\FolderOperations\";
        string destinationFolder = "Destination";
        string FolderToRename = "FolderToRename";
        string renameTo = "NewFolder";

        Console.WriteLine("Copying folder...");
        FolderOperations.CopyFolder(basePathSource+sourceFolder, basePathDestination+destinationFolder);

        Console.WriteLine("\nListing contents of destination folder after copy:");
        FolderOperations.ListFolderContents(basePathDestination + destinationFolder);

        Console.WriteLine("\nDeleting destination folder...");
        FolderOperations.DeleteFolder(basePathDestination + destinationFolder);

        Console.WriteLine("\nRenaming the Destination Folder to NewFolder:");
        FolderOperations.RenameFolder(basePathSource + FolderToRename, basePathDestination + renameTo);
    }
}