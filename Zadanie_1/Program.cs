Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
while (size < 0)
{
    Console.Write("Вы ввели отрицательное значение массива. Введите корректный размер массива: ");
    size = int.Parse(Console.ReadLine());
}
int count = 0;
int[] array = new int[size];
for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(100, 1000);
}
for (int i = 0; i < array.Length; ++i)
{
    count += array[i] % 2 == 0 ? 1 : 0;
}
Console.WriteLine("В массиве [" + string.Join(",", array) + "] количество четных чисел равно: " + count);

