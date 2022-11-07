// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Clear();

bool IsTriangle (int a, int b, int c) //  bool логическое значение, которому может быть присвоен литерал true или false.
{
    return a + b > c && a + c > b && b + c > a;
}

int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}

if (IsTriangle(array[0], array[1], array[2]))
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}