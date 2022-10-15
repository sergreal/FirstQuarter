

// Задача.
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] arrayIn = new string[9] {"one", "two", "three", "five", "six", "seven", "12", "123", "1234"};
string[] arrayOut = new string[arrayIn.Length];

void CalcArray(string[] arrayIn, string[] arrayOut)
{
    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[count] = arrayIn[i]; 
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

CalcArray(arrayIn, arrayOut);
PrintArray(arrayOut);

