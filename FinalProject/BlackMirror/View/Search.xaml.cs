using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using System.Windows;
using BlackMirror.Model;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        private List<object> _names = new List<object>();
        public static List<object> logins = new List<object>();
        public static string Log;
        public Search()
        {
            InitializeComponent();
            SearchResult1.Visibility = Visibility.Collapsed;
            SearchResult2.Visibility = Visibility.Collapsed;
        }

        private void SearchButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("Select `Name`,`Login` FROM `users` WHERE `Name` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = searchBox.Text;

            dataBase.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                _names.Add(reader["Name"]);
                logins.Add(reader["Login"]);
            }
            if (_names.Count > 0)
            {
                Results.ItemsSource = _names;
                ShowButtons();
            }
            else
                MessageBox.Show("Пользователя с таким именем не найдено");
            
            reader.Close();
            dataBase.closeConnection();
        }

        public void ShowButtons()
        {
            if (logins.Count == 1)
            {
                SearchResult1.Visibility = Visibility.Visible;
            }
            else if (logins.Count >= 2)
            {
                SearchResult1.Visibility = Visibility.Visible;
                SearchResult2.Visibility = Visibility.Visible;
            }
        }
        private void SearchResult1_Click(object sender, RoutedEventArgs e)
        {
            if(logins[0] != null)
            {
                DataContext = new MainViewModel();
                Log = logins[0].ToString();
                Hide();
            }
        }

        private void SearchResult2_Click(object sender, RoutedEventArgs e)
        {
            if (logins[1] != null)
            {
                DataContext = new MainViewModel();
                Log= logins[1].ToString();
                Hide();
            }
        }

        private void Hide()
        {
            HideElements hide = new HideElements();
            hide.MainHide(searchBox);
            hide.MainHide(SearchButton);
            hide.MainHide(SearchResult1);
            hide.MainHide(SearchResult2);
            hide.MainHide(Results);
        }
    }
}
