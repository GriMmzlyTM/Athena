using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Athena.Views.Modules.FFXIV
{
    public class FinalFantasyXIVSettingsView : UserControl
    {
        public FinalFantasyXIVSettingsView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
