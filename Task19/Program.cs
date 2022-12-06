// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int FiveDigit = int.Parse(Console.ReadLine());

int LastNum = FiveDigit % 10;
int FirstNum = FiveDigit / 10000;
int SecondNum = (FiveDigit / 1000) % 10;
int BeforeLastNum = (FiveDigit / 10) % 10;

if (FiveDigit < 10000 | FiveDigit > 99999) Console.WriteLine("Вы ввели НЕ пятизначное число!"); 
else if (SecondNum == BeforeLastNum & FirstNum == LastNum) Console.WriteLine("палиндром");
     else Console.WriteLine("НЕ палиндром");