// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите 5-ти значное число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num % 100;
// int num2 = num1 % 10;
// int num3 = num1 / 10;
// int num4 = num / 1000;
// int num5 = num4 % 10;
// int num6 = num4 / 10;

// if(num >= 10000 && num <= 99999){
//     if(num2 == num6 && num3 == num5) Console.WriteLine($"Число {num} является палиндромом");
//     else Console.WriteLine($"Число {num} не является палиндромом");
// } else Console.WriteLine("Вы ввели не 5-ти значное число");

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите x первой точки ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y первой точки ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z первой точки ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x второй точки ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y второй точки ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z второй точки ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.Write(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите любое число ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= num; i++){
//     Console.Write($"{i*i*i} ");
// }