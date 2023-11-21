
string[] fillArray (string[] arrayLocal )
    {
        
        for (int i = 0; i < arrayLocal.Length; i++)
        {
            Console.Clear();
            System.Console.Write($"Введите значение для {i + 1} элемента массива: ");
            arrayLocal[i] = Console.ReadLine();
        }
        return arrayLocal;
        Console.Clear();
    }

void writeArray(string[] array )
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }

string [] findThreeLengthElements (string [] array)
    {
        string [] newArray = new string [array.Length];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[index]  = array[i];
                index ++;
            }
        }
        return newArray;
    }






string [] array = new string[4];
fillArray(array);
System.Console.WriteLine("Не отсортированный массив: ");
writeArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив: ");
writeArray(findThreeLengthElements(array));

