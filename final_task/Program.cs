// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];
string[] array2 = new string[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++)
{
    array1[i] = Console.ReadLine();
}

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}