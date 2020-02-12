using BlackMirror.Model;
using BlackMirror.View;
using BlackMirror.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace BlackMirror
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HideElements hide = new HideElements();
            hide.MainHide(MainButton);
            hide.MainHide(MainText);
        }
    }
}
