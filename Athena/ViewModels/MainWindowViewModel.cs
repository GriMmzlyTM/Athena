using Athena.ViewModels.Application;
using Athena.ViewModels.Overlay;
using ReactiveUI;

namespace Athena.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {


        private ViewModelBase _content;
        private ApplicationHomeViewModel _applicationHomeViewModel { get; }
        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public MainWindowViewModel(
            ApplicationHomeViewModel applicationHomeViewModel)
        {

            _applicationHomeViewModel = applicationHomeViewModel;
            Content = applicationHomeViewModel;
        }

        /*public void AddItem()
        {
            var viewModel = new AddItemViewModel();

            viewModel.Ok
                .Merge(viewModel.Cancel
                    .Select(_ => (TodoItem) null))
                .Take(1)
                .Subscribe(model =>
                {
                    if (model != null)
                    {
                        ListViewModel.Items.Add(model);
                    }

                    Content = ListViewModel;
                });
            Content = viewModel;
        }*/

    }
}
