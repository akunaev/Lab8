//Программно создайте текстовый файл и запишите в него 10 случайных чисел.
//Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
using System.IO;

string filename = "randomNumbers.txt";

using (StreamWriter sw = new StreamWriter(filename))
{
    Random random = new Random();
    for (int i = 0; i < 10; i++)
    {
        sw.WriteLine(random.Next());
    }
}

using (StreamReader sr = new StreamReader(filename))
{
    int sum = 0;
    for(int i = 0;i < 10; i++)
    {
        sum+=Convert.ToInt32(sr.ReadLine());
    }
    Console.WriteLine(sum);
}
Console.ReadKey();

