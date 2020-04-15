namespace Athena.Models
{
    /// <summary>
    /// Base interface for models capable of updating
    /// </summary>
    public interface IModel
    {
        void Update<TModel>(TModel model) where TModel : class, IModel;
    }
}
