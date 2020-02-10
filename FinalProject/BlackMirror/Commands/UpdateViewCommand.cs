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
            var view = parameter.ToString();
            switch(view)
            {
                case "Registration":
                    viewModel.SelectedViewModel = new RegistrationViewModel();
                    break;
                case "Login":
                    viewModel.SelectedViewModel = new AccountViewModel();
                    break;
                case "EnterAcc":
                    viewModel.SelectedViewModel = new UserMenuViewModel();
                    break;
            }
            //if (str == "Registration")
            //{
            //    viewModel.SelectedViewModel = new RegistrationViewModel();
            //}
            //else if (str == "Login")
            //{
            //    viewModel.SelectedViewModel = new AccountViewModel();
            //}
            //else if (str == "EnterAcc")
            //{
            //    viewModel.SelectedViewModel = new UserMenuViewModel();
            //}
        }
    }
}
