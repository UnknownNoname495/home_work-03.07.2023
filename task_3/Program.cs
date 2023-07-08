// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)

Console.Write("Начальное значение для диапазона случайного числа массива: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Конечное значение для диапазона случайного числа массива: ");
int maxNum = Convert.ToInt32(Console.ReadLine());


int size = 8;
int [] array = new int[size]; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minNum, maxNum + 1); 
}
Console.WriteLine($"[{string.Join("; ", array)}]"); 