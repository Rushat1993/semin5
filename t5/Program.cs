int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumbers(7, -100, 100);

int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }

Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Сумма элементов = " + sum);