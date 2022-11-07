// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string NewMassive(int a)
{
    string arr = ""; // открывающее и закрывающее значение обозначается двойными кавычками
    while (a < 0)
    {
        arr += (a % 2).ToString();
        a /= 2;
    }
    return arr;
}

int MassiveRev(string arr)
{
    string result = "";

    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[arr.Length - 1 - i];
    }
    return int.Parse(result);
}

// int[] RemZeros(int[] arrayA)
// {
//     int IndZero = -1;

//     for (int i = 0; i < arrayA.Length; i++)
//     {
//         if (arrayA[i] != 0)
//         {
//            IndZero = i; 
//            break;
//         }
//     }
//     int[] arrayB = new int[arrayA.Length - IndZero];

//     for (int i = 0; i < arrayA.Length; i++)
//     {
//         arrayB[i] = arrayA[IndZero + 1];
//     }
//     return arrayB;
// }

Console.Clear();
Console.WriteLine("Введитеде число: ");
int num = int.Parse(Console.ReadLine()!);

string array = NewMassive(num);
int num1 = MassiveRev(array);
Console.Write($"В двоичном виде: {num}");
