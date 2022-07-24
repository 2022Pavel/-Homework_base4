//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.Console.WriteLine("введите число");

Console.WriteLine("введите число");
int Number = int.Parse(Console.ReadLine());
int sum = 0;
while (Number > 0)
{
int num = Number % 10;
Number = Number / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна ->" + sum);