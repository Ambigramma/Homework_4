// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

void ArrOut()

{
    Console.Write("Введите количество элементов массимва: ");
    int elements = int.Parse(Console.ReadLine());

    int[] myArray = new int [elements];

    for (int i = 0; i < ((byte)myArray.Length); i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Вывод массива: ");

    for (int i = 0; i < myArray.Length; i++)
    {   
        Console.Write(myArray[i]+" ");
    }
}

ArrOut();