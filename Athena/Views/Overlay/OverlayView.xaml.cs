using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Overlay
{
    public class OverlayView : UserControl
    {
        public OverlayView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
