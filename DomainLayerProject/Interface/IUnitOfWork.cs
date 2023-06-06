namespace DomainLayerProject.Interface
{
    public interface IUnitOfWork
    {
        Task SaveChange();
    }
}
