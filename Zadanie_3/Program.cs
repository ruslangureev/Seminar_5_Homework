Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
while (size < 0)
{
    Console.Write("Вы ввели отрицательное значение массива. Введите корректный размер массива: ");
    size = int.Parse(Console.ReadLine());
}
double[] array = new double[size];
double min = 90;
double max = 0;
for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(0, 90) + new Random().NextDouble();
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    
}
Console.WriteLine("В массиве " + string.Join(", ", array) + " минимальный элемент: " + Math.Round(min, 2) + ", " + " максимальный элемент: " + Math.Round(max, 2));
Console.WriteLine("Разница между максимальным и минимальным: " + Math.Round((max - min), 2));
