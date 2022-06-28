/*Задача 41. Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3  */

Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

for(int i = 0; i < length; i++)
{
    Console.Write($"Введите {i} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for(int i = 0; i < length; i++)
{
    if(numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел: {count}");


/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

// В ответе как я понял опечатка. Правильно (-0,5; -0,5)

double InputNumber(string name)
{
    System.Console.Write($"Введите  {name} = ");    
    double number = Convert.ToDouble(Console.ReadLine());
    return number;        
}

double b1 = InputNumber("b1");
double b2 = InputNumber("b2");
double k1 = InputNumber("k1");
double k2 = InputNumber("k2");

double x = (b1 - b2) / (k2 - k1);
double y = (k2 * b1 - k1 * b2) / (k2 - k1);
System.Console.WriteLine(y);
System.Console.WriteLine(x);