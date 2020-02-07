using BlackMirror.View;
using BlackMirror.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlackMirror.Commands
{
    public class UpdateViewCommand : ICommand
    { 
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Registration")
            {
                viewModel.SelectedViewModel = new RegistrationViewModel();
            }
            else if (parameter.ToString() == "Login")
            {
                viewModel.SelectedViewModel = new AccountViewModel();
            }
            else if (parameter.ToString() == "EnterAcc")
            {
                viewModel.SelectedViewModel = new UserMenuViewModel();
            }
        }
    }
}
