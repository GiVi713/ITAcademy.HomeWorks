using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;

namespace BlackMirror.View
{
    public partial class OtherUserServiceView : UserControl
    {
        string log = Search.Log;
        public OtherUserServiceView()
        {
            InitializeComponent();
            FillListBox(log);
        }
        public void FillListBox(string log)
        {
            string path = @"C:\Users\Виктор\Desktop\ITAcademy.HomeWorks\ITAcademy.HomeWorks\ITAcademy.HomeWorks\FinalProject\BlackMirror\Opinions";
            List<string> MyList = new List<string>();
            using (var streamReader = File.OpenText($"{path}\\{log}.txt"))
            {
                var s = string.Empty;
                while ((s = streamReader.ReadLine()) != null)
                    MyList.Add(s);
            }
            OpinList.ItemsSource = MyList;
        }
    }
}
