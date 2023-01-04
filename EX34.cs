//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static Library;
using static System.Console;

{
    int[] ar = CreateArray(4);
    Fill(ar);
    Console.WriteLine(Print(ar));
    int result = 0;

for (int i = 0; i < ar.Length; i++)
{
    if (ar[i] % 2 == 0)
    result = result + 1;
}
     Console.WriteLine(result);
}
