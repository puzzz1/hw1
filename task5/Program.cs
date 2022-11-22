/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

int userNumberA = new int();
Console.WriteLine("Введи число");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumberA %2 == 0); 
     