namespace GCLab;

// ==================================
// 1) Vazamento por evento (publisher)
// ==================================
class Publisher
{
    public event Action OnSomething;

    public void Raise() => OnSomething?.Invoke();

    public void RemoveHandler(Action handler)
    {
        OnSomething -= handler;
    }
}
