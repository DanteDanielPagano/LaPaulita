namespace ApplicationLayerProject.UseCases_Interfaces_.Presenter
{
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId { get; set; }
    }
}
