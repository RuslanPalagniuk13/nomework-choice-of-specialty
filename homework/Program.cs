//Задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// Примеры ввода [2, hello, sun, 33, world] -> [2, sun, 33]

using System;
using static System.Console;

Clear();

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int n) 
{
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }
    
    return count;
}

string[] AskArray() 
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
;