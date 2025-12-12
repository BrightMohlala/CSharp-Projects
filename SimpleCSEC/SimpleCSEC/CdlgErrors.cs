using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleCSEC
{
    public partial class CdlgErrors : Form
    {
        public CdlgErrors(IStaticList<string> lstErrors)
        {
            InitializeComponent();

            //Test enumerator
            foreach (string error in lstErrors)
                lstbxErrors.Items.Add(error);

            //Test set part of indexer
            //lstErrors[0] = ":"; 

            //Test get part of indexer
            //for (int i = 0; i < lstErrors.Count; i++) 
            //    lstbxErrors.Items.Add(lstErrors[i]);

        } //ctor

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
