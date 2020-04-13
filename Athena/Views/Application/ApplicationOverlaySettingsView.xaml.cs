using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Application
{
    public class ApplicationOverlaySettingsView : UserControl
    {
        public ApplicationOverlaySettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
