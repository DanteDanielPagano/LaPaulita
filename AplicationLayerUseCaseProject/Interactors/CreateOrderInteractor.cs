using ApplicationLayerProject.Aggregates;
using ApplicationLayerProject.DTOs.CreateOrder;
using ApplicationLayerProject.Ports.UseCases.CreateOrder;
using ApplicationLayerProject.UseCases_Interfaces_.Repositories;

namespace AplicationLayerUseCaseProject.Interactors
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        // Realizamo la inyección de dependencia en base a las interfaces,
        // despreocupandonos de su implementación.
        // En el constructor de la clase es donde pasaremos los objetos implementados
        // por las clases que implementas desde las interfaces.

        readonly ICreateOrderOutputPort _outputPort;
        readonly ISalesCommandRepository _repository;
        #region "Constructor"
        public CreateOrderInteractor(ICreateOrderOutputPort outputPort, ISalesCommandRepository repository)
        {
            _outputPort = outputPort;
            _repository = repository;
        }
        #endregion

        public async Task Handle(OrderHeaderDto createOrderDto)
        {
            //// Aqui realizamos el mapeo de las propiedades del DTO con la Entidad.
            CreateOrder createOrder = CreateOrder.From(createOrderDto);


            // Invocamos de manera asíncrona a los métodos
            // CreateOrder y SaveChange del repositorio.
            // Finalmente al método Handle del puerto de salida
            // retornando el Id del nuevo registro insertado en la DB.

            await _repository.CreateOrder(createOrder);
            await _repository.SaveChange();
            await _outputPort.Handle(createOrder.Id);
        }
    }
}
