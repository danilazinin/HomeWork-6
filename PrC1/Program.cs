// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.WriteLine("Введите сколько цифр вы хотите в дальнейшем ввести");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
int index = 0;
int num = 0;
int n = 0;

while (index < size)
{
    Console.WriteLine($"Введите {index + 1} число");
    num = int.Parse(Console.ReadLine());

    array[n] = num;
    n++;
    index++;
}

int[] GetArray(int size, int[] res)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;

}

int ZeroMethod(int[] array1)
{
    int kol = 0;
    int n = 0;
    int num = 0;

    while (n < array1.Length)
    {
        num = array1[n];

        if (num > 0)
        {
            kol = kol + 1;
        }
        n = n + 1;


    }
    return kol;
}


GetArray(size, array);

Console.WriteLine($"Чисел больше нуля - {ZeroMethod(array)}");


