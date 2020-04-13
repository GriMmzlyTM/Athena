namespace Athena.Models
{
    public class Model : IModel
    {
        public void Update<TModel>(TModel model) 
            where TModel : class, IModel
        {
            var newObjectProperties = model.GetType().GetProperties();
            var oldObjectProperties = GetType().GetProperties();

            foreach (var newProperty in newObjectProperties)
            {
                foreach (var oldProperty in oldObjectProperties)
                {
                    if (newProperty.Name != oldProperty.Name ||
                        newProperty.PropertyType != oldProperty.PropertyType) continue;

                    oldProperty.SetValue(this, newProperty.GetValue(model));
                    break;
                }
            }
        }

    }
}
