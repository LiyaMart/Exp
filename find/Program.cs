// Имеется одноименный массив array из n элементов, требуется найти элемент массива, равный find

void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count=coll.Length;
    int position=0;
    while (position<count)
    {
        Console.Write($"{coll[position]} ");
                position++;
    }
}

int [] array = new int[10]; 

FillArray(array);
PrintArray(array);

int IndexFind(int[] collect, int find)
{
    int len=collect.Length;
    int ind=0;
    int posit = -1;
        while (ind<len)
    {
        if (collect[ind]==find) posit=ind;
        ind++;   
    }
    return posit;
}

int pos = IndexFind(array,6);
Console.WriteLine($"; {pos}");