﻿using Athena.Services;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Athena.ViewModels;
using Athena.Views;

namespace Athena
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();

            if (!(ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)) return;
            
            var db = new Database();

            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(db),
            };

        }
    }
}
