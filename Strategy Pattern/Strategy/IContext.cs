
namespace CT8Q2_Strategy
{
    public interface IEntries<T>
    {
        int Length { get; }
        void SetRemoveStrategy(IRemoveStrategy<T> remove_strategy);
        void RemoveAt(int index);
    } //IEntries
}
