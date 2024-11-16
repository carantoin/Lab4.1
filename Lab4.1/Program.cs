int[] array = new int[14];
Console.WriteLine("Введите 14 целых чисел:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент {i+1}:");
    array[i] = int.Parse(Console.ReadLine());
}

int sumIndex = 0;
long productValue = 1;
bool hasValue = false;

for (int i = 0;i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        sumIndex += array[i];
    }

    if (array[i] % 2 != 0)
    {
        productValue *= array[i];
        hasValue = true;
    }
}

Console.WriteLine($"Сумма элементов с нечётными значениями: {sumIndex}");

if (hasValue)
{
    Console.WriteLine($"Произведение элементов с нечётными значениями: {productValue}");
}
else
{
    Console.WriteLine("В массиве нет элементов с нечётными значениями");
}