/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int userNumberA = new int();
Console.WriteLine("Введи первое число");
userNumberA = Convert.ToInt32(Console.ReadLine());
int userNumberB = new int();
Console.WriteLine("Введи второе число");
userNumberB = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;
Console.WriteLine("max = ");
if (userNumberA > userNumberB) 
{   Console.WriteLine(max);
}
else
{  
    Console.WriteLine(userNumberB);
}
