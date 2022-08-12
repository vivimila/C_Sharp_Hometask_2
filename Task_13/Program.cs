// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая ТРЕТЬЮ ЦИФРУ заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

int thirdNumber(int number)
{
    if (number > 99)
    {
        while (number > 1000 || number < -1000) // не работает &&!!!
            {
                number = number /10; // цикл
            }
        return number %10;    
    }
    else return -1;
}

// if (anyNumber < 99)
// {

// }

int result = thirdNumber(anyNumber);

if (result != -1) // Оператор неравенства != возвращает значение true. пример! a=5,b=6. 5!=6
{
    Console.WriteLine($"Из заданного числа третья цифра -> {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



