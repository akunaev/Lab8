//  Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
using System.IO;


string path = Directory.GetCurrentDirectory();
path = Directory.GetParent(path).FullName;
path = Directory.GetParent(path).FullName;
path = Directory.GetParent(path).FullName;

getdirs(path);

Console.ReadKey();



static void getdirs(string path)
{
    if (Directory.Exists(path))
    {
        foreach (string dir in Directory.GetDirectories(path))
        {
            Console.WriteLine(dir);
            getdirs(dir);
        }
        foreach (string file in Directory.GetFiles(path))
        { Console.WriteLine(file); }
    }
}