using System;
using System.Collections.Generic;
using System.IO;

class Client
{
    static void Main(string[] args)
    {
        //Black text on white background
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine();

        //Create folders on the hard drive for testing
        CreateFolders();

        //Create the composite structure
        IFolder root = new Folder("Root");
        TraverseDirDepthFirst(root);

        //Display the folders
        ShowData(root);

        //Exit program
        //Console.Write("\n\tPress any key to exit ... ");
        Console.ReadKey();
    } //Main

    //Create test data
    private static void CreateFolders()
    {
        if (Directory.Exists("Root"))
            Directory.Delete("Root", true);

        Directory.CreateDirectory("Root");
        Directory.CreateDirectory("Root\\A");
        Directory.CreateDirectory("Root\\A\\A1");
        Directory.CreateDirectory("Root\\A\\A2");
        Directory.CreateDirectory("Root\\B");
        Directory.CreateDirectory("Root\\B\\B1");
        Directory.CreateDirectory("Root\\B\\B2");
        Directory.CreateDirectory("Root\\B\\B2\\B2a");
        Directory.CreateDirectory("Root\\B\\B2\\B2b");
        Directory.CreateDirectory("Root\\B\\B2\\B2c");
        Directory.CreateDirectory("Root\\B\\B2\\B2d");
        Directory.CreateDirectory("Root\\B\\B3");
    } //CreateFolders

    private static void TraverseDirDepthFirst(IFolder folder)
    {
        DirectoryInfo dirInfo = new DirectoryInfo(folder.path);
        DirectoryInfo[] children = dirInfo.GetDirectories();

        // For each child, visit its sub-tree
        foreach (DirectoryInfo di_child in children)
        {
            IFolder child;
            string folderName = di_child.FullName;
            if (di_child.GetDirectories().Length > 0)
                child = new Folder(folderName);
            else
                child = new BasicFolder(folderName);
            ((Folder)folder).Add(child);
            TraverseDirDepthFirst(child);
        } //foreach
    } //TraverseDirDF

    //Show content of the composite structure
    private static void ShowData(IFolder folder, int nSpaces = 0)
    {
        string name = Path.GetFileName(folder.path);
        Console.WriteLine("\t" + "".PadLeft(nSpaces) + name);
        if (folder is Folder) //Not BasicFolder
        {
            //List<IFolder> subfolders = ((Folder)folder).GetChildren();
            IFolder[] subfolders = ((Folder)folder).GetChildren();
            foreach (IFolder childFolder in subfolders)
                ShowData(childFolder, nSpaces + 4);
        }
    } //ShowData

} //class Proram

