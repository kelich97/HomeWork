/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = new Random().Next(10,99999);
Console.WriteLine(" number " + number);
void Num(int a)
{
    if ((a >= 10) && (a <= 99))
    {
        Console.WriteLine("Нет третей цифры");
    }
    if((a >= 100) && (a <= 999))
    {
        Console.WriteLine(a % 10);
    }
    if((a > 999) && (a < 10000))
    {
        Console.WriteLine((a % 100) / 10);
    }
    if((a >= 10000) && (a <= 99999))
    {
        Console.WriteLine((a % 1000) / 100);
    } 
}
Num(number);

