// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 черновик

int[] Generator (int minValue, int maxValue, int size )
{
   
    int[] arriva = new int [size];
    for (int i = 0; i < size; i++ )
    {
        arriva[i] = new Random().Next(minValue, maxValue+1);
    }
   
     return arriva;
}

int [] NewArrakis (int[] array)

{
    int [] arrakis = new int [array.Length];
    int count = array.Length-1;
    for (int h = 0; h < array.Length; h++)
    {
        if (count != h)
        {
        arrakis[h] = array[h]*array[count]  ;
        }
        else
        {
            arrakis[h] = array[h];
        }
        count--;
    }

    return arrakis;
}

void Chisl (int[] arriva)
{
    Console.Write("[ ");
    for (int f = 0; f < arriva.Length; f++)
     {
            Console.Write(arriva[f]);
            Console.Write(", ");
     }
     Console.Write("\b\b ");
     Console.Write(" ]");
}

*/


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/* Решение внутри

int[] Generator (int minValue, int maxValue, int size )
{
   
    int[] arriva = new int [size];
    for (int i = 0; i < size; i++ )
    {
        arriva[i] = new Random().Next(minValue, maxValue+1);
    }
   
     return arriva;
}


int  summaPol (int[] array)

{
    int sumsum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int ost = (array[i]) % 2;
        if ( ost == 0)
        {
            sumsum = sumsum+1;
        }
    }

    return sumsum;
}


void Chisl (int[] arriva)
{
    Console.Write("[ ");
    for (int f = 0; f < arriva.Length; f++)
     {
            Console.Write(arriva[f]);
            Console.Write(", ");
     }
     Console.Write("\b\b ");
     Console.Write(" ]");
}


Console.Write("Пожалуйста введите размер массива: ");

int razmer = Convert.ToInt32(Console.ReadLine());

int [] sammas = Generator(100, 1000, razmer);

int kolvo = summaPol(sammas);

Console.Write(" Сумма четных чисел в массиве: ");
Chisl(sammas);
Console.Write($" равна: {kolvo}");
Console.WriteLine(" ");

*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
