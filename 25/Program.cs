//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите числа А и В");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int i=1;
int res = A;
int Pow(int A, int B, int i, int res)
{
while (i<B)
    {
    res=res*A;
    i++;
    }
    return res;
}
res = Pow(A, B, i, res);
Console.WriteLine($"{res} ");