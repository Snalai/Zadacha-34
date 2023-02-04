// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int funk(int a)
{
    int[] num = new int[a];
    int chot = 0;
    for (int i = 0; i < num.Length; i++)
    {
        int ran = new Random().Next(100, 1000);
        num[i] = ran;
        if (num[i] % 2 == 0)
        {
            chot++;
        }

        Console.WriteLine(num[i]);
    }
    return chot;
}
Console.Write("Выберите ширину массива: ");
int w = Convert.ToInt32(Console.ReadLine());
int chot = funk(w);
Console.WriteLine($"{chot} чётных чисел.");