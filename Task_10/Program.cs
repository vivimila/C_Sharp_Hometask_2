// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000); // все трехзначные числа
int Vivi (int num) // переменную можно называть как угодно?
{
    int firstNumber = num / 10; //находим первые  2 цифры, делением на целое
    int nov = firstNumber % 10;
    return nov;
}
int result = Vivi(number);
Console.WriteLine($"Из терхзначного {number} -> вторая цифра {result}");