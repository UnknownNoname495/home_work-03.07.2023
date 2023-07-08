// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0; 
int copyNumber = number; 

if (number != 0)
{
    while (number > 0)
    {
        result += number % 10;
        number /= 10; 
    }
}
else
{
    result++; 
}
Console.WriteLine($"Сумма цифр в числе {copyNumber} = {result}.");