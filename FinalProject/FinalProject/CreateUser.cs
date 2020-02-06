using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    private class CreateUser : IUserData
    {
        FillUser fillUser = new FillUser();
        Random rand = new Random();

        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public double UserAverageMark { get; set; }
        public string AccessLevel { get; set; }

        public void NewUser()
        {
            ID = fillUser.GetID();
            UserName = fillUser.GetName(rand.Next(0,99));
            UserLocation = fillUser.GetLocation(rand.Next(0, 23));

        }
    }
}
