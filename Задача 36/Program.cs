// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

string sumOfNegPosition()
{
    int[] arr = new int [4];
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);

        if (i % 2 != 0)
        {
            sumNeg += arr[i];
        }

    }
    
    string output = $"Array: {String.Join(", ", arr)}\nSum of numbers with negative positions = {sumNeg}";

    return output;

}

Console.WriteLine(sumOfNegPosition());