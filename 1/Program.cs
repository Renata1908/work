﻿//Написать программу, которая из имеюегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

string[] arr = { "Hello", "World", "qq", "a" };
Console.WriteLine(string.Join(", ", arr));

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        Console.Write(arr[i] + "  ");
    }
}
