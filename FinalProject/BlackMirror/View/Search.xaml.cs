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
        public List<object> _logins = new List<object>();
        public static string Log;
        public Search()
        {
            InitializeComponent();
            HideButtons();
        }
        private void SearchButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("Select `Name`,`Login` FROM `users` WHERE `Name` LIKE @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = searchBox.Text;

            dataBase.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                _names.Add(reader["Name"]);
                _logins.Add(reader["Login"]);
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
        private void SearchResult1_Click(object sender, RoutedEventArgs e)
        {
            if(_logins[0] != null)
            {
                DataContext = new MainViewModel();
                Log = _logins[0].ToString();
                Hide();
            }
        }
        private void SearchResult2_Click(object sender, RoutedEventArgs e)
        {
            if (_logins[1] != null)
            {
                DataContext = new MainViewModel();
                Log= _logins[1].ToString();
                Hide();
            }
        }
        private void SearchResult3_Click(object sender, RoutedEventArgs e)
        {
            if (_logins[2] != null)
            {
                DataContext = new MainViewModel();
                Log = _logins[2].ToString();
                Hide();
            }
        }
        private void SearchResult4_Click(object sender, RoutedEventArgs e)
        {
            if (_logins[3] != null)
            {
                DataContext = new MainViewModel();
                Log = _logins[3].ToString();
                Hide();
            }
        }
        private void SearchResult5_Click(object sender, RoutedEventArgs e)
        {
            if (_logins[4] != null)
            {
                DataContext = new MainViewModel();
                Log = _logins[4].ToString();
                Hide();
            }
        }
        private void ShowButtons()
        {
            var count = _logins.Count;
            switch (count)
            {
                case 1:
                    SearchResult1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    SearchResult1.Visibility = Visibility.Visible;
                    SearchResult2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    SearchResult1.Visibility = Visibility.Visible;
                    SearchResult2.Visibility = Visibility.Visible;
                    SearchResult3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    SearchResult1.Visibility = Visibility.Visible;
                    SearchResult2.Visibility = Visibility.Visible;
                    SearchResult3.Visibility = Visibility.Visible;
                    SearchResult4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    SearchResult1.Visibility = Visibility.Visible;
                    SearchResult2.Visibility = Visibility.Visible;
                    SearchResult3.Visibility = Visibility.Visible;
                    SearchResult4.Visibility = Visibility.Visible;
                    SearchResult5.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void HideButtons()
        {
            SearchResult1.Visibility = Visibility.Collapsed;
            SearchResult2.Visibility = Visibility.Collapsed;
            SearchResult3.Visibility = Visibility.Collapsed;
            SearchResult4.Visibility = Visibility.Collapsed;
            SearchResult5.Visibility = Visibility.Collapsed;
        }
        private void Hide()
        {
                HideElements hide = new HideElements();
                hide.MainHide(searchBox);
                hide.MainHide(SearchButton);
                hide.MainHide(SearchResult1);
                hide.MainHide(SearchResult2);
                hide.MainHide(SearchResult3);
                hide.MainHide(SearchResult4);
                hide.MainHide(SearchResult5);
                hide.MainHide(Results);
        }
    }
}
