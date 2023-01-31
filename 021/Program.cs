// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = index("x", "A");
int y1 = index("y", "A");
int z1 = index("z", "A");
int x2 = index("x", "B");
int y2 = index("y", "B");
int z2 = index("z", "B");

int index(string coordinate, string point)
{
    Console.Write($"Введите координату {coordinate} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine($"Длина отрезка: {Math.Round(distance , 2)}");