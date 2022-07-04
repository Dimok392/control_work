
string[] character_set = new string[4] { "hello", "2", "world", ":)" };
string[] character_set2 = new string[3] { "1234", "1567", "-2" };
string[] character_set4 = new string[3] { "Russia", "Denmark", "Kazan" };
string[] character_set1 = new string[character_set.Length];
string[] character_set3 = new string[character_set2.Length];
string[] character_set5 = new string[character_set4.Length];
void Сut_off_elementArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Сut_off_elementArray(character_set, character_set1);
Print(character_set1);
Сut_off_elementArray(character_set2, character_set3);
Print(character_set3);
Сut_off_elementArray(character_set4, character_set5);
Print(character_set5);
