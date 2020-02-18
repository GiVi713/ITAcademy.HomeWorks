using BlackMirror.Model;
using BlackMirror.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BlackMirror.View
{
    public partial class UserMenuView : UserControl
    {
        Raiting rait = new Raiting();
        UserData data = new UserData();
        ImageData image = new ImageData();
        HideElements hide = new HideElements();

        public UserMenuView()
        {
            InitializeComponent();
            userName.Text = data.GetName();
            userLocation.Text = data.GetLocation();
            userAge.Text = data.GetAge();
            userStatus.Text = rait.AverageRaiting();
            ImageSourceConverter imgs = new ImageSourceConverter();
            userPhoto.SetValue(Image.SourceProperty, imgs.ConvertFromString(image.GetImage()));
        }
         

        //Buttons
        private void Exit_Click(object sender,RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            hide.MainHide(Buttons);
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
            AccountView.currentLogin = "";
        }

        private void GoSearch_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }

        private void GoProfile_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }
    }
}
