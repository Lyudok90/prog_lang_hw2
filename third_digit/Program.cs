/* Напишите программу, которая выводит третью цифру заданного
 числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Еnter a number ");
int number = int.Parse(Console.ReadLine());

if(number < 100) 
Console.WriteLine("Third digit doesn't exist ");  

while(number > 999) 
{
    number /= 10;
        
}

int third_digit = number % 10;
Console.WriteLine("Third digit of number = " + third_digit);
 