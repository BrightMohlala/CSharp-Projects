using Microsoft.VisualBasic.Devices;

namespace Computers
{
    public interface IComputerBuilder
    {
        //Property or method to return the object after it has been built
        Computer GetComputer();
    } //IComputerBuilder
}
