using System.Threading;

namespace CT7Q2_Weather
{
    public abstract class AProvince
    {
        //Context
        protected CfrmWeather frmWeather;

        //Properties
        public string Name { get; protected set; }
        public double minTemp { get; protected set; }
        public double maxTemp { get; protected set; }
        public string imageFile { get; protected set; }

        //Constructor
        public AProvince(CfrmWeather frmWeather)
        {
            this.frmWeather = frmWeather;
            minTemp = maxTemp = -100;
            imageFile = "sa_blank.png";
        } //ctor

        public abstract void NextProvince(); //NextState in conceptual CD

    } //class AState
} //namespace
