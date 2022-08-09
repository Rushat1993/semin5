int[] array = new int[8];
    Console.WriteLine($"Введите числа для массива из {array.Length}-ми элементов");

    for (int i = 0; i < array.Length;  i++)
    {
        Console.Write($"{i + 1}й элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine($"Введен следующий массив [{string.Join(", ", array)}]");