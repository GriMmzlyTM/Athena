using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views
{
    public class FindAccountView : UserControl
    {
        public FindAccountView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
