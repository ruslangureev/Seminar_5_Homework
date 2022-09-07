Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное число диапазона генерации: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число диапазона генерации: ");
int maxNumber = int.Parse(Console.ReadLine());

int sum = 0;
while (minNumber > maxNumber || size <0)
{
    if (minNumber > maxNumber)
    {
        Console.Write("Вы ввели неверный диапазон");
        Console.Write("Введите минимальное число диапазона генерации: ");
        minNumber = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное число диапазона генерации: ");
        maxNumber = int.Parse(Console.ReadLine());
    }
    if (size < 0)
    {
        Console.Write("Вы ввели отрицательный размер массива");
        size = int.Parse(Console.ReadLine());
    }
    
}

int[] array = new int[size];
for (int index = 0; index < array.Length; ++index)
{
    array[index] = new Random().Next(minNumber, maxNumber + 1);
}
for (int index = 0; index < array.Length; ++index)
{
    sum += index % 2 == 1 ? array[index] : 0;
}
Console.WriteLine("В массиве [" + string.Join(",", array) + "] сумма элементов на нечетных позициях равна: " + sum);
