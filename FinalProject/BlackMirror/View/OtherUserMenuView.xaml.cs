using BlackMirror.Model;
using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for OtherUserMenuView.xaml
    /// </summary>
    public partial class OtherUserMenuView : UserControl
    {
        string log = Search.Log;
        Raiting rait = new Raiting();
        UserData data = new UserData();

        public OtherUserMenuView()
        {
            InitializeComponent();
            userName.Text = data.GetName(log);
            userLocation.Text = data.GetLocation(log);
            userAge.Text = data.GetAge(log);
            userStatus.Text = rait.AverageRaiting(log);
        }
        private void SetOpinion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetRaiting_Click(object sender, RoutedEventArgs e)
        {
            /// Тут нужно добавить проверку !!!!
            int temp = Int32.Parse(Raiting.Text);
            if (rait.CheckAvailable())
                rait.SetRaiting(temp);
           
        }

    }
}
