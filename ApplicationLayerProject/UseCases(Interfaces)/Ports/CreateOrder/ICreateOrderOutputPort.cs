namespace ApplicationLayerProject.Ports.UseCases.CreateOrder
{
    public interface ICreateOrderOutputPort
    {
        Task Handle(int orderId);
    }
}
