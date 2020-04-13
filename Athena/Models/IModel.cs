namespace Athena.Models
{
    public interface IModel
    {
        void Update<TModel>(TModel model) where TModel : class, IModel;
    }
}
