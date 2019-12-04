using System;
using System.IO;

namespace Photo

    /*
     Укажем местонахождения нашего файла 
     Вызовем метод с помощью которого будем читать наш тхт.
     Создадим массив строк
     Создадим массив байтов 
     Далее зададим цикл,с помощью которого будет пересматривать весь наш двоичный код 
     и переводить его в изоюражение
     Укажем куда и под каким именем сохранять файл

     */
   
{
    class Program
    {
        static void Main(string[] args)
        {   
            StreamReader textReader = new StreamReader(@"C:\Users\Виктор\Desktop\image.txt", true);
             string textReaderResult = textReader.ReadToEnd();
             string[] arrayOfTextResult = textReaderResult.Split(' ');
             byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for
                (int i = 0; i < arrayOfTextResult.Length - 1;i++) {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;

            }
            textReader.Dispose();
            File.WriteAllBytes(@"C:\Users\Виктор\Desktop\image.png", imageBytes);
                
        }
    }
}
