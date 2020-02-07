using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalProject
{
    class FillUserData
    {
        public static List<string> names = new List<string> { };
        public static List<string> cities = new List<string> { };


        public void FillNames()
        {
            string path = @"C:\Users\Виктор\Desktop\ITAcademy.HomeWorks\ITAcademy.HomeWorks\ITAcademy.HomeWorks\FinalProject\FinalProject\UserNames.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
        }

        public void FillLocation()
        {
            string path = @"C:\Users\Виктор\Desktop\ITAcademy.HomeWorks\ITAcademy.HomeWorks\ITAcademy.HomeWorks\FinalProject\FinalProject\Cities.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    cities.Add(line);
                }
            }
        }
    }
}
