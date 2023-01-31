/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
/*
//инициализируем массив
int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;  
    }

    return result;
}
int[] startArray = InitArray(10);
PrintArray(startArray);

int[] resultArray = ReverseArray(startArray);
PrintArray(resultArray);

int[] arrStart = Enumerable.Range(1,10).ToArray();
PrintArray(arrStart);

int[] arr = Enumerable.Range(1,10).Reverse().ToArray();
PrintArray(arr);

Array.Reverse(arr);

arr.Reverse();
*/


/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());


if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
  Console.WriteLine("Треугольник существует!");  
}
else
    Console.WriteLine("Треугольник не может существовать!");
*/
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное
число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
Console.WriteLine("Введите число для перевода в двоичную систему: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_str = "";
while (number > 0)
{
    number_str = number_str + number % 2;
    number = number / 2;

}

Console.WriteLine(new string(number_str.Reverse().ToArray()));
*/

/*
Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

int [] Fibonachi (int number)
{
    int [] arr = new int [number];
    if (number == 1)
        return new int [1] {0};
    if (number == 2)
        return new int [2] {0, 1};
    arr [0] = 0;
    arr [1] = 1;
    for (int i = 2; i < number; i++)
    {
        arr [i] = arr[i-1] + arr[i-2];
    }    
    return arr;
}

Console.WriteLine("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = Fibonachi(number);
Console.WriteLine(string.Join(", ", array));
*/


/*
Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного копирования.
*/
int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

int [] CopyArray (int [] startArr)
{
    int [] arr = new int [startArr.Length];
    for (int i = 0; i < startArr.Length; i++)
    {
        arr [i] = startArr [i];
    }
    return arr;
}

int dimension = 5;
int [] startArr = InitArray(dimension);
Console.WriteLine(string.Join(",", startArr));
int [] arr = CopyArray(startArr);
Console.WriteLine("[{0}]",string.Join(",", arr));
/*
*/
/*
*/
/*
*/
/*
*/