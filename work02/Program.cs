// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты точки А "); 
int x1;
x1 = Convert.ToInt32(Console.ReadLine());
int y1;
y1 = Convert.ToInt32(Console.ReadLine());
int z1;
z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B ");
int x2;
x2 = Convert.ToInt32(Console.ReadLine());
int y2;
y2 = Convert.ToInt32(Console.ReadLine());
int z2;
z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine(("{0:0.00}"), result);
