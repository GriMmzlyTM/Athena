﻿using Athena.Models;
using ReactiveUI;
using System.Reactive;

namespace Athena.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        /*
        private string _description;
        public ReactiveCommand<Unit, TodoItem> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(
                () => new TodoItem {Description = Description}, okEnabled);

            Cancel = ReactiveCommand.Create(() => { });

        }
        */

    }
}
