using BlackMirror.Model;
using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace BlackMirror.View
{
    /// <summary>
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        public static List<string> list = new List<string>();
        public AccountView()
        {
            InitializeComponent();
        }
        
        private void ButtonEnterAccount(object sender, RoutedEventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Password;
            list.Add(loginUser);

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
            command.Parameters.Add("@ul",MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {   
                Hide();
                MessageBox.Show("Вы успешно авторизованы.");
                DataContext = new MainViewModel();
            }

            else
                MessageBox.Show("Вы ввели неверные данные либо такого пользователя не существует.");
        }
        private void Hide()
        {
            HideElements hide = new HideElements();
            hide.MainHide(Enter);
            hide.MainHide(pass);
            hide.MainHide(loginField);
            hide.MainHide(passField);
            hide.MainHide(login);
            hide.MainHide(LogReturn);
        }

        private void LogReturn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            DataContext = new MainViewModel();
            LogReturn.Visibility = Visibility.Collapsed;
        }
    }
}
