// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ("Введите число");
string number = Console.ReadLine();
int length = number.Length;
double result = 0;
for (int i = 0; i < length; i++)
{
    result = result + number[i] - '0';
}
Console.Write("Сумма цифр числа ");
Console.Write(result);