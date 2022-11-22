/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int userNumberA = new int();
Console.WriteLine("Введи первое число");
userNumberA = Convert.ToInt32(Console.ReadLine());
int userNumberB = new int();
Console.WriteLine("Введи второе число");
userNumberB = Convert.ToInt32(Console.ReadLine());
int userNumberC = new int();
Console.WriteLine("Введи третье число");
userNumberC = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;

if (userNumberA > userNumberB) max = userNumberA;
if (userNumberB > userNumberC) max = userNumberB;
if (userNumberC > userNumberA) max = userNumberC;

    
Console.WriteLine("max = ");
Console.WriteLine(max);
