using BlackMirror.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlackMirror.Model
{
    public class Raiting
    {
        string log = Search.Log;
        UserData data = new UserData();
        DataBase dataBase = new DataBase();
        string _log = AccountView.currentLogin;
        

        public void SetRaiting(int point)
        {
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Raiting` = @rai,`PointsCount` = @point WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log;
            command.Parameters.Add("@rai", MySqlDbType.VarChar).Value = data.GetRaiting(log) + point;
            command.Parameters.Add("@point", MySqlDbType.Int32).Value = data.GetPoints(log) + 1;
            command.ExecuteNonQuery();
            MessageBox.Show($"Ваша оценка пользователю {log}:  {point}");
            dataBase.closeConnection();
        }

        public string AverageRaiting()
        {
            decimal sum = 0;
            decimal count = 0;
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("Select `Raiting`,`PointsCount` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sum = (int)reader[0];
                count = (int)reader[1];
            }
            reader.Close();
            dataBase.closeConnection();
            if (count != 0)
            {
                decimal result = sum / count;
                string output = result.ToString();
                return output;
            }
            else
                return sum.ToString();
        }

        public string AverageRaiting(string log)
        {
            int sum = 0;
            int count = 0;
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("Select `Raiting`,`PointsCount` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sum = (int)reader[0];
                count = (int)reader[1];
            }
            reader.Close();
            dataBase.closeConnection();
            if (count != 0)
            {
                decimal result = sum / count;
                string output = result.ToString();
                return output;
            }
            else
                return sum.ToString();
        }


        public bool CheckAvailable()
        {
            string temp="";
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("Select `Access` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;
            command.Parameters.Add("@access", MySqlDbType.VarChar).Value = log + " ";
            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = (string)reader[0];
            }
            if (temp.Contains(log))
            {
                MessageBox.Show("Вы уже голосовали эа этого пользователя");
                reader.Close();
                dataBase.closeConnection();
                return false;
            }
            else if (_log == log)
            {
                MessageBox.Show("За себя голосовать нельзя проказник");
                reader.Close();
                dataBase.closeConnection();
                UpdateAccess();
                return false;
            }
            else
            {
                reader.Close();
                dataBase.closeConnection();
                UpdateAccess();
                return true;
            }
        }


        private void UpdateAccess()
        {
            dataBase.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `access` = @access WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = _log;
            command.Parameters.Add("@access", MySqlDbType.VarChar).Value = log + " ";
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
    }   
}
