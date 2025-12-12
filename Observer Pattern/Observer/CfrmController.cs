using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CT7Q1_Observer
{
    public partial class CfrmController : Form
    {
        private List<IObserver> lstObservers = new List<IObserver>();

        public CfrmController()
        {
            InitializeComponent();
        } //ctor

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        } //btnClose_Click

        private void CfrmController_Shown(object sender, EventArgs e)
        {
            IObserver station1 = new CfrmStation("Station 1");
            ((Form)station1).Location = new System.Drawing.Point(500, this.Bottom);
            ((Form)station1).Show();
            lstObservers.Add(station1);

            IObserver station2 = new CfrmStation("Station 2");
            ((Form)station2).Location = new System.Drawing.Point(700, this.Bottom);
            ((Form)station2).Show();
            lstObservers.Add(station2);

            IObserver station3 = new CfrmStation("Station 3");
            ((Form)station3).Location = new System.Drawing.Point(900, this.Bottom);
            ((Form)station3).Show();
            lstObservers.Add(station3);

            IObserver station4 = new CfrmStation("Station 4");
            ((Form)station4).Location = new System.Drawing.Point(1100, this.Bottom);
            ((Form)station4).Show();
            lstObservers.Add(station4);

        } //CfrmController_Shown

        private void chStation_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (IObserver observer in lstObservers)
            for (int i = 0; i < lstObservers.Count; i++)
            {
                IObserver observer = lstObservers[i];
                if (sender is CheckBox cb)
                {
                    //CheckBox cb = (CheckBox)sender;
                    if (((CfrmStation)observer).Text == cb.Text)
                        observer.Update(cb.Checked);
                } //if
            } //for

        } //chStation_CheckedChanged

    } //class
}
