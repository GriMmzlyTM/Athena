using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Overlay
{
    public class CSOverlayView : UserControl
    {
        public CSOverlayView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
