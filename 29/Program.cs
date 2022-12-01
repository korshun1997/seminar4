// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] nums = new int[8];
for (int k = 0; k < nums.Length; k++)
{
    Console.WriteLine("Введите элемент массива");
    nums[k]=Convert.ToInt32(Console.ReadLine());
}
for (int k = 0; k < nums.Length; k++)
{
    Console.WriteLine($"{nums[k]}");
}
