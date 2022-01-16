//Вручную подготовьте текстовый файл с фрагментом текста.
//Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.

using System.IO;


string path = Directory.GetCurrentDirectory();
path = Directory.GetParent(path).FullName;
path = Directory.GetParent(path).FullName;
path = Directory.GetParent(path).FullName;

path += "/New Text Document.txt";

using (StreamReader sr = new StreamReader(path))
{
    int chars = 0, strings = 0, words = 0;
    string str;
 
    while ((str=sr.ReadLine())!=null)
    {
        strings++;
        chars+=str.Length;
        string[] strWords = str.Split();
        foreach(string word in strWords) { words++; }
    }

    Console.WriteLine("Символов: {0}\nСтрок: {1}\nСлов: {2}", chars,strings,words);
}
Console.ReadKey();