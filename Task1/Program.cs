//Заполнения массива из строки
string[] array1 = new string[6] {"Dom", "hello", "work", ":-", "12", "London"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        ++count;
        }
    }
}

void PrintStrArray(string[] array1)
{
    int count = array1.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(array1[index]);
        ++index;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
SecondArray(array1, array2);
PrintStrArray(array2);