using System;
using System.IO;

namespace Lab__5_RegExp
{
    //Вариант №5 В программу подается текст из файла, в котором находится
    //текст, в котором нужно заменить числа, написанные прописью, на числа,
    //написанные цифрами.Например, текст “сто одиннадцать тысяч фиолетовых
    //оленей” будет записан как “111 000 фиолетовых оленей”. Считать, что числа
    //прописью написаны без ошибок в грамматике, падеже и т.д.
    class Program
    {
        static void Main(string[] args)
        {
            string line = @"..\..\..\text.txt";
            string text = TextReader.GoReadAndGetString(line);
            Console.WriteLine(text);
            Console.WriteLine("----------------------------------------------------------------");
        }
    }

    static class TextReader
    {
        // Читаем файл
        static public string GoReadAndGetString(string pathFile)
        {
            string resultline;
            try
            {
                using (StreamReader sr = new StreamReader(pathFile, System.Text.Encoding.Default))
                {

                    while ((resultline = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(resultline);
                    }
                }
                return resultline;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
