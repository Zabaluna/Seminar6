// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string ToBin(int num)
{
    string result = "";
    string temp = "";
    while(num > 0)
    {
    temp = Convert.ToString(num%2);
    result = temp + result;
    num = num/2; 
    }
    return result;
}

Console.WriteLine(ToBin(2));


