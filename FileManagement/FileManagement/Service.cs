using System.IO;

class FileManagement : IFileManagement
{
    public string fileName { get; private set; }

    public FileManagement(string fileName)
    {
        this.fileName = fileName;
    } //Constructor

    public string Read()
    {
        return File.ReadAllText(fileName);
    }

    public void Write(string text)
    {
        File.WriteAllText(fileName, text);
    }

} //class

