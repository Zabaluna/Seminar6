// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] nums = CreateRandomArray(10, 0, 51);
int[] newnums = new int[10];

Console.Write($"Старый массив: [ {String.Join(",", nums)} ]");

for (int i = 0; i < nums.Length; i++)
{
    newnums[i] = nums[i];
}
Console.WriteLine();
Console.WriteLine($"Новый массив: [ {String.Join(",", newnums)} ]");