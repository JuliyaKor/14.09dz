/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] doubles = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double differenceBetweenMaxAndMin(double[] doubles)
{
    double min = doubles[0];
    double max = 0;

    for (int i = 0; i < doubles.Length; i++)
    {
        if (doubles[i] > max)
            max = doubles[i];

        if (doubles[i] < min)
            min = doubles[i];
    }

    return max - min;
}

Console.WriteLine(differenceBetweenMaxAndMin(doubles));
