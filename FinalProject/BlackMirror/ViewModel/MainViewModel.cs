using System.Windows.Input;
using BlackMirror.Commands;

namespace BlackMirror.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
		private BaseViewModel _selectedViewModel;

		public MainViewModel()
		{
			UpdateViewCommand = new UpdateViewCommand(this);
		}

		public BaseViewModel SelectedViewModel
		{
			get { return _selectedViewModel; }
			set 
			{
				_selectedViewModel = value;
				OnPropertyChanged(nameof(SelectedViewModel));
			}
		}

		public ICommand UpdateViewCommand { get; set; } 		
	}
}
