/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Input day");
int day = Convert.ToInt32(Console.ReadLine());
if((day > 0) && (day < 7))
{
    Console.WriteLine("weekday");
}
if((day >5) && (day < 8))
{
    Console.WriteLine("weekend");
}
if((day < 1) || (day > 7))
{
    Console.WriteLine("error");
}