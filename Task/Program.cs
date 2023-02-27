
string[] Array1 = new string[] {"1234", "1567", "-2", "computer science"};
string[] result = new string[Array1.Length];

void FindArray(string[] array1, string[] result)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
     result[count] = array1[i];
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
FindArray(Array1, result);
PrintArray(result);
