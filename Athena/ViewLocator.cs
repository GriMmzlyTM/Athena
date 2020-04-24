using System;
using System.Collections.Generic;
using System.Drawing;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Athena.ViewModels;

namespace Athena
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;

        private Dictionary<string, IControl> registeredViews = new Dictionary<string, IControl>();

        public IControl Build(object data)
        {
            var name = data.GetType().FullName.Replace("ViewModel", "View");
            if (registeredViews.ContainsKey(name))
            {
                return (Control) registeredViews[name];
            }
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type);
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public void RegisterView(string viewModelName, IControl viewInstance)
        {
            registeredViews.Add(viewModelName, viewInstance);
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}