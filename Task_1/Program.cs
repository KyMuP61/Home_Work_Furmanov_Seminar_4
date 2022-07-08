/*

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/
Console.Clear();
int GetNumber(string messange)
{
    int result = 0;
    Console.WriteLine(messange);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы не ввели число. Введите число");
        }

    }
    return result;
}

int a = GetNumber("Введите число А:");
int b = GetNumber("Введите число B:");

int result = 1;
int count = 0;

while (count < b)
{
    result = result * a;
    count++;

}


Console.WriteLine(result);