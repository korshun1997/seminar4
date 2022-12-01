// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int f = 0;
int s = 0;
int ss = 0;
int Sum(int N, int s)
{
while (N % 10 != 0 )
    {
    f = N % 10;
    s = s+f;
    N = N / 10;
    }
    return s;
}
ss = Sum(N, s);
Console.WriteLine($" {ss} ");