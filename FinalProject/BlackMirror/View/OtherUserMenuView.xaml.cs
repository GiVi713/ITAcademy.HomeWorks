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
        private List<object> _data = new List<object>();
        string log = Search.Log; DataBase dataBase = new DataBase();
        public OtherUserMenuView()
        {
            InitializeComponent();
           
            MySqlCommand command = new MySqlCommand("Select `Name`, `Location`,`Age`,`Photo`,`PointsCount`,`Raiting` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = log;
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
                _data.Add(reader["PointsCount"]);
                _data.Add(reader["Raiting"]);
            }
            userName.Text = (string)_data[0];
            userLocation.Text = (string)_data[1];
            userAge.Text = (string)_data[2];
            dataBase.closeConnection();
            reader.Close();
        }
        private void SetOpinion_Click(object sender, RoutedEventArgs e)
        {
            //if(Raiting.Text.Length > 0 && Raiting.Text == "1")
            //dataBase.openConnection();
            //MySqlCommand co = new MySqlCommand("UPDATE `users` SET (`PointsCount` = @count,`Raiting` = @rait WHERE `Login` = @uL", dataBase.getConnection());
            //co.Parameters.Add("@rait", MySqlDbType.Double).Value = Raiting.Text;
            //co.Parameters.Add("@uL", MySqlDbType.Double).Value = log;
            //co.Parameters.Add("@count", MySqlDbType.Double).Value = +1;
            //co.ExecuteNonQuery();
            //dataBase.closeConnection();
        }

        private void SetRaiting_Click(object sender, RoutedEventArgs e)
        {
            dataBase.openConnection();
            MySqlCommand co = new MySqlCommand("UPDATE `users` SET `PointsCount` = @count,`Raiting` = @rait WHERE `Login` = @uL", dataBase.getConnection());
            co.Parameters.Add("@rait", MySqlDbType.VarChar).Value = _data[4] + Raiting.Text;
            co.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log;
            co.Parameters.Add("@count", MySqlDbType.VarChar).Value = (int)_data[3] + 1;
            co.ExecuteNonQuery();
            dataBase.closeConnection();
        }
    }
}
