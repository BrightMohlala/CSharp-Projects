using System.Drawing;
using System.Windows.Forms;

namespace CT7Q1_Observer
{
    public partial class CfrmStation : Form, IObserver
    {
        public bool isOn { get; private set; }
        public CfrmStation(string name)
        {
            InitializeComponent();
            Text = name;
        } //ctor

        public void Update(bool isOn)
        {
            this.isOn = isOn;
            lblStatus.Text = isOn? "Status: On" : "Status: Off";
            BackColor = isOn? Color.LightBlue : SystemColors.Control;
        } //Update
    } //class
} //namespace
