namespace ApplicationLayerProject.Ports.UseCases.CreateOrder
{
    public interface ICreateOrderInputPort
    {
        Task Handle(OrderHeaderDto createOrderDto);
    }
}
