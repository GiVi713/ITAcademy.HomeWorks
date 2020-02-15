using BlackMirror.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMirror.Model
{
    public class SetRaiting
    {
        string log = Search.Log;
        DataBase db = new DataBase();

        public void AddNum(int point)
        {
            db.openConnection();
            MySqlCommand co = new MySqlCommand("UPDATE `users` SET `Raiting` = @rai WHERE `Login` = @uL", db.getConnection());
            co.Parameters.Add("@rai", MySqlDbType.Double).Value = point;
            co.Parameters.Add("@uL", MySqlDbType.Double).Value = log;
            co.ExecuteNonQuery();
            db.closeConnection();
        }
    }   
}
