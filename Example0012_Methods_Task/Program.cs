//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);




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

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPisition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPisition]) minPisition = j;
        }

        int temporary = array[i];
        array[i] = array[minPisition];
        array[minPisition] = temporary;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPisition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPisition]) maxPisition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPisition];
        array[maxPisition] = temporary;
    }
}

PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
// SelectionSortMax(arr);
// PrintArray(arr);
Array.Reverse(arr);
PrintArray(arr);