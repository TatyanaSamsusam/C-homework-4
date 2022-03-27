/*
Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random() .Next(-100, 100);
        index++;
    }
}

void PintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
       Console.Write(col[position] + " ");
       position++;
    }
}


int[] array = new int[10];

FillArray(array);
PintArray(array);
