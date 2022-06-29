/*
// Вид 1
void Method1()
{
    Console.WriteLine('Автор ...');
}
//вызов
Method1();
*/

/*
// Вид 2
void Method2(string msg)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
    }
}

*/

// Мкеод 3

/*
int Method3(string msg)
{
    return DateTime.Now.Year;
}
//вызов
int year = Method3();
// Console.WriteLine(year);


*/



//Метод4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);
Console.WriteLine();

// Циклы со щетчиком: for

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

*/

//======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на большие "К",
// а большие "С" заменить на маленькие "с".

// Ясна ли задача?

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие пруского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "q w e r t y"
//             0 1 2 3 4 5
//  s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
*/



int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}



void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPositions = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPositions]) minPositions = j;  // Меняя сортировку масива. < от минимального; > от максимального;
        }
        int temporary = array[i];
        array[i] = array[minPositions];
        array[minPositions] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();

PrintArray(arr);
