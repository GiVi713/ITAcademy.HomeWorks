using BlackMirror.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMirror.Model
{

    public class UserData
    {
        string _log = AccountView.currentLogin;
        DataBase dataBase = new DataBase();
        private string _data = "";
        private int _rait = 0;

        public string GetName()
        {
            MySqlCommand command = new MySqlCommand("Select `Name` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = _log;
            
            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public string GetAge()
        {
            MySqlCommand command = new MySqlCommand("Select `Age` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = _log;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public string GetLocation()
        {
            MySqlCommand command = new MySqlCommand("Select `Location` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = _log;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public int GetRaiting()
        {
            MySqlCommand command = new MySqlCommand("Select `Raiting` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = _log;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _rait = (int)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _rait;
        }


        // Методы с перегрузкой для получения информации по Логину
        public string GetName(string temp)
        {
            MySqlCommand command = new MySqlCommand("Select `Name` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = temp;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public string GetAge(string temp)
        {
            MySqlCommand command = new MySqlCommand("Select `Age` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = temp;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public string GetLocation(string temp)
        {
            MySqlCommand command = new MySqlCommand("Select `Location` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = temp;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _data = (string)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _data;
        }

        public int GetRaiting(string temp)
        {
            MySqlCommand command = new MySqlCommand("Select `Raiting` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = temp;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _rait = (int)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _rait;
        }

        public int GetPoints(string temp)
        {
            MySqlCommand command = new MySqlCommand("Select `PointsCount` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = temp;

            dataBase.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                _rait = (int)reader[0];
            }
            reader.Close();
            dataBase.closeConnection();
            return _rait;
        }
    }
}

