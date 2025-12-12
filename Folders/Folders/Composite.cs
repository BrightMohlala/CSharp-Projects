using System;
using System.Collections.Generic;

class Folder : IFolder
{
    //private List<IFolder> lstFolders = new List<IFolder>();
    private IFolder[] arrFolders = [];
    public string path { get; }

    //Constructor
    public Folder(string path)
    {
        this.path = path;
    } //ctor

    public void Add(IFolder folder)
    {
        //lstFolders.Add(folder);
        Array.Resize(ref arrFolders, arrFolders.Length + 1);
        arrFolders[arrFolders.Length - 1] = folder;
    } //Add

    //public List<IFolder> GetChildren()
    //{
    //    return lstFolders;
    //} //GetChildren

    public IFolder[] GetChildren()
    {
        return arrFolders;
    } //GetChildren
} //class Folder

