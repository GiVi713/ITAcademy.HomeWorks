﻿using BlackMirror.View;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlackMirror.Model
{
    public class ImageData
    {
        string _data = "";
        DataBase dataBase = new DataBase();
        string curLog = AccountView.currentLogin;
        
        public void LoadImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            _data = dialog.FileName;
            CheckImage(_data);
        }

        public string CheckImage(string data)
        {
            if(data.Length != 0)
            {
                MessageBox.Show("Фотография добавлена");
                return data;
            }
            else
            {
                MessageBox.Show("Вы не добавили фотографии и мы добавили свою");
                data = "Pictures\\ProfileImage.png";
                return data;
            }
        }

        public string GetImage()
        {
            MySqlCommand command = new MySqlCommand("Select `Photo` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = curLog;

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

        public string GetImage(string log)
        {
            MySqlCommand command = new MySqlCommand("Select `Photo` FROM `users` WHERE `Login` = @uL", dataBase.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = log;

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
    }
}