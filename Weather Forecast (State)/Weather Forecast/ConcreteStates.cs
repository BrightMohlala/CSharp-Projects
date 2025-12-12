using System.Threading;

namespace CT7Q2_Weather
{
    public class GP :  AProvince
    {
        public GP(CfrmWeather frmWeather): base (frmWeather)
        {
            this.Name = "Gauteng";
            imageFile = "gp_red.png";
            minTemp = 1;
            maxTemp = 18;
        } //ctor

        public override void NextProvince() //NextState in conceptual CD
        {
            AProvince next_province = new LP(frmWeather);
            frmWeather.SetProvince(next_province); //Implicitly calling NextProvince
        } //NextProvince
    } //class Gauteng

    public class LP : AProvince
    {
        public LP(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Limpopo";
            imageFile = "lp_red.png";
            minTemp = 11;
            maxTemp = 28;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new MP(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince

    } //class Limpopo

    public class MP : AProvince
    {
        public MP(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Mpumalanga";
            imageFile = "mp_red.png";
            minTemp = 9;
            maxTemp = 27;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new KZN(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince

    } //class Mpumalanga
        
    public class KZN : AProvince
    {
        public KZN(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "KwaZulu-Natal";
            imageFile = "kzn_red.png";
            minTemp = 11;
            maxTemp = 13;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new EC(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince

    } //class KwaZuluNatal

    public class EC : AProvince
    {
        public EC(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Eastern Cape";
            imageFile = "ec_red.png";
            minTemp = -3;
            maxTemp = 21;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new WC(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class EasternCape

    public class WC : AProvince
    {
        public WC(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Western Cape";
            imageFile = "wc_red.png";
            minTemp = 8;
            maxTemp = 15;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new NC(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class WesternCape

    public class NC : AProvince
    {
        public NC(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Northern Cape";
            imageFile = "nc_red.png";
            minTemp = -4;
            maxTemp = 18;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new NW(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class NorthernCape

    public class NW : AProvince
    {
        public NW(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "North-West";
            imageFile = "nw_red.png";
            minTemp = -1;
            maxTemp = 11;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new FS(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class Northwest

    public class FS : AProvince
    {
        public FS(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "Free State";
            imageFile = "fs_red.png";
            minTemp = -5;
            maxTemp = 13;
        } //ctor

        public override void NextProvince()
        {
            AProvince next_province = new SA(frmWeather);
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class Freestate

    public class SA : AProvince
    {
        public SA(CfrmWeather frmWeather) : base(frmWeather)
        {
            this.Name = "South Africa";
            imageFile = "sa_blank.png";
        } //ctor

        public override void NextProvince()
        {
            //Do nothing
            AProvince next_province = null;
            frmWeather.SetProvince(next_province);
        } //NextProvince
    } //class SA


} //namespace
