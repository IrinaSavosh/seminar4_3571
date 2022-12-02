// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!
Console.Write("Введите число, которое возведем в степень: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положтельное число , которое будет степенью числа: ");
int deg = Convert.ToInt32(Console.ReadLine());
int prod = 1;
for(int i = 1; i <= deg; i++)
{
   prod = prod * num;
   Console.WriteLine(prod);
}
Console.Write($"Число {num} в степени {deg} = {prod}");