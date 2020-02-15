using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BlackMirror.Model
{
    public class ShowElements
    {
        public void MainShow(Button button)
        {
            button.Visibility = Visibility.Visible;
        }

        public void MainShow(TextBlock textBlock)
        {
            textBlock.Visibility = Visibility.Visible;
        }
        public void MainShow(TextBox textBox)
        {
            textBox.Visibility = Visibility.Visible;
        }
        public void MainShow(PasswordBox password)
        {
            password.Visibility = Visibility.Visible;
        }
        public void MainShow(StackPanel stackPanel)
        {
            stackPanel.Visibility = Visibility.Visible;
        }
        public void MainShow(ListBox listBox)
        {
            listBox.Visibility = Visibility.Visible;
        }
        public void MainShow(Image image)
        {
            image.Visibility = Visibility.Visible;
        }
    }
}
