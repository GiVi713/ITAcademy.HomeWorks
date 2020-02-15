using System;
using System.Collections.Generic;
using System.Text;

namespace SushiBot
{
    internal class Menu
    {
        internal void Greeting()
        {
            Console.WriteLine("Мы рады вас приветствовать на нашем сайте. Чувствуйте себя как дома." +
                                                        "Пожалуйста выберите то, что вас интересует.\n ");
        }

        internal enum ListMenu
        {
            Суши = 1,
            О_нас,
            Доставка,
            Акции,
            Обратная_связь
        }
        CompanyInfo info = new CompanyInfo();
        c
        internal ListMenu FromChoice(ListMenu clientChoice) =>
        clientChoice switch
        {
           // ListMenu.Суши => 
            ListMenu.О_нас => info.Info(),
            //ListMenu.Доставка => 
            //ListMenu.Акции => 
            //ListMenu.Обратная_связь => 
        };
    }
}
