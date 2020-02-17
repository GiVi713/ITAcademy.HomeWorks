using BlackMirror.View;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.Windows;

namespace BlackMirror.Model
{
    public class Opinion
    {
        string _log = AccountView.currentLogin;
        DataBase dataBase = new DataBase();
        string fText = "";
        string temp = "";

        public void CreateOpinion(string text,string log)
        {
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("Select `Name` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = (string)reader[0];
            }
            fText = $"{temp} о вас: \n {text} \n* \n* ";
            string path = @"C:\Users\Виктор\Desktop\ITAcademy.HomeWorks\ITAcademy.HomeWorks\ITAcademy.HomeWorks\FinalProject\BlackMirror\Opinions";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            dataBase.closeConnection();
            if (CheckAvailable(_log, log))
            {
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                using (FileStream stream = new FileStream($"{path}\\{log}.txt", FileMode.OpenOrCreate))
                {
                    byte[] array = Encoding.Default.GetBytes(fText);
                    stream.Write(array, 0, array.Length);
                    MessageBox.Show("Ваше мнение добавлено");
                }
            }
        }

        public void UpdateAvailable(string log)
        {
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `OAccess` = @oaccess WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;
            command.Parameters.Add("@oaccess", MySqlDbType.VarChar).Value = log + " ";
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public bool CheckAvailable(string curLog, string log)
        {
            
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("Select `OAccess` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;
            command.Parameters.Add("@oaccess", MySqlDbType.VarChar).Value = log + " ";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = (string)reader[0];
            }
            if (temp.Contains(log))
            {
                MessageBox.Show("Вы уже оставили отзыв на этого пользователя");
                reader.Close();
                dataBase.closeConnection();
                return false;
            }
            else if (_log == log)
            {
                MessageBox.Show("Писать отзыв о себе. Я такого не допущу.");
                reader.Close();
                dataBase.closeConnection();
                UpdateAvailable(log);
                return false;
            }
            else
            {
                reader.Close();
                dataBase.closeConnection();
                UpdateAvailable(log);
                return true;
            }
        }
    }
}
