using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Application
{
    public class ApplicationStatusView : UserControl
    {
        public ApplicationStatusView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
