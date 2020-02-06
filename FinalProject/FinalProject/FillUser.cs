using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalProject
{
  private  class FillUser
    {
        FillUserData fill = new FillUserData();

        private static List<string> _names = FillUserData.names;
        private static List<string> _cities = FillUserData.cities;
        static int id = 0000;
        public int GetID()
        {
            id++;
            return id;
        }

        public string GetName(int num)
        {
            fill.FillNames();
            var name = _names[num];
            return name;
        }

        public string GetLocation(int num)
        {
            fill.FillLocation();
            var city = _cities[num];
            return city;
        }
    }
}
