using BlackMirror.Model;
using BlackMirror.ViewModel;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void ButtonRegAccount(object sender, RoutedEventArgs e)
        {

            if( logbox.Text == "")
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }
            if (name.Text == "")
            {
                MessageBox.Show("Нужно заполнить Имя и Фамилию");
                return;
            }
            if (passbox.Text == "")
            {
                MessageBox.Show("Придумайте пароль");
                return;
            }
            if (locBox.Text == "")
            {
                MessageBox.Show("Укажите свой город");
                return;
            }

            if (CheckLogin())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Name`, `Login`, `Password`, `Age`, `Location`,`LoadPhoto`) VALUES (@name, @login, @pass, @age, @location, @photo)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = ageBox.Text;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = locBox.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Reg.Visibility = Visibility.Collapsed;
                MessageBox.Show("Аккаунт был создан");
            }

            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        }

        public Boolean CheckLogin()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = logbox.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин уже занят");
                return true;
            }
            else
                return false ;
        }

        private void RegReturn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            DataContext = new MainViewModel();
            //RegReturn.Visibility = Visibility.Collapsed;
        }
        private void Hide()
        {
            HideElements hide = new HideElements();
            hide.MainHide(login);
            hide.MainHide(logbox);
            hide.MainHide(passbox);
            hide.MainHide(password);
            hide.MainHide(name);
            hide.MainHide(nameBox);
            hide.MainHide(age);
            hide.MainHide(ageBox);
            hide.MainHide(location);
            hide.MainHide(locBox);
            hide.MainHide(Reg);
            hide.MainHide(RegReturn);
        }
    }
}
