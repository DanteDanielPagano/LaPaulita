namespace ApplicationLayerProject.UseCases_Interfaces_.Controllers
{
    public interface ICreateOrderController
    {
        Task<int> CreateOrder(OrderHeaderDto order);
    }
}
