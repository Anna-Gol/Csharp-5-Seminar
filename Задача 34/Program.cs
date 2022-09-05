// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

string numberOfPositives()
{
    int[] arr = new int [4];
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);

        if (arr[i] % 2 == 0)
        {
            count++;
        }

    }
    
    string output = $"Array: {String.Join(", ", arr)}\nNumber of positives = {count}";

    return output;

}

Console.WriteLine(numberOfPositives());