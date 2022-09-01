/*Задача 63: Задайте значение N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.*/


using static System.Console;
Clear();

int num = int.Parse(ReadLine());

WriteLine($"{GetStringNumbers(num)}");

string GetStringNumbers(int n)
{
    if(n == 1) return  "1";
    return GetStringNumbers(n-1)+" "+$" {n}";
}