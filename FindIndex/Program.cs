// Написать программу, которая из имеющегося массива строк формирует
//  массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
//  с клавиатуры, либо задать на старте выполнения алгоритма. 


System.Console.WriteLine("Введите строки через пробел: ");
string UsrStr = Console.ReadLine();
string[] splt = UsrStr.Split(' ');
string[] array2 = new string[splt.Length];

void SecondArrayWithIF(string[] splt1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < splt.Length; i++)
    {
    if(splt[i].Length <= 3)
        {
        array2[count] = splt[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(splt, array2);
PrintArray(array2);