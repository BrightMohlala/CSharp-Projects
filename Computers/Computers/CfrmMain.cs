using System.Collections.Generic;
using System.Windows.Forms;

namespace Computers
{
    public partial class CfrmMain : Form
    {
        private List<Computer> lstComputers;

        public CfrmMain()
        {
            InitializeComponent();

            //Instantiate list of computers
            lstComputers = new List<Computer>();

            //Use builders to create new computers and add to list
            //- Barebone
            IComputerBuilder bareboneBuilder = new BareboneBuilder("Barebone");
            //bareboneBuilder.SetAttributes();
            lstComputers.Add(bareboneBuilder.GetComputer());

            //- Home
            IComputerBuilder homeBuilder = new HomeBuilder("Home computer");
            //homeBuilder.SetAttributes();
            lstComputers.Add(homeBuilder.GetComputer());

            //- Office
            IComputerBuilder officeBuilder = new OfficeBuilder("Office computer");
            //officeBuilder.SetAttributes();
            lstComputers.Add(officeBuilder.GetComputer());

            //- Gaming
            IComputerBuilder gamingBuilder = new BareboneBuilder("Gaming computer");
            //gamingBuilder.SetAttributes();
            lstComputers.Add(gamingBuilder.GetComputer());

            //- Beast
            IComputerBuilder beastBuilder = new BeastBuilder("Beast");
            //beastBuilder.SetAttributes();
            lstComputers.Add(beastBuilder.GetComputer());

            //Load listbox
            lstbxComputers.DataSource = lstComputers;
            lstbxComputers.DisplayMember = "Name";
        } //ctor

        private void lstbxComputers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstbxComputers.SelectedIndex >= 0)
                new CdlgMessage(((Computer)lstbxComputers.SelectedItem).Name, lstbxComputers.SelectedItem.ToString()).ShowDialog();
            //MessageBox.Show(lstbxComputers.SelectedItem.ToString(), ((Computer)lstbxComputers.SelectedItem).Name, MessageBoxButtons.OK);
        }
    } //class CfrmMain
} //namespace
