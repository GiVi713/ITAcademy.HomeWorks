using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("srever = localhost; port=3306;username=root;password=root;database = users");
    }
}
