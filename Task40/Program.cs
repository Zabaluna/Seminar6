// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] treangle = CreateRandomArray(3, 10, 101);
ShowArray(treangle);

{ 
    if (treangle[0]<treangle[1]+treangle[2] && treangle[1]<treangle[0]+treangle[2] && treangle[2]<treangle[1]+treangle[0])
    {
       Console.WriteLine(" Треугольник может быть");
    }
    else
    {
       Console.WriteLine(" Такого треугольника быть не может"); 
    }
}
