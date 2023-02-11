//Задайте массив заполненныйслучайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine("Чётных чисел = " + count);
