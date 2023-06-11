//Функция ввода с разделителем
string[] Prompt(string msg)
{
    Console.Write(msg);
    return Console.ReadLine().Split(", ");
}

//Функция получения массива строк 
string[] GetArrayThreeSymbol(string[] array)
{
    int count = 0;
    string[] preresult = new string[count];
    string[] result = preresult;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            preresult = new string[count];
            for (int j = 0; j < preresult.Length - 1; j++)
            {
                preresult[j] = result[j];
            }
            preresult[count - 1] = array[i];
            result = preresult;
        }
    }
    return result;
}

//Функция вывода с проверкой длинны
void PrintArray(string[] array)
{
 string mass = "[";
 if (array.Length > 0)
    {
 mass += "\"" + array[0] + "\"";
 for (int i = 1; i < array.Length; i++)
        {
 mass += ", \"" + array[i] + "\"";
        }
    }
 mass += "]";
 Console.Write(mass);
}

string[] arrayString = Prompt("Введите элементы массива строк,используя разделитель (, ): ");
string[] arrayThreeSymbol = GetArrayThreeSymbol(arrayString);
Console.Write("Сформирован массив ");
PrintArray(arrayString);
Console.Write(", длина которых меньше или равна 3 символам, равен ");
PrintArray(arrayThreeSymbol);