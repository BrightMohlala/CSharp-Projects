
namespace CT8Q2_Strategy
{
    public interface IRemoveStrategy<T>
    {
        void RemoveAt(ref T[] array, int index);
    }
}
