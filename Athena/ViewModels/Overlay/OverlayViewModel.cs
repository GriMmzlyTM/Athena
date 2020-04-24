using Avalonia.Markup.Xaml;
using ReactiveUI;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using Avalonia.Controls;

namespace Athena.ViewModels.Overlay
{
    public class OverlayViewModel : ViewModelBase
    {

        private ViewModelBase _content;

        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public OverlayViewModel()
        {

        }

    }
}
