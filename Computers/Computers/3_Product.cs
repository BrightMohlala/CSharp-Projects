namespace Computers
{
    public class Computer
    {
        public string Name { get; set; }
        public string CPU { get; set; }
        public string Cooler { get; set; }
        public string Memory { get; set; }
        public string SSD { get; set; }
        public string Graphics { get; set; }
        public decimal Price { get; set; }

        public Computer()
        {

        } //ctor

        public override string ToString()
        {
            string s = "Name     : " + Name + "\n"
                     + "CPU      : " + CPU + "\n"
                     + "Cooler   : " + Cooler + "\n"
                     + "Memory   : " + Memory + "\n"
                     + "SSD      : " + SSD + "\n"
                     + "Graphics : " + Graphics + "\n"
                     + "Price    : " + Price.ToString("C");
            return s;
        } //ToString

    } //class Computer
}
