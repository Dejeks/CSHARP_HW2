/*Задача 15: 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

int numb = Convert.ToInt16(Console.ReadLine());
if (numb > 0 & numb <= 7)
{
    if (numb == 6 || numb == 7) 
    {
        Console.WriteLine("Этот день выходной!");
    }
    else
    Console.WriteLine("Этот день не выходной =( Иди работать!");
}
else
Console.WriteLine("Это не день недели 0_о");