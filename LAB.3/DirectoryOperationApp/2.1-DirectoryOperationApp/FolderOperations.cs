using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_DirectoryOperationApp
{
    internal class FolderOperations
    {
        public static void CopyFolder(string sourceFolder, string destinationFolder)
        {
            if (!Directory.Exists(sourceFolder))
            {
                Console.WriteLine($"Source folder '{sourceFolder}' does not exist.");
                return;
            }

            Directory.CreateDirectory(destinationFolder);

            foreach (string file in Directory.GetFiles(sourceFolder))
            {
                string destFile = Path.Combine(destinationFolder, Path.GetFileName(file));
                File.Copy(file, destFile, true);
                Console.WriteLine($"Copied file: '{file}' to '{destFile}'");
            }

            foreach (string subFolder in Directory.GetDirectories(sourceFolder))
            {
                string destSubFolder = Path.Combine(destinationFolder, Path.GetFileName(subFolder));
                CopyFolder(subFolder, destSubFolder);
            }
        }

        public static void DeleteFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Folder '{folderPath}' does not exist.");
                return;
            }

            foreach (string file in Directory.GetFiles(folderPath))
            {
                File.Delete(file);
                Console.WriteLine($"Deleted file: '{file}'");
            }

            foreach (string subFolder in Directory.GetDirectories(folderPath))
            {
                DeleteFolder(subFolder);
            }

            Directory.Delete(folderPath);
            Console.WriteLine($"Deleted folder: '{folderPath}'");
        }

        public static void RenameFolder(string folderPath, string newName)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Folder '{folderPath}' does not exist.");
                return;
            }

            if (Directory.Exists(newName))
            {
                Console.WriteLine($"Folder '{newName}' already exists.");
                return;
            }

            Directory.Move(folderPath, newName);
            Console.WriteLine($"Renamed folder: '{folderPath}' to '{newName}'");
        }

        public static void ListFolderContents(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Folder '{folderPath}' does not exist.");
                return;
            }

            Console.WriteLine($"Contents of folder '{folderPath}':");
            foreach (string file in Directory.GetFiles(folderPath))
            {
                Console.WriteLine($"File: {file}");
            }

            foreach (string subFolder in Directory.GetDirectories(folderPath))
            {
                Console.WriteLine($"Subfolder: {subFolder}");
                ListFolderContents(subFolder);
            }
        }
    }
}
