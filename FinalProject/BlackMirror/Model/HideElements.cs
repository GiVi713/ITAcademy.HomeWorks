using System.Windows;
using System.Windows.Controls;

namespace BlackMirror.Model
{
    public class HideElements
    {
        public void MainHide(Button button)
        {
            button.Visibility = Visibility.Collapsed;
        }

        public void MainHide(TextBlock textBlock)
        {
            textBlock.Visibility = Visibility.Collapsed;
        }
        public void MainHide(TextBox textBox)
        {
            textBox.Visibility = Visibility.Collapsed;
        }
        public void MainHide(PasswordBox password)
        {
            password.Visibility = Visibility.Collapsed;
        }
    }
}
