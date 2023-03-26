string[] array1 = new string[5] {"222", "hi", "there", "world", "13"};
string[] array2 = new string[array1.Length];
void CheckArrayLength(string[] array1, string[] array2)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[num] = array1[i];
        num++;
        }
    }
}
void NewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CheckArrayLength(array1, array2);
NewArray(array2);
