//  Задача 41: Пользователь вводит с клавиатуры M чисел.
//   Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите ваши числа через пробел: ");
int[] numbers = GetArrayFromString(Console.ReadLine());

Console.WriteLine($"Числа больше нуля: {ResultArray(numbers)}");

int[] GetArrayFromString(string stringArray) // берем из предыдущей задачи метод:
{                                             //преобразование строк в числа в массиве
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int ResultArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numbers[i] > 0) result++;
    }
    return result;
}
