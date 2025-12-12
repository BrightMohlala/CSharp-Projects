public interface IObserver
{
    bool isOn { get; } //Status
    void Update(bool isOn);
}