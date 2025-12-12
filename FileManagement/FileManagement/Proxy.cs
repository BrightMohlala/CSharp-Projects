using System.IO;

class FMProxy : IFileManagement
{
    private FileManagement fm;

    public FMProxy(string fileName)
    {
        fm = new FileManagement(fileName);
    } //Constructor

    public string Read()
    {
        if (File.Exists(fm.fileName))
            return fm.Read();
        return "";
    } //Read

    public void Write(string text)
    {
        fm.Write(text);
    } //Write
} //class

