/*
* Урок 5. Функции продолжение
*
* Задача 34: Задайте массив заполненный случайными положительными 
* трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*
* [345, 897, 568, 234] -> 2
*
* Решение:
*/

int countEven(int[] arr)
{
    int count = 0;
    foreach (var number in arr)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите значение количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 1)
{
    Console.WriteLine("Некорректное значение");
}
else
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(100, 1000);
    }

    Console.WriteLine("Количество чётных чисел в массиве: " + countEven(arr));
}

/*
* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
* Найдите сумму элементов, стоящих на нечётных позициях.
*
* [3, 7, 23, 12] -> 19
*
* [-4, -6, 89, 6] -> 0
*
* Решение: 
*/

/*
* Здесь текст задачи проитворечит примерам:
* Считая элементы массива на нечётных позициях, то есть на первой,
* на третьей, на пятой и так далее, нам надо будет считать четные индексы: 0, 2, 4 и т.д.
*
* В примере, однако
* [3, 7, 23, 12] -> 19
*
* Учтены элементы, стоящие на нечётных индексах: [1]=7 и [3] = 12. Получая, таким образом,
* сумму значений элементов на ЧЕТНЫХ позициях, на второй(7) и четвёртой(12) = 19.
* Аналогично здесь:
*
* [-4, -6, 89, 6] -> 0
*
* [1] = -6 и [3] = 6
* сумма второго и четвертого элемента равна 0.
*/

int summOddIndicies(int[] arr)
{
    int summ = 0;
    for (int index = 1; index < arr.Length; index = index + 2)
    {
        summ += arr[index];
    }
    return summ;
}

Console.WriteLine("Введите значение количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 1)
{
    Console.WriteLine("Некорректное значение");
}
else
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(-99, 100); // В задание не указано, но если судить по примеру, значения [-99, 99]
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + summOddIndicies(arr));
}

/*
* Задача 38: Задайте массив вещественных чисел. 
* Найдите разницу между максимальным и минимальным элементов массива.
*
* [3 7 22 2 78] -> 76
* 
* Решенеие: 
*/

void enterArrayElement(double[] arr, int index)
{
    Console.WriteLine("Введите значение элемента на позиции " + (index + 1));
    arr[index] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите значение количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[size];
for (int index = 0; index < size; index++)
{
    enterArrayElement(arr, index);
}

double min = Double.MaxValue;
double max = Double.MinValue;

foreach (var number in arr)
{
    if (number < min)
    {
        min = number;
    }
    if (number > max)
    {
        max = number;
    }
}

// Не округляю результат, ибо разница может оказаться близкой к нулю и, таким образом, потеряна
Console.WriteLine("Разницу между максимальным и минимальным элементом массива: " + (max - min));