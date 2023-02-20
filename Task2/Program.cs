/* Задача 13:
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. */

int result = -1;
int number = 0;

while(true)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
}
