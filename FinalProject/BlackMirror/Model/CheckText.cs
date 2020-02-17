using System.Text.RegularExpressions;
using System.Windows;

namespace BlackMirror.Model
{
    public class CheckText
    {
        public bool CheckLogin(string text)
        {
            string pattern = @"\w";
            if (Regex.IsMatch(text, pattern) && text.Length > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Логин пуст или вы ввели недопустимые символы в нем. Используйте буквы от А до Я и A до Z");
                return true;
            }
        }

        public bool CheckName (string text)
        {
            string pattern = @"\w";
            if (Regex.IsMatch(text, pattern) && text.Length > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Поле 'Имя' пустое или вы ввели недопустимые символы в Имени. Используйте буквы от А до Я и A до Z");
                return true;
            }
        }

        public bool CheckAge(string text)
        {
            string pattern = @"\d";
            if (Regex.IsMatch(text, pattern) && text != "")
            {
                return false;
            }
            else
            {
                MessageBox.Show("Возраст пуст или вы ввели недопустимые символы в Имени. Используйте цифра от 0 до 9");
                return true;
            }
        }

        public bool CheckLocation(string text)
        {
            string pattern = @"\w";
            if (Regex.IsMatch(text, pattern) && text != "")
            {
                return false;
            }
            else
            {
                MessageBox.Show("Местоположение не заполнено или вы ввели недопустимые символы в Имени. Используйте буквы от А до Я и A до Z");
                return true;
            }
        }

        public bool CheckPass(string text)
        {
            string pattern = @"\w";
            if (Regex.IsMatch(text, pattern) && text != "")
            {
                return false;
            }
            else
            {
                MessageBox.Show("Пароль не заполнен или вы ввели недопустимые символы в Имени. Используйте цифра от 0 до 9");
                return true;
            }
        }
    }
}
