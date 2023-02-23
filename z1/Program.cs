/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int [] CreateNewArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Введите {i+1} элемент массива: ");
        array [i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}

int CountPositiveNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine ("Введите количество элементов массива: ");
int user_size = Convert.ToInt32 (Console.ReadLine());

int [] newArray = CreateNewArray (user_size);
ShowArray (newArray);
Console.WriteLine ($"Количество положительных чисел равно {CountPositiveNumbers (newArray)}");