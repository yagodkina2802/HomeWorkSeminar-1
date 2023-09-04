// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int lastDigit = number%10;
if(lastDigit == 0 ||lastDigit == 2 || lastDigit == 4 || lastDigit == 6 || lastDigit == 8)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}