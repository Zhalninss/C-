
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Введите первое число:  ");
string number = Console.ReadLine();
int num1 = int.Parse(number);
Console.Write("Введите второе число:  ");
number = Console.ReadLine();
int num2 = int.Parse(number);
if (num1 > num2)

{
    Console.WriteLine ("Первое число больше второго");
}
else
{
    Console.WriteLine ("Второе число больше первого");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите первое число:  ");
string number = Console.ReadLine();
int num1 = int.Parse(number);
Console.Write("Введите второе число:  ");
number = Console.ReadLine();
int num2 = int.Parse(number);
Console.Write("Введите третье число:  ");
number = Console.ReadLine();
int num3 = int.Parse(number);
int max = num1;
if (num1 < num2) max = num2;
if (num1 < num3) max = num3;
{
    Console.WriteLine ("Максимальное число: (max)");
}



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Введите первое число:  ");
string number = Console.ReadLine();
int num = int.Parse(number);
if (num % 2 == 0)

{
    Console.WriteLine ("Да. Число является четным");
}
else
{
    Console.WriteLine ("Нет.Число является нечетным");
}
*/



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.WriteLine($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i+", ");
}
*/