void PrintArray(string[] arr) //Вывод массива
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите колличество элементов в массиве: "); //Задаем колличество элементов в массиве
int volume = int.Parse(Console.ReadLine());

string[] array = new string[volume]; //Создаем массив

for (int i = 0; i < volume; i++) //Заполняем массив
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

int ChangeLenght(string[] arr) //Нахождение длины нового массива
{
    int length = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            length++;
        }
    }
    return length;
}

int size = ChangeLenght(array);

string[] newArray = new string[size]; //Создание нового массива

int j = 0;
for (int i = 0; i < volume; i++) //Заполнение новго массива
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
if(j == 0) Console.WriteLine("[]"); //Проверка: если в массиве все элементы с колличеством символов больше 3

PrintArray(newArray);
