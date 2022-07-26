//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите количество элементов массива под индексом {i}:\t");
        myArray[i] = int.Parse(Console.ReadLine());
    }
Console.Write($"\nВыведите массив ->" );
for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i]);
    }
