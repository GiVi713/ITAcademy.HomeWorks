using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
        }

        private void ButtonEnterAccount(object sender, RoutedEventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Password;

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
                MessageBox.Show("Вы успешно авторизованы.");
                DataContext = new MainViewModel();
            }

            else
                MessageBox.Show("Вы ввели неверные данные либо такого пользователя не существует.");
        }
    }
}
