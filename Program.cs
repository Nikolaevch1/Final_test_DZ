// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] originalArray = {"Hello", "2", "world", ":-)"};
string[] newArray = GetShortStrings(originalArray);

foreach (string str in newArray)
{
    System.Console.Write(str + ", ");
}

static string[] GetShortStrings(string[] originalArray)
{
    int count = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <=3)
        {
            count++;
        }
    }


    string[]resultArray = new string[count];
    int index = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            resultArray[index] = originalArray[i];
            index++;
        }
    }
    return resultArray;
}
