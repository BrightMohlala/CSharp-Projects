using Microsoft.VisualBasic.Devices;

namespace Computers
{
    public abstract class AComputerBuilder : IComputerBuilder
    {
        protected Computer computer;

        public AComputerBuilder(string name)
        {
            computer = new Computer();
            computer.Name = name;
        } //ctor

        //public abstract void SetAttributes();

        public Computer GetComputer()
        {
            return computer;
        }
    } //class AComputerBuilder

    class BareboneBuilder : AComputerBuilder, IComputerBuilder
    {
        public BareboneBuilder(string name) : base(name)
        {
            computer.CPU = "Intel i3";
            computer.Cooler = "Air 95 mm";
            computer.Memory = "16 GB DDR5";
            computer.SSD = "240 GB";
            computer.Graphics = "Intel on-board";
            computer.Price = 7800m;
        } //ctor

        //public override void SetAttributes()
        //{
        //    computer.CPU = "Intel i3";
        //} //SetAttributes
    } //class BareboneBuilder

    class HomeBuilder : AComputerBuilder, IComputerBuilder
    {
        public HomeBuilder(string name) : base(name)
        {
            computer.CPU = "Intel i5";
            computer.Cooler = "Air 120 mm";
            computer.Memory = "24 GB DDR5";
            computer.SSD = "1 TB";
            computer.Graphics = "GeForce RTX 4060";
            computer.Price = 16900;
        } //ctor

        //public override void SetAttributes()
        //{

        //} //SetAttributes
    } //class HomeBuilder

    class OfficeBuilder : AComputerBuilder, IComputerBuilder
    {
        public OfficeBuilder(string name) : base(name)
        {
            computer.CPU = "Intel i7";
            computer.Cooler = "Air 120 mm";
            computer.Memory = "32 GB DDR4";
            computer.SSD = "2 TB with heatsink";
            computer.Graphics = "GeForce RTX 4060";
            computer.Price = 24500;
        } //ctor

        //public override void SetAttributes()
        //{

        //} //SetAttributes
    } //class OfficeBuilder

    class GamingBuilder : AComputerBuilder, IComputerBuilder
    {
        public GamingBuilder(string name) : base(name)
        {
            computer.CPU = "Intel i9";
            computer.Cooler = "Liquid";
            computer.Memory = "48 GB DDR5";
            computer.SSD = "2 TB";
            computer.Graphics = "ASRock Intel A750";
            computer.Price = 46000;
        } //ctor

        //public override void SetAttributes()
        //{
        //    computer.CPU = "Intel i9";
        //} //SetAttributes
    } //class GamingBuilder

    class BeastBuilder : AComputerBuilder, IComputerBuilder
    {
        public BeastBuilder(string name) : base(name)
        {
            computer.CPU = "AMD Ryzen7970X";
            computer.Cooler = "Liquid";
            computer.Memory = "Micron 128 GB DDR4";
            computer.SSD = "Micron 7450 Pro";
            computer.Graphics = "GeForce RTX4070Ti";
            computer.Price = 210000;
        } //ctor

        //public override void SetAttributes()
        //{
        //    computer.CPU = "AMD Ryzen7970X";
        //} //SetAttributes
    } //class BeastBuilder

} //namespace
