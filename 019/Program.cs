// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int num = Number / 1000;
int rewnumb = Number % 100;
rewnumb = rewnumb % 10 * 10 + rewnumb / 10;

if (num == rewnumb)
Console.WriteLine("ДА");
else 
Console.WriteLine("Нет");









