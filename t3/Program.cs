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

int[] array = FillArrayWithRandomNumbers(8, 100, 1000);

int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            cnt = cnt + 1;
        }
    }

Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Количество чётных чисел = " + cnt);