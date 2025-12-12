using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT7Q2_Weather
{
    public partial class CfrmWeather : Form
    {
        //Current state
        private AProvince province { get; set; }

        //Constructor
        public CfrmWeather()
        {
            InitializeComponent();
        } //ctor

        private void CfrmWeather_Shown(object sender, System.EventArgs e)
        {
            picWeather.Load("sa_blank.png");
        }  //Shown

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        } //btnClose_Click

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start with Gauteng
            province = new GP(this);

            while (province != null)
            {
                Display();

                Thread.Sleep(1000);
                GetNextProvince();
            }
        } //btnStart_Click

        private void GetNextProvince()
        {
            province.NextProvince();
        } //GetNextProvince

        //SetState in conceptual class diagram
        public void SetProvince(AProvince next_province)
        {
            //Replace current state with its successor
            province = next_province;
        } //LoadProvince

        private void Display()
        {
            //Display properties
            lblProvince.Text = province.Name;
            lblMaxTemp.Visible = lblMinTemp.Visible = province.minTemp != -100;
            lblMinTemp.Text = "Min temperature: " + province.minTemp.ToString() + ((char)176) + "C";
            lblMaxTemp.Text = "Max temperature: " + province.maxTemp.ToString() + ((char)176) + "C";
            picWeather.Load(province.imageFile);

            //Update GUI thread
            this.Refresh();
        } //Display
    } //class CfrmWeather
}
