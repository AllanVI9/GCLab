namespace GCLab;

class LeakySubscriber
{
    private static readonly List<LeakySubscriber> _registry = new();
    private Publisher _publisher;

    public LeakySubscriber(Publisher publisher)
    {
        _publisher = publisher;
        _publisher.OnSomething += Handle;
        _registry.Add(this);
    }
    public void Dispose()
    {
        _publisher.OnSomething -= Handle;  // Remover o manipulador de evento
    }

    private void Handle() { /* noop */ }
}