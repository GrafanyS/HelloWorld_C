void FillArray(int[] collecion)

{
    int length = collecion.Length;
    int index = 0;
    while (index <length)
    {
        collecion[index] = new Random().Next(1, 10);
        index++;
    };
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
    
}

int Inex0f(int[] collecion, int find)
{
    int count = collecion.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collecion[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos =Inex0f(array, 4);
Console.WriteLine(pos);
