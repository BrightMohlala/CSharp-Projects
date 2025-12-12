
namespace CT8Q2_Strategy
{
    public class Entries<T> : IEntries<T>
    {
        //Properties
        public T[] entries { get; private set; }
        //public int Length => entries.Length;
        public int Length { get { return entries.Length; } }

        private IRemoveStrategy<T> remove_strategy;

        //Constructor
        public Entries(T[] entries)
        {
            this.entries = entries;
        } //ctor

        //Set remove strategy
        public void SetRemoveStrategy(IRemoveStrategy<T> remove_strategy)
        {
            this.remove_strategy = remove_strategy;
        } //SetRemoveStrategy

        public void RemoveAt(int index)
        {
            T[] tmp = entries;
            remove_strategy.RemoveAt(ref tmp, index);
            entries = tmp;
        } //RemoveAt

    } //class Entries
}
