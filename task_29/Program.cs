// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];
void FillArray(int[] a)
{
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next();
    }
}
void PrintArray(int[] ar)
{
    System.Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
       if (i < 7) Console.Write($"{ar[i]}, ");
       else Console.WriteLine($"{ar[i]}]");
    }
}
FillArray(array);
PrintArray(array);