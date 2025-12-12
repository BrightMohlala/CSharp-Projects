using System.Collections.Generic;
using System.IO;


internal static class FileManagement
{
    public static string[][] Read (string fileName  )
    {
        List<string> lstBooks = new List<string>();
        if (File.Exists(fileName))
        {
            using (StreamReader f = new StreamReader(fileName))
            {
                while (!f.EndOfStream)
                    lstBooks.Add(f.ReadLine());
            } //using f

            string[][] content = new string[lstBooks.Count][];
            for (int i = 0; i < lstBooks.Count; i++)
                content[i] = lstBooks[i].Split('\t');
            return content;
        } //if file exists

        return null;
    } //Read

    public static bool Save(string fileName, string[][] content)
    {
        try
        {
            using (StreamWriter f = new StreamWriter(fileName, false))
            {
                foreach (string[] line in content)
                {
                    foreach (string field in line)
                        f.Write(field + "\t");
                    f.WriteLine();
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    } //Save

} //class

