using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Application
{
    public class ApplicationSettingsView : UserControl
    {
        public ApplicationSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
