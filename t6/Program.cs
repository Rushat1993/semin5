
void InputArray(double[] arr)
{
    Console.WriteLine($"Введите числа для массива из {arr.Length}-ми элементов");

    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

Console.Write("Введите желаемую размерность массива ");
int arrLen = Convert.ToInt32(Console.ReadLine());

double[] array = new double[arrLen];
InputArray(array);

double max = array[0];
    for (int i = 0; i < array.Length; i++)
    
        if (max < array[i] )
        {
            max = array[i];
        }

double min = array[0];
    for (int i = 0; i < array.Length; i++)
    
        if (min > array[i] )
        {
            min = array[i];
        }

double difference = max-min;

Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Разница элементов = " + difference);