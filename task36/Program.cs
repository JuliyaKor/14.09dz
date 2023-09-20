/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
FillArrayRandomNumber(number);
PrintArray(number);

int sumNumberIndex = 0;

for (int i = 0; i < number.Length; i += 2)
{
    sumNumberIndex += number[i];
}
Console.Write(sumNumberIndex);



void FillArrayRandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}