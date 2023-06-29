// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, что, "
//            + "ежели бы вас послали вместо нашего милого Винценгероде, "
//            + "вы бы взяли приступом согласия прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

//string Replace(string t, char oldValue, char newValue)
//{
//    string res = String.Empty;
//    int length = t.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if (t[i] == oldValue) res = res + $"{newValue}";
//        else res = res + $"{t[i]}";
//    }
//    return res;
//}
//string newText = Replace(text, ' ', '-' );
//string newText1 = Replace(newText, 'к', 'К');
//string newText2 = Replace(newText1, 'С', 'с');
//Console.WriteLine(newText2);

// Упорядочить массив от меньшего к большему

// int[] array = {3, 4, 5, 6, 7, 2, 1, 9, 0, 3};

// void PrintArray(int[] a)
// {
//     int c = a.Length;

// for (int i=0; i<c; i++)
// {
//     Console.Write($"{a[i]} ");
// }
// Console.WriteLine();
// }

// void SelectionSort(int[] arr)
// {
//     for (int ind=0; ind<arr.Length-1; ind++)
//     {
//         int minPos = ind;
        
//         for (int j=ind+1; j<arr.Length; j++)
//         {
//             if(arr[j]<arr[minPos]) minPos=j;
//         }
//         int temporary = arr[ind];
//         arr[ind] = arr[minPos];
//         arr[minPos] = temporary;   
//     }
// }
// PrintArray(array);
// SelectionSort(array);
// PrintArray(array);

// Упорядочить массив от большего к меньшего

int[] array = {3, 4, 5, 6, 7, 2, 1, 9, 0, 3};

void PrintArray(int[] a)
{
    int c = a.Length;

for (int i=0; i<c; i++)
{
    Console.Write($"{a[i]} ");
}
Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int ind=0; ind<arr.Length-1; ind++)
    {
        int maxPos = ind;
        
        for (int j=ind+1; j<arr.Length; j++)
        {
            if(arr[j]>arr[maxPos]) maxPos=j;
        }
        int temporary = arr[ind];
        arr[ind] = arr[maxPos];
        arr[maxPos] = temporary;   
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);