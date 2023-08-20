/* Проверка на палиндром

bool Polindrom(string numbers)
{   
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        if (numbers[i] != numbers[numbers.Length - i - 1]) 
        return false;
    }
    return true;
}

Console.Write("input number: ");
string  num = Console.ReadLine();
Console.WriteLine(Polindrom(num));
*/


/* Создаем массив из m вещественных чисел и находим разницу между мин и макс значением

double[] CreateArray (int size)
{
    double[] array = new double[size];
    int i = 0;
    while (i < size)
    {
        Console.Write($"Введите элемент под индексом {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        i++;
    }
    return array;
}

void WriteLine(double[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + "  ");
        i++;
    }
    Console.WriteLine();
}

double difference (double[] array)
{
    int i = 1;
    double minV = array[0];
    double maxV = array[0];
    double diff = 0;
    while (i < array.Length)
    {
        if (array[i] > maxV) maxV = array[i];
        if (array[i] < minV) minV = array[i];
        i++;
    }
    Console.WriteLine($"min = {minV};   max = {maxV};");
    return  diff = maxV - minV;
}

Console.Write("Enter size an array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] MyArray = CreateArray (size);
WriteLine(MyArray);
Console.WriteLine($"Разница между мин и макс значением составляет --> {difference (MyArray)}");
*/


/* Делаем из числа массив из цифр

int[] CreateArray (string numbers)
{
    int[] array = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        array [i] = Convert.ToInt32(numbers[i].ToString());
        Console.Write(array[i] + " ");
    }
    return array;
}

Console.Write("Enter the number: ");
CreateArray (Console.ReadLine());
*/

