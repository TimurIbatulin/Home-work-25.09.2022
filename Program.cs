// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.Write("Введите пятизначное число: ");
// int X = Convert.ToInt32(Console.ReadLine());
// int c = 10;
// int z=10000;
// if (X/z==X%c)
// {
//     z = z / 10;
//     c = c * 10;
//     if ((X/z)%10==(X%c)/10)
//     {
//         Console.WriteLine ($"{X} является полиндромным числом");
//     }
   
// }
//  else
//     {
//         Console.WriteLine ($"{X} неявляется полиндромным числом");
//     }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите первую координату x -  ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("y - ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("z");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату x1 -  ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1 - ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// double l = Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1)+(z-z1)*(z-z1));
// Console.Write($"Расстояние между первой и второй точкой состовляет {l}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N-");
int N = Convert.ToInt32(Console.ReadLine());
for (int i= 0; i <= N; i++)
{
    int z = i*i*i;
    Console.WriteLine($"{i} в кубе равно {z}");
}