/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Еnter a three-digit number ");
int number = int.Parse(Console.ReadLine());

if(number < 100 || number >= 1000)
Console.WriteLine("Please, enter a three-digit number ");
else 
{
    int second_digit = number / 10 % 10;
    Console.WriteLine("Second digit of nuumber = " + second_digit);
}

