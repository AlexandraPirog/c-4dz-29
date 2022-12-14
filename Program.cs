//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArray = Auto();
int[] Auto()
{
    int[] myArray;
    myArray = new int[8];
    for (int i = 0; i < myArray.Length; i++)
    {

        System.Console.WriteLine($"Введите значение элемента массива индекса {i}");
        myArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    return myArray;
}
System.Console.WriteLine(string.Join(" | ", myArray));
