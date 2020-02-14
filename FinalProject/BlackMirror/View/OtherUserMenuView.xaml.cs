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
    public partial class OtherUserMenuView : UserControl, Iinterface1
    {
        private List<object> _data = new List<object>();
        public string Log { get; set; }
        public OtherUserMenuView()
        {
            InitializeComponent();
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("Select `Name`, `Location`,`Age`,`Photo` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = Log;
            dataBase.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] data = (byte[])reader[3];
                using (MemoryStream ms = new MemoryStream(data))
                {
                    var imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.StreamSource = ms;
                    imageSource.CacheOption = BitmapCacheOption.OnLoad;
                    imageSource.EndInit();
                    userPhoto.Source = imageSource;
                }
                _data.Add(reader["Name"]);
                _data.Add(reader["Location"]);
                _data.Add(reader["Age"]);
            }
            userName.Text = (string)_data[0];
            userLocation.Text = (string)_data[1];
            userAge.Text = (string)_data[2];
            reader.Close();
            dataBase.closeConnection();
        }
       
        private void GoProfile_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        private void GoSearch_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            HideElements hide = new HideElements();
            Search search = new Search();
            search.ShowButtons();
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            HideElements hide = new HideElements();
            hide.MainHide(Buttons);
            hide.MainHide(List);
            hide.MainHide(UserData);
            hide.MainHide(userPhoto);
        }
    }
}
