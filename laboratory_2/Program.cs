var arraySize = 0;
do
{
    try
    {
        arraySize = Convert.ToInt23(Console.ReadLine());
        if (arraySize < 1)
        {
            Console.WriteLine("Введите число больше 0");
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("Вы ввели не числовое значение");
    }
} while (arraySize < 1);

var maxValue = (int) Math.Pow(arraySize + 5, 2);

var random = new Random(); 
var array = new float[arraySize];
for (int i = 0; i < arraySize; i++)
{
    array[i] = random.Next() % maxValue;
    Console.Write($"{array[i]} ");
}
