using BlackMirror.ViewModel;
using System.Windows.Controls;
using System.Windows;
using BlackMirror.Model;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void RegMenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (RegMenuButton.IsVisible == true)
            {
                RegMenuButton.Visibility = Visibility.Collapsed;
                EnterMenuButton.Visibility = Visibility.Collapsed;
            }
            else
                RegMenuButton.Visibility = Visibility.Visible;
        }

        private void EnterMenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (EnterMenuButton.IsVisible == true)
            {
                EnterMenuButton.Visibility = Visibility.Collapsed;
                RegMenuButton.Visibility = Visibility.Collapsed;
            }
            else
                EnterMenuButton.Visibility = Visibility.Visible;
        }

        private void LogReturn_Click(object sender, RoutedEventArgs e)
        {
            if (EnterMenuButton.IsVisible == true && RegMenuButton.IsVisible == true)
            {
                EnterMenuButton.Visibility = Visibility.Visible;
                RegMenuButton.Visibility = Visibility.Visible;
            }
        }
    }
}
