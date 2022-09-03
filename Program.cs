
//__________________________Домашняя работа семинар 5_________________________

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

Console.Write(" Количество четных чисел в массиве: ");
Chisl(sammas);
Console.Write($" равно: {kolvo}");
Console.WriteLine(" ");

*/

//__________________________________________________

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int zumma (int[] array)

{
    int zum = 0;

    for (int h = 0; h < array.Length; h++)
    {
      
        int ostatok = h % 2;

        if (ostatok > 0)
        {
        zum = zum + array[h] ;
        }
    }

    return zum;
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


Console.Write("Пожалуйста, введите размер массива: ");

int razm = Convert.ToInt32(Console.ReadLine());

int[] newMassiv = Generator(-99, 99, razm);

int summ = zumma(newMassiv);


Console.Write(" Сумма элементов, стоящих на нечетных позициях в массиве: ");
Chisl(newMassiv);
Console.Write($" Равна: {summ} ");
Console.WriteLine("Конец программы.");

*/

//____________________________________________________________________

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/* Решение внутри

double[] Generator (int minValue, int maxValue, int size )
{
   
    double[] arriva = new double [size];
    for (int i = 0; i < size; i++ )
    {
        Random rand = new Random();

        double dobav = rand.NextDouble(); // число от 0 до 1

        arriva[i] = (new Random().Next(minValue, maxValue+1)) + dobav;
    }
   
     return arriva;
}

double minElem (double[] array)

{
    double minZum = array[0];

    for (int h = 0; h < array.Length; h++)
    {
      
        if (array[h] < minZum)
        {
        minZum = array[h] ;
        }
    }

    return minZum;
}

double maxElem (double[] array)

{
    double maxZum = array[0];

    for (int h = 0; h < array.Length; h++)
    {
      
        if (array[h] > maxZum)
        {
        maxZum = array[h] ;
        }
    }

    return maxZum;
}

void Chisl (double[] arriva)
{
    Console.Write("[ ");
    for (int f = 0; f < arriva.Length; f++)
     {
            Console.Write(arriva[f]);
            Console.Write(", ");
     }
     Console.Write("\b\b ");
     Console.Write("]");
}

Console.Write("Пожалуйста введите размер массива: ");
int razzm = Convert.ToInt32(Console.ReadLine());

double [] massivVesh = Generator(-99, 99, razzm);

double minNum =  minElem(massivVesh);

double maxNum = maxElem(massivVesh);

double raznica = maxNum - minNum;

Console.WriteLine($" Разница между максимальным и минимальным элементом в массиве: ");
Chisl(massivVesh);
Console.Write($" равна: {raznica} ");
Console.WriteLine(" ");
Console.WriteLine("Конец программы.");

*/