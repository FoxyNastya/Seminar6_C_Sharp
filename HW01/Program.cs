/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите подряд несколько чисел");
int[] array = new int[dimension];
array =
*/
Console.Write("Введите любые числа, например: 1, -7, 567, 89, 223");
int[] arr = Array.ConvertAll<string,int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: {count}");

/*
Console.Write("Введите любые числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: {count}");



ATTANTION: *в задании "1, -7, 567, 89, 223-> 3" вот это некорректно. Там чисел больше нуля 4: 1, 567, 89, 223!!!*
*/