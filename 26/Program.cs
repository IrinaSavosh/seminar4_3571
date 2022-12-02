// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= num)
{
   num = num / 10;
   i++;

}
Console.WriteLine($"В числе цифр {i}");
