// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.WriteLine("введите число A");
//int A= int.Parse(Console.ReadLine());
//Console.WriteLine("введите число B");
//int B= int.Parse(Console.ReadLine());
//int deg = 1;
//for (int i=1; i<=B; i++)
//{
//    deg= deg*A;
//}
//Console.WriteLine(deg);

//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Enter number: ");
int Num = int.Parse(Console.ReadLine());

Console.WriteLine($"Int Sum = {IntSum(Num)}");
int IntSum(int Num)
{
    int sum=0;
    for ( ;Num > 0; )
    //while ( Num > 0 )
    {
        sum += Num % 10;
        Num /= 10;
    }
    return sum;
}


//Console.WriteLine("Enter 8-th numbers:");

//int[] arr = new int [8];
//for (int i = 0; i < arr.Length; i++)  
//    {
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//    }
//Console.Write (string.Join(", ", arr));


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//int[] arr = new int[8];
//for (int i = 0; i < 8; i++)
//{
//    var rnd = new Random();
//    arr[i] = rnd.Next(-1000,1000);
//    Console.Write (arr[i]+ ",");
//}

//Решение 2

//Console.WriteLine("Enter 8-th numbers:");

//int[] arr = new int [8];
//for (int i = 0; i < arr.Length; i++)  
//    {
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//    }
//Console.Write (string.Join(", ", arr));

//Решение 3
//Console.Clear();

//int[] array = GetRandomArray(8, 0, 100);
//Console.WriteLine($"[{String.Join(",", array)}]");


//int[] GetRandomArray(int size, int minValue, int maxValue)
//{
//    int[] result = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        result[i] = new Random().Next(minValue, maxValue+1);
//    }
//
//    return result;
//}