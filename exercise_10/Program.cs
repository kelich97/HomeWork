/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Input number from 100 till 999");
int number = Convert.ToInt32(Console.ReadLine());
if((number > 99) && (number < 1000))
{
    Console.WriteLine(number % 100 / 10);
}


