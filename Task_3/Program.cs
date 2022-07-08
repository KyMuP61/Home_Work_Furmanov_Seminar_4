/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

*/


// как понял задачу - массив должен быть рандомный.
// а метод вывода нашел в гугле

Console.Clear();

void GetArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next();
    }
}


int[] array = new int[8];
GetArray(array);
Console.WriteLine("[{0}]", string.Join(", ", array)); ;