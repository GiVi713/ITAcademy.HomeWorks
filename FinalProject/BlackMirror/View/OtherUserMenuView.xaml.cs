using BlackMirror.Model;
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
        }
        private void SetOpinion_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
