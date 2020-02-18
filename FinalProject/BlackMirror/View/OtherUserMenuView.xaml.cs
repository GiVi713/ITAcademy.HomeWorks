using BlackMirror.Model;
using BlackMirror.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BlackMirror.View
{
    public partial class OtherUserMenuView : UserControl
    {
        string log = Search.Log;
        Raiting rait = new Raiting();
        UserData data = new UserData();
        CheckText Text = new CheckText();
        ImageData image = new ImageData();

        public OtherUserMenuView()
        {
            InitializeComponent();
            userName.Text = data.GetName(log);
            userLocation.Text = data.GetLocation(log);
            userAge.Text = data.GetAge(log);
            userStatus.Text = rait.AverageRaiting(log);
            ImageSourceConverter imgs = new ImageSourceConverter();
            userPhoto.SetValue(Image.SourceProperty, imgs.ConvertFromString(image.GetImage(log)));
            LogReturn.Visibility = Visibility.Collapsed;
        }
        private void SetOpinion_Click(object sender, RoutedEventArgs e)
        {
            Opinion opinion = new Opinion();
            opinion.CreateOpinion(Opinion.Text,log);
        }

        private void SetRaiting_Click(object sender, RoutedEventArgs e)
        {
            if (Text.CheckRait(Raiting.Text))
            {
                int temp = Int32.Parse(Raiting.Text);
                if (rait.CheckAvailable())
                rait.SetRaiting(temp);
            }
        }

        private void OtherOpinion_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            HideElements hide = new HideElements();
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
            hide.MainHide(Opinion);
            hide.MainHide(Raiting);
            hide.MainHide(SetRaiting);
            hide.MainHide(SetOpinion);
            hide.MainHide(OtherOpinion);
            LogReturn.Visibility = Visibility.Visible;
        }

        private void LogReturn_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            LogReturn.Visibility = Visibility.Collapsed;
        }
    }
}
