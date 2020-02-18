using BlackMirror.Model;
using BlackMirror.ViewModel;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace BlackMirror.View
{
    public partial class HomeView : UserControl
    {
        DataBase db = new DataBase();
        CheckText checkText = new CheckText();
        ImageData load = new ImageData();
        
        public HomeView()
        {
            InitializeComponent();
        }


        //Buttons
        private void ButtonRegAccount(object sender, RoutedEventArgs e)
        {
            
            if (checkText.CheckLogin(logbox.Text))
                return;

            if (checkText.CheckPass(passbox.Password))
                return;

            if (checkText.CheckName(nameBox.Text))
                return;

            if (checkText.CheckAge(ageBox.Text))
                return;

            if (checkText.CheckLocation(locBox.Text))
                return;
        
            if (CheckLogin())
                return;
            
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Name`, `Login`, `Password`, `Age`, `Location`,`Photo`) VALUES (@name, @login, @pass, @age, @location, @photo)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passbox.Password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = ageBox.Text;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = locBox.Text;
            command.Parameters.Add("@photo", MySqlDbType.VarChar).Value = load.GetImage();
            CheckText text = new CheckText();

            string path = @"C:\Users\Виктор\Desktop\ITAcademy.HomeWorks\ITAcademy.HomeWorks\ITAcademy.HomeWorks\FinalProject\BlackMirror\Opinions";
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Reg.Visibility = Visibility.Collapsed;
                MessageBox.Show("Аккаунт был создан");
                AccountView.currentLogin = logbox.Text;
                FileStream stream = new FileStream($"{path}\\{logbox.Text}.txt", FileMode.Create);
                Hide();
                DataContext = new MainViewModel();
            }

            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        }


        private void RegReturn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            DataContext = new MainViewModel();
        }


        private void UploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            load.LoadImage();
        }



        //Methods
        public Boolean CheckLogin()
        {
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
                return false;
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
            hide.MainHide(UploadPhoto);
        }
    }
}
