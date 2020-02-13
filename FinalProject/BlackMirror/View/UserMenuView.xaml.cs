using BlackMirror.Model;
using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for UserMenuView.xaml
    /// </summary>
    public partial class UserMenuView : UserControl
    {
        static private List<string> _fill = AccountView.list;
        private List<object> _data = new List<object>();
        public UserMenuView()
        {
            InitializeComponent();
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("Select `Name`, `Location`,`BirthDate`,`Photo` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = _fill[0];
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
                _data.Add(reader["BirthDate"]);
            }
            userName.Text = (string)_data[0];
            userLocation.Text = (string)_data[1];
            userAge.Text = (string)_data[2];
            reader.Close();
            dataBase.closeConnection();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
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
