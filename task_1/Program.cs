// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
string? stringNumberA = Console.ReadLine();

Console.Write("Введите число B: ");
string? stringNumberB = Console.ReadLine();

int numA;
int numB;

bool isNumberA = int.TryParse(stringNumberA, out numA);
bool isNumberB = int.TryParse(stringNumberB, out numB);

int result = 1; 

if (isNumberA && isNumberB)
{ 
    for (int i = 1; i <= numB; i++)
    {
        result = Convert.ToInt32(Math.Pow(numA, i));  
    }
    Console.WriteLine($"{stringNumberA} в степени {stringNumberB} = {result} ");
}
else
{
Console.WriteLine($"В значениях {stringNumberA} и {stringNumberB} находятся символы");
}
