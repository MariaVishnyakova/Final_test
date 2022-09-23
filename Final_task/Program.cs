string[] array = new string[] { "1234", "1567", "-2", "computer science" };

int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}
string[] newArray = new string[lenNewArray];
int idx = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}
PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}