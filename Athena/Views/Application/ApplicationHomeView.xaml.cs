using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Application
{
    public class ApplicationHomeView : UserControl
    {
        public ApplicationHomeView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
