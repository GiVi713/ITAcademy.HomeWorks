using BlackMirror.Model;
using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for UserMenuView.xaml
    /// </summary>
    public partial class UserMenuView : UserControl
    {
        
        Raiting rait = new Raiting();
        UserData data = new UserData();
        ImageData image = new ImageData();
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
         
        private void Exit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            HideElements hide = new HideElements();
            hide.MainHide(Buttons);
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }

        private void GoSearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            HideElements hide = new HideElements();
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }

        private void GoProfile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }
    }
}
