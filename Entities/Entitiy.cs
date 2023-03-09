public abstract class Entity
{
    public List<Component> components = new();
    public Guid Id = Guid.NewGuid();
    public T? GetComponent<T>() where T:Component
    {
        return components.OfType<T>().FirstOrDefault();
    }
}