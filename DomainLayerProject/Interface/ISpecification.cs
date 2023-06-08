namespace DomainLayerProject.Interface
{
    public interface ISpecification<T> where T : class
    {
        string ErrorMessage { get; } //solo lectura
        bool IsSatisfiedBy(T entity);

    }
}
