using Athena.Services;
using Athena.Services.Config;
using ReactiveUI;

namespace Athena.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {


        private ViewModelBase _content;
        private ApplicationStatusViewModel _applicationStatusViewModel { get; set; }
        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public MainWindowViewModel(
            ApplicationStatusViewModel applicationStatusViewModel)
        {
            _applicationStatusViewModel = applicationStatusViewModel;
            Content = _applicationStatusViewModel;
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
