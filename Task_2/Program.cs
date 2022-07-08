/*

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

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
            Console.WriteLine("Введите корректное число: ");
        }
    }
    return result;
}




int result = GetNumber("Введите число");

int sum = 0;
int i = result;
while (result > 1)
{
    i = result % 10;
    result = result / 10;
    sum = sum + i;


}
Console.WriteLine(sum);
