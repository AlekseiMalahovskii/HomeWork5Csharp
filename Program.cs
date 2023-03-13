// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] %2 == 0)
{
count++;
}
}
Console.WriteLine($"Количество четных чисел равно {count}");
*/




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] FillArrayWhithRandomNumber(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
*/

/* Сортировка по возрастанию
int[] ChangeArray(int[] arr, int size)
{
    int[] copyArr = new int[size];
    for (int i = 0; i < copyArr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    for (int i = 0; i < copyArr.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < copyArr.Length; j++)
        {
            if (copyArr[j] < copyArr[minPosition])
                minPosition = j;
        }
        int temp = copyArr[i];
        copyArr[i] = copyArr[minPosition];
        copyArr[minPosition] = temp;
    }
    return copyArr;
}
*/

/*
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение диапазона случайного числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение диапазона случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArrayWhithRandomNumber(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
*/

/*Отсортирован по возрастанию
int[] changeArray = ChangeArray(array, size);
System.Console.WriteLine($"Новый массив:    [{string.Join(", ", changeArray)}]");
*/


// Задача 38: Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

// NextDoudle и округление, где было расстояние между точками
// Можно округлить когда задаем рандом
// Есть методы макс и мин - можно использовать


double[] FillArrayWhithRandomNumber(int size)   //  (int size, int min, int max) 
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 3); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    }
    return arr;
}

/*
double[,] FillMatrix(int rows, int cols)
{
    double [,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return array;
}
*/

/*
double[,] a = new double[5, 10]; // 5 строк по 10 элементов
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,9:F2}", a[i, j]); // 0,9 расстояние между элементами
    }
    Console.WriteLine();
}
*/


Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите начальное значение диапазона случайного числа: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное значение диапазона случайного числа: ");
// int max = Convert.ToInt32(Console.ReadLine());

double[] array = FillArrayWhithRandomNumber(size);  //  (size, min, max)
Console.WriteLine($"[{string.Join(", ", array)}]");


double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }   
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine($"Максимальное значение:{max}");
Console.WriteLine($"Разность: {Math.Round(max - min, 2)}");

