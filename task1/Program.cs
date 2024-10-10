//  Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void FillingArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент: ");
        str[i] = Console.ReadLine();
    }
}

void PrintArray(string[] str)
{   Console.Write("[");
    for (int i = 0; i < str.Length; i++)
    {
        if (i<str.Length-1)
        {
            Console.Write($"{str[i]}, ");
        }
        else
        {
            Console.Write(str[i]);
        }
    }
    Console.WriteLine("]");
}

string[] NewArrayLessThan3char(string[] str)
{   int size = 0;
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            size++;
        }
    }
    string[] newStrArray = new string[size];
    for (int j = 0; j < str.Length; j++)
    {
        if(str[j].Length <= 3)
        {
            newStrArray[count] = str[j];
            count++;
        }
    }
    return newStrArray;
}

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] strArray = new string[size];

FillingArray(strArray);
PrintArray(strArray);
string[] newArrResult = NewArrayLessThan3char(strArray);
PrintArray(newArrResult);