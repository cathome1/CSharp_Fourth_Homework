// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А :");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B :");
int B = Convert.ToInt32(Console.ReadLine());
int GetPowerOfNumber(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
Console.WriteLine($"Число {A} в степени {B} = {GetPowerOfNumber(A,B)}");