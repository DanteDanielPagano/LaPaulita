namespace ApplicationLayerProject.UseCases_Interfaces_.Repositories
{
    public interface ISalesCommandRepository : IUnitOfWork
    {
        Task CreateOrder(CreateOrder order);
    }
}
