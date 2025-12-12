using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCSEC
{
    public partial class CfrmMain : Form
    {
        //Data members
        private IStaticList<string> lstErrors = new StaticList<string>();

        //Constructor
        public CfrmMain()
        {
            InitializeComponent();
        } //ctor

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        } //btnClose_Click

        private void btnNewConsoleApp_Click(object sender, System.EventArgs e)
        {
            txtMain.Clear();

            txtMain.Text = "/*\n\tStudent number           : \n\tStudent name and surname : \n*/\n\n"
                         + "using System;\n\npublic class CProgram\n{\n\tpublic static void Main()\n\t{"
                         + "\n\t\tConsole.WriteLine(\"\\n\\tHi there!\");\n\t\n"
                         + "\t\n"
                         + "\t\tConsole.Write(\"\\n\\n\\tPress any key to exit ...\");\n\t\tConsole.ReadKey();\n\t} //End of Main\n} //End of class";

        } //btnNewConsoleApp_Click

        private void btnErrors_Click(object sender, EventArgs e)
        {
            new CdlgErrors(lstErrors).ShowDialog();
        } //btnErrors_Click

        #region Compile and run

        private void btnRun_Click(object sender, System.EventArgs e)
        {
            //Get compiler
            string csc = GetCSC();
            if (csc == "")
            {
                MessageBox.Show("Compiler not found");
                return;
            } //if csc not found

            //File names
            string cs_filename = Path.GetDirectoryName(Application.ExecutablePath) + "\\HelloWorld.cs";
            string exe_filename = Path.GetDirectoryName(Application.ExecutablePath) + "\\HelloWorld.exe";
            txtMain.SaveFile(cs_filename, RichTextBoxStreamType.PlainText);

            //Delete exe from previous run
            if (File.Exists(exe_filename))
                File.Delete(exe_filename);

            //Compile
            Process prCompile = new();
            prCompile.StartInfo.CreateNoWindow = true;
            prCompile.StartInfo.UseShellExecute = false; //Must be false to redirect streams
            prCompile.StartInfo.RedirectStandardOutput = true;
            prCompile.StartInfo.FileName = "\"" + csc + "\"";
            prCompile.StartInfo.Arguments = "/out:\"" + exe_filename + "\" \"" + cs_filename + "\"";
            bool isNewProcessStarted = prCompile.Start();
            prCompile.WaitForExit();
            txtCompilerOutput.Text = prCompile.StandardOutput.ReadToEnd();

            //Q3.2 Add errors to list
            lstErrors.Clear();            
            string[] lines = txtCompilerOutput.Text.Split(['\n']);

            //List<string> lstErrorLines = new List<string>(lines).Where(line => line.Contains("error")).ToList();
            //foreach (string line in lstErrorLines)
            //    lstErrors.Add(line);

            foreach (string line in lines)
                if (line.Contains("error"))
                    lstErrors.Add(line);

            //for (int i = 0; i < lines.Length; i++)
            //    if (lines[i].Contains("error"))
            //        lstErrors.Add(lines[i]);

            //Run
            if (File.Exists(exe_filename))
            {
                lstErrors.Clear();
                Process prRun = new();
                prRun.EnableRaisingEvents = true;
                prRun.StartInfo.FileName = exe_filename;
                prRun.Start(); //Breaks in any case if there is a runtime error in the program               
            } //if exe exists
        } //btnRun_Click

        //Find compiler file on the user's computer
        private string GetCSC()
        {
            List<string> lstCSCs = [.. Directory.GetFiles("C:\\Windows\\Microsoft.NET\\Framework\\", "csc.exe", SearchOption.AllDirectories)];
            if (lstCSCs.Count > 0)
                return lstCSCs[lstCSCs.Count - 1];  //Last one is probably the latest one
            else
                return "";
        } //GetCSC

        #endregion Compile and run

    } //class CfrmMain
} //namespace
